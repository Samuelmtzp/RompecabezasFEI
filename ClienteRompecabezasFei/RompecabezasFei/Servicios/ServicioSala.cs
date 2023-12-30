using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.ServiceModel;

namespace RompecabezasFei.Servicios
{
    public class ServicioSala : Servicio
    {
        private ServicioSalaClient clienteServicioSala;

        public ServicioSala()
        {
            clienteServicioSala = new ServicioSalaClient(
                new InstanceContext(new PaginaSala()));
            clienteServicioSala.Open();
        }

        public ServicioSala(PaginaSala paginaSala)
        {
            clienteServicioSala = new ServicioSalaClient(
                new InstanceContext(paginaSala));
            clienteServicioSala.Open();
        }

        public void CerrarConexion()
        {
            if (clienteServicioSala.State == CommunicationState.Opened)
            {
                try
                {
                    clienteServicioSala.Close();
                }
                catch (CommunicationException excepcion)
                {
                    ManejarExcepcionDeServidor(excepcion, true);
                }
                catch (TimeoutException excepcion)
                {
                    ManejarExcepcionDeServidor(excepcion, true);
                }
            }
        }

        public bool ExisteSalaDisponible(string codigoSala)
        {
            bool hayDisponibilidad = false;

            try
            {
                hayDisponibilidad = clienteServicioSala.
                    ExisteSalaDisponible(codigoSala);
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
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, true);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioSala.Abort();
                }
            }

            return hayDisponibilidad;
        }

        public bool CrearNuevaSala(string nombreAnfitrion, string codigoSala)
        {
            bool resultado = false;

            try
            {
                resultado = clienteServicioSala.
                    CrearNuevaSala(nombreAnfitrion, codigoSala);
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
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, true);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioSala.Abort();
                }
            }

            return resultado;
        }

        public string GenerarCodigoParaNuevaSala()
        {
            string codigoSala = "";

            try
            {
                codigoSala = clienteServicioSala.GenerarCodigoParaNuevaSala();
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
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, true);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioSala.Abort();
                }
            }

            return codigoSala;
        }

        public List<CuentaJugador> ObtenerJugadoresConectadosEnSala(
            string codigoSala)
        {
            List<CuentaJugador> jugadoresEnSala = new List<CuentaJugador>();

            try
            {
                var jugadoresObtenidos = clienteServicioSala.
                    ObtenerJugadoresEnSala(codigoSala);
                
                foreach (var jugadorObtenido in jugadoresObtenidos)
                {
                    jugadoresEnSala.Add(jugadorObtenido);
                }

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
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, true);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioSala.Abort();
                }
            }

            return jugadoresEnSala;
        }

        public bool ActivarNotificacionesDeSala(string nombreJugador)
        {
            bool operacionRealizada = false;

            try
            {
                clienteServicioSala.ActivarNotificacionesDeSala(nombreJugador);
                EstadoOperacion = EstadoOperacion.Correcto;
                operacionRealizada = true;
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
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, true);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioSala.Abort();
                }
            }

            return operacionRealizada;
        }        

        public void EnviarMensajeEnChatDeSala(string mensaje, string codigoSala)
        {
            try
            {
                clienteServicioSala.EnviarMensajeDeSala(Dominio.CuentaJugador.
                    Actual.NombreJugador, codigoSala, mensaje);
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
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, true);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioSala.Abort();
                }
            }
        }

        public void DesactivarNotificacionesDeSala(string nombreJugador)
        {
            try
            {
                clienteServicioSala.DesactivarNotificacionesDeSala(nombreJugador);
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
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, true);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioSala.Abort();
                }
            }
        }

        public bool UnirseASala(string nombreJugador, string codigoSala)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = clienteServicioSala.
                    UnirseASala(nombreJugador, codigoSala);
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
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, true);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioSala.Abort();
                }
            }

            return operacionRealizada;
        }

        public bool AbandonarSala(string nombreJugador, string codigoSala)
        {
            bool operacionRealizada = false;

            try
            {
                clienteServicioSala.AbandonarSala(nombreJugador, codigoSala);
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
                ManejarExcepcionDeServidor(excepcion, false);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion, true);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioSala.Abort();
                }
            }

            return operacionRealizada;
        }        
    }
}