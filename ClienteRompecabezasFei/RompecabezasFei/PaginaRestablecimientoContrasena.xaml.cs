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

        private void ActualizarContraseña(object sender, RoutedEventArgs e)
        {
            contraseña = CuadroContrasenaNueva.Password.ToString();
            if (!ExistenCamposInvalidos())
            {
                if (CuadroContrasenaNueva.Password.Equals(CuadroConfirmarNuevaContrasena.Password))
                {
                    contraseñaCifrada = EncriptadorContrasena.
                            CalcularHashSha512(contraseña);
                    ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
                    bool resultadoActualizacion = cliente.RestablecerContrasena(correo, contraseñaCifrada);
                    if (resultadoActualizacion)
                    {
                        MessageBox.Show("Su nueva contraseña ha sido actualizada correctamente",
                                        "Contraseña restablecida", MessageBoxButton.OK);
                        VentanaPrincipal.CambiarPagina(this, new PaginaInicioSesion());
                    }
                    else
                    {
                        MessageBox.Show("Su contraseña no se pudo restablecer",
                                       "Contraseña no restablecida", MessageBoxButton.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden",
                                       "Contraseñas diferentes", MessageBoxButton.OK);
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
                MessageBox.Show("La contraseña que has ingresado es inválida",
                    "Contraseña inválida", MessageBoxButton.OK);
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
                MessageBox.Show("Corrige los campos excedidos",
                    "Campos excedidos", MessageBoxButton.OK);
            }
            return camposExcedidos;
        }

        #endregion
    }
}
