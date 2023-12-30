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
            if (new Servicios.ServicioSala().
                ExisteSalaDisponible(cuadroTextoCodigoSala.Text))
            {
                PaginaSala paginaSala = new PaginaSala(false, cuadroTextoCodigoSala.Text);
                VentanaPrincipal.CambiarPagina(paginaSala);
            }
        }

        private void IrAPaginaMenuPrincipal(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
        }
    }
}