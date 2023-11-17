﻿using RompecabezasFei.ServicioRompecabezasFei;
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
            ImagenAvatarActual.Tag = Convert.ToInt16(numeroAvatar);
        }

        private void AccionRegresar(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
        }

        private void AccionSeleccionarAvatar(object objetoOrigen, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(new PaginaSeleccionAvatar(
                Convert.ToInt32(ImagenAvatarActual.Tag), CuadroTextoNombreJugador.Text,
                CuadroTextoCorreoElectronico.Text, CuadroContrasena.Password,
                CuadroConfirmacionContrasena.Password));
        }

        private void AccionSiguiente(object objetoOrigen, RoutedEventArgs evento)
        {
            string nombreJugador = CuadroTextoNombreJugador.Text;
            string correo = CuadroTextoCorreoElectronico.Text.ToLower();
            string contrasena = CuadroContrasena.Password;
            int numeroAvatar = Convert.ToInt32(ImagenAvatarActual.Tag);

            if (!ExistenCamposInvalidos())
            {
                if (!ExisteNombreJugador(nombreJugador) &&
                    !ExisteCorreoElectronico(correo))
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
        }

        #region Validaciones
        private bool ExisteNombreJugador(string nombreJugador)
        {
            ServicioJugadorClient cliente = new ServicioJugadorClient();
            bool resultado = false;

            try 
            {
                resultado = cliente.ExisteNombreJugador(nombreJugador);
            }
            catch (CommunicationException)
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
            finally
            {
                cliente.Abort();
            }

            return resultado;
        }

        private bool ExisteCorreoElectronico(string correoElectronico)
        {
            ServicioJugadorClient cliente = new ServicioJugadorClient();
            bool resultado = false;

            try
            {
                resultado = cliente.ExisteCorreoElectronico(correoElectronico);
            }
            catch (CommunicationException)
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
            finally
            {
                cliente.Abort();
            }

            if (resultado)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_REGISTRO_CORREONODISPONIBLE, Properties.Resources.
                    ETIQUETA_REGISTRO_MENSAJECORREONODISPONIBLE,
                    MessageBoxButton.OK);
            }

            return resultado;
        }

        private bool ExistenCamposInvalidos()
        {
            bool resultado = false;

            if (ExistenCamposVacios() || ExistenCadenasInvalidas() || 
                ExistenLongitudesExcedidas() || ExisteContrasenaInvalida() || 
                !HayCoincidenciasEnContrasenas())
            {
                resultado = true;
                MessageBox.Show(Properties.Resources.ETIQUETA_VALIDACION_MENSAJECAMPOSINVALIDOS);
            }

            return resultado;
        }

        private bool ExistenCamposVacios()
        {
            bool resultado = false;

            if (string.IsNullOrWhiteSpace(CuadroTextoNombreJugador.Text)
                || string.IsNullOrWhiteSpace(CuadroTextoCorreoElectronico.Text)
                || string.IsNullOrWhiteSpace(CuadroContrasena.Password)
                || string.IsNullOrWhiteSpace(CuadroConfirmacionContrasena.Password))
            {
                resultado = true;
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_VALIDACION_MENSAJECAMPOSVACIOS, Properties.Resources.
                    ETIQUETA_VALIDACION_CAMPOSVACIOS, MessageBoxButton.OK);
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
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_VALIDACION_MENSAJECAMPOSEXCEDIDOS, Properties.Resources.
                    ETIQUETA_VALIDACION_CAMPOSEXCEDIDOS, MessageBoxButton.OK);
            }

            return resultado;
        }

        private bool ExistenCadenasInvalidas()
        {
            bool resultado = false;

            if (ExistenCaracteresInvalidos(CuadroTextoNombreJugador.Text))
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_VALIDACION_MENSAJENOMBREUSUARIOINVALIDO, Properties.Resources.
                    ETIQUETA_VALIDACION_NOMBREUSUARIOINVALIDO, MessageBoxButton.OK);
                resultado = true;
            }

            if (ExistenCaracteresInvalidosParaCorreo(CuadroTextoCorreoElectronico.Text))
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_VALIDACION_MENSAJECORREOINVALIDO, Properties.Resources.
                    ETIQUETA_VALIDACION_CORREOINVALIDO, MessageBoxButton.OK);
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
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_VALIDACION_MENSAJECONTRASENAINVALIDA, Properties.Resources.
                    ETIQUETA_VALIDACION_CONTRASENAINVALIDA, MessageBoxButton.OK);
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
                @"^[a-zA-Z0-9]+(?:\s[a-zA-Z0-9]+)?$") == false)
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
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_VALIDACION_MENSAJECONTRASENADIFERENTE, Properties.Resources.
                    ETIQUETA_VALIDACION_CONTRASENADIFERENTE, MessageBoxButton.OK);
            }

            return resultado;
        }
        #endregion
    }
}
