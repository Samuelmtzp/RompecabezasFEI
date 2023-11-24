using Dominio;
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
        
        private const string IdiomaIngles = "en-US";
        
        private const string IdiomaEspanol = "es-MX";

        public PaginaAjustes()
        {
            InitializeComponent();
        }

        private void InicializarSeleccionIdioma()
        {
            if (App.Current.IdiomaActual == IdiomaIngles)
            {
                cajaOpcionesIdioma.SelectedIndex = (int)Idioma.Ingles;
            }
            else
            {
                cajaOpcionesIdioma.SelectedIndex = (int)Idioma.Espanol;
            }
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

        private void InicializarOpcionesDeAjustes(object objetoOrigen, RoutedEventArgs evento)
        {
            InicializarSeleccionIdioma();
            InicializarSeleccionMusica();
        }

        private void SeleccionarIdioma(object controlOrigen, SelectionChangedEventArgs evento)
        {
            if (cajaOpcionesIdioma.SelectedIndex == (int)Idioma.Ingles)
            {
                idioma = IdiomaIngles;
            }
            else
            {
                idioma = IdiomaEspanol;
            }
        }

        private void IrAPaginaAnterior(object objetoOrigen, MouseButtonEventArgs evento)
        {
            if (VentanaPrincipal.PaginaAnterior is PaginaInicioSesion)
            {
                VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
            }
            else
            {
                VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
            }
        }

        private void CajaDeOpcionesDeIdiomaCerrada(object objetoOrigen, EventArgs evento)
        {
            App.Current.CambiarIdioma(idioma);
            RefrescarPaginaActual();
        }

        private void ActivarMusica(object objetoOrigen, RoutedEventArgs evento)
        {
            if (!hayMusicaActivadaInicialmente)
            {
                App.Current.EstadoMusica(true);
            }
        }

        private void DesactivarMusica(object objetoOrigen, RoutedEventArgs evento)
        {
            App.Current.EstadoMusica(false);
        }
    }
}