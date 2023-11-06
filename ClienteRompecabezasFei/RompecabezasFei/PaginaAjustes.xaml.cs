using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    public partial class PaginaAjustes : Page
    {
        private string idioma;
        private bool hayMusicaActivadaInicialmente;
     
        public PaginaAjustes()
        {
            InitializeComponent();
        }

        #region Métodos privados
        private void InicializarSeleccionIdioma()
        {
            if (App.Current.IdiomaActual == "en-US")
                cajaOpcionesIdioma.SelectedIndex = 0;
            else
                cajaOpcionesIdioma.SelectedIndex = 1;
        }

        private void InicializarSeleccionMusica()
        {
            if (App.Current.MusicaActiva)
            {
                hayMusicaActivadaInicialmente = true;
                botonCambioMusica.IsChecked = true;
            }
            else
            {
                hayMusicaActivadaInicialmente = false;
                botonCambioMusica.IsChecked = false;                
            }
        }

        private void RefrescarPaginaActual()
        {
            VentanaPrincipal.CambiarPagina(new PaginaAjustes());
        }
        #endregion

        #region Eventos
        private void EventoPaginaAjustesCargada(object controlOrigen, RoutedEventArgs evento)
        {
            InicializarSeleccionIdioma();
            InicializarSeleccionMusica();
        }

        private void EventoCambioIdioma(object controlOrigen, SelectionChangedEventArgs evento)
        {
            if (cajaOpcionesIdioma.SelectedIndex == 0)
                idioma = "en-US";
            else
                idioma = "es-MX";
        }
        
        private void EventoClickRegresar(object controlOrigen, MouseButtonEventArgs evento)
        {
            if (typeof(PaginaInicioSesion).IsInstanceOfType(VentanaPrincipal.PaginaAnterior))
            {
                VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
            } 
            else
            {
                VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
            }
        }

        private void EventoCajaOpcionesIdiomaCerrada(object controlOrigen, EventArgs evento)
        {
            App.Current.CambiarIdioma(idioma);
            RefrescarPaginaActual();
        }

        private void EventoBotonCambioMusicaActivado(object controlOrigen, RoutedEventArgs evento)
        {
            if (!hayMusicaActivadaInicialmente)
            {
                App.Current.EstadoMusica(true);
            }            
        }

        private void EventoBotonCambioMusicaDesactivado(object controlOrigen, 
            RoutedEventArgs evento)
        {              
            App.Current.EstadoMusica(false);
        }
        #endregion
    }
}