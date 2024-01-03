using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.ServiceModel;

namespace RompecabezasFei.Servicios
{
    public class ServicioPartida : Servicio
    {
        private readonly ServicioPartidaClient clienteServicioPartida;

        public ServicioPartida()
        {
            clienteServicioPartida = new ServicioPartidaClient(
                new InstanceContext(new PaginaPartida()));
            AbrirConexion();
        }

        public ServicioPartida(PaginaPartida paginaPartida)
        {
            clienteServicioPartida = new ServicioPartidaClient(
                new InstanceContext(paginaPartida));
            AbrirConexion();
        }

        public override void AbrirConexion()
        {
            try
            {
                clienteServicioPartida.Open();
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
            if (clienteServicioPartida.State == CommunicationState.Opened)
            {
                try
                {
                    clienteServicioPartida.Close();
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
            catch (ObjectDisposedException excepcion)
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
                    clienteServicioPartida.Abort();
                }
            }

            return operacionRealizada;
        }

        public void UnirseAPartida(string codigoSala, string nombreJugador)
        {
            try
            {
                clienteServicioPartida.UnirseAPartida(
                    codigoSala, nombreJugador);
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
            catch (ObjectDisposedException excepcion)
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
                    clienteServicioPartida.Abort();
                }
            }
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
            catch (ObjectDisposedException excepcion)
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
            catch (ObjectDisposedException excepcion)
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
            catch (ObjectDisposedException excepcion)
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
            catch (ObjectDisposedException excepcion)
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
            catch (ObjectDisposedException excepcion)
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
                    clienteServicioPartida.Abort();
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
            catch (ObjectDisposedException excepcion)
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
            catch (ObjectDisposedException excepcion)
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
                    clienteServicioPartida.Abort();
                }
            }

            return resultado;
        }

        public void ExpulsarJugadorEnPartida(string nombreJugadorExpulsion, 
            string codigoSala)
        {
            try
            {
                clienteServicioPartida.ExpulsarJugadorEnPartida(
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
            catch (ObjectDisposedException excepcion)
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
                    clienteServicioPartida.Abort();
                }
            }
        }

        public List<CuentaJugador> ObtenerJugadoresEnPartida(string codigoSala)
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
            catch (ObjectDisposedException excepcion)
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
                    clienteServicioPartida.Abort();
                }
            }

            return jugadoresEnPartida;
        }

        public void ConvertirJugadorEnAnfitrionDesdePartida(
            string nombreJugador, string codigoSala)
        {
            try
            {
                clienteServicioPartida.
                    ConvertirJugadorEnAnfitrionDesdePartida(
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
            catch (ObjectDisposedException excepcion)
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
                    clienteServicioPartida.Abort();
                }
            }
        }
    }
}