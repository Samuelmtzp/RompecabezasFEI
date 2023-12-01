using Dominio;
using RompecabezasFei.ServicioRompecabezasFei;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace RompecabezasFei
{
    public partial class PaginaCreacionNuevaPartida : Page
    {
        private Border bordeImagenSeleccionada;

        private DificultadPartida dificultadSeleccionada;
        
        private int numeroImagenSeleccionada;
        
        private const int TotalImagenes = 16;

        private const int NumeroImagenInicial = 1;

        public ObservableCollection<ImagenRompecabezas> ImagenesRompecabezas { get; set; }

        public string CodigoSala { get; set; }

        public ServicioSalaClient ClienteServicioSala { get; set; }

        public PaginaCreacionNuevaPartida()
        {
            InitializeComponent();
            MostrarImagenesDeRompecabezas();
            dificultadSeleccionada = DificultadPartida.Facil;
            cuadroSeleccionDificultad.SelectedIndex = (int)dificultadSeleccionada;
            numeroImagenSeleccionada = NumeroImagenInicial;
            galeriaImagenesRompecabezas.DataContext = this;
        }

        private void MostrarImagenesDeRompecabezas()
        {
            ImagenesRompecabezas = new ObservableCollection<ImagenRompecabezas>();

            for (int indiceImagen = NumeroImagenInicial; indiceImagen <= TotalImagenes;  
                indiceImagen++)
            {
                var nuevaImagen = new ImagenRompecabezas
                {
                    Ruta = $"Imagenes\\Rompecabezas\\{indiceImagen}.png",
                    NumeroImagen = indiceImagen
                };

                ImagenesRompecabezas.Add(nuevaImagen);
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
            numeroImagenSeleccionada = imagen.NumeroImagen;
            bordeImagenSeleccionada = borde;
            borde.BorderBrush = new SolidColorBrush(Colors.Green);
        }

        private void IrAPaginaSala(object objetoOrigen, MouseButtonEventArgs evento)
        {
            PaginaSala paginaSala = new PaginaSala(true)
            {
                CodigoSala = CodigoSala,
            };
            paginaSala.RecargarSala(true);
            VentanaPrincipal.CambiarPagina(paginaSala);
        }

        private void SeleccionarDificultad(object objetoOrigen,
            SelectionChangedEventArgs evento)
        {
            dificultadSeleccionada = (DificultadPartida)cuadroSeleccionDificultad.SelectedIndex;
        }

        private void IrAPaginaPartida(object objetoOrigen, RoutedEventArgs evento)
        {
            PaginaPartida paginaPartida = new PaginaPartida(CodigoSala, 
                dificultadSeleccionada, numeroImagenSeleccionada);
            paginaPartida.EsAnfitrion = true;
            VentanaPrincipal.CambiarPagina(paginaPartida);
        }
    }
}