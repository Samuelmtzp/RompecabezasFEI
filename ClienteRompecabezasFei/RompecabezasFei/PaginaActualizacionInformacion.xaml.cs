using System;
using System.ServiceModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    public partial class PaginaActualizacionInformacion : Page
    {
        public PaginaActualizacionInformacion(string nombreJugador, int numeroAvatar)
        {
            InitializeComponent();
            MostrarDatosEdicion(nombreJugador, numeroAvatar);
        }

        #region Métodos privados
        private void MostrarDatosEdicion(string nombreJugador, int numeroAvatar)
        {
            cuadroTextoNombreUsuario.Text = nombreJugador;
            imagenAvatarActual.Tag = Convert.ToInt16(numeroAvatar);
            imagenAvatarActual.Source = Utilidades.GeneradorImagenes.
                GenerarFuenteImagenAvatar(numeroAvatar);            
        }

        private void ActualizarInformacion(string nuevoNombre, int nuevoNumeroAvatar)
        {            
            bool esNombreDisponible = false;

            try
            {
                esNombreDisponible = !VentanaPrincipal.ClienteServicioGestionJugador.
                    ExisteNombreJugador(nuevoNombre);
            }
            catch (EndpointNotFoundException)
            {
                VentanaPrincipal.ClienteServicioGestionJugador.Abort();
            }

            if (esNombreDisponible)
            {
                bool actualizacionRealizada = false;
                string nombreAnterior = Dominio.CuentaJugador.Actual.NombreJugador;

                try
                {
                    actualizacionRealizada = VentanaPrincipal.ClienteServicioGestionJugador.
                        ActualizarInformacion(nombreAnterior, nuevoNombre, nuevoNumeroAvatar);
                }
                catch(EndpointNotFoundException)
                {
                    
                }

                if (actualizacionRealizada)
                {
                    MessageBox.Show(
                      Properties.Resources.ETIQUETA_ACTUALIZACIONINFORMACION_MENSAJEACTUALIZACION,
                     Properties.Resources.ETIQUETA_ACTUALIZACIONINFORMACION_ACTUALIZACIONREALIZADA,
                        MessageBoxButton.OK);
                    Dominio.CuentaJugador.Actual.NumeroAvatar = nuevoNumeroAvatar;
                    Dominio.CuentaJugador.Actual.NombreJugador = nuevoNombre;
                    Dominio.CuentaJugador.Actual.FuenteImagenAvatar = Utilidades.
                        GeneradorImagenes.GenerarFuenteImagenAvatar(nuevoNumeroAvatar);                    
                    VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
                }
                else
                {
                    MessageBox.Show(
                   Properties.Resources.ETIQUETA_ACTUALIZACIONINFORMACION_ACTUALIZACIONNOREALIZADA,
                        Properties.Resources.ETIQUETA_ACTUALIZACIONINFORMACION_ERRORACTUALIZACION,
                        MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show(
                    Properties.Resources.ETIQUETA_ACTUALIZACIONINFORMACION_NOMBRENODISPONIBLE,
                    Properties.Resources.ETIQUETA_ACTUALIZACIONINFORMACION_ERRORACTUALIZACION, 
                    MessageBoxButton.OK);
            }
        }        
        #endregion

        #region Eventos        
        private void EventoClickRegresar(object controlOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
        }

        private void EventoClickGuardarCambios(object controlOrigen, RoutedEventArgs evento)
        {
            string nuevoNombre = cuadroTextoNombreUsuario.Text.Trim();
            int nuevoNumeroAvatar = Convert.ToInt32(imagenAvatarActual.Tag);
            bool esNombreDiferente = false;
            bool esAvatarDiferente = false;

            if (!ExistenModificacionesEnNombre(nuevoNombre) &&
                !ExistenModificacionesEnAvatar(nuevoNumeroAvatar))
            {
                VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
            }
            else
            {
                if (ExistenModificacionesEnAvatar(nuevoNumeroAvatar))
                {
                    esAvatarDiferente = true; 
                }
                if (ExistenModificacionesEnNombre(nuevoNombre))
                {
                    esNombreDiferente = true;
                }
            }

            if (esNombreDiferente || esAvatarDiferente)
            {
                if (!ExistenCamposInvalidos())
                {
                    ActualizarInformacion(nuevoNombre, nuevoNumeroAvatar);
                }
            }
        }

        private void EventoClickCambiarAvatar(object controlOrigen, RoutedEventArgs evento)
        {
            PaginaSeleccionAvatar paginaSeleccionAvatar = new PaginaSeleccionAvatar(
                Convert.ToInt32(imagenAvatarActual.Tag), cuadroTextoNombreUsuario.Text);
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(paginaSeleccionAvatar);
        }
        #endregion

        #region Validaciones
        private bool ExistenModificacionesEnAvatar(int nuevoNumeroAvatar)
        {
            bool resultado = true;

            if (Dominio.CuentaJugador.Actual.NumeroAvatar.Equals(nuevoNumeroAvatar))
            {
                resultado = false;
            }

            return resultado;
        }

        private bool ExistenModificacionesEnNombre(string nuevoNombre)
        {
            bool resultado = true;

            if (Dominio.CuentaJugador.Actual.NombreJugador.Equals(nuevoNombre))
            {
                resultado = false;
            }

            return resultado;
        }

        private bool ExistenCamposInvalidos()
        {
            bool resultado = false;

            if (ExistenCamposVacios() || ExistenCadenasInvalidas() || 
                ExistenLongitudesExcedidas())
            {
                resultado = true;
            }

            return resultado;
        }

        private bool ExistenCamposVacios()
        {
            bool resultado = false;
            
            if (string.IsNullOrWhiteSpace(cuadroTextoNombreUsuario.Text))
            {
                resultado = true;
                MessageBox.Show(Properties.Resources.ETIQUETA_VALIDACION_MENSAJECAMPOSVACIOS,
                    Properties.Resources.ETIQUETA_VALIDACION_CAMPOSVACIOS, 
                    MessageBoxButton.OK);
            }

            return resultado;
        }

        private bool ExistenLongitudesExcedidas()
        {
            bool resultado = false;
            
            if (cuadroTextoNombreUsuario.Text.Length > 15)
            {
                resultado = true;
                MessageBox.Show(Properties.Resources.ETIQUETA_VALIDACION_MENSAJECAMPOSEXCEDIDOS,
                    Properties.Resources.ETIQUETA_VALIDACION_CAMPOSEXCEDIDOS, 
                    MessageBoxButton.OK);
            }

            return resultado;
        }

        private bool ExistenCadenasInvalidas()
        {
            bool resultado = false;
            
            if (ExistenCaracteresInvalidos(cuadroTextoNombreUsuario.Text))
            {
                resultado = true; 
                MessageBox.Show(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJENOMBREUSUARIOINVALIDO,
                    Properties.Resources.ETIQUETA_VALIDACION_NOMBREUSUARIOINVALIDO, 
                    MessageBoxButton.OK);                
            }

            return resultado;
        }

        private bool ExistenCaracteresInvalidos(String textoValido)
        {
            bool resultado = false;
            
            if (Regex.IsMatch(textoValido, 
                @"^[A-Za-zÁÉÍÓÚáéíóúñÑ]+(?:\s[A-Za-zÁÉÍÓÚáéíóúñÑ]+)?$") == false)
            {
                resultado = true;
            }

            return resultado;
        }
        #endregion

        #region Método prueba
        public void PruebaParaActualizarInformacion(string nuevoNombre, int nuevoNumeroAvatar)
        {
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
            bool esNombreDisponible = false;

            try
            {
                esNombreDisponible = !cliente.ExisteNombreJugador(nuevoNombre);
            }
            catch (EndpointNotFoundException)
            {
                cliente.Abort();
            }

            if (esNombreDisponible)
            {
                bool actualizacionRealizada = false;
                string nombreAnterior = Dominio.CuentaJugador.Actual.NombreJugador;

                try
                {
                    actualizacionRealizada = cliente.ActualizarInformacion(nombreAnterior,
                        nuevoNombre, nuevoNumeroAvatar);
                    cliente.Close();
                }
                catch (EndpointNotFoundException)
                {
                    cliente.Abort();
                }

                if (actualizacionRealizada)
                {
                    MessageBox.Show(
                      Properties.Resources.ETIQUETA_ACTUALIZACIONINFORMACION_MENSAJEACTUALIZACION,
                     Properties.Resources.ETIQUETA_ACTUALIZACIONINFORMACION_ACTUALIZACIONREALIZADA,
                        MessageBoxButton.OK);
                    Dominio.CuentaJugador.Actual.NumeroAvatar = nuevoNumeroAvatar;
                    Dominio.CuentaJugador.Actual.NombreJugador = nuevoNombre;
                    Dominio.CuentaJugador.Actual.FuenteImagenAvatar = Utilidades.
                        GeneradorImagenes.GenerarFuenteImagenAvatar(nuevoNumeroAvatar);
                    VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
                }
                else
                {
                    MessageBox.Show(
                   Properties.Resources.ETIQUETA_ACTUALIZACIONINFORMACION_ACTUALIZACIONNOREALIZADA,
                        Properties.Resources.ETIQUETA_ACTUALIZACIONINFORMACION_ERRORACTUALIZACION,
                        MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show(
                    Properties.Resources.ETIQUETA_ACTUALIZACIONINFORMACION_NOMBRENODISPONIBLE,
                    Properties.Resources.ETIQUETA_ACTUALIZACIONINFORMACION_ERRORACTUALIZACION,
                    MessageBoxButton.OK);
            }
        }
        #endregion
    }
}