using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.ServiceModel;
using System.Windows;

namespace RompecabezasFei.Servicios
{
    public class ServicioPartida
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
