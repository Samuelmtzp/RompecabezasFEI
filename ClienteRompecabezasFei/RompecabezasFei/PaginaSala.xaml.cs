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

namespace RompecabezasFei
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public partial class PaginaSala : Page, IServicioSalaCallback
    {
        private ServicioSalaClient clienteServicioSala;

        public string CodigoSala { get; set; }

        public bool EsAnfitrion { get; set; }

        public ObservableCollection<Dominio.CuentaJugador> JugadoresEnSala { get; set; }

        public PaginaSala()
        {
            InitializeComponent();
            JugadoresEnSala = new ObservableCollection<Dominio.CuentaJugador>();
            listaJugadoresSala.DataContext = this;
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
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioSala.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioSala.Abort();
            }
            catch (TimeoutException excepcion)
            {
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
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioSala.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioSala.Abort();
            }
            catch (TimeoutException excepcion)
            {
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                clienteServicioSala.Abort();
            }

            clienteServicioSala = null;
        }

        private void ModificarJugadoresEnSala(object objetoOrigen,
            MouseButtonEventArgs evento)
        {
            // Ir a la página de modificacion de jugadores de sala
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