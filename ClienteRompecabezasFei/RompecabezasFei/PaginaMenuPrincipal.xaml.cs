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
            cargarImagenUsuario();
        }

        private void cargarImagenUsuario()
        {
            string rutaImagen = "/Imagenes/Avatares/";
            BitmapImage ImagenUsuarioMapaBits = new BitmapImage();
            ImagenUsuarioMapaBits.BeginInit();

            MessageBox.Show("Es invitado = " + Jugador.JugadorActual.EsInvitado);
            MessageBox.Show("Número de avatar = " + Jugador.JugadorActual.NumeroAvatar);
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

        private void BotonCrearSala_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click en botón crear sala");
        }

        private void BotonUnirseASala_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click en botón unirse a sala");
        }

        private void ImagenMisAmigos_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Click en opción mis amigos");
        }

        private void ImagenCerrarSesion_Click(object sender, MouseButtonEventArgs e)
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

        private void ImagenMiPerfil_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Click en opción mi perfil");
        }

        private void ImagenAjustes_Click(object sender, MouseButtonEventArgs e)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaAjustes());
        }

    }
}
