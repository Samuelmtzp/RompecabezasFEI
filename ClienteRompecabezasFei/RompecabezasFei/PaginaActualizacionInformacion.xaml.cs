using Seguridad;
using System;
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

        private void MostrarDatosEdicion(string nombreJugador, int numeroAvatar)
        {
            cuadroTextoNombreUsuario.Text = nombreJugador;
            imagenAvatarActual.Tag = Convert.ToInt16(numeroAvatar);
            imagenAvatarActual.Source = Utilidades.GeneradorImagenes.
                GenerarFuenteImagenAvatar(numeroAvatar);            
        }

        #region Eventos        
        private void EventoClickRegresar(object controlOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
        }

        private void GuardarModificacionesDatosJugador(object objetoOrigen, 
            RoutedEventArgs evento)
        {
            string nombreAnterior = Dominio.CuentaJugador.Actual.NombreJugador;
            string nuevoNombre = cuadroTextoNombreUsuario.Text.Trim();
            int nuevoNumeroAvatar = Convert.ToInt32(imagenAvatarActual.Tag);
            bool esNombreDiferente = ExistenModificacionesEnNombreJugador(nuevoNombre);
            bool esAvatarDiferente = ExistenModificacionesEnNumeroAvatar(nuevoNumeroAvatar);

            if (!esNombreDiferente && !esAvatarDiferente)
            {
                VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
            }

            if (esNombreDiferente || esAvatarDiferente)
            {
                if (!ExistenDatosInvalidosParaActualizacion())
                {
                    if (!Servicios.ServicioJugador.ExisteNombreJugador(nuevoNombre))
                    {
                        bool actualizacionRealizada = Servicios.ServicioJugador.
                            ActualizarInformacion(nombreAnterior, nuevoNombre, nuevoNumeroAvatar);

                        if (actualizacionRealizada)
                        {
                            MessageBox.Show(Properties.Resources.
                                ETIQUETA_ACTUALIZACIONINFORMACION_MENSAJEACTUALIZACION,
                                Properties.Resources.
                                ETIQUETA_ACTUALIZACIONINFORMACION_ACTUALIZACIONREALIZADA,
                                MessageBoxButton.OK);
                            Dominio.CuentaJugador.Actual.NumeroAvatar = nuevoNumeroAvatar;
                            Dominio.CuentaJugador.Actual.NombreJugador = nuevoNombre;
                            Dominio.CuentaJugador.Actual.FuenteImagenAvatar = Utilidades.
                                GeneradorImagenes.GenerarFuenteImagenAvatar(nuevoNumeroAvatar);
                            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
                        }
                        else
                        {
                            MessageBox.Show(Properties.Resources.
                                ETIQUETA_ACTUALIZACIONINFORMACION_ACTUALIZACIONNOREALIZADA,
                                Properties.Resources.
                                ETIQUETA_ACTUALIZACIONINFORMACION_ERRORACTUALIZACION,
                                MessageBoxButton.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            Properties.Resources.
                            ETIQUETA_ACTUALIZACIONINFORMACION_NOMBRENODISPONIBLE, 
                            Properties.Resources.
                            ETIQUETA_ACTUALIZACIONINFORMACION_ERRORACTUALIZACION,
                            MessageBoxButton.OK);
                    }
                }
            }
        }

        private void NavegarAPaginaSeleccionAvatar(object objetoOrigen, RoutedEventArgs evento)
        {
            PaginaSeleccionAvatar paginaSeleccionAvatar = new PaginaSeleccionAvatar(
                Convert.ToInt32(imagenAvatarActual.Tag), cuadroTextoNombreUsuario.Text);
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(paginaSeleccionAvatar);
        }
        #endregion

        #region Validaciones
        private bool ExistenModificacionesEnNumeroAvatar(int nuevoNumeroAvatar)
        {
            bool resultado = true;

            if (Dominio.CuentaJugador.Actual.NumeroAvatar.Equals(nuevoNumeroAvatar))
            {
                resultado = false;
            }

            return resultado;
        }

        private bool ExistenModificacionesEnNombreJugador(string nuevoNombreJugador)
        {
            bool resultado = true;

            if (Dominio.CuentaJugador.Actual.NombreJugador.Equals(nuevoNombreJugador))
            {
                resultado = false;
            }

            return resultado;
        }

        private bool ExistenDatosInvalidosParaActualizacion()
        {
            bool datosInvalidos = false;

            if (ValidadorDatos.EsCadenaVacia(cuadroTextoNombreUsuario.Text))
            {
                datosInvalidos = true;
                MessageBox.Show(Properties.Resources.ETIQUETA_VALIDACION_MENSAJECAMPOSVACIOS,
                    Properties.Resources.ETIQUETA_VALIDACION_CAMPOSVACIOS,
                    MessageBoxButton.OK);
            }

            if (ValidadorDatos.ExisteLongitudExcedidaEnNombreJugador(
                cuadroTextoNombreUsuario.Text))
            {
                datosInvalidos = true;
                MessageBox.Show(Properties.Resources.ETIQUETA_VALIDACION_MENSAJECAMPOSEXCEDIDOS,
                    Properties.Resources.ETIQUETA_VALIDACION_CAMPOSEXCEDIDOS,
                    MessageBoxButton.OK);
            }
                
            if (ValidadorDatos.ExistenCaracteresInvalidosParaNombreJugador(
                cuadroTextoNombreUsuario.Text))
            {
                datosInvalidos = true;
                MessageBox.Show(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJENOMBREUSUARIOINVALIDO,
                    Properties.Resources.ETIQUETA_VALIDACION_NOMBREUSUARIOINVALIDO,
                    MessageBoxButton.OK);
            }

            return datosInvalidos;
        }
        #endregion
    }
}