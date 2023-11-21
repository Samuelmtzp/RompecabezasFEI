using RompecabezasFei.ServicioRompecabezasFei;
using RompecabezasFei.Utilidades;
using System;
using System.ServiceModel;
using System.Windows;

namespace RompecabezasFei.Servicios
{
    public static class ServicioPartida
    {
        public static int ObtenerNumeroPartidasJugadas(string nombreJugador)
        {
            ServicioPartidaClient cliente = new ServicioPartidaClient(
                new InstanceContext(new PaginaPartida()));
            int resultado = 0;

            try
            {
                resultado = cliente.ObtenerNumeroPartidasJugadas(nombreJugador);
                cliente.Close();
            }
            catch (EndpointNotFoundException excepcion)
            {
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                cliente.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                cliente.Abort();
            }
            catch (TimeoutException excepcion)
            {
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                cliente.Abort();
            }

            return resultado;
        }

        public static int ObtenerNumeroPartidasGanadas(string nombreJugador)
        {
            ServicioPartidaClient cliente = new ServicioPartidaClient(
                new InstanceContext(new PaginaPartida()));
            int resultado = 0;

            try
            {
                resultado = cliente.ObtenerNumeroPartidasGanadas(nombreJugador);
                cliente.Close();
            }
            catch (EndpointNotFoundException excepcion)
            {
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                cliente.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                cliente.Abort();
            }
            catch (TimeoutException excepcion)
            {
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                cliente.Abort();
            }

            return resultado;
        }
    }
}