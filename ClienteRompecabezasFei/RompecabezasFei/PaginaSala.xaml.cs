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

        private bool esAnfitrion;

        public ObservableCollection<Dominio.CuentaJugador> JugadoresEnSala { get; set; }

        public PaginaSala(bool cargarDatos)
        {
            if (cargarDatos)
            {
                InitializeComponent();                
                JugadoresEnSala = new ObservableCollection<Dominio.CuentaJugador>();
                listaJugadoresSala.DataContext = this;
            }
        }

        public void RecargarSala(bool esAnfitrion)
        {
            this.esAnfitrion = esAnfitrion;
            clienteServicioSala = new ServicioSalaClient(new InstanceContext(this));
            clienteServicioSala.Open();
            clienteServicioSala.RefrescarSesionEnSala(
                Dominio.CuentaJugador.Actual.NombreJugador, CodigoSala);
            CargarJugadoresEnSala();
            etiquetaCodigoSala.Content = CodigoSala;

            if (esAnfitrion)
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
                try
                {
                    clienteServicioSala.EnviarMensajeDeSala(Dominio.CuentaJugador.
                        Actual.NombreJugador, CodigoSala, cuadroTextoMensajeUsuario.Text);
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

        public void UnirseASala(bool esAnfitrion)
        {
            this.esAnfitrion = esAnfitrion;

            if (esAnfitrion)
            {
                MostrarFuncionesDeAnfitrion();
                CrearNuevaSala();
            }
            else
            {
                CargarJugadoresEnSala();
            }

            etiquetaCodigoSala.Content = CodigoSala;
            ConectarCuentaJugadorASala(Dominio.CuentaJugador.Actual.NombreJugador);
            JugadoresEnSala.Add(Dominio.CuentaJugador.Actual);
        }

        private void ConectarCuentaJugadorASala(string nombreJugador)
        {
            clienteServicioSala = new ServicioSalaClient(new InstanceContext(this));
            clienteServicioSala.Open();

            try
            {
                clienteServicioSala.ConectarJugadorASala(nombreJugador,
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
                    FuenteImagenAvatar = GeneradorImagenes.
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
                clienteServicioSala.DesconectarJugadorDeSala(Dominio.
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
            // Mostrar panel de modificación de jugadores de sala
        }

        #region Callbacks
        public void MostrarMensajeDeSala(string mensaje)
        {
            cuadroTextoMensajes.AppendText(mensaje + "\n");
        }

        public void NotificarNuevoJugadorConectadoEnSala(CuentaJugador nuevoJugador)
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

        public void NotificarJugadorDesconectadoDeSala(string nombreJugadorDesconectado)
        {
            if (JugadoresEnSala != null)
            {
                if (Dominio.CuentaJugador.Actual.NombreJugador != nombreJugadorDesconectado)
                {
                    Dominio.CuentaJugador cuentaJugadorEncontrada = JugadoresEnSala.
                        FirstOrDefault(jugador => jugador.NombreJugador == 
                        nombreJugadorDesconectado);

                    if (cuentaJugadorEncontrada != null)
                    {
                        JugadoresEnSala.Remove(cuentaJugadorEncontrada);
                    }
                }
                else
                {
                    VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
                }
            }
        }

        public void NotificarCreacionDePartida()
        {
            PaginaPartida paginaPartida = new PaginaPartida(true, CodigoSala);
            paginaPartida.CargarJugadoresEnPartida();
            VentanaPrincipal.CambiarPagina(paginaPartida);
        }

        public void MostrarFuncionesDeAnfitrion()
        {
            etiquetaModificarJugadores.Visibility = Visibility.Visible;
            imagenModificarJugadores.Visibility= Visibility.Visible;
            botonNuevaPartida.Visibility= Visibility.Visible;
        }
        #endregion
    }
}