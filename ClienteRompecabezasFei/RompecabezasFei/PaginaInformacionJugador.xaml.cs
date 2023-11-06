using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace RompecabezasFei
{
    public partial class PaginaInformacionJugador : Page
    {
        public PaginaInformacionJugador()
        {
            InitializeComponent();
            CargarDatosJugador();
        }

        #region Métodos Públicos
        public void CargarDatosJugador()
        {
            etiquetaNombreJugador.Content = Dominio.CuentaJugador.
                CuentaJugadorActual.NombreJugador;
            imagenAvatarJugador.Source = Dominio.CuentaJugador.
                CuentaJugadorActual.FuenteImagenAvatar;
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
            cuadroTextoPartidasJugadas.Text = Convert.ToString(cliente.
                ObtenerNumeroPartidasJugadas(Dominio.CuentaJugador.
                CuentaJugadorActual.NombreJugador));
            cuadroTextoPartidasGanadas.Text = Convert.ToString(cliente.
                ObtenerNumeroPartidasGanadas(Dominio.CuentaJugador.
                CuentaJugadorActual.NombreJugador));
            cliente.Abort();
        }
        #endregion

        #region Eventos
        private void EventoClickCambiarContrasena(object controlOrigen, 
            RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaActualizacionContrasena());
        }

        private void EventoClickActualizarInformacion(object controlOrigen, 
            RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaActualizacionInformacion());
        }

        private void EventoClickRegresar(object controlOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
        }
        #endregion
    }
}
