using Dominio;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace RompecabezasFei
{
    public partial class PaginaNuevaPartida : Page
    {
        public ObservableCollection<ImagenRompecabezas> imagenesRompecabezas { get; set; }
        private Border bordeImagenSeleccionada;
        private Dificultad dificultad;
        private int numeroImagen;
        private string codigoSala;

        public PaginaNuevaPartida(string codigoSala)
        {
            InitializeComponent();
            CargarImagenes();
            this.codigoSala = codigoSala;
            dificultad = Dificultad.Facil;
            cuadroSeleccionDificultad.SelectedIndex = (int)dificultad;
            numeroImagen = 1;
            galeriaImagenesRompecabezas.DataContext = this;
        }
        #region Métodos privados
        private void CargarImagenes()
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
        #endregion

        #region Eventos 
        private void CursorSobreImagen(object objetoOrigen, MouseEventArgs evento)
        {
            Border borde = objetoOrigen as Border;

            if (borde != bordeImagenSeleccionada)
            {
                borde.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }

        private void CursorFueraDeImagen(object objetoOrigen, MouseEventArgs evento)
        {
            Border borde = objetoOrigen as Border;
            
            if (borde != bordeImagenSeleccionada)
            {
                ImagenRompecabezas imagen = borde.DataContext as ImagenRompecabezas;
                borde.BorderBrush = new SolidColorBrush(imagen.ColorDeBorde);
            }
        }

        private void ClickEnImagen(object objetoOrigen, MouseButtonEventArgs evento)
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

        private void RegresarPaginaSala(object objetoOrigen, MouseButtonEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaSala());
        }

        private void SeleccionDificultad(object controlOrigen, 
            SelectionChangedEventArgs evento)
        {
            dificultad = (Dificultad) cuadroSeleccionDificultad.SelectedIndex;
        }
        #endregion Eventos

        private void CrearPartida(object objetoOrigen, RoutedEventArgs evento)
        {
            VentanaPrincipal.CambiarPagina(new PaginaPartida(dificultad, numeroImagen));
        }
    }

    public class ImagenRompecabezas
    {
        private string ruta;
        private Color colorDeBorde;
        private int numeroImagen;

        public string Ruta 
        { 
            get { return ruta; } 
            set { ruta = value; }
        }

        public Color ColorDeBorde 
        { 
            get { return colorDeBorde; } 
            set { colorDeBorde = value; }
        }

        public int NumeroImagen 
        { 
            get { return numeroImagen; }
            set { numeroImagen = value; }
        }
    }
}
