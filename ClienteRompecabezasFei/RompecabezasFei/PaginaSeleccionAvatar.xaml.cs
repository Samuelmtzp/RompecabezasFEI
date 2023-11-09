using Dominio;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RompecabezasFei
{
    public partial class PaginaSeleccionAvatar : Page
    {
        private readonly string nombreJugador;
        private readonly string correo;
        private readonly string contrasena;
        private readonly string confirmacionContrasena;
        private readonly int numeroAvatar;

        public PaginaSeleccionAvatar(int numeroAvatar, string nombreJugador)
        {
            InitializeComponent();
            this.nombreJugador = nombreJugador;
            this.numeroAvatar = numeroAvatar;
        }

        public PaginaSeleccionAvatar(int numeroAvatar, string nombreJugador,
            string correo, string contrasena, string confirmacionContrasena)
        {
            InitializeComponent();
            this.nombreJugador = nombreJugador;
            this.correo = correo;
            this.contrasena = contrasena;
            this.numeroAvatar = numeroAvatar;
            this.confirmacionContrasena = confirmacionContrasena;
        }

        private void AccionSeleccionAvatar(object remitente, MouseButtonEventArgs evento)
        {
            Image imagenSeleccionada = remitente as Image;
            ImagenAvatarActual.Source = imagenSeleccionada.Source;
            ImagenAvatarActual.Tag = imagenSeleccionada.Tag;
        }

        private void AccionAceptar(object remitente, RoutedEventArgs evento)
        {
            if (typeof(PaginaRegistroJugador).IsInstanceOfType(VentanaPrincipal.PaginaAnterior))
            {
                PaginaRegistroJugador paginaRegistroUsuario = new PaginaRegistroJugador(
                    numeroAvatar, nombreJugador, correo, contrasena, confirmacionContrasena);
                VentanaPrincipal.CambiarPagina(paginaRegistroUsuario);
            }
            else
            {
                PaginaActualizacionInformacion paginaActualizacionInformacion =
                        new PaginaActualizacionInformacion(nombreJugador, numeroAvatar);
                VentanaPrincipal.CambiarPagina(paginaActualizacionInformacion);
            }
        }
    }
}
