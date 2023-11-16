using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.Collections.ObjectModel;
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
        #region Atributos
        private string codigoSala;
        private bool esNuevaSala;
        private bool esAnfitrion;
        private bool hayConexionEstablecida;
        private ServicioSalaClient clienteServicioJuego;
        private ObservableCollection<Dominio.CuentaJugador> jugadoresSala;
        #endregion

        #region Propiedades
        public string CodigoSala 
        {
            get { return codigoSala; }
            set { codigoSala = value; }
        }
        public bool EsNuevaSala
        {
            get { return esNuevaSala; }
            set { esNuevaSala = value; }
        }
        public ObservableCollection<Dominio.CuentaJugador> JugadoresSala
        {
            get { return jugadoresSala; }
            set { jugadoresSala = value; }
        }
        #endregion

        public PaginaSala()
        {
            InitializeComponent();
            jugadoresSala = new ObservableCollection<Dominio.CuentaJugador>();
            listaJugadoresSala.DataContext = this;
        }        

        private void EventoClickRegresar(object remitente, MouseButtonEventArgs evento)
        {
            FinalizarConexionConSala();
            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
        }

        private void AccionCopiarCodigoSala(object remitente, RoutedEventArgs evento)
        {
            Clipboard.SetText(codigoSala);
        }

        private void AccionEnviarMensaje(object remitente, RoutedEventArgs evento)
        {
            if (!string.IsNullOrEmpty(CuadroTextoMensajeUsuario.Text.Trim()))
            {
                clienteServicioJuego.EnviarMensajeDeSala(Dominio.CuentaJugador.
                    Actual.NombreJugador, codigoSala, CuadroTextoMensajeUsuario.Text);
                CuadroTextoMensajeUsuario.Clear();
            }
        }

        private void EventoClickNuevaPartida(object remitente, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaNuevaPartida(codigoSala));
            
        }

        public void IniciarConexionConSala(bool esNuevaSala)
        {
            this.esNuevaSala = esNuevaSala;

            if (!hayConexionEstablecida)
            {
                clienteServicioJuego = new ServicioSalaClient(new InstanceContext(this));

                if (esNuevaSala)
                {
                    esAnfitrion = true;
                    botonNuevaPartida.Visibility = Visibility.Visible;
                    CrearNuevaSala();
                }
                else
                {
                    esAnfitrion = false;
                    botonNuevaPartida.Visibility = Visibility.Hidden;
                }

                jugadoresSala.Add(Dominio.CuentaJugador.Actual);
                EtiquetaCodigoSala.Content = codigoSala;                
                CargarJugadoresEnSala();
                clienteServicioJuego.ConectarCuentaJugadorASala(Dominio.CuentaJugador.
                    Actual.NombreJugador, codigoSala, 
                    Properties.Resources.ETIQUETA_MENSAJESALA_BIENVENIDA);
                hayConexionEstablecida = true;
            }
        }

        private void CargarJugadoresEnSala()
        {
            CuentaJugador[] jugadoresACargar = clienteServicioJuego.
                ObtenerJugadoresConectadosEnSala(codigoSala);

            foreach (CuentaJugador jugador in jugadoresACargar)
            {
                jugadoresSala.Add(new Dominio.CuentaJugador
                {
                    NombreJugador = jugador.NombreJugador,
                    FuenteImagenAvatar = Utilidades.GeneradorImagenes.
                        GenerarFuenteImagenAvatar(jugador.NumeroAvatar)
                });
            }
        }

        public void CargarDatosSala(bool esAnfitrion, string codigoSala)
        {
            this.esAnfitrion = esAnfitrion;
            EtiquetaCodigoSala.Content = codigoSala;
        }

        private void CrearNuevaSala()
        {
            try
            {
                codigoSala = clienteServicioJuego.GenerarCodigoParaNuevaSala();
                clienteServicioJuego.CrearNuevaSala(Dominio.CuentaJugador.
                    Actual.NombreJugador, codigoSala);
            }
            catch (CommunicationException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioJuego.Abort();
            }
            catch (TimeoutException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioJuego.Abort();
            }
        }

        private void FinalizarConexionConSala()
        {
            if (hayConexionEstablecida)
            {
                try
                {
                    clienteServicioJuego.DesconectarCuentaJugadorDeSala(Dominio.
                        CuentaJugador.Actual.NombreJugador, codigoSala,
                        Properties.Resources.ETIQUETA_MENSAJESALA_DESPEDIDA);
                }
                catch (CommunicationException)
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

                clienteServicioJuego = null;
                hayConexionEstablecida = false;
            }
        }

        public bool VerificarDisponibilidadSala(string idSala)
        {
            bool disponibilidadSala = false;
            ServicioSalaClient cliente = new 
                ServicioSalaClient(new InstanceContext(this));

            try
            {
                disponibilidadSala = cliente.ExisteSalaDisponible(idSala);
            }
            catch (CommunicationException)
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
                cliente.Abort();
            }

            return disponibilidadSala;
        }

        private void EventoClickModificarJugadores(object objetoOrigen,
            MouseButtonEventArgs evento)
        {

        }

        #region Callbacks
        public void MostrarMensajeDeSala(string mensaje)
        {
            CuadroTextoMensajes.AppendText(mensaje + "\n");
        }

        public void NotificarNuevoJugadorConectadoEnSala(CuentaJugador nuevoJugador)
        {
            if (jugadoresSala != null)
            {
                Dominio.CuentaJugador nuevaCuentaJugador = new Dominio.CuentaJugador
                {
                    FuenteImagenAvatar = Utilidades.GeneradorImagenes.
                        GenerarFuenteImagenAvatar(nuevoJugador.NumeroAvatar),
                    NombreJugador = nuevoJugador.NombreJugador
                };
                jugadoresSala.Add(nuevaCuentaJugador);
            }
        }

        public void NotificarJugadorDesconectadoDeSala(string nombreJugador)
        {
            if (jugadoresSala != null)
            {
                Dominio.CuentaJugador cuentaJugadorEncontrada = 
                    jugadoresSala.Where(jugador => jugador.NombreJugador == 
                    nombreJugador).FirstOrDefault();

                if (cuentaJugadorEncontrada != null)
                {
                    jugadoresSala.Remove(cuentaJugadorEncontrada);
                }
            }
        }
        #endregion
    }
}