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

        private void AccionRegresar(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaInformacionJugador());
        }

        private void AccionGuardarCambios(object remitente, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaInformacionJugador());
        }
    }
}
