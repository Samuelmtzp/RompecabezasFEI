using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RompecabezasFei
{
    public partial class PaginaAjustes : Page
    {
        string idioma;
        
        public PaginaAjustes()
        {
            InitializeComponent();
            if (App.Current.IdiomaActual == "en-US")
                CajaOpcionesIdioma.SelectedIndex = 0;
            else
                CajaOpcionesIdioma.SelectedIndex = 1;
        }

        private void AccionSeleccionIdioma(object remitente, SelectionChangedEventArgs evento)
        {
            if (CajaOpcionesIdioma.SelectedIndex == 0)
                idioma = "en-US";
            else
                idioma = "es-MX";
        }

        private void RefrescarPaginaActual()
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaAjustes());
        }

        private void AccionRegresar(object remitente, MouseButtonEventArgs evento)
        {
            if (typeof(PaginaInicioSesion).IsInstanceOfType(VentanaPrincipal.PaginaAnterior))
            {
                VentanaPrincipal.CambiarPagina(this, new PaginaInicioSesion());
            } 
            else
            {
                VentanaPrincipal.CambiarPagina(this, new PaginaMenuPrincipal());
            }            
        }

        private void AccionOpcionesIdiomaCerrado(object remitente, EventArgs evento)
        {
            App.Current.CambiarIdioma(idioma);
            RefrescarPaginaActual();
        }
    }
}
