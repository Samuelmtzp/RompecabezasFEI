using RompecabezasFei.ServicioRompecabezasFei;
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
    public partial class PaginaInicioSesion : Page
    {
        public PaginaInicioSesion()
        {
            InitializeComponent();
        }

        private void AccionModoInvitado(object remitente, RoutedEventArgs evento)
        {
            int numeroAleatorio = new Random().Next();
            Dominio.CuentaJugador.CuentaJugadorActual = new Dominio.CuentaJugador()
            {
                NombreJugador = Properties.Resources.ETIQUETA_GENERAL_INVITADO + numeroAleatorio,
                EsInvitado = true
            };

            VentanaPrincipal.CambiarPagina(this, new PaginaMenuPrincipal());
        }

        private void AccionRecuperarContrasena(object remitente, 
            MouseButtonEventArgs evento)
        {

        }

        private void AccionRegistro(object remitente, MouseButtonEventArgs evento)
        {            
            VentanaPrincipal.CambiarPagina(this, new PaginaRegistroJugador());
        }

        
        private void AccionAjustes(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(this, new PaginaAjustes());
        }

        private void AccionInicioSesion(object remitente, RoutedEventArgs evento)
        {
            var nombreUsuario = CuadroTextoNombreUsuario.Text;
            var contrasena = CuadroContrasena.Password;
            if (!String.IsNullOrWhiteSpace(nombreUsuario) && 
                !String.IsNullOrWhiteSpace(contrasena))
            {
                if (ExistenCadenasValidas(nombreUsuario, contrasena) && 
                    !ExistenLongitudesExcedidas(nombreUsuario, contrasena))
                {
                    try
                    {
                        IniciarSesion(nombreUsuario, 
                            EncriptadorContrasena.CalcularHashSha512(contrasena));
                    }
                    catch (EndpointNotFoundException)
                    {
                        MessageBox.Show(Properties.Resources.
                            ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                            ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO, 
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    catch (CommunicationObjectFaultedException)
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


        private void IniciarSesion(string nombreJugador, string contrasena)
        {
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
            ServicioRompecabezasFei.CuentaJugador cuentaJugadorAutenticada = 
                cliente.IniciarSesion(nombreJugador, contrasena);

            if (cuentaJugadorAutenticada.IdJugador != 0)
            {
                Dominio.CuentaJugador.CuentaJugadorActual = new Dominio.CuentaJugador
                {
                    Contrasena = cuentaJugadorAutenticada.Contrasena,
                    Correo = cuentaJugadorAutenticada.Correo,
                    IdJugador = cuentaJugadorAutenticada.IdJugador,
                    IdCuenta = cuentaJugadorAutenticada.IdCuenta,
                    NombreJugador = cuentaJugadorAutenticada.NombreJugador,
                    NumeroAvatar = cuentaJugadorAutenticada.NumeroAvatar,
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

        private bool ExistenCadenasValidas(string nombreJugador, string contrasena)
        {
            var esValido = false;
            if (Regex.IsMatch(nombreJugador, "^[a-zA-Z0-9]*$") && Regex.IsMatch(contrasena,
                "^(?=\\w*\\d)(?=\\w*[A-Z])(?=\\w*[a-z])\\S{8,}$"))
            {
                esValido = true;
            }
            return esValido;
        }

        private bool ExistenLongitudesExcedidas(string nombreJugador, string contrasena)
        {
            var camposExcedidos = false;
            if (nombreJugador.Length > 15 || contrasena.Length > 45)
            {
                camposExcedidos = true;
            }
            return camposExcedidos;
        }
    }
}
