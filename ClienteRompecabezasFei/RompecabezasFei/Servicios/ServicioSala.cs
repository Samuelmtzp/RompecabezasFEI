using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.ServiceModel;

namespace RompecabezasFei.Servicios
{
    public class ServicioSala : Servicio
    {
        private readonly ServicioSalaClient clienteServicioSala;

        public ServicioSala()
        {
            clienteServicioSala = new ServicioSalaClient(
                new InstanceContext(new PaginaSala()));
            AbrirConexion();
        }

        public ServicioSala(PaginaSala paginaSala)
        {
            clienteServicioSala = new ServicioSalaClient(
                new InstanceContext(paginaSala));
            AbrirConexion();
        }

        public override void AbrirConexion()
        {
            try
            {
                clienteServicioSala.Open();
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (InvalidOperationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
        }

        public override void CerrarConexion()
        {
            if (clienteServicioSala.State == CommunicationState.Opened)
            {
                try
                {
                    clienteServicioSala.Close();
                    EstadoOperacion = EstadoOperacion.Correcto;
                }
                catch (CommunicationException excepcion)
                {
                    ManejarExcepcionDeServidor(excepcion);
                }
                catch (TimeoutException excepcion)
                {
                    ManejarExcepcionDeServidor(excepcion);
                }
                catch (InvalidOperationException excepcion)
                {
                    ManejarExcepcionDeServidor(excepcion);                        
                }
            }
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
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
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
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
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

        public void ActivarNotificacionesDeSala(string nombreJugador)
        {
            try
            {
                clienteServicioSala.ActivarNotificacionesDeSala(nombreJugador);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
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
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioSala.Abort();
                }
            }
        }

        public void AbandonarSala(string nombreJugador, string codigoSala)
        {
            try
            {
                clienteServicioSala.AbandonarSala(nombreJugador, codigoSala);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioSala.Abort();
                }
            }
        }

        public List<CuentaJugador> ObtenerJugadoresEnSala(string codigoSala)
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
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
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

        public void EnviarMensajeDeSala(string mensaje, string codigoSala)
        {
            try
            {
                clienteServicioSala.EnviarMensajeDeSala(Dominio.CuentaJugador.
                    Actual.NombreJugador, codigoSala, mensaje);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioSala.Abort();
                }
            }
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
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
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
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
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

        public void ConvertirJugadorEnAnfitrionDesdeSala(
            string nombreJugador, string codigoSala)
        {
            try
            {
                clienteServicioSala.ConvertirJugadorEnAnfitrionDesdeSala(
                    nombreJugador, codigoSala);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioSala.Abort();
                }
            }
        }

        public void InvitarJugador(string nombreJugador, 
            string nombreAnfitrion, string codigoSala)
        {
            try
            {
                clienteServicioSala.InvitarJugador(nombreJugador, 
                    nombreAnfitrion, codigoSala);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioSala.Abort();
                }
            }
        }

        public void ExpulsarJugadorEnSala(string nombreJugadorExpulsion, 
            string codigoSala)
        {
            try
            {
                clienteServicioSala.ExpulsarJugadorEnSala(
                    nombreJugadorExpulsion, codigoSala);
                EstadoOperacion = EstadoOperacion.Correcto;
            }
            catch (EndpointNotFoundException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationObjectAbortedException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (CommunicationException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            catch (TimeoutException excepcion)
            {
                ManejarExcepcionDeServidor(excepcion);
            }
            finally
            {
                if (EstadoOperacion == EstadoOperacion.Error)
                {
                    clienteServicioSala.Abort();
                }
            }
        }
    }
}