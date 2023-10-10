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
        private static Page paginaAnterior;
        public static Page PaginaAnterior
        {
            get
            {
                return paginaAnterior;
            }
            private set
            {
                paginaAnterior = value;
            }
        }

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
            PaginaAnterior = paginaAntigua;
            VentanaPrincipal ventanaPrincipal = (VentanaPrincipal) GetWindow(paginaAntigua);
            ventanaPrincipal.MarcoPaginaActual.Navigate(nuevaPagina);
        }

        public static void IrPaginaAnterior(Page paginaAntigua)
        {
            CambiarPagina(paginaAntigua, paginaAnterior);
        }
    }
}
