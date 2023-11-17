using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.ServiceModel;
using System.Windows;

namespace RompecabezasFei.Servicios
{
    public class ServicioSala
    {
        public static bool ExisteSalaDisponible(string idSala)
        {
            bool hayDisponibilidad = false;
            ServicioSalaClient cliente = new ServicioSalaClient(new 
                InstanceContext(new PaginaSala()));

            try
            {
                hayDisponibilidad = cliente.ExisteSalaDisponible(idSala);
                cliente.Abort();
            }
            catch (EndpointNotFoundException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (TimeoutException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
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
                //string codigoSala = cliente.GenerarCodigoParaNuevaSala();
                resultado = cliente.CrearNuevaSala(nombreAnfitrion, codigoSala);
                cliente.Close();
            }
            catch (EndpointNotFoundException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (TimeoutException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
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
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (TimeoutException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
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
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (CommunicationObjectFaultedException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (TimeoutException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return jugadoresEnSala;
        }
    }
}