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
            ServicioJugadorClient cliente = new ServicioJugadorClient();

            try
            {
                cuadroTextoPartidasJugadas.Text = Convert.ToString(cliente.
                    ObtenerNumeroPartidasJugadas(Dominio.CuentaJugador.Actual.NombreJugador));                
            }
            catch (CommunicationException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (TimeoutException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                cliente.Abort();
            }
        }

        private void MostrarPartidasGanadas()
        {
            ServicioJugadorClient cliente = new ServicioJugadorClient();

            try
            {
                cuadroTextoPartidasGanadas.Text = Convert.ToString(cliente.
                    ObtenerNumeroPartidasGanadas(Dominio.CuentaJugador.Actual.NombreJugador));
            }
            catch (CommunicationException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (TimeoutException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                MessageBox.Show(Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                    ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion

        #region Eventos
        private void CambiarContrasena(object objetoOrigen, 
            RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaActualizacionContrasena());
        }

        private void ActualizarInformacionJugador(object controlOrigen, 
            RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaActualizacionInformacion(
                Dominio.CuentaJugador.Actual.NombreJugador, 
                Dominio.CuentaJugador.Actual.NumeroAvatar));
        }

        private void RegresarPaginaMenuPrincipal(object controlOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaMenuPrincipal());
        }
        #endregion
    }
}
