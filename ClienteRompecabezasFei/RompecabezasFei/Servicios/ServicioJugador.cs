using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.Net.Sockets;
using System.ServiceModel;
using System.Timers;
using System.Windows;

namespace RompecabezasFei.Servicios
{
    public class ServicioJugador : Servicio
    {
        private const int IntervaloMilisegundosTemporizador = 1000;
        
        private static Timer temporizador;
        
        public static ServicioJugadorClient ClienteServicioJugador { get; set; }

        public void IniciarTemporizador()
        {
            temporizador = new Timer();
            temporizador.Interval = IntervaloMilisegundosTemporizador;
            temporizador.Elapsed += ProbarConexionServidor;
            temporizador.Start();
        }

        public void DetenerTemporizador()
        {
            temporizador.Stop();
        }

        public bool HayTemporizadorActivo()
        {
            return temporizador.Enabled;
        }

        public void AbrirNuevaConexion()
        {
            ClienteServicioJugador = new ServicioJugadorClient(
                new InstanceContext(VentanaPrincipal.ObtenerVentanaActual()));
            
            try
            {
                ClienteServicioJugador.Open();
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (SocketException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    ClienteServicioJugador.Abort();
                }
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (ClienteServicioJugador.State == CommunicationState.Opened)
                {
                    ClienteServicioJugador.Close();
                }
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (SocketException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, true);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, true);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    ClienteServicioJugador.Abort();
                }
            }
        }

        public bool RegistrarJugador(CuentaJugador cuentaJugador)
        {
            bool resultado = false;

            try
            {
                resultado = ClienteServicioJugador.
                    RegistrarJugador(cuentaJugador);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (SocketException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    ClienteServicioJugador.Abort();
                }
            }

            return resultado;
        }

        public CuentaJugador IniciarSesionComoJugador(
            string nombreJugador, string contrasena)
        {
            CuentaJugador cuentaJugador = null;

            try
            {
                cuentaJugador = ClienteServicioJugador.
                    IniciarSesionComoJugador(nombreJugador, contrasena);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (SocketException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    ClienteServicioJugador.Abort();
                }
            }

            return cuentaJugador;
        }

        public CuentaJugador IniciarSesionComoInvitado(string nombreJugador)
        {
            CuentaJugador cuentaInvitado = null;

            try
            {
                cuentaInvitado = ClienteServicioJugador.
                    IniciarSesionComoInvitado(nombreJugador);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (SocketException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    ClienteServicioJugador.Abort();
                }
            }

            return cuentaInvitado;
        }

        public void CerrarSesion(string nombreJugador)
        {
            try
            {
                ClienteServicioJugador.CerrarSesion(nombreJugador);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (SocketException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    ClienteServicioJugador.Abort();
                }
            }
        }

        public bool ActualizarContrasena(string correo, string nuevaContrasena)
        {
            bool resultado = false;

            try
            {
                resultado = ClienteServicioJugador.
                    ActualizarContrasena(correo, nuevaContrasena);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (SocketException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    ClienteServicioJugador.Abort();
                }
            }

            return resultado;
        }

        public bool ActualizarNombreJugador(string nombreAnterior, 
            string nuevoNombre)
        {
            bool resultado = false;

            try
            {
                resultado = ClienteServicioJugador.
                    ActualizarNombreJugador(nombreAnterior,nuevoNombre);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (SocketException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    ClienteServicioJugador.Abort();
                }
            }

            return resultado;
        }

        public bool ActualizarNumeroAvatar(string nombreJugador, 
            int nuevoNumeroAvatar)
        {
            bool resultado = false;

            try
            {
                resultado = ClienteServicioJugador.
                    ActualizarNumeroAvatar(nombreJugador, nuevoNumeroAvatar);                
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (SocketException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    ClienteServicioJugador.Abort();
                }
            }

            return resultado;
        }

        public bool ExisteNombreJugadorRegistrado(string nombreJugador)
        {
            bool resultado = false;

            try
            {
                resultado = ClienteServicioJugador.
                    ExisteNombreJugadorRegistrado(nombreJugador);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (SocketException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    ClienteServicioJugador.Abort();
                }
            }

            return resultado;
        }

        public bool EsLaMismaContrasenaDeJugador(string nombreJugador, string contrasena)
        {
            bool resultado = false;

            try
            {
                resultado = ClienteServicioJugador.
                    EsLaMismaContrasenaDeJugador(nombreJugador, contrasena);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (SocketException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, false);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    ClienteServicioJugador.Abort();
                }
            }

            return resultado;
        }

        public void ProbarConexionServidor(object sender, ElapsedEventArgs e)
        {
            Application.Current.Dispatcher.Invoke((Action)delegate 
            {
                try
                {
                    DetenerTemporizador();
                    ClienteServicioJugador.ProbarConexionServidor();
                    IniciarTemporizador();
                    EstadoOperacion = EstadoOperacion.Correcto;
                }
                catch (EndpointNotFoundException excepcion)
                {
                    ManejarExcepcionDeServidor(excepcion, true);
                }
                catch (CommunicationObjectFaultedException excepcion)
                {
                    ManejarExcepcionDeServidor(excepcion, true);
                }
                catch (CommunicationObjectAbortedException excepcion)
                {
                    ManejarExcepcionDeServidor(excepcion, true);
                }
                catch (SocketException excepcion)
                {
                    ManejarExcepcionDeServidor(excepcion, true);
                }
                catch (TimeoutException excepcion)
                {
                    ManejarExcepcionDeServidor(excepcion, true);
                }
                finally
                {
                    if (EstadoOperacion == EstadoOperacion.Error)
                    {
                        ClienteServicioJugador.Abort();
                    }
                }
            });
        }
    }
}