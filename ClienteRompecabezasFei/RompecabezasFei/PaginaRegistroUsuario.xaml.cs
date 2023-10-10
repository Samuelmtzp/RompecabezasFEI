using RompecabezasFei.ServicioGestionJugador;
using Security;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    /// <summary>
    /// Interaction logic for PaginaRegistroUsuario.xaml
    /// </summary>
    public partial class PaginaRegistroUsuario : Page
    {
        String nombreUsuario;
        String correoElectronico;
        String contrasena;
        String confirmacionContrasena;
        short numeroAvatar;

        public PaginaRegistroUsuario()
        {
            InitializeComponent();
        }

        private void ImagenFlechaRegreso_MouseDown(object sender, MouseButtonEventArgs e)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaInicioSesion());
        }

        private void BotonSeleccionarAvatar_Click(object sender, RoutedEventArgs e)
        {
            PaginaSeleccionAvatar paginaSeleccionAvatar = new PaginaSeleccionAvatar();
            paginaSeleccionAvatar.ImagenAvatarActual.Source = this.ImagenAvatarActual.Source;
            VentanaPrincipal.CambiarPagina(this, paginaSeleccionAvatar);
        }

        private void BotonSiguiente_Click(object sender, RoutedEventArgs e)
        {
            nombreUsuario = CuadroTextoNombreUsuario.Text;
            correoElectronico = CuadroTextoCorreoElectronico.Text;
            contrasena = CuadroContrasena.Password;
            confirmacionContrasena = CuadroConfirmacionContrasena.Password;
            numeroAvatar = Convert.ToInt16(ImagenAvatarActual.Tag);
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();

            if (!ExistenCamposInvalidos())
            {
                string contrasenaCifrada = EncriptadorContrasena.CalcularHashSha512(contrasena);
                Jugador jugador = new Jugador()
                {
                    NombreJugador = nombreUsuario,
                    NumeroAvatar = numeroAvatar,
                    Contrasena = contrasenaCifrada,
                    Correo = correoElectronico
                };
                bool resultadoExistencias = false;
                if (cliente.ExisteNombreUsuario(nombreUsuario) || 
                    cliente.ExisteCorreoElectronico(correoElectronico))
                {
                    resultadoExistencias = true;
                }

                if (!resultadoExistencias)
                {
                    bool resultadoRegistro = cliente.Registrar(jugador);
                    if (resultadoRegistro)
                    {
                        MessageBox.Show("El registro de usuario se ha realizado correctamente", 
                            "Registro realizado correctamente", MessageBoxButton.OK);
                        cliente.Abort();
                    }
                    else
                    {
                        MessageBox.Show("El registro de usuario no se ha realizado", 
                            "Error al realizar registro", MessageBoxButton.OK);
                    }
                }
            }
        }

        #region Validaciones
        private bool ExistenCamposInvalidos()
        {
            bool camposInvalidos = false;
            if (ExistenCamposVacios() || ExistenCadenasInvalidas() || ExistenLongitudesExcedidas()
                || ExisteContrasenaInvalida() || ExisteContrasenaIncorrecta())
            {
                camposInvalidos = true;
            }
            return camposInvalidos;
        }

        private bool ExistenCamposVacios()
        {
            bool camposVacios = false;
            if (String.IsNullOrWhiteSpace(nombreUsuario) 
                || String.IsNullOrWhiteSpace(correoElectronico) 
                || String.IsNullOrWhiteSpace(contrasena) 
                || String.IsNullOrWhiteSpace(confirmacionContrasena))
            {
                camposVacios = true;
                MessageBox.Show("No puedes dejar campos vacíos", 
                    "Campos vacíos", MessageBoxButton.OK);
            }
            return camposVacios;
        }

        private bool ExistenLongitudesExcedidas()
        {
            bool camposExcedidos = false;
            if (nombreUsuario.Length > 15 || correoElectronico.Length > 65 
                || contrasena.Length > 45)
            {
                camposExcedidos = true;
                MessageBox.Show("Corrige los campos excedidos", 
                    "Campos excedidos", MessageBoxButton.OK);
            }
            return camposExcedidos;
        }

        private bool ExistenCadenasInvalidas()
        {
            bool cadenasInvalidas = false;
            if (ExistenCaracteresInvalidos(CuadroTextoNombreUsuario.Text))
            {
                MessageBox.Show("El correo electrónico que has ingresado es inválido", 
                    "Nombre de usuario inválido", MessageBoxButton.OK);
                cadenasInvalidas = true;
            }

            if (ExistenCaracteresInvalidosParaCorreo(CuadroTextoCorreoElectronico.Text))
            {
                MessageBox.Show("El correo electrónico que has ingresado es inválido", 
                    "Correo electrónico inválido", MessageBoxButton.OK);
                cadenasInvalidas = true;
            }
            return cadenasInvalidas;
        }

        private bool ExisteContrasenaInvalida()
        {
            bool contrasenaInvalida = false;
            if (Regex.IsMatch(contrasena, "^(?=\\w*\\d)(?=\\w*[A-Z])(?=\\w*[a-z])\\S{8,}$") 
                == false)
            {
                MessageBox.Show("La contraseña que has ingresado es inválida", 
                    "Contraseña inválida", MessageBoxButton.OK);
                contrasenaInvalida = true;
            }
            return contrasenaInvalida;
        }

        private bool ExistenCaracteresInvalidosParaCorreo(String textoValido)
        {
            bool caracteresInvalidos = false;
            if (Regex.IsMatch(textoValido, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") == false)
            {
                caracteresInvalidos = true;
            }
            return caracteresInvalidos;
        }

        private bool ExistenCaracteresInvalidos(String textoValido)
        {
            bool caracteresInvalidos = false;
            if (Regex.IsMatch(textoValido, "^[A-Za-zÁÉÍÓÚáéíóúñÑ\\s]+$") == false)
            {
                caracteresInvalidos = true;
            }
            return caracteresInvalidos;
        }

        private bool ExisteContrasenaIncorrecta()
        {
            bool contrasenaInvalida;
            if (contrasena == confirmacionContrasena)
            {
                contrasenaInvalida = false;
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", 
                    "Contraseñas diferentes", MessageBoxButton.OK);
                contrasenaInvalida = true;
            }
            return contrasenaInvalida;

        }
        #endregion 
    }
}
