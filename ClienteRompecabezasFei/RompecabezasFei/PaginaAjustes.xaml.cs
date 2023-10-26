using System;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    public partial class PaginaAjustes : Page
    {
        string idioma;
        bool esNuevaVentana;
     
        public PaginaAjustes()
        {
            InitializeComponent();
            InicializarSeleccionIdioma();
            esNuevaVentana = true;
            InicializarSeleccionMusica();
        }

        private void InicializarSeleccionIdioma()
        {
            if (App.Current.IdiomaActual == "en-US")
                CajaOpcionesIdioma.SelectedIndex = 0;
            else
                CajaOpcionesIdioma.SelectedIndex = 1;
        }

        private void InicializarSeleccionMusica()
        {
            if (App.Current.MusicaActiva)
            {
                BotonCambioMusica.IsChecked = true;
            }
            else
            {
                BotonCambioMusica.IsChecked = false;
                esNuevaVentana = false;
            }
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

        private void BotonCambioMusica_Checked(object remitente, RoutedEventArgs evento)
        {
            if (!esNuevaVentana)
            {
                App.Current.EstadoMusica(true);
            }
            else
            {
                esNuevaVentana = false;
            }
        }

        private void BotonCambioMusica_Unchecked(object sender, RoutedEventArgs e)
        {
              
            App.Current.EstadoMusica(false);
        }
    }
}