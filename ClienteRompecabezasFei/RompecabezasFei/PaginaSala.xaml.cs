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
using System.Windows.Media;

namespace RompecabezasFei
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public partial class PaginaSala : Page, IServicioSalaCallback
    {
        private string codigoSala;

        private ServicioSala servicioSala;

        private Temporizador temporizador;

        public ObservableCollection<Dominio.CuentaJugador> CuentasDeAmigos { get; set; }

        public bool HayConexionConSala { get; set; }

        Color colorActivo = (Color)ColorConverter.ConvertFromString("#FF03A64A");

        Color colorDesactivado = (Color)ColorConverter.ConvertFromString("#808080");

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
            JugadoresEnSalaPestana = new ObservableCollection<Dominio.CuentaJugador>();
            listaJugadoresSala.DataContext = this;
            listaJugadoresEnSala.DataContext = this;
            listaAmigosDisponibles.DataContext = this;
            panelModificacionJugador.Visibility = Visibility.Hidden;
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
                        CargarJugadoresEnPestanaSala();
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

        public void ActualizarTiempoRestante(object objetoOrigen, EventArgs evento)
        {
            if (temporizador.SegundosRestantes > Temporizador.MinimoSegundosRestantes)
            {
                temporizador.SegundosRestantes--;
                TimeSpan tiempoRestante = TimeSpan.FromSeconds(temporizador.SegundosRestantes);
                etiquetaTiempoRestante.Content = $"{tiempoRestante.Minutes:00}:" +
                    $"{tiempoRestante.Seconds:00}";
            }
            else
            {
                temporizador.DetenerTemporizador();
                etiquetaTiempoRestante.Content = "01:00";
                HabilitarBotonEnviarInvitacion();
            }
        }

        private void HabilitarBotonEnviarInvitacion()
        {
            botonEnviarInvitacion.IsEnabled = true;
            botonEnviarInvitacion.Background = new SolidColorBrush(colorActivo);
        }

        private void DeshabilitarBotonEnviarInvitacion()
        {
            botonEnviarInvitacion.IsEnabled = false;
            botonEnviarInvitacion.Background = new SolidColorBrush(colorDesactivado);
        }

        private void ComenzarTemporizador()
        {
            DeshabilitarBotonEnviarInvitacion();
            temporizador = new Temporizador();
            temporizador.IniciarTemporizador(Temporizador.DuracionSegundosMaximaReenvioDeCorreo);
            temporizador.DespachadorDeTiempo.Tick += ActualizarTiempoRestante;
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

        private void CargarJugadoresEnPestanaSala()
        {
            CuentaJugador[] jugadoresRecuperados = Servicios.ServicioSala.
                ObtenerJugadoresConectadosEnSala(CodigoSala);

            foreach (CuentaJugador jugador in jugadoresRecuperados)
            {
                    var cuentaJugador = new Dominio.CuentaJugador
                    {
                        NombreJugador = jugador.NombreJugador,
                        FuenteImagenAvatar = GeneradorImagenes.
                        GenerarFuenteImagenAvatar(jugador.NumeroAvatar)
                    };
                    JugadoresEnSalaPestana.Add(cuentaJugador);
            }
        }

        private void CargarAmigosJugador()
        {
            CuentasDeAmigos = new ObservableCollection<Dominio.CuentaJugador>();
            CuentaJugador[] amigosObtenidos = Servicios.ServicioAmistades.
                ObtenerAmigosDeJugador(Dominio.CuentaJugador.Actual.NombreJugador);

            if (amigosObtenidos != null && amigosObtenidos.Any())
            {
                foreach (CuentaJugador amigo in amigosObtenidos)
                {
                    if (ObtenerEstadoConectividad(amigo.EstadoConectividad))
                    {
                        Dominio.CuentaJugador cuentaAmigo = new Dominio.CuentaJugador
                        {
                            NombreJugador = amigo.NombreJugador,
                            NumeroAvatar = amigo.NumeroAvatar,
                            FuenteImagenAvatar = Utilidades.GeneradorImagenes.
                           GenerarFuenteImagenAvatar(amigo.NumeroAvatar),
                        };
                        CuentasDeAmigos.Add(cuentaAmigo);
                    }
                }
            }
        }

        private bool ObtenerEstadoConectividad(
           ConectividadJugador estado)
        {
            bool disponibilidadJugador;
            switch (estado)
            {
                case ConectividadJugador.Disponible:
                    disponibilidadJugador = true;
                    break;
                case ConectividadJugador.NoDisponible:
                    disponibilidadJugador = false;
                    break;
                default:
                    disponibilidadJugador = false;
                    break;
            }
            return disponibilidadJugador;
        }

        private void CrearNuevaSala()
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

        private void MostrarPanelModificarJugadoresEnSala(object objetoOrigen,
            MouseButtonEventArgs evento)
        {
            panelModificacionJugador.Visibility = Visibility.Visible;  
        }

        private void CerrarModificacionJugadores(object objetoOrigen, 
            MouseButtonEventArgs evento)
        {
            panelModificacionJugador.Visibility = Visibility.Hidden;
        }

        private void EnviarInvitacionPorCorreo(object objetoOrigen, RoutedEventArgs evento)
        {
            string correoDestino = cuadroTextoCorreoElectronico.Text.Trim();

            if (!ValidadorDatos.ExistenCaracteresInvalidosParaCorreo(correoDestino))
            {
                if (correoDestino!=Dominio.CuentaJugador.Actual.Correo)
                {
                    if (Servicios.ServicioCorreo.ExisteCorreoElectronico(correoDestino))
                    {
                        bool envioDeInvitacionRealizado = GestionadorCodigoCorreo.
                        EnviarInvitacionSalaACorreo(correoDestino, Properties.Resources.
                        ETIQUETA_MODIFICACIONSALA_CORREOINVITACIONASUNTO, Properties.Resources.
                        ETIQUETA_MODIFICACIONSALA_MENSAJECORREOINVITACIONASUNTO, CodigoSala);

                        if (!envioDeInvitacionRealizado)
                        {
                            MessageBox.Show(Properties.Resources.
                                        ETIQUETA_CODIGO_MENSAJENOENVIADO, Properties.Resources.
                                        ETIQUETA_CODIGO_CODIGONOENVIADO,
                                        MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            ComenzarTemporizador();
                            MessageBox.Show(Properties.Resources.
                                        ETIQUETA_MODIFICACIONSALA_MENSAJEINVITACIONENVIADA,
                                        Properties.Resources.
                                        ETIQUETA_MODIFICACIONSALA_INVITACIONENVIADA,
                                        MessageBoxButton.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show(Properties.Resources.
                            ETIQUETA_RECUPERACIONCONTRASENA_MENSAJECORREOINEXISTENE, Properties.
                            Resources.ETIQUETA_RECUPERACIONCONTRASENA_CORREOINEXISTENTE,
                            MessageBoxButton.OK);
                    }
                }
                else
                {
                    MessageBox.Show(Properties.Resources.ETIQUETA_SALA_MISMOCORREO,
                    Properties.Resources.ETIQUETA_VALIDACION_CORREOINVALIDO,
                    MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show(Properties.Resources.ETIQUETA_VALIDACION_MENSAJECORREOINVALIDO,
                    Properties.Resources.ETIQUETA_VALIDACION_CORREOINVALIDO, 
                    MessageBoxButton.OK);
            }
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
                JugadoresEnSalaPestana.Add(nuevaCuentaJugador);
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
                    JugadoresEnSalaPastana.Remove(cuentaJugadorEncontrada);
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
            etiquetaModificarJugador.Visibility = Visibility.Visible;
            imagenModificarJugador.Visibility= Visibility.Visible;
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