using Dominio;
using RompecabezasFei.ServicioRompecabezasFei;
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
    public partial class PaginaInformacionJugador : Page
    {
        public PaginaInformacionJugador()
        {
            InitializeComponent();
            CargarDatosJugador();
        }

        private void CargarDatosJugador()
        {
            EtiquetaNombreJugador.Content = Dominio.CuentaJugador.CuentaJugadorActual.NombreJugador;
            CargarImagenJugador();
            ServicioGestionJugadorClient cliente = new ServicioGestionJugadorClient();
            CuadroTextoPartidasJugadas.Text = Convert.ToString(cliente.ObtenerNumeroPartidasJugadas(Dominio.CuentaJugador.CuentaJugadorActual.NombreJugador));
            CuadroTextoPartidasGanadas.Text = Convert.ToString(cliente.ObtenerNumeroPartidasGanadas(Dominio.CuentaJugador.CuentaJugadorActual.NombreJugador));
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
            ImagenAvatarJugador.Source = ImagenUsuarioMapaBits;
        }

        private void AccionCambiarContrasena(object remitente, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaActualizacionContrasena());
        }

        private void AccionActualizarInformacion(object remitente, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaActualizacionInformacion());
        }

        private void AccionRegresar(object remitente, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(this, new PaginaMenuPrincipal());
        }
    }
}
