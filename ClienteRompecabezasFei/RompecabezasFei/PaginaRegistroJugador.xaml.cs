using Seguridad;
using System;
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
            cuadroTextoNombreJugador.Text = nombreJugador;
            cuadroTextoCorreoElectronico.Text = correo;
            cuadroContrasenaContrasena.Password = contrasena;
            cuadroContrasenaConfirmacionContrasena.Password = confirmacionContrasena;
            imagenAvatarActual.Source = Utilidades.GeneradorImagenes.
                GenerarFuenteImagenAvatar(numeroAvatar);
            imagenAvatarActual.Tag = Convert.ToInt16(numeroAvatar);
        }

        private void IrAPaginaInicioSesion(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
        }

        private void IrAPaginaSeleccionAvatar(object objetoOrigen, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(new PaginaSeleccionAvatar(
                Convert.ToInt32(imagenAvatarActual.Tag), cuadroTextoNombreJugador.Text,
                cuadroTextoCorreoElectronico.Text, cuadroContrasenaContrasena.Password,
                cuadroContrasenaConfirmacionContrasena.Password));
        }

        private void IrAPaginaVerificacionCorreo(object objetoOrigen, RoutedEventArgs evento)
        {
            string nombreJugador = cuadroTextoNombreJugador.Text;
            string correo = cuadroTextoCorreoElectronico.Text.ToLower();
            string contrasena = cuadroContrasenaContrasena.Password;
            int numeroAvatar = Convert.ToInt32(imagenAvatarActual.Tag);

            if (!ExistenCamposInvalidos())
            {
                if (!Servicios.ServicioJugador.ExisteNombreJugador(nombreJugador))
                {
                    if (!Servicios.ServicioCorreo.ExisteCorreoElectronico(correo))
                    {
                        Dominio.CuentaJugador jugadorRegistro = new Dominio.CuentaJugador
                        {
                            NombreJugador = nombreJugador,
                            Correo = correo,
                            Contrasena = contrasena,
                            NumeroAvatar = numeroAvatar,
                        };
                        VentanaPrincipal.CambiarPagina(new PaginaVerificacionCorreo(
                            jugadorRegistro));
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
        }

        #region Validaciones        
        private bool ExistenCamposInvalidos()
        {
            bool hayCamposInvalidos = false;

            if (ExistenCamposVacios())
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_VALIDACION_MENSAJECAMPOSVACIOS, Properties.Resources.
                    ETIQUETA_VALIDACION_CAMPOSVACIOS, MessageBoxButton.OK);
                hayCamposInvalidos = true;                
            }

            if (ValidadorDatos.ExistenCaracteresInvalidosParaNombreJugador(
                cuadroTextoNombreJugador.Text))
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_VALIDACION_MENSAJENOMBREUSUARIOINVALIDO, Properties.Resources.
                    ETIQUETA_VALIDACION_NOMBREUSUARIOINVALIDO, MessageBoxButton.OK);
                hayCamposInvalidos = true;
            }

            if (ValidadorDatos.ExistenCaracteresInvalidosParaCorreo(
                cuadroTextoCorreoElectronico.Text))
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_VALIDACION_MENSAJECORREOINVALIDO, Properties.Resources.
                    ETIQUETA_VALIDACION_CORREOINVALIDO, MessageBoxButton.OK);
                hayCamposInvalidos = true;
            }

            if (ValidadorDatos.ExistenCaracteresInvalidosParaContrasena(
                cuadroContrasenaContrasena.Password))
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_VALIDACION_MENSAJECONTRASENAINVALIDA, Properties.Resources.
                    ETIQUETA_VALIDACION_CONTRASENAINVALIDA, MessageBoxButton.OK);
                hayCamposInvalidos = true;
            }
            
            if (ExistenLongitudesExcedidas())
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_VALIDACION_MENSAJECAMPOSEXCEDIDOS, Properties.Resources.
                    ETIQUETA_VALIDACION_CAMPOSEXCEDIDOS, MessageBoxButton.OK); 
                hayCamposInvalidos = true;                
            }

            if (!ValidadorDatos.ExisteCoincidenciaEnCadenas(cuadroContrasenaContrasena.Password,
                cuadroContrasenaConfirmacionContrasena.Password))
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_VALIDACION_MENSAJECONTRASENADIFERENTE, Properties.Resources.
                    ETIQUETA_VALIDACION_CONTRASENADIFERENTE, MessageBoxButton.OK);
                hayCamposInvalidos = true;
            }

            return hayCamposInvalidos;
        }

        private bool ExistenCamposVacios()
        {
            bool resultado = false;

            if (ValidadorDatos.EsCadenaVacia(cuadroTextoNombreJugador.Text)
                || ValidadorDatos.EsCadenaVacia(cuadroTextoCorreoElectronico.Text)
                || ValidadorDatos.EsCadenaVacia(cuadroContrasenaContrasena.Password)
                || ValidadorDatos.EsCadenaVacia(cuadroContrasenaConfirmacionContrasena.Password))
            {
                resultado = true;
            }

            return resultado;
        }

        private bool ExistenLongitudesExcedidas()
        {
            bool resultado = false;

            if (ValidadorDatos.ExisteLongitudExcedidaEnNombreJugador(
                cuadroTextoNombreJugador.Text) ||
                ValidadorDatos.ExisteLongitudExcedidaEnCorreo(
                cuadroTextoCorreoElectronico.Text) ||
                ValidadorDatos.ExisteLongitudExcedidaEnContrasena(
                cuadroContrasenaContrasena.Password))
            {
                resultado = true;
            }

            return resultado;
        }
        #endregion
    }
}
