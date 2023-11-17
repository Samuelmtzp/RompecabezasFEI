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
                MostrarOpcionesJugadorRegistrado();
            }
        }

        private void MostrarOpcionesJugadorRegistrado()
        {
            etiquetaMisAmigos.Visibility = Visibility.Visible;
            etiquetaMiPerfil.Visibility = Visibility.Visible;
            imagenAvatarUsuario.Visibility = Visibility.Visible;
            imagenMisAmigos.Visibility = Visibility.Visible;
            imagenAvatarUsuario.Source = Dominio.CuentaJugador.Actual.FuenteImagenAvatar;
        }

        #region Eventos
        private void CrearNuevaSala(object objetoOrigen, RoutedEventArgs evento)
        {
            PaginaSala paginaSala = new PaginaSala
            {
                EsAnfitrion = true
            };
            paginaSala.UnirseASala();
            VentanaPrincipal.CambiarPagina(paginaSala);
        }

        private void IrPaginaUnirseSala(object objetoOrigen, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaUnirseSala());
        }

        private void IrPaginaAmistades(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaAmistades(true));
        }

        private void CerrarSesion(object objetoOrigen, MouseButtonEventArgs evento)
        {
            MessageBoxResult resultadoOpcionCerrarSesion = MessageBox.Show(
                Properties.Resources.ETIQUETA_CERRARSESION_MENSAJE,
                Properties.Resources.ETIQUETA_CERRARSESION_TITULO,
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (resultadoOpcionCerrarSesion == MessageBoxResult.Yes)
            {
                Servicios.ServicioJugador.CerrarSesion(Dominio.CuentaJugador.Actual.NombreJugador);
                Dominio.CuentaJugador.Actual = null;
                VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
            }
        }

        private void IrPaginaInformacionJugador(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
        }

        private void IrPaginaAjustes(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(new PaginaAjustes());
        }
        #endregion
    }
}
