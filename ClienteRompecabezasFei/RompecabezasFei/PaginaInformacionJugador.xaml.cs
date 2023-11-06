using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.ServiceModel;
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

        #region Métodos públicos
        public void CargarDatosJugador()
        {
            etiquetaNombreJugador.Content = Dominio.CuentaJugador.
                CuentaJugadorActual.NombreJugador;
            imagenAvatarJugador.Source = Dominio.CuentaJugador.
                CuentaJugadorActual.FuenteImagenAvatar;
            CargarPartidasJugadas();
            CargarPartidasGanadas();
        }
        #endregion

        #region Métodos privados
        private void CargarPartidasJugadas()
        {
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();

            try
            {
                cuadroTextoPartidasJugadas.Text = Convert.ToString(cliente.
                    ObtenerNumeroPartidasJugadas(Dominio.CuentaJugador.
                    CuentaJugadorActual.NombreJugador));
                cliente.Close();
            }
            catch (EndpointNotFoundException)
            {
                cliente.Abort();
            }            
        }

        private void CargarPartidasGanadas()
        {
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();

            try
            {
                cuadroTextoPartidasGanadas.Text = Convert.ToString(cliente.
                    ObtenerNumeroPartidasGanadas(Dominio.CuentaJugador.
                    CuentaJugadorActual.NombreJugador));
                cliente.Close();
            }
            catch (EndpointNotFoundException)
            {
                cliente.Abort();
            }
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
