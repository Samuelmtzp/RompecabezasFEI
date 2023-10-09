using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RompecabezasFei
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class VentanaPrincipal : Window
    {
        public Window GetVentana()
        {
            return this;
        }

        public VentanaPrincipal()
        {
            InitializeComponent();
            MarcoPaginaActual.Navigate(new PaginaInicioSesion());
        }

        public static void CambiarPagina(Page paginaAntigua, Page nuevaPagina)
        {
            VentanaPrincipal ventanaPrincipal = (VentanaPrincipal) GetWindow(paginaAntigua);
            ventanaPrincipal.MarcoPaginaActual.Navigate(nuevaPagina);
        }
    }
}
