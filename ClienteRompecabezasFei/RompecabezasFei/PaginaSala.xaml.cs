using Dominio;
using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using static System.Runtime.CompilerServices.RuntimeHelpers;

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
        private ServicioRompecabezasFei.CuentaJugador[] listaCuentasJugador;
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
            VentanaPrincipal.CambiarPagina(this, new PaginaMenuPrincipal());
        }

        private void AccionOpcionesSala(object remitente, RoutedEventArgs evento)
        {

        }

        private void AccionEnviarMensaje(object remitente, RoutedEventArgs evento)
        {
            if (!string.IsNullOrEmpty(CuadroTextoMensajeUsuario.Text))
            {
                clienteServicioJuego.EnviarMensaje(Dominio.CuentaJugador.CuentaJugadorActual.NombreJugador, 
                    idSala, CuadroTextoMensajes.Text);
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
                IniciarSala();
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

        private void IniciarSala()
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
                    CuentaJugadorActual.NombreJugador, idSala);
                hayConexionEstablecida = true;
            }
        }

        public bool VerificarDisponibilidadSala(string idSala)
        {
            clienteServicioJuego = new ServicioJuegoClient(new InstanceContext(this));
            var disponibilidadSala = false;

            try
            {
                disponibilidadSala = clienteServicioJuego.ExisteSalaDisponible(idSala);
            }
            catch (EndpointNotFoundException)
            {
            }
            catch (CommunicationObjectFaultedException)
            {
            }
            catch (TimeoutException)
            {
            }
            finally
            {
                clienteServicioJuego.Abort();
            }

            return disponibilidadSala;
        }

        #region Callbacks
        public void MensajeCallBack(string mensaje)
        {
            CuadroTextoMensajes.Text += mensaje + "\n";
        }
        #endregion
    }
}
