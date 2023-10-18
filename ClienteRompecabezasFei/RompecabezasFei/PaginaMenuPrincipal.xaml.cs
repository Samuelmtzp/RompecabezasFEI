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
            VentanaPrincipal.CambiarPagina(this, paginaSala);

        }

        private void AccionUnirseASala(object remintente, RoutedEventArgs evento)
        {
            PaginaSala paginaSala = new PaginaSala();
            paginaSala.CrearNuevaSala(true);

            if (paginaSala.VerificarDisponibilidadSala(CuadroTextoCodigoSala.Text))
            {
                if (paginaSala.CrearNuevaSala(false))
                {
                    VentanaPrincipal.CambiarPagina(this, paginaSala);
                }
            }
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
                CuentaJugador.CuentaJugadorActual = null;
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
