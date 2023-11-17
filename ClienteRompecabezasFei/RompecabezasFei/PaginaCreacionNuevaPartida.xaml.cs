using Dominio;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace RompecabezasFei
{
    public partial class PaginaCreacionNuevaPartida : Page
    {
        private ObservableCollection<ImagenRompecabezas> imagenesRompecabezas;
        private Border bordeImagenSeleccionada;
        private Dificultad dificultad;
        private int numeroImagen;
        private string codigoSala;

        public ObservableCollection<ImagenRompecabezas> ImagenesRompecabezas
        {
            get { return imagenesRompecabezas; }
            set { imagenesRompecabezas = value; }
        }

        public string CodigoSala
        {
            get { return codigoSala; }
            set { codigoSala = value; }
        }

        public PaginaCreacionNuevaPartida()
        {
            InitializeComponent();
            MostrarImagenesDeRompecabezas();
            dificultad = Dificultad.Facil;
            cuadroSeleccionDificultad.SelectedIndex = (int)dificultad;
            numeroImagen = 1;
            galeriaImagenesRompecabezas.DataContext = this;
        }

        private void MostrarImagenesDeRompecabezas()
        {
            imagenesRompecabezas = new ObservableCollection<ImagenRompecabezas>();

            for (int indiceImagen = 1; indiceImagen <= 16;  indiceImagen++)
            {
                imagenesRompecabezas.Add(new ImagenRompecabezas
                {
                    Ruta = $"Imagenes\\Rompecabezas\\{indiceImagen}.png",
                    NumeroImagen = indiceImagen
                });
            }
        }

        private void MostrarPreseleccionDeImagen(object objetoOrigen, MouseEventArgs evento)
        {
            Border borde = objetoOrigen as Border;

            if (borde != bordeImagenSeleccionada)
            {
                borde.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }

        private void OcultarPreseleccionDeImagen(object objetoOrigen, MouseEventArgs evento)
        {
            Border borde = objetoOrigen as Border;

            if (borde != bordeImagenSeleccionada)
            {
                ImagenRompecabezas imagen = borde.DataContext as ImagenRompecabezas;
                borde.BorderBrush = new SolidColorBrush(imagen.ColorDeBorde);
            }
        }

        private void SeleccionarImagen(object objetoOrigen, MouseButtonEventArgs evento)
        {
            Border borde = objetoOrigen as Border;

            if (bordeImagenSeleccionada != null)
            {
                bordeImagenSeleccionada.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

            ImagenRompecabezas imagen = borde.DataContext as ImagenRompecabezas;
            numeroImagen = imagen.NumeroImagen;
            bordeImagenSeleccionada = borde;
            borde.BorderBrush = new SolidColorBrush(Colors.Green);
        }

        private void IrAPaginaSala(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaSala());
            // Cargar datos que ya estaban en sala
            // - Lista de jugadores conectados
            // - EsAnfitrion
            // - boton iniciar partida
        }

        private void SeleccionarDificultad(object controlOrigen,
            SelectionChangedEventArgs evento)
        {
            dificultad = (Dificultad)cuadroSeleccionDificultad.SelectedIndex;
        }

        private void IrAPaginaPartida(object objetoOrigen, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaPartida(dificultad, numeroImagen));
        }
    }
}
