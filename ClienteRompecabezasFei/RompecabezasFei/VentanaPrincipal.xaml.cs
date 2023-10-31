﻿using System.Windows;
using System.Windows.Controls;

namespace RompecabezasFei
{
    public partial class VentanaPrincipal : Window
    {
        private static Page paginaActual;
        private static Page paginaAnterior;        
        public static Page PaginaAnterior
        {
            get { return paginaAnterior; }
            set { paginaAnterior = value; }
        }

        public Window GetVentana()
        {
            return this;
        }

        public VentanaPrincipal()
        {
            InitializeComponent();
            paginaActual = new PaginaInicioSesion();
            MarcoPaginaActual.Navigate(paginaActual);
        }

        public static void CambiarPagina(Page nuevaPagina)
        {
            VentanaPrincipal ventanaPrincipal = (VentanaPrincipal)GetWindow(paginaActual);
            paginaActual = nuevaPagina;
            ventanaPrincipal.MarcoPaginaActual.Navigate(nuevaPagina);
        }

        public static void CambiarPaginaGuardandoAnterior(Page nuevaPagina)
        {
            CambiarPagina(nuevaPagina);
            PaginaAnterior = paginaActual;
        }
    }
}
