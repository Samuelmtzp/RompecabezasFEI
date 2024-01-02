using RompecabezasFei.Utilidades;
using RompecabezasFei.Servicios;
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
            imagenAvatarActual.Source = GeneradorImagenes.
                GenerarFuenteImagenAvatar(numeroAvatar);
        }

        private void IrAPaginaInformacionJugador(object controlOrigen,
            MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
        }

        private void ActualizarInformacion(object objetoOrigen,
            RoutedEventArgs evento)
        {
            string nuevoNombre = cuadroTextoNombreUsuario.Text.Trim();
            int nuevoNumeroAvatar = Convert.ToInt32(imagenAvatarActual.Tag);
            bool esNombreDiferente = !HayNombreJugadorSinModificar();
            bool esAvatarDiferente = !HayNumeroAvatarSinModificar();

            if (!esNombreDiferente && !esAvatarDiferente)
            {
                VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
            }

            if (!ExistenDatosInvalidosParaActualizacion())
            {
                bool actualizacionNombreRealizada = false;
                bool actualizacionAvatarRealizada = false;

                if (esNombreDiferente)
                {
                    actualizacionNombreRealizada = 
                        ActualizarNombreJugador(Dominio.CuentaJugador.
                        Actual.NombreJugador, nuevoNombre);
                }

                if (VentanaPrincipal.ServicioJugador.EstadoOperacion == 
                    EstadoOperacion.Correcto && esAvatarDiferente)
                {
                    actualizacionAvatarRealizada = 
                        ActualizarNumeroAvatar(Dominio.CuentaJugador.
                        Actual.NombreJugador, nuevoNumeroAvatar);
                }

                if ((esNombreDiferente && !actualizacionNombreRealizada) || 
                    (esAvatarDiferente && !actualizacionAvatarRealizada))
                {
                    GestorCuadroDialogo.MostrarAdvertencia(Properties.Resources.
                        ETIQUETA_ACTUALIZACIONINFORMACION_ACTUALIZACIONNOREALIZADA,
                        Properties.Resources.
                        ETIQUETA_ACTUALIZACIONINFORMACION_ERRORACTUALIZACION);
                    VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
                }
                else
                {
                    GestorCuadroDialogo.MostrarInformacion(Properties.Resources.
                        ETIQUETA_ACTUALIZACIONINFORMACION_ACTUALIZACIONREALIZADA,
                        Properties.Resources.
                        ETIQUETA_ACTUALIZACIONINFORMACION_MENSAJEACTUALIZACION);
                }
            }
        }

        private bool ActualizarNombreJugador(string nombreAnterior, 
            string nuevoNombre)
        {
            bool actualizacionRealizada = VentanaPrincipal.ServicioJugador.
                ActualizarNombreJugador(nombreAnterior, nuevoNombre);

            if (VentanaPrincipal.ServicioJugador.EstadoOperacion == 
                EstadoOperacion.Correcto && actualizacionRealizada)
            {
                Dominio.CuentaJugador.Actual.NombreJugador = nuevoNombre;                        
            }

            return actualizacionRealizada;
        }

        private bool ActualizarNumeroAvatar(string nombreJugador, int nuevoNumeroAvatar)
        {           
            bool actualizacionRealizada = VentanaPrincipal.ServicioJugador.
                ActualizarNumeroAvatar(nombreJugador, nuevoNumeroAvatar);

            if (VentanaPrincipal.ServicioJugador.EstadoOperacion == 
                EstadoOperacion.Correcto && actualizacionRealizada)
            {
                Dominio.CuentaJugador.Actual.
                    NumeroAvatar = nuevoNumeroAvatar;
                Dominio.CuentaJugador.Actual.
                    FuenteImagenAvatar = GeneradorImagenes.
                    GenerarFuenteImagenAvatar(nuevoNumeroAvatar);
            }

            return actualizacionRealizada;
        }

        private void IrAPaginaSeleccionAvatar(object objetoOrigen, 
            RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(
                new PaginaSeleccionAvatar(Convert.ToInt32(imagenAvatarActual.Tag), 
                cuadroTextoNombreUsuario.Text));
        }

        private bool HayNumeroAvatarSinModificar()
        {
            return Dominio.CuentaJugador.Actual.NumeroAvatar.
                Equals(Convert.ToInt32(imagenAvatarActual.Tag));
        }

        private bool HayNombreJugadorSinModificar()
        {
            return Dominio.CuentaJugador.Actual.NombreJugador.
                Equals(cuadroTextoNombreUsuario.Text.Trim());
        }

        private bool ExistenDatosInvalidosParaActualizacion()
        {
            bool hayDatosInvalidos = false;
            string nombreJugador = cuadroTextoNombreUsuario.Text;

            if (ValidadorDatos.EsCadenaVacia(nombreJugador))
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJECAMPOSVACIOS,
                    Properties.Resources.ETIQUETA_VALIDACION_CAMPOSVACIOS);
                hayDatosInvalidos = true;
            }

            if (!hayDatosInvalidos && ValidadorDatos.
                ExisteLongitudExcedidaEnNombreJugador(nombreJugador))
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJECAMPOSEXCEDIDOS,
                    Properties.Resources.ETIQUETA_VALIDACION_CAMPOSEXCEDIDOS);
                hayDatosInvalidos = true;
            }

            if (!hayDatosInvalidos && ValidadorDatos.
                ExistenCaracteresInvalidosParaNombreJugador(nombreJugador))
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJENOMBREUSUARIOINVALIDO,
                    Properties.Resources.ETIQUETA_VALIDACION_NOMBREUSUARIOINVALIDO);
                hayDatosInvalidos = true;
            }

            if (!hayDatosInvalidos && !HayNombreJugadorSinModificar())
            {
                bool esNombreDisponible = !VentanaPrincipal.ServicioJugador.
                    ExisteNombreJugadorRegistrado(nombreJugador);

                if (VentanaPrincipal.ServicioJugador.EstadoOperacion == 
                    EstadoOperacion.Correcto && !esNombreDisponible)
                { 
                    GestorCuadroDialogo.MostrarAdvertencia(Properties.Resources.
                        ETIQUETA_ACTUALIZACIONINFORMACION_NOMBRENODISPONIBLE,
                        Properties.Resources.
                        ETIQUETA_ACTUALIZACIONINFORMACION_ERRORACTUALIZACION);
                    hayDatosInvalidos = true;
                }
            }

            return hayDatosInvalidos;
        }
    }
}