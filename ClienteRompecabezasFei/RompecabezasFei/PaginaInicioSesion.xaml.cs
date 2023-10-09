using RompecabezasFei.ServicioGestionJugador;
using Security;
using System;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    /// <summary>
    /// Interaction logic for PaginaInicioSesion.xaml
    /// </summary>
    public partial class PaginaInicioSesion : Page
    {
        public PaginaInicioSesion()
        {
            InitializeComponent();
        }

        private void BotonModoInvitado_Click(object sender, RoutedEventArgs e)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaMenuPrincipal());
        }

        private void OpcionRecuperarContrasena_MouseLeftButtonUp(object sender, 
            MouseButtonEventArgs e)
        {
            MessageBox.Show("Click en opción recuperar contraseña");
        }

        private void OpcionRegistro_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaRegistroUsuario());
        }

        
        private void ImagenAjustes_Click(object sender, MouseButtonEventArgs e)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaAjustes());
        }

        private void BotonInicioSesion_Click(object sender, RoutedEventArgs e)
        {
            var nombreUsuario = CuadroTextoNombreUsuario.Text;
            var contrasena = CuadroContrasena.Password;
            if (!String.IsNullOrWhiteSpace(nombreUsuario) && !String.IsNullOrWhiteSpace(
                contrasena))
            {
                if (ExistenCadenasValidas(nombreUsuario, contrasena) && 
                    !ExistenLongitudesExcedidas(nombreUsuario, contrasena))
                {
                    try
                    {
                        IniciarSesion(nombreUsuario, contrasena);
                    }
                    catch (EndpointNotFoundException excepcion)
                    {
                        MessageBox.Show("No se ha establecido una conexión", "Error de conexión", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    catch (CommunicationObjectFaultedException excepcion)
                    {
                        MessageBox.Show("No se ha establecido una conexión", "Error de conexión", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    catch (TimeoutException excepcion)
                    {
                        MessageBox.Show("No se ha establecido una conexión", "Error de conexión", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }

        private void IniciarSesion(string nombreUsuario, string contrasena)
        {
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
            Jugador jugador = cliente.IniciarSesion(nombreUsuario, 
                EncriptadorContrasena.CalcularHashSha512(contrasena));

            if (jugador != null)
            {
                MessageBox.Show($"Bienvenido a Rompecabezas FEI {jugador.NombreJugador}", 
                    "Bienvenido", MessageBoxButton.OK, MessageBoxImage.Information);
                VentanaPrincipal.CambiarPagina(this, new PaginaMenuPrincipal());
            }
            else
            {
                MessageBox.Show("No se pudo iniciar sesión", "Inicio de sesión cancelado", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool ExistenCadenasValidas(string nombreUsuario, string contrasena)
        {
            var esValido = false;
            if (Regex.IsMatch(nombreUsuario, "^[a-zA-Z0-9]*$") && Regex.IsMatch(contrasena, 
                "^[a-zA-Z0-9]*$"))
            {
                esValido = true;
            }
            return esValido;
        }

        private bool ExistenLongitudesExcedidas(string nombreUsuario, string contrasena)
        {
            var camposExcedidos = true;
            if (nombreUsuario.Length <= 15 || contrasena.Length <= 45)
            {
                camposExcedidos = false;
            }
            return camposExcedidos;
        }
    }
}
