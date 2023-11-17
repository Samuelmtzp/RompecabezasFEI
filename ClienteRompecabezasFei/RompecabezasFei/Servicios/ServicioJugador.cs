using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.ServiceModel;
using System.Windows;

namespace RompecabezasFei.Servicios
{
    public class ServicioJugador
    {
        public static bool RegistrarJugador(CuentaJugador cuentaJugador)
        {
            ServicioJugadorClient cliente = new ServicioJugadorClient();
            bool resultado = false;

            try
            {
                resultado = cliente.Registrar(cuentaJugador);
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

        public static CuentaJugador IniciarSesion(string nombreJugador, string contrasena)
        {
            ServicioJugadorClient cliente = new ServicioJugadorClient();
            CuentaJugador cuentaJugadorAutenticada = null;

            try
            {
                cuentaJugadorAutenticada = cliente.IniciarSesion(nombreJugador, contrasena);
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
            catch (CommunicationObjectAbortedException excepcion)
            {
                //Registros.Registros.escribirRegistro(excepcion.Message);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                cliente.Abort();
            }
            catch (CommunicationException excepcion)
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

            return cuentaJugadorAutenticada;
        }

        public static bool CerrarSesion(string nombreJugador)
        {
            ServicioJugadorClient cliente = new ServicioJugadorClient();
            bool resultado = false;

            try
            {
                resultado = cliente.CerrarSesion(nombreJugador);
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

        public static bool ActualizarContrasena(string correo, string nuevaContrasena)
        {
            ServicioJugadorClient cliente = new ServicioJugadorClient(); 
            bool resultado = false;            

            try
            {
                resultado = cliente.ActualizarContrasena(correo, nuevaContrasena);
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

        public static bool ActualizarInformacion(string nombreAnterior, string nuevoNombre, 
            int nuevoNumeroAvatar)
        {
            bool resultado = false;
            ServicioJugadorClient cliente = new ServicioJugadorClient();

            try
            {
                resultado = cliente.ActualizarInformacion(nombreAnterior, 
                    nuevoNombre, nuevoNumeroAvatar);
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

        public static bool ExisteNombreJugador(string nombreJugador)
        {
            ServicioJugadorClient cliente = new ServicioJugadorClient();
            bool resultado = false;

            try
            {
                resultado = cliente.ExisteNombreJugador(nombreJugador);
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