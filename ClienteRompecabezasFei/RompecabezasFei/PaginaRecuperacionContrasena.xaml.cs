using System;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using RompecabezasFei.ServicioRompecabezasFei;

namespace RompecabezasFei
{
    public partial class PaginaRecuperacionContrasena : Page
    {
        private string correo;

        public PaginaRecuperacionContrasena()
        {
            InitializeComponent();
        }

        private void EventoClickSiguiente(object objetoOrigen, RoutedEventArgs evento)
        {
            correo = CuadroCorreo.Text.Trim();

            if (!ExistenCaracteresInvalidosParaCorreo(correo))
            {
                if (ExisteCorreoElectronico(correo))
                {
                    PaginaCodigoRestablecimientoContrasena 
                        paginaCodigoRestablecimientoContrasena = new 
                        PaginaCodigoRestablecimientoContrasena(correo);
                    VentanaPrincipal.CambiarPagina(paginaCodigoRestablecimientoContrasena);
                }
                else
                {
                    MessageBox.Show(Properties.Resources.
                        ETIQUETA_RECUPERACIONCONTRASENA_MENSAJECORREOINEXISTENE, Properties.
                        Resources.ETIQUETA_RECUPERACIONCONTRASENA_CORREOINEXISTENTE, 
                        MessageBoxButton.OK);
                }
            }
        }

        private void EventoClickAccionRegresar(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
        }

        private bool ExistenCaracteresInvalidosParaCorreo(string textoValido)
        {
            bool caracteresInvalidos = false;

            if (Regex.IsMatch(textoValido, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") == false)
            {
                caracteresInvalidos = true;
                MessageBox.Show(Properties.Resources.ETIQUETA_VALIDACION_MENSAJECORREOINVALIDO,
                    Properties.Resources.ETIQUETA_VALIDACION_CORREOINVALIDO, MessageBoxButton.OK);
            }
            return caracteresInvalidos;
        }

        private bool ExisteCorreoElectronico(string correoElectronico)
        {
            ServicioJugadorClient cliente = new ServicioJugadorClient();
            bool resultado = false;

            try
            {
                resultado = cliente.ExisteCorreoElectronico(correoElectronico);
            }
            catch (CommunicationException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (TimeoutException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                cliente.Abort();
            }

            return resultado;
        }
    }
}
