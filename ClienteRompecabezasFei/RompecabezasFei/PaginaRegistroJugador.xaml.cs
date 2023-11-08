using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    public partial class PaginaRegistroJugador : Page
    {
        public PaginaRegistroJugador()
        {
            InitializeComponent();
        }

        public PaginaRegistroJugador(int numeroAvatar, string nombreJugador,
            string correo, string contrasena, string confirmacionContrasena)
        {
            InitializeComponent();
            CargarDatosEdicion(numeroAvatar, nombreJugador, correo, 
                contrasena, confirmacionContrasena);
        }

        private void CargarDatosEdicion(int numeroAvatar, string nombreJugador,
            string correo, string contrasena, string confirmacionContrasena)
        {
            CuadroTextoNombreJugador.Text = nombreJugador;
            CuadroTextoCorreoElectronico.Text = correo;
            CuadroContrasena.Password = contrasena;
            CuadroConfirmacionContrasena.Password = confirmacionContrasena;
            ImagenAvatarActual.Source = Utilidades.GeneradorImagenes.
                GenerarFuenteImagenAvatar(numeroAvatar);
        }

        private void AccionRegresar(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
        }

        private void AccionSeleccionarAvatar(object remitente, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(new PaginaSeleccionAvatar(
                (int)ImagenAvatarActual.Tag, CuadroTextoNombreJugador.Text,
                CuadroTextoCorreoElectronico.Text, CuadroContrasena.Password,
                CuadroConfirmacionContrasena.Password));
        }

        private void AccionSiguiente(object remitente, RoutedEventArgs evento)
        {
            string nombreJugador = CuadroTextoNombreJugador.Text;
            string correo = CuadroTextoCorreoElectronico.Text;
            string contrasena = CuadroContrasena.Password;
            int numeroAvatar = (int)ImagenAvatarActual.Tag; 

            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();

            if (!ExistenCamposInvalidos())
            {     
                try
                {
                    if (!cliente.ExisteNombreJugador(nombreJugador) &&
                    !cliente.ExisteCorreoElectronico(correo))
                    {
                        Dominio.CuentaJugador jugadorRegistro = new Dominio.CuentaJugador
                        {
                            NombreJugador = nombreJugador,
                            Correo = correo,
                            Contrasena = contrasena,
                            NumeroAvatar = numeroAvatar,
                        };
                        PaginaVerificacionCorreo paginaVerificacionCorreo =
                            new PaginaVerificacionCorreo(jugadorRegistro);
                        VentanaPrincipal.CambiarPagina(paginaVerificacionCorreo);
                    }
                }
                catch (EndpointNotFoundException)
                {
                    // log
                }                
            }
        }

        #region Validaciones
        private bool ExistenCamposInvalidos()
        {
            bool resultado = false;

            if (ExistenCamposVacios() || ExistenCadenasInvalidas() || ExistenLongitudesExcedidas()
                || ExisteContrasenaInvalida() || HayCoincidenciasEnContrasenas())
            {
                resultado = true;
            }

            return resultado;
        }

        private bool ExistenCamposVacios()
        {
            bool resultado = false;

            if (String.IsNullOrWhiteSpace(CuadroTextoNombreJugador.Text) 
                || String.IsNullOrWhiteSpace(CuadroTextoCorreoElectronico.Text) 
                || String.IsNullOrWhiteSpace(CuadroContrasena.Password) 
                || String.IsNullOrWhiteSpace(CuadroConfirmacionContrasena.Password))
            {
                resultado = true;
                MessageBox.Show("No puedes dejar campos vacíos", 
                    "Campos vacíos", MessageBoxButton.OK);
            }

            return resultado;
        }

        private bool ExistenLongitudesExcedidas()
        {
            bool resultado = false;

            if (CuadroTextoNombreJugador.Text.Length > 15 || 
                CuadroTextoCorreoElectronico.Text.Length > 65 || 
                CuadroContrasena.Password.Length > 45)
            {
                resultado = true;
                MessageBox.Show("Corrige los campos excedidos", 
                    "Campos excedidos", MessageBoxButton.OK);
            }

            return resultado;
        }

        private bool ExistenCadenasInvalidas()
        {
            bool resultado = false;

            if (ExistenCaracteresInvalidos(CuadroTextoNombreJugador.Text))
            {
                MessageBox.Show("El nombre de usuario que has ingresado es inválido", 
                    "Nombre de usuario inválido", MessageBoxButton.OK);
                resultado = true;
            }

            if (ExistenCaracteresInvalidosParaCorreo(CuadroTextoCorreoElectronico.Text))
            {
                MessageBox.Show("El correo electrónico que has ingresado es inválido", 
                    "Correo electrónico inválido", MessageBoxButton.OK);
                resultado = true;
            }

            return resultado;
        }

        private bool ExisteContrasenaInvalida()
        {
            bool resultado = false;
            
            if (Regex.IsMatch(CuadroContrasena.Password, 
                "^(?=\\w*\\d)(?=\\w*[A-Z])(?=\\w*[a-z])\\S{8,}$") 
                == false)
            {
                MessageBox.Show("La contraseña que has ingresado es inválida", 
                    "Contraseña inválida", MessageBoxButton.OK);
                resultado = true;
            }

            return resultado;
        }

        private bool ExistenCaracteresInvalidosParaCorreo(string correo)
        {
            bool resultado = false;

            if (Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") == false)
            {
                resultado = true;
            }

            return resultado;
        }

        private bool ExistenCaracteresInvalidos(string texto)
        {
            bool resultado = false;

            if (Regex.IsMatch(texto, 
                @"^[A-Za-zÁÉÍÓÚáéíóúñÑ]+(?:\s[A-Za-zÁÉÍÓÚáéíóúñÑ]+)?$") == false)
            {
                resultado = true;
            }

            return resultado;
        }

        private bool HayCoincidenciasEnContrasenas()
        {
            bool resultado = false;
            
            if (CuadroContrasena.Password == CuadroConfirmacionContrasena.Password)
            {
                resultado = true;
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", 
                    "Contraseñas diferentes", MessageBoxButton.OK);
            }

            return resultado;
        }
        #endregion 
    }
}
