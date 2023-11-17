using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    public partial class PaginaUnirseSala : Page
    {
        public PaginaUnirseSala()
        {
            InitializeComponent();
        }

        private void IntentarUnirJugadorASala(object objetoOrigen, RoutedEventArgs evento)
        {
            PaginaSala paginaSala = new PaginaSala();

            if (Servicios.ServicioSala.ExisteSalaDisponible(cuadroTextoCodigoSala.Text))
            {
                paginaSala.CodigoSala = cuadroTextoCodigoSala.Text;
                paginaSala.EsAnfitrion = false;
                paginaSala.etiquetaCodigoSala.Content = cuadroTextoCodigoSala.Text; 
                paginaSala.UnirseASala();                
                VentanaPrincipal.CambiarPagina(paginaSala);
            }
        }

        private void IrAPaginaMenuPrincipal(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
        }
    }
}