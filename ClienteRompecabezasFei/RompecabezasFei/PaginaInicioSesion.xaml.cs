using RompecabezasFei.ServicioGestionJugador;
using Dominio;
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

        private void AccionModoInvitado(object remitente, RoutedEventArgs evento)
        {
            
            Dominio.Jugador.JugadorActual = new Dominio.Jugador()
            {
                NombreJugador = $"Invitado{new Random().Next()}",
                EsInvitado = true
            };

            VentanaPrincipal.CambiarPagina(this, new PaginaMenuPrincipal());
        }

        private void AccionRecuperarContrasena(object remitente, 
            MouseButtonEventArgs evento)
        {
            MessageBox.Show("Click en opción recuperar contraseña");
        }

        private void AccionRegistro(object remitente, MouseButtonEventArgs evento)
        {            
            VentanaPrincipal.CambiarPagina(this, new PaginaRegistroUsuario());
        }

        
        private void AccionAjustes(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(this, new PaginaAjustes());
        }

        private void AccionInicioSesion(object remitente, RoutedEventArgs evento)
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
                        MessageBox.Show("No se ha establecido una conexión", "Error de conexión", 
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    catch (CommunicationObjectFaultedException excepcion)
                    {
                        MessageBox.Show("No se ha establecido una conexión", "Error de conexión", 
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    catch (TimeoutException excepcion)
                    {
                        MessageBox.Show("No se ha establecido una conexión", "Error de conexión", 
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Alguno de los campos es inválido", 
                        "Campos inválidos", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Alguno de los campos está vacío", "Campos vacíos",
                            MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void IniciarSesion(string nombreUsuario, string contrasena)
        {
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
            ServicioGestionJugador.Jugador jugadorAutenticado = cliente.IniciarSesion(nombreUsuario, 
                EncriptadorContrasena.CalcularHashSha512(contrasena));

            if (jugadorAutenticado.IdJugador != 0)
            {
                Dominio.Jugador.JugadorActual = new Dominio.Jugador
                {
                    Contrasena = jugadorAutenticado.Contrasena,
                    Correo = jugadorAutenticado.Correo,
                    IdJugador = jugadorAutenticado.IdJugador,
                    IdUsuario = jugadorAutenticado.IdUsuario,
                    NombreJugador = jugadorAutenticado.NombreJugador,
                    NumeroAvatar = jugadorAutenticado.NumeroAvatar,
                    EsInvitado = false
                };

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
