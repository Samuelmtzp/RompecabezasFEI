using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.Net.Sockets;
using System.ServiceModel;

namespace RompecabezasFei.Servicios
{
    public class ServicioCorreo : Servicio
    {
        public bool EnviarMensajeACorreoElectronico(string encabezado, 
            string correoDestino, string asunto, string mensaje)
        {
            ServicioCorreoClient cliente = new ServicioCorreoClient();
            bool resultado = false;

            try
            {
                cliente.EnviarMensajeACorreo(encabezado, correoDestino, asunto, mensaje);
                cliente.Close();
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
                    cliente.Abort();
                }
            }

            return resultado;
        }

        public bool ExisteCorreo(string correo)
        {
            ServicioCorreoClient cliente = new ServicioCorreoClient();
            bool resultado = false;

            try
            {
                resultado = cliente.ExisteCorreo(correo);
                cliente.Close();
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
                    cliente.Abort();
                }
            }

            return resultado;
        }
    }
}