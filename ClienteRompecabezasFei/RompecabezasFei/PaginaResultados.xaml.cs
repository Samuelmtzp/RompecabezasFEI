using System.Windows;
using System.Windows.Controls;

namespace RompecabezasFei
{
    public partial class PaginaResultados : Page
    {
        bool esAnfitrion;
        string codigoSala;

        public PaginaResultados(bool esAnfitrion, string codigoSala)
        {
            InitializeComponent();
            this.esAnfitrion = esAnfitrion;
            this.codigoSala = codigoSala;
        }

        private void EventoClickAceptar(object objetoOrigen, RoutedEventArgs evento)
        {
            PaginaSala paginaSala = new PaginaSala();
            VentanaPrincipal.CambiarPagina(paginaSala);
            paginaSala.CargarDatosSala(esAnfitrion, codigoSala);
        }
    }
}
