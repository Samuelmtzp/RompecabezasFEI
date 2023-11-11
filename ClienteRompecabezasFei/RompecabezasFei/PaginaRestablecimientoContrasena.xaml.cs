using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using RompecabezasFei.ServicioRompecabezasFei;
using Security;

namespace RompecabezasFei
{
    public partial class PaginaRestablecimientoContrasena : Page
    {
        string correo, contraseña, contraseñaCifrada;
        public PaginaRestablecimientoContrasena(string correo)
        {
            InitializeComponent();
            this.correo = correo;   
        }

        private void EventoActualizarContraseña(object controlOrigen, RoutedEventArgs evento)
        {
            contraseña = CuadroContrasenaNueva.Password.ToString();
            if (!ExistenCamposInvalidos())
            {
                if (CuadroContrasenaNueva.Password.Equals(CuadroConfirmarNuevaContrasena.Password))
                {
                    contraseñaCifrada = EncriptadorContrasena.
                            CalcularHashSha512(contraseña);
                    ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
                    bool resultadoActualizacion = cliente.ActualizarContrasena(correo, contraseñaCifrada);
                    if (resultadoActualizacion)
                    {
                        MessageBox.Show(Properties.Resources.ETIQUETA_RESTABLECIMIENTO_MENSAJECONTRASENAACTUALIZADA,
                                        Properties.Resources.ETIQUETA_RESTABLECIMIENTO_CONTRASENARESTABLECIDA, MessageBoxButton.OK);
                        VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
                    }
                    else
                    {
                        MessageBox.Show(Properties.Resources.ETIQUETA_RESTABLECIMIENTO_MENSAJECONTRASENANORESTABLECIDA,
                                      Properties.Resources.ETIQUETA_RESTABLECIMIENTO_CONTRASENANORESTABLECIDA, MessageBoxButton.OK);
                    }
                }
                else
                {
                    MessageBox.Show(Properties.Resources.ETIQUETA_VALIDACION_MENSAJECONTRASENADIFERENTE,
                                       Properties.Resources.ETIQUETA_VALIDACION_CONTRASENADIFERENTE, MessageBoxButton.OK);
                }
            }
        }

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
            if (Regex.IsMatch(contraseña,
                "^(?=\\w*\\d)(?=\\w*[A-Z])(?=\\w*[a-z])\\S{8,}$")
                == false)
            {
                MessageBox.Show(Properties.Resources.ETIQUETA_VALIDACION_MENSAJECONTRASENAINVALIDA,
                    Properties.Resources.ETIQUETA_VALIDACION_CONTRASENAINVALIDA, MessageBoxButton.OK);
                contrasenaInvalida = true;
            }
            return contrasenaInvalida;
        }

        private bool ExistenLongitudesExcedidas()
        {
            bool camposExcedidos = false;
            if (contraseña.Length > 45)
            {
                camposExcedidos = true;
                MessageBox.Show(Properties.Resources.ETIQUETA_VALIDACION_MENSAJELONGITUDEXCEDIDA,
                    Properties.Resources.ETIQUETA_VALIDACION_CAMPOSEXCEDIDOS, MessageBoxButton.OK);
            }
            return camposExcedidos;
        }

        #endregion
    }
}
