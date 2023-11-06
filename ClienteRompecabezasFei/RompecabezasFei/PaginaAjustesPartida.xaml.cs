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
        #region Métodos privados
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
        #endregion

        #region Eventos 
        private void EventoCursorSobreImagen(object controlOrigen, MouseEventArgs evento)
        {
            Border borde = controlOrigen as Border;
            if (borde != bordeSeleccionado)
            {
                borde.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }

        private void EventoCursorFueraDeImagen(object controlOrigen, MouseEventArgs evento)
        {
            Border borde = controlOrigen as Border;
            if (borde != bordeSeleccionado)
            {
                ImagenRompecabezas imagen = borde.DataContext as ImagenRompecabezas;
                borde.BorderBrush = new SolidColorBrush(imagen.ColorDeBorde);
            }
        }

        private void EventoClickEnImagen(object controlOrigen, MouseButtonEventArgs evento)
        {
            Border borde = controlOrigen as Border;
            if (bordeSeleccionado != null)
            {
                ImagenRompecabezas imagen = borde.DataContext as ImagenRompecabezas;
                bordeSeleccionado.BorderBrush = new SolidColorBrush(imagen.ColorDeBorde);
            }
            bordeSeleccionado = borde;
            borde.BorderBrush = new SolidColorBrush(Colors.Green);
        }

        private void EventoClickRegresar(object controlOrigen, MouseButtonEventArgs e)
        {
            VentanaPrincipal.CambiarPagina(new PaginaSala());
        }

        private void EventoClickGestionarJugadores(object controlOrigen, System.Windows.RoutedEventArgs e)
        {

        }

        private void EventoSeleccionDificultad(object controlOrigen, SelectionChangedEventArgs e)
        {

        }        
        #endregion Eventos
    }

    public class ImagenRompecabezas
    {
        public string Ruta { get; set; }
        public Color ColorDeBorde { get; set; }
    }
}
