using Dominio;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace RompecabezasFei
{
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
            if (!string.IsNullOrEmpty(CuadroTextoMensajeUsuario.Text))
            {
                CuadroTextoMensajes.Text = CuadroTextoMensajes.Text +
                CuentaJugador.CuentaJugadorActual.NombreJugador + ": " +
                CuadroTextoMensajeUsuario.Text + "\n";
                CuadroTextoMensajeUsuario.Text = "";
            }
        }

        private void AccionIniciarPartida(object remitente, RoutedEventArgs evento)
        {
            
        }
    }
}
