using RompecabezasFei.ServicioRompecabezasFei;
using RompecabezasFei.Utilidades;
using System;
using System.ServiceModel;
using System.Windows;

namespace RompecabezasFei.Servicios
{
    public static class ServicioSala
    {
        public static bool ExisteSalaDisponible(string idSala)
        {
            bool hayDisponibilidad = false;
            ServicioSalaClient cliente = new ServicioSalaClient(new 
                InstanceContext(new PaginaSala()));

            try
            {
                hayDisponibilidad = cliente.ExisteSalaDisponible(idSala);
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

            return hayDisponibilidad;
        }

        public static bool CrearNuevaSala(string nombreAnfitrion, string codigoSala)
        {
            ServicioSalaClient cliente = new ServicioSalaClient(new InstanceContext(
                new PaginaSala())); 
            bool resultado = false;

            try
            {
                resultado = cliente.CrearNuevaSala(nombreAnfitrion, codigoSala);
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

        public static string GenerarCodigoParaNuevaSala()
        {
            ServicioSalaClient cliente = new ServicioSalaClient(new InstanceContext(
                new PaginaSala()));
            string codigoSala = null;

            try
            {
                codigoSala = cliente.GenerarCodigoParaNuevaSala();
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

            return codigoSala;
        }

        public static CuentaJugador[] ObtenerJugadoresConectadosEnSala(string codigoSala)
        {
            ServicioSalaClient cliente = new ServicioSalaClient(new InstanceContext(
                new PaginaSala()));
            CuentaJugador[] jugadoresEnSala = null;

            try
            {
                jugadoresEnSala = cliente.ObtenerJugadoresConectadosEnSala(codigoSala);
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

            return jugadoresEnSala;
        }
    }
}