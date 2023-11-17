using Dominio;
using System;
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
        private int numeroAvatar;

        public PaginaSeleccionAvatar(int numeroAvatar, string nombreJugador)
        {
            InitializeComponent();
            this.nombreJugador = nombreJugador;
            this.numeroAvatar = numeroAvatar;
            MostrarImagenAvatarActual();
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
            MostrarImagenAvatarActual();
        }

        private void MostrarImagenAvatarActual()
        {
            imagenAvatarActual.Source = Utilidades.GeneradorImagenes.
                GenerarFuenteImagenAvatar(numeroAvatar);
        }

        private void SeleccionarNuevoAvatar(object objetoOrigen, MouseButtonEventArgs evento)
        {
            Image imagenSeleccionada = objetoOrigen as Image;
            imagenAvatarActual.Source = imagenSeleccionada.Source;
            imagenAvatarActual.Tag = imagenSeleccionada.Tag;
            numeroAvatar = Convert.ToInt32(imagenSeleccionada.Tag);
        }

        private void IrAPaginaAnterior(object objetoOrigen, RoutedEventArgs evento)
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