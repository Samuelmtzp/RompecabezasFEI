using RompecabezasFei.ServicioRompecabezasFei;
using Seguridad;
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
        private string codigoSala;
        private bool esAnfitrion;
        private ServicioSalaClient clienteServicioJuego;
        private ObservableCollection<Dominio.CuentaJugador> jugadoresEnSala;

        public string CodigoSala 
        {
            get { return codigoSala; }
            set { codigoSala = value; }
        }

        public bool EsAnfitrion
        {
            get { return esAnfitrion; }
            set { esAnfitrion = value; }
        }

        public ObservableCollection<Dominio.CuentaJugador> JugadoresEnSala
        {
            get { return jugadoresEnSala; }
            set { jugadoresEnSala = value; }
        }

        public PaginaSala()
        {
            InitializeComponent();
            jugadoresEnSala = new ObservableCollection<Dominio.CuentaJugador>();
            listaJugadoresSala.DataContext = this;
        }        

        private void IrAPaginaMenuPrincipal(object objetoOrigen, MouseButtonEventArgs evento)
        {
            FinalizarConexionConSala();
            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
        }

        private void CopiarCodigoDeSalaEnPortapapeles(object objetoOrigen, 
            RoutedEventArgs evento)
        {
            Clipboard.SetText(codigoSala);
        }

        private void EnviarMensajeEnChatDeSala(object objetoOrigen, RoutedEventArgs evento)
        {
            if (!ValidadorDatos.EsCadenaVacia(cuadroTextoMensajeUsuario.Text.Trim()))
            {
                clienteServicioJuego.EnviarMensajeDeSala(Dominio.CuentaJugador.
                    Actual.NombreJugador, codigoSala, cuadroTextoMensajeUsuario.Text);
                cuadroTextoMensajeUsuario.Clear();
            }
        }

        private void IrAPaginaCreacionNuevaPartida(object objetoOrigen, RoutedEventArgs evento)
        {
            PaginaCreacionNuevaPartida paginaCreacionNuevaPartida = 
                new PaginaCreacionNuevaPartida();
            paginaCreacionNuevaPartida.CodigoSala = codigoSala;
            VentanaPrincipal.CambiarPagina(paginaCreacionNuevaPartida);
        }

        public void UnirseASala()
        {
            clienteServicioJuego = new ServicioSalaClient(new InstanceContext(this));

            if (esAnfitrion)
            {
                botonNuevaPartida.Visibility = Visibility.Visible;
                CrearNuevaSala();
            }
            else
            {
                botonNuevaPartida.Visibility = Visibility.Hidden;
                CargarJugadoresEnSala();
            }

            etiquetaCodigoSala.Content = codigoSala;            
            ConectarCuentaJugadorASala(Dominio.CuentaJugador.Actual.NombreJugador);
            jugadoresEnSala.Add(Dominio.CuentaJugador.Actual);
        }

        private void ConectarCuentaJugadorASala(string nombreJugador)
        {
            try
            {
                clienteServicioJuego.ConectarCuentaJugadorASala(nombreJugador,
                    codigoSala, Properties.Resources.ETIQUETA_MENSAJESALA_BIENVENIDA);
            }
            catch (EndpointNotFoundException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioJuego.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioJuego.Abort();
            }
            catch (TimeoutException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioJuego.Abort();
            }
        }

        private void CargarJugadoresEnSala()
        {
            CuentaJugador[] jugadoresRecuperados = Servicios.ServicioSala.
                ObtenerJugadoresConectadosEnSala(codigoSala);

            foreach (CuentaJugador jugador in jugadoresRecuperados)
            {
                jugadoresEnSala.Add(new Dominio.CuentaJugador
                {
                    NombreJugador = jugador.NombreJugador,
                    FuenteImagenAvatar = Utilidades.GeneradorImagenes.
                        GenerarFuenteImagenAvatar(jugador.NumeroAvatar)
                });
            }
        }

        private void CrearNuevaSala()
        {
            codigoSala = Servicios.ServicioSala.GenerarCodigoParaNuevaSala();
            
            if (codigoSala != null)
            {
                Servicios.ServicioSala.CrearNuevaSala(Dominio.CuentaJugador.
                    Actual.NombreJugador, codigoSala);
            }     
        }

        private void FinalizarConexionConSala()
        {
            try
            {
                clienteServicioJuego.DesconectarCuentaJugadorDeSala(Dominio.
                    CuentaJugador.Actual.NombreJugador, codigoSala,
                    Properties.Resources.ETIQUETA_MENSAJESALA_DESPEDIDA);
                clienteServicioJuego.Close();
            }
            catch (EndpointNotFoundException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioJuego.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioJuego.Abort();
            }
            catch (TimeoutException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                clienteServicioJuego.Abort();
            }

            clienteServicioJuego = null;
        }

        private void ModificarJugadoresEnSala(object objetoOrigen,
            MouseButtonEventArgs evento)
        {

        }

        #region Callbacks
        public void MostrarMensajeDeSala(string mensaje)
        {
            cuadroTextoMensajes.AppendText(mensaje + "\n");
        }

        public void NotificarNuevoJugadorConectadoEnSala(CuentaJugador nuevoJugador)
        {
            if (jugadoresEnSala != null)
            {
                Dominio.CuentaJugador nuevaCuentaJugador = new Dominio.CuentaJugador
                {
                    FuenteImagenAvatar = Utilidades.GeneradorImagenes.
                        GenerarFuenteImagenAvatar(nuevoJugador.NumeroAvatar),
                    NombreJugador = nuevoJugador.NombreJugador
                };
                jugadoresEnSala.Add(nuevaCuentaJugador);
            }
        }

        public void NotificarJugadorDesconectadoDeSala(string nombreJugador)
        {
            if (jugadoresEnSala != null)
            {
                Dominio.CuentaJugador cuentaJugadorEncontrada = 
                    jugadoresEnSala.Where(jugador => jugador.NombreJugador == 
                    nombreJugador).FirstOrDefault();

                if (cuentaJugadorEncontrada != null)
                {
                    jugadoresEnSala.Remove(cuentaJugadorEncontrada);
                }
            }
        }
        #endregion
    }
}