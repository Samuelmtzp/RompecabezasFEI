using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.ServiceModel;

namespace RompecabezasFei.Servicios
{
    public class ServicioPartida : Servicio
    {
        private ServicioPartidaClient clienteServicioPartida;

        public ServicioPartida()
        {
            clienteServicioPartida = new ServicioPartidaClient(
                new InstanceContext(new PaginaPartida()));
            clienteServicioPartida.Open();
        }

        public ServicioPartida(PaginaPartida paginaPartida)
        {
            clienteServicioPartida = new ServicioPartidaClient(
                new InstanceContext(paginaPartida));
            clienteServicioPartida.Open();
        }

        public void CerrarConexion()
        {
            if (clienteServicioPartida.State == CommunicationState.Opened)
            {
                try
                {
                    clienteServicioPartida.Close();
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

        public int ObtenerNumeroPartidasJugadas(string nombreJugador)
        {
            int resultado = 0;

            try
            {
                resultado = clienteServicioPartida.
                    ObtenerNumeroDePartidasJugadas(nombreJugador);
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
                    clienteServicioPartida.Abort();
                }
            }

            return resultado;
        }

        public int ObtenerNumeroPartidasGanadas(string nombreJugador)
        {
            int resultado = 0;

            try
            {
                resultado = clienteServicioPartida.
                    ObtenerNumeroDePartidasGanadas(nombreJugador);
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
                    clienteServicioPartida.Abort();
                }
            }

            return resultado;
        }

        public List<CuentaJugador> ObtenerJugadoresConectadosEnPartida(
            string codigoSala)
        {
            List<CuentaJugador> jugadoresEnPartida = new List<CuentaJugador>();

            try
            {
                var jugadoresObtenidos = clienteServicioPartida.
                    ObtenerJugadoresEnPartida(codigoSala);

                foreach (var jugadorObtenido in jugadoresObtenidos)
                {
                    jugadoresEnPartida.Add(jugadorObtenido);
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
                    clienteServicioPartida.Abort();
                }
            }

            return jugadoresEnPartida;
        }

        public bool CrearNuevaPartida(string codigoSala, 
            DificultadPartida dificultadPartida, int numeroImagen)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = clienteServicioPartida.CrearNuevaPartida(
                    codigoSala, dificultadPartida, numeroImagen);
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
                    clienteServicioPartida.Abort();
                }
            }

            return operacionRealizada;
        }

        public bool UnirseAPartida(string codigoSala, string nombreJugador)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = clienteServicioPartida.
                    UnirseAPartida(codigoSala, nombreJugador);
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
                    clienteServicioPartida.Abort();
                }
            }

            return operacionRealizada;
        }

        public void AbandonarPartida(string codigoSala, string nombreJugador)
        {
            try
            {
                clienteServicioPartida.AbandonarPartida(codigoSala, nombreJugador);
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
                    clienteServicioPartida.Abort();
                }
            }
        }

        public void IniciarPartida(string codigoSala)
        {
            try
            {
                clienteServicioPartida.IniciarPartida(codigoSala);
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
                    clienteServicioPartida.Abort();
                }
            }
        }

        public void BloquearPieza(string codigoSala, 
            int numeroPieza, string nombreJugador)
        {
            try
            {
                clienteServicioPartida.BloquearPieza(
                    codigoSala, numeroPieza, nombreJugador);
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
                    clienteServicioPartida.Abort();
                }
            }
        }

        public void DesbloquearPieza(string codigoSala,
            int numeroPieza, string nombreJugador)
        {
            try
            {
                clienteServicioPartida.DesbloquearPieza(
                    codigoSala, numeroPieza, nombreJugador);
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
                    clienteServicioPartida.Abort();
                }
            }
        }

        public void ColocarPieza(string codigoSala, int numeroPieza, 
            string nombreJugador, Posicion posicion)
        {
            try
            {
                clienteServicioPartida.ColocarPieza(
                    codigoSala, numeroPieza, nombreJugador, posicion);
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
                    clienteServicioPartida.Abort();
                }
            }
        }
    }
}