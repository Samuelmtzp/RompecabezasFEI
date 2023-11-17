using Security;
using Seguridad;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    public partial class PaginaActualizacionContrasena : Page
    {
        public PaginaActualizacionContrasena()
        {
            InitializeComponent();
        }

        #region Eventos
        private void IrAPaginaInformacionJugador(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
        }

        private void ActualizarContrasena(object objetoOrigen, RoutedEventArgs evento)
        {
            string contrasenaActual = Dominio.CuentaJugador.Actual.Contrasena;
            string contrasenaAnterior = cuadroContrasenaActual.Password;
            string nuevaContrasena = cuadroNuevaContrasena.Password;
            string confirmacionContrasena = cuadroConfirmacionContrasena.Password;

            if (ValidadorDatos.ExisteCoincidenciaEnCadenas(contrasenaAnterior, contrasenaActual))
            {
                if (!ValidadorDatos.ExisteCoincidenciaEnCadenas(contrasenaAnterior,
                    nuevaContrasena))
                {
                    if (!ExistenDatosInvalidos(nuevaContrasena, confirmacionContrasena))
                    {
                        string correoJugador = Dominio.CuentaJugador.Actual.Correo;
                        string nuevaContrasenaCifrada = EncriptadorContrasena.
                            CalcularHashSha512(nuevaContrasena);
                        bool actualizacionRealizada = Servicios.ServicioJugador.
                            ActualizarContrasena(correoJugador, nuevaContrasenaCifrada);

                        if (actualizacionRealizada)
                        {
                            MessageBox.Show("La actualización de la contraseña " +
                                "se ha realizado correctamente",
                                "Actualización realizada correctamente",
                                MessageBoxButton.OK);
                            Dominio.CuentaJugador.Actual.Contrasena = nuevaContrasena;
                            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
                        }
                        else
                        {
                            MessageBox.Show("La actualización de la contraseña no se ha realizado",
                                "Error al actualizar información", MessageBoxButton.OK);
                        }
                    }
                }
            }
        }
        #endregion

        #region Validaciones
        private bool ExistenDatosInvalidos(string nuevaContrasena,
            string confirmacionContrasena)
        {
            bool hayDatosInvalidos = false;

            if (ValidadorDatos.ExistenCaracteresInvalidosParaContrasena(nuevaContrasena))
            {
                MessageBox.Show(Properties.Resources.ETIQUETA_VALIDACION_MENSAJECONTRASENANUEVA,
                    Properties.Resources.ETIQUETA_VALIDACION_CONTRASENAINVALIDA,
                    MessageBoxButton.OK);
                hayDatosInvalidos = true;
            }

            if (ValidadorDatos.ExisteLongitudExcedidaEnContrasena(
                cuadroContrasenaActual.Password))
            {
                MessageBox.Show(Properties.Resources.ETIQUETA_VALIDACION_CONTRASENAEXCEDIDA,
                     Properties.Resources.ETIQUETA_VALIDACION_LONGITUDEXCEDIDA,
                     MessageBoxButton.OK);
                hayDatosInvalidos = true;
            }

            if (ExistenCamposVacios())
            {
                MessageBox.Show(Properties.Resources.ETIQUETA_VALIDACION_MENSAJECAMPOSVACIOS,
                   Properties.Resources.ETIQUETA_VALIDACION_CAMPOSVACIOS,
                   MessageBoxButton.OK);
                hayDatosInvalidos = true;
            }

            if (!ValidadorDatos.ExisteCoincidenciaEnCadenas(nuevaContrasena,
                confirmacionContrasena))
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_VALIDACION_MENSAJECONTRASENADIFERENTE, Properties.Resources.
                    ETIQUETA_VALIDACION_CONTRASENADIFERENTE, MessageBoxButton.OK);
            }

            return hayDatosInvalidos;
        }

        private bool ExistenCamposVacios()
        {
            bool resultado = false;

            if (ValidadorDatos.EsCadenaVacia(cuadroContrasenaActual.Password) ||
                ValidadorDatos.EsCadenaVacia(cuadroNuevaContrasena.Password) ||
                ValidadorDatos.EsCadenaVacia(cuadroConfirmacionContrasena.Password))
            {
                resultado = true;
            }

            return resultado;
        }
        #endregion
    }
}
