using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.ServiceModel;

namespace RompecabezasFei.Servicios
{
    public class ServicioAmistades : Servicio
    {
        private ServicioAmistadesClient clienteServicioAmistades;

        public ServicioAmistades()
        {
            clienteServicioAmistades = new ServicioAmistadesClient(
                new InstanceContext(new PaginaAmistades(false)));
            clienteServicioAmistades.Open();
        }

        public ServicioAmistades(PaginaAmistades paginaPartida)
        {
            clienteServicioAmistades = new ServicioAmistadesClient(
                new InstanceContext(paginaPartida));
            clienteServicioAmistades.Open();
        }

        public void CerrarConexion()
        {
            if (clienteServicioAmistades.State == CommunicationState.Opened)
            {
                try
                {
                    clienteServicioAmistades.Close();
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


        public List<CuentaJugador> ObtenerAmigosDeJugador(string nombreJugador)
        {
            var amigosDeJugador = new List<CuentaJugador>();

            try
            {
                var amigosObtenidos = clienteServicioAmistades.
                    ObtenerAmigosDeJugador(nombreJugador);
                
                if (amigosObtenidos.Any())
                {
                    foreach (var amigo in amigosObtenidos)
                    {
                        amigosDeJugador.Add(amigo);
                    }
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
                    clienteServicioAmistades.Abort();
                }
            }

            return amigosDeJugador;
        }

        public List<CuentaJugador> ObtenerJugadoresConSolicitudPendiente(
            string nombreJugador)
        {
            var jugadoresConSolicitud = new List<CuentaJugador>();

            try
            {
                var jugadoresObtenidos = clienteServicioAmistades.
                    ObtenerJugadoresConSolicitudPendiente(nombreJugador);

                if (jugadoresObtenidos.Any())
                {
                    foreach (var jugador in jugadoresObtenidos)
                    {
                        jugadoresConSolicitud.Add(jugador);
                    }
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
                    clienteServicioAmistades.Abort();
                }
            }

            return jugadoresConSolicitud;
        }

        public bool ExisteSolicitudAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            bool existeSolicitudAmistad = false;

            try
            {
                existeSolicitudAmistad = clienteServicioAmistades.
                    ExisteSolicitudDeAmistad(nombreJugadorOrigen, 
                    nombreJugadorDestino);
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
                    clienteServicioAmistades.Abort();
                }
            }

            return existeSolicitudAmistad;
        }

        public bool ExisteAmistadConJugador(string nombreJugadorA, 
            string nombreJugadorB)
        {
            bool existeSolicitudAmistad = false;

            try
            {
                existeSolicitudAmistad = clienteServicioAmistades.
                    ExisteSolicitudDeAmistad(nombreJugadorA, nombreJugadorB);
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
                    clienteServicioAmistades.Abort();
                }
            }

            return existeSolicitudAmistad;
        }

        public bool RechazarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            bool solicitudRechazada = false;

            try
            {
                solicitudRechazada = clienteServicioAmistades.
                    RechazarSolicitudDeAmistad(nombreJugadorOrigen, nombreJugadorDestino);
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
                    clienteServicioAmistades.Abort();
                }
            }

            return solicitudRechazada;
        }

        public void ActivarNotificaciones(string nombreJugador)
        {
            try
            {
                clienteServicioAmistades.ActivarNotificacionesDeAmistades(nombreJugador);
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
                    clienteServicioAmistades.Abort();
                }
            }
        }

        public void DesactivarNotificaciones(string nombreJugador)
        {
            try
            {
                clienteServicioAmistades.DesactivarNotificacionesDeAmistades(nombreJugador);
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
                    clienteServicioAmistades.Abort();
                }
            }
        }

        public bool EnviarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = clienteServicioAmistades.
                    EnviarSolicitudDeAmistad(nombreJugadorOrigen, nombreJugadorDestino);
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
                    clienteServicioAmistades.Abort();
                }
            }

            return operacionRealizada;
        }

        public bool EliminarAmistad(string nombreJugadorA, string nombreJugadorB)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = clienteServicioAmistades.
                    EnviarSolicitudDeAmistad(nombreJugadorA, nombreJugadorB);
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
                    clienteServicioAmistades.Abort();
                }
            }

            return operacionRealizada;
        }

        public bool AceptarSolicitudDeAmistad(string nombreJugadorA, 
            string nombreJugadorB)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = clienteServicioAmistades.
                    AceptarSolicitudDeAmistad(nombreJugadorA, nombreJugadorB);
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
                    clienteServicioAmistades.Abort();
                }
            }

            return operacionRealizada;
        }
    }
}