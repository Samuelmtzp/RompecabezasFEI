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
        private Dominio.DatosRegistro datosRegistro;
        public Dominio.DatosRegistro DatosRegistro
        {
            get { return datosRegistro; }
            set { datosRegistro = value; }
        }

        public PaginaRegistroUsuario()
        {
            InitializeComponent();            
        }

        private void AccionRegresar(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaInicioSesion());
        }

        private void AccionSeleccionarAvatar(object remitente, RoutedEventArgs evento)
        {
            PaginaSeleccionAvatar paginaSeleccionAvatar = new PaginaSeleccionAvatar();
            paginaSeleccionAvatar.ImagenAvatarActual.Source = ImagenAvatarActual.Source;
            GuardarDatosEdicion();
            paginaSeleccionAvatar.DatosRegistro = DatosRegistro;
            VentanaPrincipal.CambiarPagina(this, paginaSeleccionAvatar);
        }

        public void CargarDatosEdicion()
        {
            CuadroTextoNombreUsuario.Text = datosRegistro.NombreUsuario;
            CuadroTextoCorreoElectronico.Text = datosRegistro.CorreoElectronico;
            CuadroContrasena.Password = datosRegistro.Contrasena;
            CuadroConfirmacionContrasena.Password = datosRegistro.ConfirmacionContrasena;
        }

        private void GuardarDatosEdicion()
        {
            DatosRegistro = new Dominio.DatosRegistro()
            {
                NombreUsuario = CuadroTextoNombreUsuario.Text,
                CorreoElectronico = CuadroTextoCorreoElectronico.Text,
                Contrasena = CuadroContrasena.Password,
                ConfirmacionContrasena = CuadroConfirmacionContrasena.Password
            };
        }

        private void AccionSiguiente(object remitente, RoutedEventArgs evento)
        {
            datosRegistro.NombreUsuario = CuadroTextoNombreUsuario.Text;
            datosRegistro.CorreoElectronico = CuadroTextoCorreoElectronico.Text;
            datosRegistro.Contrasena = CuadroContrasena.Password;
            datosRegistro.ConfirmacionContrasena = CuadroConfirmacionContrasena.Password;
            datosRegistro.NumeroAvatar = Convert.ToInt16(ImagenAvatarActual.Tag);
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();

            if (!ExistenCamposInvalidos())
            {
                string contrasenaCifrada = EncriptadorContrasena.CalcularHashSha512(datosRegistro.Contrasena);
                Jugador jugador = new Jugador()
                {
                    NombreJugador = datosRegistro.NombreUsuario,
                    NumeroAvatar = datosRegistro.NumeroAvatar,
                    Contrasena = contrasenaCifrada,
                    Correo = datosRegistro.CorreoElectronico
                };
                bool resultadoExistencias = false;
                if (cliente.ExisteNombreUsuario(datosRegistro.NombreUsuario) || 
                    cliente.ExisteCorreoElectronico(datosRegistro.CorreoElectronico))
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
            if (String.IsNullOrWhiteSpace(datosRegistro.NombreUsuario) 
                || String.IsNullOrWhiteSpace(datosRegistro.CorreoElectronico) 
                || String.IsNullOrWhiteSpace(datosRegistro.Contrasena) 
                || String.IsNullOrWhiteSpace(datosRegistro.ConfirmacionContrasena))
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
            if (datosRegistro.NombreUsuario.Length > 15 || datosRegistro.CorreoElectronico.Length > 65 
                || datosRegistro.Contrasena.Length > 45)
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
            if (Regex.IsMatch(datosRegistro.Contrasena, "^(?=\\w*\\d)(?=\\w*[A-Z])(?=\\w*[a-z])\\S{8,}$") 
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
            if (datosRegistro.Contrasena == datosRegistro.ConfirmacionContrasena)
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
