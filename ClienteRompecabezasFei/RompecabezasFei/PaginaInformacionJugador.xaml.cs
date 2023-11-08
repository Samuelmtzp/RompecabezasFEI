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
            etiquetaNombreJugador.Content = Dominio.CuentaJugador.Actual.NombreJugador;
            imagenAvatarJugador.Source = Dominio.CuentaJugador.Actual.FuenteImagenAvatar;
            MostrarPartidasJugadas();
            MostrarPartidasGanadas();
        }
        #endregion

        #region Métodos privados
        private void MostrarPartidasJugadas()
        {
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();

            try
            {
                cuadroTextoPartidasJugadas.Text = Convert.ToString(cliente.
                    ObtenerNumeroPartidasJugadas(Dominio.CuentaJugador.Actual.NombreJugador));
                cliente.Close();
            }
            catch (EndpointNotFoundException)
            {
                cliente.Abort();
            }            
        }

        private void MostrarPartidasGanadas()
        {
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();

            try
            {
                cuadroTextoPartidasGanadas.Text = Convert.ToString(cliente.
                    ObtenerNumeroPartidasGanadas(Dominio.CuentaJugador.Actual.NombreJugador));
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
            VentanaPrincipal.CambiarPagina(new PaginaActualizacionInformacion(
                Dominio.CuentaJugador.Actual.NombreJugador, 
                Dominio.CuentaJugador.Actual.NumeroAvatar));
        }

        private void EventoClickRegresar(object controlOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
        }
        #endregion
    }
}
