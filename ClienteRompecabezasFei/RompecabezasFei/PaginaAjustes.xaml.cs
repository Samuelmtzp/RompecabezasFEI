using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    public partial class PaginaAjustes : Page
    {
        string idioma;
        
        public PaginaAjustes()
        {
            InitializeComponent();
            InicializarSeleccionIdioma();
        }

        private void InicializarSeleccionIdioma()
        {
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