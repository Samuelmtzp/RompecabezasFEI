using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Seguridad;

namespace RompecabezasFei
{
    public partial class PaginaRecuperacionContrasena : Page
    {
        public PaginaRecuperacionContrasena()
        {
            InitializeComponent();
        }

        private void IrAPaginaRestablecimientoContrasena(object objetoOrigen,
            RoutedEventArgs evento)
        {
            string correo = cuadroTextoCorreo.Text;

            if (!ValidadorDatos.ExistenCaracteresInvalidosParaCorreo(correo))
            {
                if (Servicios.ServicioCorreo.ExisteCorreoElectronico(correo))
                {
                    PaginaCodigoRestablecimientoContrasena
                        paginaCodigoRestablecimientoContrasena = new
                        PaginaCodigoRestablecimientoContrasena(correo);
                    VentanaPrincipal.CambiarPagina(paginaCodigoRestablecimientoContrasena);
                }
                else
                {
                    MessageBox.Show(Properties.Resources.
                        ETIQUETA_RECUPERACIONCONTRASENA_MENSAJECORREOINEXISTENE, Properties.
                        Resources.ETIQUETA_RECUPERACIONCONTRASENA_CORREOINEXISTENTE,
                        MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show(Properties.Resources.ETIQUETA_VALIDACION_MENSAJECORREOINVALIDO,
                    Properties.Resources.ETIQUETA_VALIDACION_CORREOINVALIDO, MessageBoxButton.OK);
            }
        }

        private void IrAPaginaInicioSesion(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
        }
    }
}
