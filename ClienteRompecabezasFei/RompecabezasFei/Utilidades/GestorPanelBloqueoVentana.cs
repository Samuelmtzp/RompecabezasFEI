using System;
using System.Windows;

namespace RompecabezasFei.Utilidades
{
    public static class GestorPanelBloqueoVentana
    {
        public static void MostrarPanelBloqueo()
        {
            Application.Current.Dispatcher.Invoke(new Action(() =>
            {
                VentanaPrincipal.ObtenerVentanaActual().
                    panelBloqueo.Visibility = Visibility.Visible;
            }));
        }

        public static void OcultarPanelBloqueo()
        {
            Application.Current.Dispatcher.Invoke(new Action(() =>
            {
                VentanaPrincipal.ObtenerVentanaActual().
                    panelBloqueo.Visibility = Visibility.Hidden;
            }));
        }
    }
}