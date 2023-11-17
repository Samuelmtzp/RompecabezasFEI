using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.ServiceModel;
using System.Windows;

namespace RompecabezasFei.Servicios
{
    public class ServicioCorreo
    {
        public static bool EnviarMensajeACorreoElectronico(string encabezado, 
            string correoDestino, string asunto, string mensaje)
        {
            ServicioCorreoClient cliente = new ServicioCorreoClient();
            bool resultado = false;

            try
            {
                cliente.EnviarMensajeCorreo(encabezado, correoDestino, asunto, mensaje);
                cliente.Close();
            }
            catch (EndpointNotFoundException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }
            catch (TimeoutException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
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
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }
            catch (TimeoutException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }

            return resultado;
        }
    }
}