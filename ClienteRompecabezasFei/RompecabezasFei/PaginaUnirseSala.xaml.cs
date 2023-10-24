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

        private void AccionUnirse(object remitente, RoutedEventArgs evento)
        {
            PaginaSala paginaSala = new PaginaSala();

            if (paginaSala.VerificarDisponibilidadSala(CuadroTextoCodigoSala.Text))
            {
                paginaSala.IdSala = CuadroTextoCodigoSala.Text;
                if (paginaSala.CrearNuevaSala(false))
                {
                    paginaSala.EtiquetaCodigoSala.Content = CuadroTextoCodigoSala.Text;
                    VentanaPrincipal.CambiarPagina(this, paginaSala);
                }
            }
        }

        private void AccionRegresar(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaMenuPrincipal());
        }
    }
}
