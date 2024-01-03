using System.Windows;
using System.Windows.Controls;
using RompecabezasFei.Utilidades;
using RompecabezasFei.Servicios;
using Security;
using Seguridad;

namespace RompecabezasFei
{
    public partial class PaginaRestablecimientoContrasena : Page
    {
        private readonly string correo;

        public PaginaRestablecimientoContrasena(string correo)
        {
            InitializeComponent();
            this.correo = correo;
        }

        private void ActualizarContrasena(object objetoOrigen, RoutedEventArgs evento)
        {
            string contrasena = cuadroContrasenaNueva.Password.ToString();

            if (!EsContrasenaInvalida(contrasena))
            {
                if (cuadroContrasenaNueva.Password.Equals(
                    cuadroConfirmarNuevaContrasena.Password))
                {
                    string contrasenaCifrada = EncriptadorContrasena.
                        CalcularHashSha512(contrasena);
                    var servicio = new ServicioJugador();
                    bool actualizacionRealizada = servicio.ActualizarContrasena(
                        correo, contrasenaCifrada);

                    switch (servicio.EstadoOperacion)
                    {
                        case EstadoOperacion.Correcto:
                            
                            if (actualizacionRealizada)
                            {
                                GestorCuadroDialogo.MostrarInformacion(Properties.Resources.
                                    ETIQUETA_RESTABLECIMIENTO_MENSAJECONTRASENAACTUALIZADA, 
                                    Properties.Resources.
                                    ETIQUETA_RESTABLECIMIENTO_CONTRASENARESTABLECIDA);
                                VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
                            }
                            else
                            {
                                GestorCuadroDialogo.MostrarError(Properties.Resources.
                                    ETIQUETA_RESTABLECIMIENTO_MENSAJECONTRASENANORESTABLECIDA, 
                                    Properties.Resources.
                                    ETIQUETA_RESTABLECIMIENTO_CONTRASENANORESTABLECIDA);
                            }

                            break;
                    }
                }
                else
                {
                    GestorCuadroDialogo.MostrarAdvertencia(
                        Properties.Resources.ETIQUETA_VALIDACION_MENSAJECONTRASENADIFERENTE,
                        Properties.Resources.ETIQUETA_VALIDACION_CONTRASENADIFERENTE);
                }
            }
            else
            {
                GestorCuadroDialogo.MostrarAdvertencia(
                       Properties.Resources.ETIQUETA_VALIDACION_MENSAJECONTRASENAINVALIDA,
                       Properties.Resources.ETIQUETA_VALIDACION_CONTRASENAINVALIDA);
            }
        }

        private bool EsContrasenaInvalida(string contrasena)
        {
            bool camposInvalidos = false;

            if (ValidadorDatos.ExisteLongitudExcedidaEnContrasena(contrasena) ||
                ValidadorDatos.ExistenCaracteresInvalidosParaContrasena(contrasena))
            {
                camposInvalidos = true;
            }

            return camposInvalidos;
        }
    }
}