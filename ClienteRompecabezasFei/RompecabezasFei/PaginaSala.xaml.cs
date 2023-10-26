using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.ServiceModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public partial class PaginaSala : Page, IServicioJuegoCallback
    {
        #region Atributos
        private string idSala;
        private bool esNuevaSala;
        private bool esAnfitrion;
        private bool hayConexionEstablecida;
        private ServicioJuegoClient clienteServicioJuego;
        #endregion

        #region Propiedades
        public string IdSala 
        {
            get { return idSala; }
            set { idSala = value; }
        }
        public bool EsNuevaSala
        {
            get { return esNuevaSala; }
            set { esNuevaSala = value; }
        }
        #endregion

        public PaginaSala()
        {
            InitializeComponent();
        }

        private void AccionRegresar(object remitente, MouseButtonEventArgs evento)
        {
            FinalizarConexionConSala();
            VentanaPrincipal.CambiarPagina(this, new PaginaMenuPrincipal());
        }

        private void AccionOpcionesSala(object remitente, RoutedEventArgs evento)
        {

        }

        private void AccionCopiarCodigoSala(object remitente, RoutedEventArgs evento)
        {
            Clipboard.SetText(idSala);
        }

        private void AccionEnviarMensaje(object remitente, RoutedEventArgs evento)
        {
            if (!String.IsNullOrEmpty(CuadroTextoMensajeUsuario.Text))
            {
                clienteServicioJuego.EnviarMensajeDeSala(Dominio.CuentaJugador.
                    CuentaJugadorActual.NombreJugador, idSala, CuadroTextoMensajeUsuario.Text);
                CuadroTextoMensajeUsuario.Clear();
            }
        }

        private void AccionIniciarPartida(object remitente, RoutedEventArgs evento)
        {
            
        }

        public bool CrearNuevaSala(bool esNuevaSala)
        {
            bool estadoCreacionSala = true;
            this.esNuevaSala = esNuevaSala;

            if (esNuevaSala)
            {
                BotonIniciarPartida.Visibility = Visibility.Visible;
            }
            else
            {
                BotonIniciarPartida.Visibility = Visibility.Hidden;
            }

            try
            {
                IniciarConexionConSala();
            }
            catch (EndpointNotFoundException)
            {
                estadoCreacionSala = false;                
            }
            catch (CommunicationObjectFaultedException)
            {
                estadoCreacionSala = false;
            }
            catch (TimeoutException)
            {
                estadoCreacionSala = false;
            }
            return estadoCreacionSala;
        }

        private void IniciarConexionConSala()
        {
            if (!hayConexionEstablecida)
            {
                clienteServicioJuego = new ServicioJuegoClient(new InstanceContext(this));
                if (esNuevaSala)
                {
                    esAnfitrion = true;
                    idSala = clienteServicioJuego.GenerarCodigoParaNuevaSala();
                    clienteServicioJuego.NuevaSala(Dominio.CuentaJugador.
                        CuentaJugadorActual.NombreJugador, idSala);
                }
                else
                {
                    esAnfitrion = false;
                }
                EtiquetaCodigoSala.Content = idSala;
                clienteServicioJuego.ConectarCuentaJugadorASala(Dominio.CuentaJugador.
                    CuentaJugadorActual.NombreJugador, idSala, 
                    Properties.Resources.ETIQUETA_MENSAJESALA_BIENVENIDA);
                hayConexionEstablecida = true;
            }
        }

        private void FinalizarConexionConSala()
        {
            if (hayConexionEstablecida)
            {
                clienteServicioJuego.DesconectarCuentaJugadorDeSala(Dominio.CuentaJugador.
                        CuentaJugadorActual.NombreJugador, idSala, 
                        Properties.Resources.ETIQUETA_MENSAJESALA_DESPEDIDA);
                clienteServicioJuego.Abort();
                clienteServicioJuego = null;
                hayConexionEstablecida = false;
            }
        }

        public bool VerificarDisponibilidadSala(string idSala)
        {
            clienteServicioJuego = new ServicioJuegoClient(new InstanceContext(this));
            bool disponibilidadSala = false;

            try
            {
                disponibilidadSala = clienteServicioJuego.ExisteSalaDisponible(idSala);
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (CommunicationObjectFaultedException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (TimeoutException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                clienteServicioJuego.Abort();
            }

            return disponibilidadSala;
        }

        #region Callbacks
        public void MensajeDeSalaCallBack(string mensaje)
        {
            CuadroTextoMensajes.AppendText(mensaje + "\n");
        }
        #endregion
    }
}