using RompecabezasFei.ServicioRompecabezasFei;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace RompecabezasFei
{
    public partial class PaginaInformacionJugador : Page
    {
        public PaginaInformacionJugador()
        {
            InitializeComponent();
            CargarDatosJugador();
        }

        public void CargarDatosJugador()
        {
            etiquetaNombreJugador.Content = Dominio.CuentaJugador.
                CuentaJugadorActual.NombreJugador;
            CargarImagenJugador();
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
            cuadroTextoPartidasJugadas.Text = Convert.ToString(cliente.
                ObtenerNumeroPartidasJugadas(Dominio.CuentaJugador.
                CuentaJugadorActual.NombreJugador));
            cuadroTextoPartidasGanadas.Text = Convert.ToString(cliente.
                ObtenerNumeroPartidasGanadas(Dominio.CuentaJugador.
                CuentaJugadorActual.NombreJugador));
            cliente.Abort();
        }

        private void CargarImagenJugador()
        {
            string rutaImagen = "/Imagenes/Avatares/";
            BitmapImage ImagenUsuarioMapaBits = new BitmapImage();
            ImagenUsuarioMapaBits.BeginInit();
            rutaImagen += Dominio.CuentaJugador.CuentaJugadorActual.NumeroAvatar + ".png";
            ImagenUsuarioMapaBits.UriSource = new Uri(rutaImagen, UriKind.RelativeOrAbsolute);
            ImagenUsuarioMapaBits.EndInit();
            imagenAvatarJugador.Source = ImagenUsuarioMapaBits;
        }

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
    }
}
