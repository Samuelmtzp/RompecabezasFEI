using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.ServiceModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    public partial class PaginaMenuPrincipal : Page
    {
        public PaginaMenuPrincipal()
        {
            InitializeComponent();

            if (!Dominio.CuentaJugador.Actual.EsInvitado)
            {
                CargarOpcionesJugador();
            }
        }

        #region Métodos privados
        private void CargarOpcionesJugador()
        {
            MostrarOpcionesJugadorRegistrado();
        }

        private void MostrarOpcionesJugadorRegistrado()
        {
            etiquetaMisAmigos.Visibility = Visibility.Visible;
            etiquetaMiPerfil.Visibility = Visibility.Visible;
            imagenAvatarUsuario.Visibility = Visibility.Visible;
            imagenMisAmigos.Visibility = Visibility.Visible;
            imagenAvatarUsuario.Source = Dominio.CuentaJugador.Actual.FuenteImagenAvatar;
        }
        #endregion

        #region Eventos
        private void EventoClickCrearSala(object controlOrigen, RoutedEventArgs evento)
        {
            PaginaSala paginaSala = new PaginaSala();
            paginaSala.IniciarConexionConSala(true);
            VentanaPrincipal.CambiarPagina(paginaSala);
        }

        private void EventoClickUnirseASala(object controlOrigen, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaUnirseSala());
        }

        private void EventoClickMisAmigos(object controlOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaAmistades());
        }

        private void EventoClickCerrarSesion(object controlOrigen, MouseButtonEventArgs evento)
        {
            MessageBoxResult resultadoOpcionCerrarSesion = MessageBox.Show(
                Properties.Resources.ETIQUETA_CERRARSESION_MENSAJE, 
                Properties.Resources.ETIQUETA_CERRARSESION_TITULO, 
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (resultadoOpcionCerrarSesion == MessageBoxResult.Yes)
            {
                ServicioJugadorClient cliente = new ServicioJugadorClient();

                try
                {
                    cliente.CerrarSesion(Dominio.CuentaJugador.Actual.NombreJugador);
                }                
                catch (CommunicationException)
                {
                    MessageBox.Show(Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                catch (TimeoutException)
                {
                    MessageBox.Show(Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                        ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                        MessageBoxButton.OK, MessageBoxImage.Error);                    
                }
                finally
                {
                    cliente.Abort();
                }

                Dominio.CuentaJugador.Actual = null;
                VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
            }
        }

        private void EventoClickMiPerfil(object controlOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
        }

        private void EventoClickAjustes(object controlOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(new PaginaAjustes());
        }
        #endregion
    }
}