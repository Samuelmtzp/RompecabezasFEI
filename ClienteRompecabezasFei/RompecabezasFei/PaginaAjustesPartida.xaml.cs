using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace RompecabezasFei
{
    public partial class PaginaAjustesPartida : Page
    {
        public ObservableCollection<ImagenRompecabezas> imagenesRompecabezas { get; set; }
        private Border bordeSeleccionado;

        public PaginaAjustesPartida()
        {
            InitializeComponent();
            imagenesRompecabezas = new ObservableCollection<ImagenRompecabezas>();
            CargarImagenes();
            DataContext = this;
        }

        private void CargarImagenes()
        {
            for (int indiceImagen = 1; indiceImagen <= 16;  indiceImagen++)
            {
                imagenesRompecabezas.Add(new ImagenRompecabezas 
                { 
                    Ruta = $"Imagenes\\Rompecabezas\\{indiceImagen}.png" 
                });
            }            
        }

        private void EventoCursorSobreImagen(object remitente, MouseEventArgs evento)
        {
            Border borde = remitente as Border;
            if (borde != bordeSeleccionado)
            {
                borde.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }

        private void EventoCursorFueraDeImagen(object remitente, MouseEventArgs evento)
        {
            Border borde = remitente as Border;
            if (borde != bordeSeleccionado)
            {
                ImagenRompecabezas imagen = borde.DataContext as ImagenRompecabezas;
                borde.BorderBrush = new SolidColorBrush(imagen.ColorDeBorde);
            }
        }

        private void EventoClickEnImagen(object remitente, MouseButtonEventArgs evento)
        {
            Border borde = remitente as Border;
            if (bordeSeleccionado != null)
            {
                ImagenRompecabezas imagen = borde.DataContext as ImagenRompecabezas;
                bordeSeleccionado.BorderBrush = new SolidColorBrush(imagen.ColorDeBorde);
            }
            bordeSeleccionado = borde;
            borde.BorderBrush = new SolidColorBrush(Colors.Green);
        }

        private void EventoClickRegresar(object sender, MouseButtonEventArgs e)
        {

        }

        private void EventoClickGestionarJugadores(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void EventoSeleccionDificultad(object sender, SelectionChangedEventArgs e)
        {

        }
    }

    public class ImagenRompecabezas
    {
        public string Ruta { get; set; }
        public Color ColorDeBorde { get; set; }
    }
}
