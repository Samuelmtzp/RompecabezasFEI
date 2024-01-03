using System;
using System.Windows;

namespace RompecabezasFei.Utilidades
{
    public static class GestorControlesVentana
    {
        public static void DeshabilitarControlesDeVentana()
        {
            Application.Current.Dispatcher.Invoke(new Action(() =>
            {
                VentanaPrincipal.ObtenerVentanaActual().
                    marcoPaginaActual.IsEnabled = false;
            }));
        }

        public static void HabilitarControlesDeVentana()
        {
            Application.Current.Dispatcher.Invoke(new Action(() =>
            {
                VentanaPrincipal.ObtenerVentanaActual().
                    marcoPaginaActual.IsEnabled = true;
                VentanaPrincipal.ObtenerVentanaActual().
                    RecargarPaginaActual();
            }));
        }
    }
}