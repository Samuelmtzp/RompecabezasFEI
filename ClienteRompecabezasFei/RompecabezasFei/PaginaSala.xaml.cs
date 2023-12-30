using RompecabezasFei.ServicioRompecabezasFei;
using RompecabezasFei.Servicios;
using RompecabezasFei.Utilidades;
using Seguridad;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public partial class PaginaSala : Page, IServicioSalaCallback
    {
        private string codigoSala;

        private ServicioSala servicioSala;

        public bool HayConexionConSala { get; set; }

        public ObservableCollection<Dominio.CuentaJugador> JugadoresEnSala { get; set; }

        public string CodigoSala
        {
            get { return codigoSala; }
            set
            {
                codigoSala = value;

                if (etiquetaCodigoSala != null)
                {
                    etiquetaCodigoSala.Content = codigoSala;
                }
            }
        }

        public PaginaSala() { }

        public PaginaSala(bool esAnfitrion, string codigoSala)
        {
            InitializeComponent();
            JugadoresEnSala = new ObservableCollection<Dominio.CuentaJugador>();
            listaJugadoresSala.DataContext = this;
            CodigoSala = codigoSala;
            servicioSala = new ServicioSala(this);
            HayConexionConSala = false;
            ConfigurarSesionEnSala(esAnfitrion);
        }

        private void ConfigurarSesionEnSala(bool esAnfitrion)
        {
            if (esAnfitrion && !string.IsNullOrEmpty(codigoSala))
            {                
                servicioSala.ActivarNotificacionesDeSala(
                    Dominio.CuentaJugador.Actual.NombreJugador);

                switch (servicioSala.EstadoOperacion)
                {
                    case EstadoOperacion.Correcto:
                        MostrarFuncionesDeAnfitrion();
                        HayConexionConSala = true;                        
                        break;
                }
            }
            else
            {
                bool creacionSalaRealizada = false;

                if (esAnfitrion && string.IsNullOrEmpty(codigoSala))
                {
                    creacionSalaRealizada = CrearNuevaSala();
                    
                    if (creacionSalaRealizada)
                    {
                        MostrarFuncionesDeAnfitrion();
                    }
                }

                if ((esAnfitrion && !string.IsNullOrEmpty(codigoSala) && creacionSalaRealizada) || 
                    !esAnfitrion && !string.IsNullOrEmpty(codigoSala))
                {
                    UnirseASala();
                }
            }

            CargarJugadoresEnSala();
        }

        private void IrAPaginaMenuPrincipal(object objetoOrigen, MouseButtonEventArgs evento)
        {
            MessageBoxResult opcionSeleccionada = 
                GestorCuadroDialogo.MostrarPreguntaNormal(
                Properties.Resources.ETIQUETA_ABANDONOSALA_MENSAJE,
                Properties.Resources.ETIQUETA_ABANDONOSALA_TITULO);

            if (opcionSeleccionada == MessageBoxResult.Yes)
            {
                AbandonarSala(new object(), new CancelEventArgs());
                VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
            }                
        }

        private void CopiarCodigoDeSalaEnPortapapeles(object objetoOrigen, 
            RoutedEventArgs evento)
        {
            Clipboard.SetText(CodigoSala);
        }

        private void EnviarMensajeEnChatDeSala(object objetoOrigen, 
            RoutedEventArgs evento)
        {
            if (!ValidadorDatos.EsCadenaVacia(
                cuadroTextoMensajeUsuario.Text.Trim()))
            {
                servicioSala.EnviarMensajeEnChatDeSala(
                    cuadroTextoMensajeUsuario.Text, CodigoSala);
                
                switch (servicioSala.EstadoOperacion)
                {
                    case EstadoOperacion.Correcto:
                        cuadroTextoMensajeUsuario.Clear();
                        break;
                }
            }
        }

        private void IrAPaginaCreacionNuevaPartida(object objetoOrigen, 
            RoutedEventArgs evento)
        {
            servicioSala.DesactivarNotificacionesDeSala(
                Dominio.CuentaJugador.Actual.NombreJugador);

            switch (servicioSala.EstadoOperacion)
            {
                case EstadoOperacion.Correcto:
                    VentanaPrincipal.CambiarPagina(
                        new PaginaCreacionNuevaPartida(CodigoSala));
                    break;
            }
        }

        private void UnirseASala()
        {            
            HayConexionConSala = servicioSala.UnirseASala(
                Dominio.CuentaJugador.Actual.NombreJugador, codigoSala);

            switch (servicioSala.EstadoOperacion)
            {
                case EstadoOperacion.Correcto:
                    
                    if (!HayConexionConSala)
                    {
                        GestorCuadroDialogo.MostrarAdvertencia(
                            "No se ha podido conectar al jugador a la sala debido a que la sala no está disponible",
                            "Sala no disponible");
                    }

                    break;
            }
        }

        private void CargarJugadoresEnSala()
        {            
            List<CuentaJugador> jugadoresRecuperados = servicioSala.
                ObtenerJugadoresConectadosEnSala(CodigoSala);

            switch (servicioSala.EstadoOperacion)
            {
                case EstadoOperacion.Correcto:
                    
                    if (jugadoresRecuperados.Any())
                    {
                        foreach (CuentaJugador jugador in jugadoresRecuperados)
                        {
                            JugadoresEnSala.Add(new Dominio.CuentaJugador
                            {
                                NombreJugador = jugador.NombreJugador,
                                FuenteImagenAvatar = GeneradorImagenes.
                                    GenerarFuenteImagenAvatar(jugador.NumeroAvatar)
                            });
                        }
                    }

                    break;
            }

        }

        private bool CrearNuevaSala()
        {
            CodigoSala = servicioSala.GenerarCodigoParaNuevaSala();
            bool creacionRealizada = false;
            
            switch (servicioSala.EstadoOperacion)
            {
                case EstadoOperacion.Correcto:
                    
                    if (!string.IsNullOrEmpty(CodigoSala))
                    {
                        creacionRealizada = servicioSala.
                            CrearNuevaSala(Dominio.CuentaJugador.
                            Actual.NombreJugador, CodigoSala);

                        switch (servicioSala.EstadoOperacion)
                        {
                            case EstadoOperacion.Correcto:
                                
                                if (!creacionRealizada)
                                {
                                    GestorCuadroDialogo.MostrarAdvertencia(
                                        "No se ha podido realizar la creación de la sala",
                                        "Error al crear la sala");
                                }

                                break;
                        }
                    }
                    else
                    {
                        GestorCuadroDialogo.MostrarAdvertencia(
                            "No se ha podido realizar la creación de la sala",
                            "Error al crear la sala");
                    }

                    break;
            }

            return creacionRealizada;
        }

        private void AbandonarSala(object objetoOrigen, CancelEventArgs evento)
        {
            var servicio = new ServicioSala();
            servicio.AbandonarSala(Dominio.CuentaJugador.
                Actual.NombreJugador, CodigoSala);
            servicio.CerrarConexion();
        }

        private void MostrarOpcionesModificacionJugadoresEnSala(object objetoOrigen,
            MouseButtonEventArgs evento)
        {
            // Solo mostrar el panel de modificación de jugadores
        }

        public void MostrarMensajeDeSala(string mensaje)
        {
            cuadroTextoMensajes.AppendText(mensaje + "\n");
        }

        public void MostrarNuevoJugadorEnSala(CuentaJugador nuevoJugador)
        {
            if (JugadoresEnSala != null)
            {
                Dominio.CuentaJugador nuevaCuentaJugador = new Dominio.CuentaJugador
                {
                    FuenteImagenAvatar = GeneradorImagenes.
                        GenerarFuenteImagenAvatar(nuevoJugador.NumeroAvatar),
                    NombreJugador = nuevoJugador.NombreJugador
                };
                JugadoresEnSala.Add(nuevaCuentaJugador);
            }
        }

        public void MostrarDesconexionDeJugadorEnSala(string nombreJugadorDesconexion)
        {
            if (JugadoresEnSala != null)
            {
                Dominio.CuentaJugador cuentaJugadorEncontrada = JugadoresEnSala.
                    FirstOrDefault(jugador => jugador.NombreJugador == 
                    nombreJugadorDesconexion);

                if (cuentaJugadorEncontrada != null)
                {
                    JugadoresEnSala.Remove(cuentaJugadorEncontrada);
                }
            }
        }

        public void MostrarNuevaPartida()
        {
            PaginaPartida paginaPartida = new PaginaPartida(CodigoSala);
            paginaPartida.CargarJugadoresEnPartida();
            VentanaPrincipal.CambiarPagina(paginaPartida);
        }

        public void MostrarFuncionesDeAnfitrion()
        {
            etiquetaModificarJugadores.Visibility = Visibility.Visible;
            imagenModificarJugadores.Visibility= Visibility.Visible;
            botonNuevaPartida.Visibility= Visibility.Visible;
        }

        public void MostrarMensajeExpulsionDeSala()
        {
            servicioSala.AbandonarSala(Dominio.CuentaJugador.
                Actual.NombreJugador, codigoSala);

            switch (servicioSala.EstadoOperacion)
            {
                case EstadoOperacion.Correcto:
                    GestorCuadroDialogo.MostrarAdvertencia(
                        "El anfitrión te ha expulsado de la sala",
                        "Expulsión de sala");
                    VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());                    
                    break;
            }
        }

        public void MostrarFuncionesDeAnfitrionEnSala()
        {
            botonNuevaPartida.Visibility = Visibility.Visible;
            etiquetaModificarJugadores.Visibility = Visibility.Visible;
            imagenModificarJugadores.Visibility = Visibility.Visible;
        }

        public void HabilitarInicioDePartida()
        {
            botonNuevaPartida.Visibility = Visibility.Visible;
        }

        public void DeshabilitarInicioDePartida()
        {
            botonNuevaPartida.Visibility = Visibility.Hidden;
        }

        public void MostrarAmigoDisponible(CuentaJugador cuentaAmigo)
        {
            // Agregar a la lista de amigos disponibles al nuevo jugador
        }

        public void OcultarAmigoNoDisponible(string nombreAmigo)
        {
            // remover de la lista de amigos disponibles al jugador con el mismo nombre
        }
    }
}