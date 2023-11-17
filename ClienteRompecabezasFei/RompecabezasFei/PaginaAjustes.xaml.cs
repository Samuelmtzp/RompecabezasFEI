﻿using Dominio;
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

        #region Métodos privados
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
        #endregion

        #region Eventos
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
        
        private void RegresarAPaginaAnterior(object objetoOrigen, MouseButtonEventArgs evento)
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

        private void CajaDeOpcionesDeIdiomaCerrada(object objetoOrigen, EventArgs evento)
        {
            App.Current.CambiarIdioma(idioma);
            RefrescarPaginaActual();
        }

        private void EventoBotonCambioMusicaActivado(object controlOrigen, 
            RoutedEventArgs evento)
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