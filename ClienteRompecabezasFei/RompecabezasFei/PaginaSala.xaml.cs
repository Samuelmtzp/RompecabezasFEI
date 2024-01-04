using RompecabezasFei.ServicioRompecabezasFei;
using RompecabezasFei.Servicios;
using RompecabezasFei.Utilidades;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private readonly ServicioSala servicioSala;

        private Temporizador temporizador;

        private const int CantidadJugadoresMinimosParaIniciarPartida = 2;

        //Color colorActivo = (Color)ColorConverter.ConvertFromString("#FF03A64A");
        
        //Color colorDesactivado = (Color)ColorConverter.ConvertFromString("#808080");

        public bool HayConexionConSala { get; set; }

        public ObservableCollection<Dominio.CuentaJugador> CuentasDeAmigos { get; set; }

        public ObservableCollection<Dominio.CuentaJugador> JugadoresEnSala { get; set; }

        public ObservableCollection<Dominio.CuentaJugador> JugadoresEnSalaPestana { get; set; }

        public ObservableCollection<Dominio.CuentaJugador> AmigosDisponibles { get; set; }

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

        public PaginaSala() 
        {
        }

        public PaginaSala(bool esAnfitrion, string codigoSala)
        {
            InitializeComponent();
            JugadoresEnSala = new ObservableCollection<Dominio.CuentaJugador>();
            JugadoresEnSalaPestana = new ObservableCollection<Dominio.CuentaJugador>();
            AmigosDisponibles = new ObservableCollection<Dominio.CuentaJugador>();
            CuentasDeAmigos = new ObservableCollection<Dominio.CuentaJugador>();
            listaJugadoresSala.DataContext = this;
            listaJugadoresEnSala.DataContext = this;
            listaAmigosDisponibles.DataContext = this;
            panelModificacionJugador.Visibility = Visibility.Hidden;
            CodigoSala = codigoSala;
            HayConexionConSala = false;
            servicioSala = new ServicioSala(this);
            
            if (servicioSala.EstadoOperacion == EstadoOperacion.Correcto)
            {
                ConfigurarSesionEnSala(esAnfitrion);
            }
        }

        private void ConfigurarSesionEnSala(bool esAnfitrion)
        {
            if (esAnfitrion)
            {
                if (!string.IsNullOrEmpty(codigoSala))
                {
                    UnirseASala();
                }
                else
                {
                    CrearNuevaSala();
                }

                MostrarFuncionesDeAnfitrionEnSala();
            }
            else
            {
                UnirseASala();
            }
        }

        public void ActualizarTiempoRestante(object objetoOrigen, EventArgs evento)
        {
            if (temporizador.SegundosRestantes > Temporizador.MinimoSegundosRestantes)
            {
                temporizador.SegundosRestantes--;
                TimeSpan tiempoRestante = TimeSpan.
                    FromSeconds(temporizador.SegundosRestantes);
                etiquetaTiempoRestante.Content = 
                    $"{tiempoRestante.Minutes:00}:" +
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
            //botonEnviarInvitacion.Background = new SolidColorBrush(colorActivo);
        }

        private void DeshabilitarBotonEnviarInvitacion()
        {
            botonEnviarInvitacion.IsEnabled = false;
            //botonEnviarInvitacion.Background = new SolidColorBrush(colorDesactivado);
        }

        private void ComenzarTemporizador()
        {
            DeshabilitarBotonEnviarInvitacion();
            temporizador = new Temporizador();
            temporizador.IniciarTemporizador(Temporizador.
                DuracionSegundosMaximaReenvioDeCorreo);
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
                AbandonarSala();
            }                
        }

        private void CopiarCodigoDeSalaEnPortapapeles(object objetoOrigen, 
            RoutedEventArgs evento)
        {
            Clipboard.SetText(CodigoSala);
        }

        private void EnviarMensajeEnChatDeSala(object objetoOrigen, RoutedEventArgs evento)
        {
            if (!ValidadorDatos.EsCadenaVacia(
                cuadroTextoMensaje.Text.Trim()))
            {
                servicioSala.EnviarMensajeDeSala(
                    cuadroTextoMensaje.Text, CodigoSala);
                
                if (servicioSala.EstadoOperacion == EstadoOperacion.Correcto)
                {
                    cuadroTextoMensaje.Clear();
                }
            }
        }

        private void IrAPaginaCreacionNuevaPartida(object objetoOrigen, 
            RoutedEventArgs evento)
        {
            servicioSala.DesactivarNotificacionesDeSala(
                Dominio.CuentaJugador.Actual.NombreJugador);

            if (servicioSala.EstadoOperacion == EstadoOperacion.Correcto) 
            {
                VentanaPrincipal.CambiarPagina(
                    new PaginaCreacionNuevaPartida(CodigoSala));
            }
        }

        private void UnirseASala()
        {            
            HayConexionConSala = servicioSala.UnirseASala(
                Dominio.CuentaJugador.Actual.NombreJugador, CodigoSala);

            if (servicioSala.EstadoOperacion == EstadoOperacion.Correcto)
            {
                if (HayConexionConSala)
                {
                    CargarJugadoresEnSala();
                }
                else
                {
                    GestorCuadroDialogo.MostrarAdvertencia(
                        Properties.Resources.ETIQUETA_UNIRSESALA_MENSAJESALANODISPONIBLE,
                        Properties.Resources.ETIQUETA_UNIRSESALA_SALANODISPONIBLE);
                    servicioSala.CerrarConexion();
                }
            }
        }

        private void CargarJugadoresEnSala()
        {
            List<CuentaJugador> jugadoresRecuperados = servicioSala.
                ObtenerJugadoresEnSala(CodigoSala);

            if (servicioSala.EstadoOperacion == EstadoOperacion.Correcto)
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
        }

        private void CargarJugadoresEnPestanaSala()
        {
            var jugadoresRecuperados = servicioSala.
                ObtenerJugadoresEnSala(CodigoSala);

            if (servicioSala.EstadoOperacion == EstadoOperacion.Correcto)
            {
                foreach (var jugador in jugadoresRecuperados)
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
        }

        private void CargarAmigosDisponibles()
        {
            var servicioInvitaciones = new ServicioInvitaciones();

            if (servicioInvitaciones.EstadoOperacion == EstadoOperacion.Correcto)
            {
                var amigosRecuperados = servicioInvitaciones.
                    ObtenerAmigosDisponibles(Dominio.CuentaJugador.Actual.NombreJugador);

                if (servicioSala.EstadoOperacion == EstadoOperacion.Correcto)
                {
                    foreach (var amigo in amigosRecuperados)
                    {
                        var cuentaAmigo = new Dominio.CuentaJugador
                        {
                            NombreJugador = amigo.NombreJugador,
                            FuenteImagenAvatar = GeneradorImagenes.
                                GenerarFuenteImagenAvatar(amigo.NumeroAvatar)
                        };
                        AmigosDisponibles.Add(cuentaAmigo);
                    }
                }
            }
        }

        private bool CrearNuevaSala()
        {
            CodigoSala = servicioSala.GenerarCodigoParaNuevaSala();
            bool creacionRealizada = false;
            
            if (servicioSala.EstadoOperacion == EstadoOperacion.Correcto)
            {
                if (!string.IsNullOrEmpty(CodigoSala))
                {
                    creacionRealizada = servicioSala.CrearNuevaSala(
                        Dominio.CuentaJugador.Actual.NombreJugador, CodigoSala);

                    if (servicioSala.EstadoOperacion == EstadoOperacion.Correcto)
                    {
                        UnirseASala();
                    }
                    else
                    {
                        GestorCuadroDialogo.MostrarAdvertencia(
                            Properties.Resources.ETIQUETA_SALA_MENSAJECREACIONSALACANCELADA,
                            Properties.Resources.ETIQUETA_SALA_ERRORCREACIONSALA);
                        servicioSala.CerrarConexion();
                    }
                }
                else
                {
                    GestorCuadroDialogo.MostrarAdvertencia(
                        Properties.Resources.ETIQUETA_SALA_MENSAJECREACIONSALACANCELADA,
                        Properties.Resources.ETIQUETA_SALA_ERRORCREACIONSALA);
                    servicioSala.CerrarConexion();
                }
            }

            return creacionRealizada;
        }

        private void AbandonarSala()
        {
            servicioSala.AbandonarSala(Dominio.CuentaJugador.
                Actual.NombreJugador, CodigoSala);
            servicioSala.CerrarConexion();

            if (servicioSala.EstadoOperacion == EstadoOperacion.Correcto)
            {
                VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
            }
        }

        private void MostrarPanelModificarJugadoresEnSala(object objetoOrigen,
            MouseButtonEventArgs evento)
        {
            panelFondoModificacionJugador.Visibility = Visibility.Visible;
            panelModificacionJugador.Visibility = Visibility.Visible;  
        }

        private void CerrarModificacionJugadores(object objetoOrigen, 
            MouseButtonEventArgs evento)
        {
            panelFondoModificacionJugador.Visibility = Visibility.Hidden;
            panelModificacionJugador.Visibility = Visibility.Hidden;
        }

        private void EnviarInvitacionPorCorreo(object objetoOrigen, RoutedEventArgs evento)
        {
            string correoDestino = cuadroTextoCorreoElectronico.Text.Trim();

            if (!ValidadorDatos.ExistenCaracteresInvalidosParaCorreo(correoDestino))
            {
                if (correoDestino != Dominio.CuentaJugador.Actual.Correo)
                {
                    var servicioCorreo = new ServicioCorreo();
                    
                    if (servicioCorreo.EstadoOperacion == EstadoOperacion.Correcto)
                    {
                        bool envioDeInvitacionRealizado = servicioCorreo.
                            EnviarMensajeACorreoElectronico(correoDestino, Properties.Resources.
                            ETIQUETA_MODIFICACIONSALA_CORREOINVITACIONASUNTO, 
                            Properties.Resources.
                            ETIQUETA_MODIFICACIONSALA_MENSAJECORREOINVITACIONASUNTO, CodigoSala);

                        if (!envioDeInvitacionRealizado)
                        {
                            GestorCuadroDialogo.MostrarAdvertencia(Properties.Resources.
                                ETIQUETA_CODIGO_MENSAJENOENVIADO, Properties.Resources.
                                ETIQUETA_CODIGO_CODIGONOENVIADO);
                        }
                        else
                        {
                            ComenzarTemporizador();
                            GestorCuadroDialogo.MostrarInformacion(Properties.Resources.
                                ETIQUETA_MODIFICACIONSALA_MENSAJEINVITACIONENVIADA,
                                Properties.Resources.
                                ETIQUETA_MODIFICACIONSALA_INVITACIONENVIADA); 
                        }
                    }
                }
                else
                {
                    GestorCuadroDialogo.MostrarAdvertencia(
                        Properties.Resources.ETIQUETA_SALA_MISMOCORREO, 
                        Properties.Resources.ETIQUETA_VALIDACION_CORREOINVALIDO);
                }
            }
            else
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJECORREOINVALIDO,
                    Properties.Resources.ETIQUETA_VALIDACION_CORREOINVALIDO);
            }
        }

        public void MostrarMensajeDeSala(string mensaje)
        {
            cuadroTextoChatDeSala.AppendText(mensaje + "\n");
        }

        public void MostrarNuevoJugadorEnSala(CuentaJugador nuevoJugador)
        {
            var nuevaCuentaJugador = new Dominio.CuentaJugador
            {
                FuenteImagenAvatar = GeneradorImagenes.
                    GenerarFuenteImagenAvatar(nuevoJugador.NumeroAvatar),
                NombreJugador = nuevoJugador.NombreJugador
            };
            JugadoresEnSala.Add(nuevaCuentaJugador);
            JugadoresEnSalaPestana.Add(nuevaCuentaJugador);
        }

        public void MostrarDesconexionDeJugadorEnSala(string nombreJugadorDesconexion)
        {
            var cuentaJugadorEncontrada = JugadoresEnSala.
                FirstOrDefault(jugador => jugador.NombreJugador == 
                nombreJugadorDesconexion);

            if (cuentaJugadorEncontrada != null)
            {
                JugadoresEnSala.Remove(cuentaJugadorEncontrada);
                JugadoresEnSalaPestana.Remove(cuentaJugadorEncontrada);
            }
        }

        public void MostrarNuevaPartida()
        {
            PaginaPartida paginaPartida = new PaginaPartida(CodigoSala);
            VentanaPrincipal.CambiarPagina(paginaPartida);
        }

        public void MostrarMensajeExpulsionDeSala()
        {
            servicioSala.CerrarConexion();
            GestorCuadroDialogo.MostrarAdvertencia(
                Properties.Resources.ETIQUETA_SALA_MENSAJEEXPULSIONDESALA,
                Properties.Resources.ETIQUETA_SALA_EXPULSIONDESALA);
            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());                    
        }

        public void MostrarFuncionesDeAnfitrionEnSala()
        {
            etiquetaModificarJugador.Visibility = Visibility.Visible;
            imagenModificarJugador.Visibility = Visibility.Visible;            

            if (JugadoresEnSala.Count() >=
                CantidadJugadoresMinimosParaIniciarPartida)
            {
                botonNuevaPartida.Visibility = Visibility.Visible;
            }
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
            var nuevaCuentaAmigo = new Dominio.CuentaJugador
            {
                FuenteImagenAvatar = GeneradorImagenes.
                    GenerarFuenteImagenAvatar(cuentaAmigo.NumeroAvatar),
                NombreJugador = cuentaAmigo.NombreJugador
            };
            AmigosDisponibles.Add(nuevaCuentaAmigo);
        }

        public void OcultarAmigoNoDisponible(string nombreAmigo)
        {
            var amigoNoDisponible = AmigosDisponibles.
                FirstOrDefault(amigo => amigo.NombreJugador ==
                nombreAmigo);

            if (amigoNoDisponible != null)
            {
                AmigosDisponibles.Remove(amigoNoDisponible);
            }
        }

        private void botonHacerAnfitrion_Click(object objetoOrigen, RoutedEventArgs evento)
        {

        }

        private void botonExpulsarJugador_Click(object objetoOrigen, RoutedEventArgs evento)
        {

        }

        private void botonInvitar_Click(object objetoOrigen, RoutedEventArgs evento)
        {

        }
    }
}