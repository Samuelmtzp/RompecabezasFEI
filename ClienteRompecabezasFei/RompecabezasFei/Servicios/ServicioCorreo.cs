using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.ServiceModel;

namespace RompecabezasFei.Servicios
{
    public class ServicioCorreo : Servicio
    {
        private readonly ServicioCorreoClient clienteServicioCorreo = 
            new ServicioCorreoClient();

        public ServicioCorreo()
        {
            AbrirConexion();
        }

        public override void AbrirConexion()
        {
            try
            {
                clienteServicioCorreo.Open();
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
            if (clienteServicioCorreo.State == CommunicationState.Opened)
            {
                try
                {
                    clienteServicioCorreo.Close();
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

        public bool EnviarMensajeACorreoElectronico(string encabezado, 
            string correoDestino, string asunto, string mensaje)
        {
            bool resultado = false;

            try
            {
                resultado = clienteServicioCorreo.EnviarMensajeACorreo
                    (encabezado, correoDestino, asunto, mensaje);
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
                    clienteServicioCorreo.Abort();
                }
            }

            return resultado;
        }

        public bool ExisteCorreoRegistrado(string correo)
        {
            bool resultado = false;

            try
            {
                resultado = clienteServicioCorreo.ExisteCorreoRegistrado(correo);
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
                    clienteServicioCorreo.Abort();
                }
            }

            return resultado;
        }
    }
}