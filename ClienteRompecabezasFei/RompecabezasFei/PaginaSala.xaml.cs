using Dominio;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    /// <summary>
    /// Interaction logic for PaginaSala.xaml
    /// </summary>
    public partial class PaginaSala : Page
    {
        public PaginaSala()
        {
            InitializeComponent();
        }

        private void AccionRegresar(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaMenuPrincipal());
        }

        private void AccionOpcionesSala(object remitente, RoutedEventArgs evento)
        {

        }

        private void AccionEnviarMensaje(object remitente, RoutedEventArgs evento)
        {

        }

        private void AccionIniciarPartida(object remitente, RoutedEventArgs evento)
        {

        }
    }
}
