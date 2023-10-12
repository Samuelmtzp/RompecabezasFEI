﻿using System;
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
    /// Interaction logic for PaginaActualizacionInformacion.xaml
    /// </summary>
    public partial class PaginaActualizacionInformacion : Page
    {
        public PaginaActualizacionInformacion()
        {
            InitializeComponent();
        }

        private void AccionCambiarAvatar(object remitente, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(this, new PaginaSeleccionAvatar()); 
        }

        private void AccionGuardarCambios(object remitente, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaInformacionJugador());
        }

        private void AccionRegresar(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaInformacionJugador());
        }
    }
}