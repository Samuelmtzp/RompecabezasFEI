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
            try
            {
                cuadroTextoPartidasJugadas.Text = Convert.ToString(
                    VentanaPrincipal.ClienteServicioGestionJugador.
                    ObtenerNumeroPartidasJugadas(Dominio.CuentaJugador.
                    Actual.NombreJugador));                
            }
            catch (CommunicationException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                VentanaPrincipal.ClienteServicioGestionJugador.Abort();
            }
            catch (TimeoutException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                VentanaPrincipal.ClienteServicioGestionJugador.Abort();
            }
        }

        private void MostrarPartidasGanadas()
        {            
            try
            {
                cuadroTextoPartidasGanadas.Text = Convert.ToString(
                    VentanaPrincipal.ClienteServicioGestionJugador.
                    ObtenerNumeroPartidasGanadas(Dominio.CuentaJugador.
                    Actual.NombreJugador));
            }
            catch (CommunicationException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                VentanaPrincipal.ClienteServicioGestionJugador.Abort();
            }
            catch (TimeoutException)
            {
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
                VentanaPrincipal.ClienteServicioGestionJugador.Abort();
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
