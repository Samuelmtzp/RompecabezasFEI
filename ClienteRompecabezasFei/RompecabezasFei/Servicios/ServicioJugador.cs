using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.Net.Sockets;
using System.ServiceModel;

namespace RompecabezasFei.Servicios
{
    public class ServicioJugador : Servicio
    {
        public bool RegistrarJugador(CuentaJugador cuentaJugador)
        {
            var cliente = new ServicioJugadorClient();
            bool resultado = false;

            try
            {
                resultado = cliente.RegistrarJugador(cuentaJugador);
                cliente.Close();
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
                    cliente.Abort();
                }
            }

            return resultado;
        }

        public CuentaJugador IniciarSesionComoJugador(
            string nombreJugador, string contrasena)
        {
            var cliente = new ServicioJugadorClient();
            CuentaJugador cuentaJugador = null;

            try
            {
                cuentaJugador = cliente.IniciarSesionComoJugador(
                    nombreJugador, contrasena);
                cliente.Close();
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
                    cliente.Abort();
                }
            }

            return cuentaJugador;
        }

        public CuentaJugador IniciarSesionComoInvitado(string nombreJugador)
        {
            var cliente = new ServicioJugadorClient();
            CuentaJugador cuentaInvitado = null;

            try
            {
                cuentaInvitado = cliente.IniciarSesionComoInvitado(nombreJugador);
                cliente.Close();
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
                    cliente.Abort();
                }
            }

            return cuentaInvitado;
        }

        public void CerrarSesion(string nombreJugador)
        {
            var cliente = new ServicioJugadorClient();

            try
            {
                cliente.CerrarSesion(nombreJugador);
                cliente.Close();
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
                    cliente.Abort();
                }
            }
        }

        public bool ActualizarContrasena(string correo, string nuevaContrasena)
        {
            var cliente = new ServicioJugadorClient(); 
            bool resultado = false;

            try
            {
                resultado = cliente.ActualizarContrasena(correo, nuevaContrasena);
                cliente.Close();
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
                    cliente.Abort();
                }
            }

            return resultado;
        }

        public bool ActualizarNombreJugador(string nombreAnterior, 
            string nuevoNombre)
        {
            var cliente = new ServicioJugadorClient();
            bool resultado = false;

            try
            {
                resultado = cliente.ActualizarNombreJugador(
                    nombreAnterior,nuevoNombre);
                cliente.Close();
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
                    cliente.Abort();
                }
            }

            return resultado;
        }

        public bool ActualizarNumeroAvatar(string nombreJugador, 
            int nuevoNumeroAvatar)
        {
            var cliente = new ServicioJugadorClient();
            bool resultado = false;

            try
            {
                resultado = cliente.ActualizarNumeroAvatar(
                    nombreJugador, nuevoNumeroAvatar);
                cliente.Close();
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
                    cliente.Abort();
                }
            }

            return resultado;
        }

        public bool ExisteNombreJugador(string nombreJugador)
        {
            var cliente = new ServicioJugadorClient();
            bool resultado = false;

            try
            {
                resultado = cliente.ExisteNombreJugador(nombreJugador);
                cliente.Close();
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
                    cliente.Abort();
                }
            }

            return resultado;
        }

        public bool EsLaMismaContrasenaDeJugador(string nombreJugador, string contrasena)
        {
            var cliente = new ServicioJugadorClient();
            bool resultado = false;

            try
            {
                resultado = cliente.EsLaMismaContrasenaDeJugador(
                    nombreJugador, contrasena);
                cliente.Close();
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
                    cliente.Abort();
                }
            }

            return resultado;
        }
    }
}