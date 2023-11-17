using System.Windows;
using System.Windows.Controls;
using Security;
using Seguridad;

namespace RompecabezasFei
{
    public partial class PaginaRestablecimientoContrasena : Page
    {
        private readonly string correo;

        public PaginaRestablecimientoContrasena(string correo)
        {
            InitializeComponent();
            this.correo = correo;
        }

        private void ActualizarContrasena(object objetoOrigen, RoutedEventArgs evento)
        {
            string contrasena = cuadroContrasenaNueva.Password.ToString();

            if (!EsContrasenaInvalida(contrasena))
            {
                if (ValidadorDatos.ExisteCoincidenciaEnCadenas(cuadroContrasenaNueva.Password,
                    cuadroConfirmarNuevaContrasena.Password))
                {
                    string contrasenaCifrada = EncriptadorContrasena.
                        CalcularHashSha512(contrasena);
                    bool actualizacionRealizada = Servicios.ServicioJugador.
                        ActualizarContrasena(correo, contrasenaCifrada);

                    if (actualizacionRealizada)
                    {
                        MessageBox.Show(Properties.Resources.
                            ETIQUETA_RESTABLECIMIENTO_MENSAJECONTRASENAACTUALIZADA, Properties.
                            Resources.ETIQUETA_RESTABLECIMIENTO_CONTRASENARESTABLECIDA,
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

        #region Validaciones
        private bool EsContrasenaInvalida(string contrasena)
        {
            bool camposInvalidos = false;

            if (ValidadorDatos.ExisteLongitudExcedidaEnContrasena(contrasena) ||
                ValidadorDatos.ExistenCaracteresInvalidosParaContrasena(contrasena))
            {
                camposInvalidos = true;
            }

            return camposInvalidos;
        }
        #endregion
    }
}
