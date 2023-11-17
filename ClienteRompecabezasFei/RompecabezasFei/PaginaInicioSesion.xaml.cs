using log4net;
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
using Registros;
using System.Diagnostics;
using System.IO;

namespace RompecabezasFei
{
    public partial class PaginaInicioSesion : Page
    {
        private static readonly ILog Log = Registros.Registrador.GetLogger();

        public PaginaInicioSesion()
        {
            InitializeComponent();
        }

        #region Métodos privados
        private void IniciarSesion(string nombreJugador, string contrasena)
        {
            ServicioJugadorClient cliente = new ServicioJugadorClient();
            CuentaJugador cuentaJugadorAutenticada = cliente.
                IniciarSesion(nombreJugador, contrasena);

            if (cuentaJugadorAutenticada != null)
            {
                Dominio.CuentaJugador.Actual = new Dominio.CuentaJugador
                {
                    Contrasena = cuentaJugadorAutenticada.Contrasena,
                    Correo = cuentaJugadorAutenticada.Correo,
                    NombreJugador = cuentaJugadorAutenticada.NombreJugador,
                    NumeroAvatar = cuentaJugadorAutenticada.NumeroAvatar,
                    EsInvitado = false,
                    FuenteImagenAvatar = Utilidades.GeneradorImagenes.
                        GenerarFuenteImagenAvatar(cuentaJugadorAutenticada.NumeroAvatar)
                };
                VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
            }
            else
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_INICIOSESION_MENSAJEINICIOSESIONERROR,
                    Properties.Resources.ETIQUETA_INICIOSESION_INICIOSESIONCANCELADO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region Eventos
        private void ModoInvitado(object controlOrigen, RoutedEventArgs evento)
        {
            int numeroAleatorio = new Random().Next();

            Dominio.CuentaJugador.Actual = new Dominio.CuentaJugador()
            {
                NombreJugador = Properties.Resources.ETIQUETA_GENERAL_INVITADO + numeroAleatorio,
                EsInvitado = true,
            };

            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());

        }

        private void RecuperacionContrasena(object controlOrigen,
            MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaRecuperacionContrasena());
        }

        private void RegistrarJugador(object controlOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaRegistroJugador());
        }

        private void IrPaginaAjustes(object controlOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(new PaginaAjustes());
        }

        private void IniciarSesion(object controlOrigen, RoutedEventArgs evento)
        {
            var nombreUsuario = cuadroTextoNombreUsuario.Text;
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
                    catch (EndpointNotFoundException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                        //Log.Error($"{ex.Message}");
                        MessageBox.Show(Properties.Resources.
                            ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                            ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    catch (CommunicationObjectFaultedException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                        //Log.Error($"{ex.Message}");
                        MessageBox.Show(Properties.Resources.
                            ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                            ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    catch (TimeoutException excepcion)
                    {
                        Registros.Registrador.EscribirRegistro(excepcion);
                        //Log.Error($"{ex.Message}");
                        MessageBox.Show(Properties.Resources.
                            ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                            ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                   MessageBox.Show(Properties.Resources.
                       ETIQUETA_VALIDACION_MENSAJECAMPOSINVALIDOS,Properties.Resources.
                       ETIQUETA_VALIDACION_CAMPOSINVALIDOS,
                       MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_GENERAL_MENSAJECAMPOSVACIOS,Properties.Resources.
                    ETIQUETA_VALIDACION_CAMPOSVACIOS,
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
                MessageBox.Show(Properties.Resources.ETIQUETA_VALIDACION_MENSAJELONGITUDEXCEDIDA,
                   Properties.Resources.ETIQUETA_VALIDACION_CAMPOSEXCEDIDOS, MessageBoxButton.OK);
            }

            return resultado;
        }
        #endregion
    }
}
