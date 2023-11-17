using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    public partial class PaginaInformacionJugador : Page
    {
        public PaginaInformacionJugador()
        {
            InitializeComponent();
            CargarDatosJugador();
        }

        public void CargarDatosJugador()
        {
            etiquetaNombreJugador.Content = Dominio.CuentaJugador.Actual.NombreJugador;
            imagenAvatarJugador.Source = Dominio.CuentaJugador.Actual.FuenteImagenAvatar;
            MostrarPartidasJugadas();
            MostrarPartidasGanadas();
        }

        private void MostrarPartidasJugadas()
        {
            cuadroTextoPartidasJugadas.Text = Convert.ToString(Servicios.ServicioPartida.
                ObtenerNumeroPartidasJugadas(Dominio.CuentaJugador.Actual.NombreJugador));
        }

        private void MostrarPartidasGanadas()
        {
            cuadroTextoPartidasGanadas.Text = Convert.ToString(Servicios.ServicioPartida.
                ObtenerNumeroPartidasGanadas(Dominio.CuentaJugador.Actual.NombreJugador));
        }

        private void IrAPaginaActualizacionContrasena(object objetoOrigen, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaActualizacionContrasena());
        }

        private void IrAPaginaActualizacionInformacion(object objetoOrigen, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaActualizacionInformacion(
                Dominio.CuentaJugador.Actual.NombreJugador,
                Dominio.CuentaJugador.Actual.NumeroAvatar));
        }

        private void IrAPaginaMenuPrincipal(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
        }
    }
}