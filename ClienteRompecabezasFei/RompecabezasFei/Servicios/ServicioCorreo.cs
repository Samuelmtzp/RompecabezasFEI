using RompecabezasFei.ServicioRompecabezasFei;
using RompecabezasFei.Utilidades;
using System;
using System.ServiceModel;
using System.Windows;

namespace RompecabezasFei.Servicios
{
    public static class ServicioCorreo
    {
        public static bool EnviarMensajeACorreoElectronico(string encabezado, 
            string correoDestino, string asunto, string mensaje)
        {
            ServicioCorreoClient cliente = new ServicioCorreoClient();
            bool resultado = false;

            try
            {
                resultado = cliente.EnviarMensajeCorreo
                    (encabezado, correoDestino, asunto, mensaje);
                cliente.Close();
            }
            catch (EndpointNotFoundException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                cliente.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                cliente.Abort();
            }
            catch (TimeoutException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                cliente.Abort();
            }

            return resultado;
        }

        public static bool ExisteCorreoElectronico(string correoElectronico)
        {
            ServicioCorreoClient cliente = new ServicioCorreoClient();
            bool resultado = false;

            try
            {
                resultado = cliente.ExisteCorreoElectronico(correoElectronico);
                cliente.Close();
            }
            catch (EndpointNotFoundException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                cliente.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                cliente.Abort();
            }
            catch (TimeoutException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                GeneradorMensajes.MostrarMensajeErrorConexionServidor();
                cliente.Abort();
            }

            return resultado;
        }
    }
}