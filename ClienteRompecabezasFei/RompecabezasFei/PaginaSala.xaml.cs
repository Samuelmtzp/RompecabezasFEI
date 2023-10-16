using Dominio;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

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
            CuadroTextoMensajes.AppendText(Jugador.CuentaJugadorActual.NombreJugador + ": " + 
                CuadroTextoMensajeUsuario.Text + "\n");
        }

        private void AccionIniciarPartida(object remitente, RoutedEventArgs evento)
        {
            
        }
    }
}
