using Dominio;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace RompecabezasFei
{
    public partial class PaginaMenuPrincipal : Page
    {
        public PaginaMenuPrincipal()
        {
            InitializeComponent();
            if (!CuentaJugador.CuentaJugadorActual.EsInvitado)
            {
                CargarOpcionesJugador();
                CargarImagenJugador();
            }
        }

        private void CargarOpcionesJugador()
        {
            MostrarOpcionesJugadorRegistrado();
            CargarImagenJugador();
        }

        private void MostrarOpcionesJugadorRegistrado()
        {
            EtiquetaMisAmigos.Visibility = Visibility.Visible;
            EtiquetaMiPerfil.Visibility = Visibility.Visible;
            ImagenAvatarUsuario.Visibility = Visibility.Visible;
            ImagenMisAmigos.Visibility = Visibility.Visible;
        }

        private void CargarImagenJugador()
        {
            string rutaImagen = "/Imagenes/Avatares/";
            BitmapImage ImagenUsuarioMapaBits = new BitmapImage();
            ImagenUsuarioMapaBits.BeginInit();
            rutaImagen += CuentaJugador.CuentaJugadorActual.NumeroAvatar + ".png";

            ImagenUsuarioMapaBits.UriSource = new Uri(rutaImagen, UriKind.RelativeOrAbsolute);
            ImagenUsuarioMapaBits.EndInit();
            ImagenAvatarUsuario.Source = ImagenUsuarioMapaBits;
        }

        private void AccionCrearSala(object remitente, RoutedEventArgs evento)
        {
            PaginaSala paginaSala = new PaginaSala();
            paginaSala.CrearNuevaSala(true);
            VentanaPrincipal.CambiarPagina(paginaSala);
        }

        private void AccionUnirseASala(object remintente, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaUnirseSala());
        }

        private void AccionMisAmigos(object remitente, MouseButtonEventArgs evento)
        {

        }

        private void AccionCerrarSesion(object remitente, MouseButtonEventArgs evento)
        {
            MessageBoxResult resultado = MessageBox.Show(
                Properties.Resources.ETIQUETA_CERRARSESION_MENSAJE, 
                Properties.Resources.ETIQUETA_CERRARSESION_TITULO, 
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (resultado == MessageBoxResult.Yes)
            {
                CuentaJugador.CuentaJugadorActual = null;
                VentanaPrincipal.CambiarPagina(new PaginaInicioSesion());
            }
        }

        private void AccionMiPerfil(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaInformacionJugador());
        }

        private void AccionAjustes(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(new PaginaAjustes());
        }
    }
}