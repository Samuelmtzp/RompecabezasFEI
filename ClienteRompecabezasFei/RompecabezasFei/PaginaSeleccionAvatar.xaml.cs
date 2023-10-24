using Dominio;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    public partial class PaginaSeleccionAvatar : Page
    {
        private CuentaJugador jugadorRegistro;
        public CuentaJugador JugadorRegistro
        {
            get { return jugadorRegistro; }
            set { jugadorRegistro = value; }
        }

        public PaginaSeleccionAvatar()
        {
            InitializeComponent();
        }

        private void AccionRegresar(object remitente, MouseButtonEventArgs evento)
        {
            Regresar();
        }

        private void AccionSeleccionAvatar(object remitente, MouseButtonEventArgs evento)
        {
            Image imagenSeleccionada = remitente as Image;
            ImagenAvatarActual.Source = imagenSeleccionada.Source;
            ImagenAvatarActual.Tag = imagenSeleccionada.Tag;
        }

        private void AccionAceptar(object remitente, RoutedEventArgs evento)
        {
            Regresar();
        }

        private void Regresar()
        {
            if (typeof(PaginaRegistroJugador).IsInstanceOfType(VentanaPrincipal.PaginaAnterior))
            {
                PaginaRegistroJugador paginaRegistroUsuario = new PaginaRegistroJugador();
                paginaRegistroUsuario.ImagenAvatarActual.Source = ImagenAvatarActual.Source;
                paginaRegistroUsuario.ImagenAvatarActual.Tag = ImagenAvatarActual.Tag;
                paginaRegistroUsuario.JugadorRegistro = jugadorRegistro;
                paginaRegistroUsuario.CargarDatosEdicion();
                VentanaPrincipal.CambiarPagina(this, paginaRegistroUsuario);
            }
            else
            {
                VentanaPrincipal.CambiarPagina(this, new PaginaActualizacionInformacion());
            }
            
        }
    }
}
