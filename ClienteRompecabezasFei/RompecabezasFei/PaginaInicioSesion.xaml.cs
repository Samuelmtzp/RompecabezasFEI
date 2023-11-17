using RompecabezasFei.ServicioRompecabezasFei;
using Security;
using Seguridad;
using System;
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
        public PaginaInicioSesion()
        {
            InitializeComponent();
        }

        #region Eventos
        private void IniciarSesionComoInvitado(object objetoOrigen, RoutedEventArgs evento)
        {
            int numeroAleatorio = new Random().Next();

            Dominio.CuentaJugador.Actual = new Dominio.CuentaJugador()
            {
                NombreJugador = Properties.Resources.ETIQUETA_GENERAL_INVITADO +
                    numeroAleatorio,
                EsInvitado = true,
            };
            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());

        }

        private void IrPaginaRecuperacionContrasena(object objetoOrigen,
            MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaRecuperacionContrasena());
        }

        private void IrPaginaRegistroJugador(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaRegistroJugador());
        }

        private void IrPaginaAjustes(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(new PaginaAjustes());
        }

        private void IniciarSesion(object objetoOrigen, RoutedEventArgs evento)
        {
            string nombreJugador = cuadroTextoNombreUsuario.Text;
            string contrasena = cuadroContrasenaContrasena.Password;

            if (!ValidadorDatos.EsCadenaVacia(nombreJugador) &&
                !ValidadorDatos.EsCadenaVacia(contrasena))
            {
                if (!ExistenDatosInvalidos(nombreJugador, contrasena))
                {
                    CuentaJugador cuentaJugadorAutenticada =
                        Servicios.ServicioJugador.IniciarSesion(nombreJugador,
                        EncriptadorContrasena.CalcularHashSha512(contrasena));

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
                else
                {
                    MessageBox.Show(Properties.Resources.
                        ETIQUETA_VALIDACION_MENSAJECAMPOSINVALIDOS, Properties.Resources.
                        ETIQUETA_VALIDACION_CAMPOSINVALIDOS, MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show(Properties.Resources.ETIQUETA_GENERAL_MENSAJECAMPOSVACIOS,
                    Properties.Resources.ETIQUETA_VALIDACION_CAMPOSVACIOS,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region Validaciones

        private bool ExistenDatosInvalidos(string nombreJugador, string contrasena)
        {
            bool hayCamposInvalidos = false;

            if (ValidadorDatos.ExistenCaracteresInvalidosParaContrasena(contrasena))
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_VALIDACION_MENSAJECONTRASENAINVALIDA, Properties.Resources.
                    ETIQUETA_VALIDACION_CONTRASENAINVALIDA, MessageBoxButton.OK);
                hayCamposInvalidos = true;
            }

            if (ValidadorDatos.ExistenCaracteresInvalidosParaNombreJugador(nombreJugador))
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_VALIDACION_MENSAJENOMBREUSUARIOINVALIDO, Properties.Resources.
                    ETIQUETA_VALIDACION_NOMBREUSUARIOINVALIDO, MessageBoxButton.OK);
                hayCamposInvalidos = true;
            }

            if (ExistenLongitudesExcedidas(nombreJugador, contrasena))
            {
                MessageBox.Show(Properties.Resources.ETIQUETA_VALIDACION_MENSAJELONGITUDEXCEDIDA,
                   Properties.Resources.ETIQUETA_VALIDACION_CAMPOSEXCEDIDOS, MessageBoxButton.OK);
            }

            return hayCamposInvalidos;
        }

        private bool ExistenLongitudesExcedidas(string nombreJugador, string contrasena)
        {
            bool resultado = false;

            if (ValidadorDatos.ExisteLongitudExcedidaEnNombreJugador(nombreJugador) ||
                ValidadorDatos.ExisteLongitudExcedidaEnContrasena(contrasena))
            {
                resultado = true;
            }

            return resultado;
        }
        #endregion
    }
}
