using RompecabezasFei.ServicioRompecabezasFei;
using Security;
using System;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace RompecabezasFei
{
    public partial class PaginaInicioSesion : Page
    {
        public PaginaInicioSesion()
        {
            InitializeComponent();
        }

        #region Métodos privados
        private void IniciarSesion(string nombreJugador, string contrasena)
        {
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
            CuentaJugador cuentaJugadorAutenticada = null;

            try
            {
                cuentaJugadorAutenticada = cliente.IniciarSesion(nombreJugador, contrasena);
                cliente.Close();
            }
            catch (EndpointNotFoundException)
            {
                cliente.Abort();
            }

            if (cuentaJugadorAutenticada != null && cuentaJugadorAutenticada.IdJugador != 0)
            {
                Dominio.CuentaJugador.CuentaJugadorActual = new Dominio.CuentaJugador
                {
                    Contrasena = cuentaJugadorAutenticada.Contrasena,
                    Correo = cuentaJugadorAutenticada.Correo,
                    IdJugador = cuentaJugadorAutenticada.IdJugador,
                    IdCuenta = cuentaJugadorAutenticada.IdCuenta,
                    NombreJugador = cuentaJugadorAutenticada.NombreJugador,
                    NumeroAvatar = cuentaJugadorAutenticada.NumeroAvatar,
                    EsInvitado = false,
                    ColorEstadoConectividad = Brushes.Green,
                    FuenteImagenAvatar = GenerarFuenteImagenDeNumeroDeAvatar(
                        cuentaJugadorAutenticada.NumeroAvatar)
                };
                VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
            }
            else
            {
                MessageBox.Show("No se pudo iniciar sesión", "Inicio de sesión cancelado",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private BitmapImage GenerarFuenteImagenDeNumeroDeAvatar(int numeroAvatar)
        {
            string rutaImagen = "/Imagenes/Avatares/";
            BitmapImage fuenteImagenAvatar = new BitmapImage();
            fuenteImagenAvatar.BeginInit();
            rutaImagen += numeroAvatar + ".png";
            fuenteImagenAvatar.UriSource = new Uri(rutaImagen, UriKind.RelativeOrAbsolute);
            fuenteImagenAvatar.EndInit();

            return fuenteImagenAvatar;
        }
        #endregion

        #region Eventos
        private void EventoClickModoInvitado(object controlOrigen, RoutedEventArgs evento)
        {
            int numeroAleatorio = new Random().Next();
            Dominio.CuentaJugador.CuentaJugadorActual = new Dominio.CuentaJugador()
            {
                NombreJugador = Properties.Resources.ETIQUETA_GENERAL_INVITADO + numeroAleatorio,
                EsInvitado = true,
                ColorEstadoConectividad = Brushes.Green
            };

            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
        }

        private void EventoClickRecuperacionContrasena(object controlOrigen,
            MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaRecuperacionContrasena());
        }

        private void EventoClickRegistrar(object controlOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaRegistroJugador());
        }

        private void EventoClickAjustes(object controlOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(new PaginaAjustes());
        }

        private void EventoClickIniciarSesion(object controlOrigen, RoutedEventArgs evento)
        {
            var nombreUsuario = cuadroTextoNombreUsuario.Text.Trim();
            var contrasena = cuadroContrasena.Password;

            if (!string.IsNullOrWhiteSpace(nombreUsuario) &&
                !string.IsNullOrWhiteSpace(contrasena))
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
        #endregion

        #region Validaciones
        private bool ExistenCadenasValidas(string nombreJugador, string contrasena)
        {
            bool resultado = false;

            if (Regex.IsMatch(nombreJugador, @"^[a-zA-Z0-9]+(?:\s[a-zA-Z0-9]+)?$") && 
                Regex.IsMatch(contrasena, "^(?=\\w*\\d)(?=\\w*[A-Z])(?=\\w*[a-z])\\S{8,}$"))
            {
                resultado = true;
            }

            return resultado;
        }

        private bool ExistenLongitudesExcedidas(string nombreJugador, string contrasena)
        {
            bool resultado = false;
            
            if (nombreJugador.Length > 15 || contrasena.Length > 45)
            {
                resultado = true;
            }

            return resultado;
        }
        #endregion
    }
}