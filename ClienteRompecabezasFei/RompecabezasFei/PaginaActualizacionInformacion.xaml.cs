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

        private void IntentarActualizarInformacion(object objetoOrigen,
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

                if (esAvatarDiferente)
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
            var servicioJugador = new ServicioJugador();
            bool actualizacionRealizada = servicioJugador.
                ActualizarNombreJugador(nombreAnterior, nuevoNombre);

            switch (servicioJugador.EstadoOperacion)
            {
                case EstadoOperacion.Correcto:

                    if (actualizacionRealizada)
                    {
                        Dominio.CuentaJugador.Actual.NombreJugador = nuevoNombre;                        
                    }

                    break;
            }

            return actualizacionRealizada;
        }

        private bool ActualizarNumeroAvatar(string nombreJugador, 
            int nuevoNumeroAvatar)
        {
            var servicioJugador = new ServicioJugador();
            bool actualizacionRealizada = servicioJugador.
                ActualizarNumeroAvatar(nombreJugador, nuevoNumeroAvatar);

            switch (servicioJugador.EstadoOperacion)
            {
                case EstadoOperacion.Correcto:

                    if (actualizacionRealizada)
                    {
                        Dominio.CuentaJugador.Actual.
                            NumeroAvatar = nuevoNumeroAvatar;
                        Dominio.CuentaJugador.Actual.
                            FuenteImagenAvatar = GeneradorImagenes.
                            GenerarFuenteImagenAvatar(nuevoNumeroAvatar);
                    }

                    break;
            }

            return actualizacionRealizada;
        }

        private void NavegarAPaginaSeleccionAvatar(object objetoOrigen, RoutedEventArgs evento)
        {
            PaginaSeleccionAvatar paginaSeleccionAvatar = 
                new PaginaSeleccionAvatar(Convert.ToInt32(imagenAvatarActual.Tag), 
                cuadroTextoNombreUsuario.Text);
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(paginaSeleccionAvatar);
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

            if (ValidadorDatos.EsCadenaVacia(
                cuadroTextoNombreUsuario.Text.Trim()))
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJECAMPOSVACIOS,
                    Properties.Resources.ETIQUETA_VALIDACION_CAMPOSVACIOS);
                hayDatosInvalidos = true;
            }

            if (!hayDatosInvalidos && ValidadorDatos.
                ExisteLongitudExcedidaEnNombreJugador(
                cuadroTextoNombreUsuario.Text.Trim()))
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJECAMPOSEXCEDIDOS,
                    Properties.Resources.ETIQUETA_VALIDACION_CAMPOSEXCEDIDOS);
                hayDatosInvalidos = true;
            }

            if (!hayDatosInvalidos && ValidadorDatos.
                ExistenCaracteresInvalidosParaNombreJugador(
                cuadroTextoNombreUsuario.Text.Trim()))
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJENOMBREUSUARIOINVALIDO,
                    Properties.Resources.ETIQUETA_VALIDACION_NOMBREUSUARIOINVALIDO);
                hayDatosInvalidos = true;
            }

            if (!hayDatosInvalidos && !HayNombreJugadorSinModificar())
            {
                var servicio = new ServicioJugador();
                bool esNombreDisponible = !servicio.
                    ExisteNombreJugadorRegistrado(cuadroTextoNombreUsuario.Text);

                if (!esNombreDisponible)
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