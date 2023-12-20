using RompecabezasFei.ServicioRompecabezasFei;
using RompecabezasFei.Utilidades;
using Seguridad;
using System;
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
        private ServicioSalaClient clienteServicioSala;

        private Temporizador temporizador;

        public string CodigoSala { get; set; }

        public bool EsAnfitrion { get; set; }

        Color colorActivo = (Color)ColorConverter.ConvertFromString("#FF03A64A");
        Color colorDesactivado = (Color)ColorConverter.ConvertFromString("#808080");

        public ObservableCollection<Dominio.CuentaJugador> JugadoresEnSala { get; set; }

        public PaginaSala()
        {
            InitializeComponent();
            JugadoresEnSala = new ObservableCollection<Dominio.CuentaJugador>();
            listaJugadoresSala.DataContext = this;
            panelModificacionJugador.Visibility = Visibility.Hidden;

            if (EsAnfitrion)
            {
                imagenModificarJugador.Visibility = Visibility.Visible;
                etiquetaModificarJugador.Visibility = Visibility.Visible;
            }
            else
            {
                imagenModificarJugador.Visibility = Visibility.Hidden;
                etiquetaModificarJugador.Visibility = Visibility.Hidden;
            }
        }

        public void RecargarSala()
        {
            clienteServicioSala = new ServicioSalaClient(new InstanceContext(this));
            clienteServicioSala.ActualizarOperacionContextoSala(
                Dominio.CuentaJugador.Actual.NombreJugador, CodigoSala);
            CargarJugadoresEnSala();
            etiquetaCodigoSala.Content = CodigoSala;

            if (EsAnfitrion)
            {
                botonNuevaPartida.Visibility = Visibility.Visible;   
            }
            else
            {
                botonNuevaPartida.Visibility = Visibility.Hidden;
            }
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
                etiquetaTiempoRestante.Content = "00:00";
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

        private void IniciarTemporizador()
        {
            DeshabilitarBotonEnviarInvitacion();
            temporizador = new Temporizador();
            temporizador.Cronometro.Tick += ActualizarTiempoRestante;
            temporizador.IniciarTemporizador();
        }

        private void IrAPaginaMenuPrincipal(object objetoOrigen, MouseButtonEventArgs evento)
        {
            FinalizarConexionConSala();
            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
        }

        private void CopiarCodigoDeSalaEnPortapapeles(object objetoOrigen, 
            RoutedEventArgs evento)
        {
            Clipboard.SetText(CodigoSala);
        }

        private void EnviarMensajeEnChatDeSala(object objetoOrigen, RoutedEventArgs evento)
        {
            if (!ValidadorDatos.EsCadenaVacia(cuadroTextoMensajeUsuario.Text.Trim()))
            {
                clienteServicioSala.EnviarMensajeDeSala(Dominio.CuentaJugador.
                    Actual.NombreJugador, CodigoSala, cuadroTextoMensajeUsuario.Text);
                cuadroTextoMensajeUsuario.Clear();
            }
        }

        private void IrAPaginaCreacionNuevaPartida(object objetoOrigen, RoutedEventArgs evento)
        {
            PaginaCreacionNuevaPartida paginaCreacionNuevaPartida =
                new PaginaCreacionNuevaPartida
                {
                    CodigoSala = CodigoSala
                };
            VentanaPrincipal.CambiarPagina(paginaCreacionNuevaPartida);
        }

        public void UnirseASala()
        {
            clienteServicioSala = new ServicioSalaClient(new InstanceContext(this));

            if (EsAnfitrion)
            {
                botonNuevaPartida.Visibility = Visibility.Visible;
                CrearNuevaSala();
            }
            else
            {
                botonNuevaPartida.Visibility = Visibility.Hidden;
                CargarJugadoresEnSala();
            }

            etiquetaCodigoSala.Content = CodigoSala;            
            ConectarCuentaJugadorASala(Dominio.CuentaJugador.Actual.NombreJugador);
            JugadoresEnSala.Add(Dominio.CuentaJugador.Actual);
        }

        private void ConectarCuentaJugadorASala(string nombreJugador)
        {
            try
            {
                clienteServicioSala.ConectarCuentaJugadorASala(nombreJugador,
                    CodigoSala, Properties.Resources.ETIQUETA_MENSAJESALA_BIENVENIDA);
            }
            catch (EndpointNotFoundException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioSala.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioSala.Abort();
            }
            catch (TimeoutException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioSala.Abort();
            }
        }

        private void CargarJugadoresEnSala()
        {
            CuentaJugador[] jugadoresRecuperados = Servicios.ServicioSala.
                ObtenerJugadoresConectadosEnSala(CodigoSala);

            foreach (CuentaJugador jugador in jugadoresRecuperados)
            {
                JugadoresEnSala.Add(new Dominio.CuentaJugador
                {
                    NombreJugador = jugador.NombreJugador,
                    FuenteImagenAvatar = Utilidades.GeneradorImagenes.
                        GenerarFuenteImagenAvatar(jugador.NumeroAvatar)
                }); 
            }
        }

        private void CrearNuevaSala()
        {
            CodigoSala = Servicios.ServicioSala.GenerarCodigoParaNuevaSala();
            
            if (CodigoSala != null)
            {
                Servicios.ServicioSala.CrearNuevaSala(Dominio.CuentaJugador.
                    Actual.NombreJugador, CodigoSala);
            }     
        }

        private void FinalizarConexionConSala()
        {
            try
            {
                clienteServicioSala.DesconectarCuentaJugadorDeSala(Dominio.
                    CuentaJugador.Actual.NombreJugador, CodigoSala,
                    Properties.Resources.ETIQUETA_MENSAJESALA_DESPEDIDA);
                clienteServicioSala.Close();
            }
            catch (EndpointNotFoundException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioSala.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioSala.Abort();
            }
            catch (TimeoutException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioSala.Abort();
            }

            clienteServicioSala = null;
        }

        private void ModificarJugadoresEnSala(object objetoOrigen,
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
            string correoDestino = cuadroTextoCorreoElectronico.Text;

            if (!ValidadorDatos.ExistenCaracteresInvalidosParaCorreo(correoDestino))
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
                        MessageBox.Show(Properties.Resources.
                                    ETIQUETA_MODIFICACIONSALA_MENSAJEINVITACIONENVIADA, 
                                    Properties.Resources.
                                    ETIQUETA_MODIFICACIONSALA_INVITACIONENVIADA,
                                    MessageBoxButton.OK);
                        IniciarTemporizador();
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
                MessageBox.Show(Properties.Resources.ETIQUETA_VALIDACION_MENSAJECORREOINVALIDO,
                    Properties.Resources.ETIQUETA_VALIDACION_CORREOINVALIDO, 
                    MessageBoxButton.OK);
            }
        }

        #region Callbacks
        public void MostrarMensajeDeSala(string mensaje)
        {
            if (cuadroTextoMensajes != null)
            {
                cuadroTextoMensajes.AppendText(mensaje + "\n");
            }            
        }

        public void NotificarNuevoJugadorConectadoEnSala(CuentaJugador nuevoJugador)
        {
            if (JugadoresEnSala != null)
            {
                Dominio.CuentaJugador nuevaCuentaJugador = new Dominio.CuentaJugador
                {
                    FuenteImagenAvatar = Utilidades.GeneradorImagenes.
                        GenerarFuenteImagenAvatar(nuevoJugador.NumeroAvatar),
                    NombreJugador = nuevoJugador.NombreJugador
                };
                JugadoresEnSala.Add(nuevaCuentaJugador);
            }
        }

        public void NotificarJugadorDesconectadoDeSala(string nombreJugador)
        {
            if (JugadoresEnSala != null)
            {
                Dominio.CuentaJugador cuentaJugadorEncontrada = 
                    JugadoresEnSala.FirstOrDefault(jugador => jugador.NombreJugador == 
                    nombreJugador);

                if (cuentaJugadorEncontrada != null)
                {
                    JugadoresEnSala.Remove(cuentaJugadorEncontrada);
                }
            }
        }

        public void NotificarInicioDePartida()
        {
            PaginaPartida paginaPartida = new PaginaPartida
            {
                CodigoSala = CodigoSala
            };
            VentanaPrincipal.CambiarPagina(paginaPartida);
        }

        public void NotificarCreacionDePartida()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}