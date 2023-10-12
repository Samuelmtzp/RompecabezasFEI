using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RompecabezasFei
{
    /// <summary>
    /// Interaction logic for PaginaMenuPrincipal.xaml
    /// </summary>
    public partial class PaginaMenuPrincipal : Page
    {
        public PaginaMenuPrincipal()
        {
            InitializeComponent();
            CargarImagenUsuario();
        }

        private void CargarImagenUsuario()
        {
            string rutaImagen = "/Imagenes/Avatares/";
            BitmapImage ImagenUsuarioMapaBits = new BitmapImage();
            ImagenUsuarioMapaBits.BeginInit();

            if (Jugador.JugadorActual.EsInvitado)
            {
                rutaImagen += "Invitado.png";
            } 
            else
            {
                rutaImagen += Jugador.JugadorActual.NumeroAvatar + ".png";
            }

            ImagenUsuarioMapaBits.UriSource = new Uri(rutaImagen, UriKind.RelativeOrAbsolute);
            ImagenUsuarioMapaBits.EndInit();
            Imagen_AvatarUsuario.Source = ImagenUsuarioMapaBits;
        }

        private void AccionCrearSala(object remitente, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaSala());
        }

        private void AccionUnirseASala(object remintente, RoutedEventArgs evento)
        {
            MessageBox.Show("Click en botón unirse a sala");
        }

        private void AccionMisAmigos(object remitente, MouseButtonEventArgs evento)
        {
            MessageBox.Show("Click en opción mis amigos");
        }

        private void AccionCerrarSesion(object remitente, MouseButtonEventArgs evento)
        {
            MessageBoxResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas cerrar sesión?", 
                "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (resultado == MessageBoxResult.Yes)
            {
                Jugador.JugadorActual = null;
                VentanaPrincipal.CambiarPagina(this, new PaginaInicioSesion());
            }
        }

        private void AccionMiPerfil(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaInformacionJugador());
        }

        private void AccionAjustes(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPaginaGuardandoAnterior(this, new PaginaAjustes());
        }

    }
}
