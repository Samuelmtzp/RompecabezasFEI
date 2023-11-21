using RompecabezasFei.ServicioRompecabezasFei;
using RompecabezasFei.Utilidades;
using System;
using System.ServiceModel;

namespace RompecabezasFei.Servicios
{
    public static class ServicioAmistades
    {
        public static CuentaJugador[] ObtenerAmigosDeJugador(string nombreJugador)
        {
            ServicioAmistadesClient cliente = new ServicioAmistadesClient(
                new InstanceContext(new PaginaAmistades(false)));
            CuentaJugador[] amigosObtenidos = null;

            try
            {
                amigosObtenidos = cliente.ObtenerAmigosDeJugador(nombreJugador);
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

            return amigosObtenidos;
        }

        public static CuentaJugador[] ObtenerJugadoresConSolicitudPendiente(string nombreJugador)
        {
            ServicioAmistadesClient cliente = new ServicioAmistadesClient(
                new InstanceContext(new PaginaAmistades(false)));
            CuentaJugador[] amigosObtenidos = null;

            try
            {
                amigosObtenidos = cliente.ObtenerJugadoresConSolicitudPendiente(
                    nombreJugador);
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

            return amigosObtenidos;
        }

        public static bool ExisteSolicitudAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            ServicioAmistadesClient cliente = new ServicioAmistadesClient(
                new InstanceContext(new PaginaAmistades(false)));
            bool existeSolicitudAmistad = false;

            try
            {
                existeSolicitudAmistad = cliente.ExisteSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
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

            return existeSolicitudAmistad;
        }

        public static bool ExisteAmistadConJugador(string nombreJugadorA, string nombreJugadorB)
        {
            ServicioAmistadesClient cliente = new ServicioAmistadesClient(
                new InstanceContext(new PaginaAmistades(false)));
            bool existeSolicitudAmistad = false;

            try
            {
                existeSolicitudAmistad = cliente.ExisteSolicitudDeAmistad(
                    nombreJugadorA, nombreJugadorB);
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

            return existeSolicitudAmistad;
        }

        public static bool RechazarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            ServicioAmistadesClient cliente = new ServicioAmistadesClient(
                new InstanceContext(new PaginaAmistades(false)));
            bool solicitudRechazada = false;

            try
            {
                solicitudRechazada = cliente.RechazarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
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

            return solicitudRechazada;
        }
    }
}