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

        private void AccionUnirse(object objetoOrigen, RoutedEventArgs evento)
        {
            PaginaSala paginaSala = new PaginaSala();

            if (paginaSala.VerificarDisponibilidadSala(CuadroTextoCodigoSala.Text))
            {
                paginaSala.CodigoSala = CuadroTextoCodigoSala.Text;
                paginaSala.IniciarConexionConSala(false);
                paginaSala.EtiquetaCodigoSala.Content = CuadroTextoCodigoSala.Text;
                VentanaPrincipal.CambiarPagina(paginaSala);
            }
        }

        private void AccionRegresar(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
        }
    }
}
