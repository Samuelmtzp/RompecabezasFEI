using RompecabezasFei.Servicios;
using RompecabezasFei.Utilidades;
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

        private void IrAPaginaInformacionJugador(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
        }

        private void ActualizarContrasena(object objetoOrigen, RoutedEventArgs evento)
        {
            string nuevaContrasena = cuadroNuevaContrasena.Password;
            string confirmacionContrasena = cuadroConfirmacionContrasena.Password;

            if (!ExistenDatosInvalidos(nuevaContrasena, confirmacionContrasena))
            {
                string correoJugador = Dominio.CuentaJugador.Actual.Correo;
                string nuevaContrasenaCifrada = EncriptadorContrasena.
                    CalcularHashSha512(nuevaContrasena);
                var servicioJugador = new ServicioJugador();
                bool actualizacionRealizada = servicioJugador.
                    ActualizarContrasena(correoJugador, nuevaContrasenaCifrada);

                switch (servicioJugador.EstadoOperacion)
                {
                    case EstadoOperacion.Correcto:
                        
                        if (actualizacionRealizada)
                        {
                            GestorCuadroDialogo.MostrarInformacion(Properties.Resources.
                                ETIQUETA_ACTUALIZACIONINFORMACION_MENSAJEACTUALIZACION, 
                                Properties.Resources.ETIQUETA_CONTRASENAACTUALIZADA_MENSAJE);
                            Dominio.CuentaJugador.Actual.Contrasena = nuevaContrasena;
                            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
                        }
                        else
                        {
                            GestorCuadroDialogo.MostrarError(Properties.Resources.
                                ETIQUETA_ACTUALIZARCONTRASENA_CONTRASENANOACTUALIZADA, 
                                Properties.Resources.
                                ETIQUETA_ACTUALIZACIONINFORMACION_ERRORACTUALIZACION);
                        }
                        
                        break;
                }

            }
        }

        private bool ExistenDatosInvalidos(string nuevaContrasena,
            string confirmacionContrasena)
        {
            bool hayDatosInvalidos = false;

            if (!hayDatosInvalidos && ExistenCamposVacios())
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJECAMPOSVACIOS,
                    Properties.Resources.ETIQUETA_VALIDACION_CAMPOSVACIOS);
                hayDatosInvalidos = true;
            }

            if (!hayDatosInvalidos && ValidadorDatos.
                ExistenCaracteresInvalidosParaContrasena(nuevaContrasena))
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJECONTRASENANUEVA,
                    Properties.Resources.ETIQUETA_VALIDACION_CONTRASENAINVALIDA);
                hayDatosInvalidos = true;
            }

            if (!hayDatosInvalidos && ValidadorDatos.
                ExisteLongitudExcedidaEnContrasena(cuadroContrasenaActual.Password))
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_CONTRASENAEXCEDIDA,
                    Properties.Resources.ETIQUETA_VALIDACION_LONGITUDEXCEDIDA);
                hayDatosInvalidos = true;
            }

            if (!hayDatosInvalidos && !nuevaContrasena.
                Equals(confirmacionContrasena))
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                    Properties.Resources.ETIQUETA_VALIDACION_MENSAJECONTRASENADIFERENTE, 
                    Properties.Resources.ETIQUETA_VALIDACION_CONTRASENADIFERENTE);
                hayDatosInvalidos = true;
            }

            if (!hayDatosInvalidos)
            {
                var servicioJugador = new ServicioJugador();
                bool esContrasenaActualCorrecta = servicioJugador.
                    EsLaMismaContrasenaDeJugador(Dominio.CuentaJugador.
                    Actual.NombreJugador, EncriptadorContrasena.CalcularHashSha512(
                        cuadroContrasenaActual.Password));

                switch (servicioJugador.EstadoOperacion)
                {
                    case EstadoOperacion.Correcto:

                        if (!esContrasenaActualCorrecta)
                        {
                            GestorCuadroDialogo.MostrarAdvertencia(
                                "El campo de contraseña actual es incorrecto", 
                                "Contraseña actual no coincide");
                            hayDatosInvalidos = true;
                        }

                        break;
                }
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
    }
}