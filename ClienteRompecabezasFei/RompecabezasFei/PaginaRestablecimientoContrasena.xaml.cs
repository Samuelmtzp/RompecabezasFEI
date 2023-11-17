using System;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using RompecabezasFei.ServicioRompecabezasFei;
using Security;

namespace RompecabezasFei
{
    public partial class PaginaRestablecimientoContrasena : Page
    {
        private string correo;
        private string contrasena; 
        private string contrasenaCifrada;
        private const int LongitudMaximaContrasena = 45;

        public PaginaRestablecimientoContrasena(string correo)
        {
            InitializeComponent();
            this.correo = correo;   
        }

        #region Métodos privados
        private bool ClienteActualizarContrasena(string nuevaContrasena)
        {
            bool resultado = false;
            ServicioJugadorClient cliente = new ServicioJugadorClient();

            try
            {
                resultado = cliente.ActualizarContrasena(correo, nuevaContrasena);
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
        #endregion

        #region Eventos
        private void ActualizarContrasena(object objetoOrigen, RoutedEventArgs evento)
        {
            contrasena = CuadroContrasenaNueva.Password.ToString();

            if (!ExistenCamposInvalidos())
            {
                if (CuadroContrasenaNueva.Password.Equals(
                    CuadroConfirmarNuevaContrasena.Password))
                {
                    contrasenaCifrada = EncriptadorContrasena.
                            CalcularHashSha512(contrasena);
                    bool resultadoActualizacion = ClienteActualizarContrasena(contrasenaCifrada);

                    if (resultadoActualizacion)
                    {
                        MessageBox.Show(Properties.Resources.
                            ETIQUETA_RESTABLECIMIENTO_MENSAJECONTRASENAACTUALIZADA,
                            Properties.Resources.ETIQUETA_RESTABLECIMIENTO_CONTRASENARESTABLECIDA,
                            MessageBoxButton.OK);
                        VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
                    }
                    else
                    {
                        MessageBox.Show(Properties.Resources.
                            ETIQUETA_RESTABLECIMIENTO_MENSAJECONTRASENANORESTABLECIDA, Properties.
                            Resources.ETIQUETA_RESTABLECIMIENTO_CONTRASENANORESTABLECIDA,
                            MessageBoxButton.OK);
                    }
                }
                else
                {
                    MessageBox.Show(Properties.Resources.
                        ETIQUETA_VALIDACION_MENSAJECONTRASENADIFERENTE,
                        Properties.Resources.ETIQUETA_VALIDACION_CONTRASENADIFERENTE,
                        MessageBoxButton.OK);
                }
            }
        }
        #endregion

        #region Validaciones

        private bool ExistenCamposInvalidos()
        {
            bool camposInvalidos = false;

            if (ExistenLongitudesExcedidas() || ExisteContrasenaInvalida())
            {
                camposInvalidos = true;
            }

            return camposInvalidos;
        }

        private bool ExisteContrasenaInvalida()
        {
            bool contrasenaInvalida = false;
            
            if (Regex.IsMatch(contrasena,
                "^(?=\\w*\\d)(?=\\w*[A-Z])(?=\\w*[a-z])\\S{8,}$")
                == false)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_VALIDACION_MENSAJECONTRASENAINVALIDA, Properties.Resources.
                    ETIQUETA_VALIDACION_CONTRASENAINVALIDA, MessageBoxButton.OK);
                contrasenaInvalida = true;
            }

            return contrasenaInvalida;
        }

        private bool ExistenLongitudesExcedidas()
        {
            bool camposExcedidos = false;
            
            if (contrasena.Length > LongitudMaximaContrasena)
            {
                camposExcedidos = true;
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_VALIDACION_MENSAJELONGITUDEXCEDIDA, Properties.Resources.
                    ETIQUETA_VALIDACION_CAMPOSEXCEDIDOS, MessageBoxButton.OK);
            }

            return camposExcedidos;
        }
        #endregion
    }
}
