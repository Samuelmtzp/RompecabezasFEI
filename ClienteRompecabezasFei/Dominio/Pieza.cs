using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Dominio
{
    public class Pieza : UIElement
    {
        private Border borde;
        private bool estaDentroDeCelda;

        public double Ancho { get; set; }

        public double Alto { get; set; }

        public Image Imagen { get; set; }

        public Border Borde
        {
            get { return borde; }
            set
            {
                borde = value;
                borde.Child = Imagen;
            }
        }

        public bool EstaDentroDeCelda
        {
            get { return estaDentroDeCelda; }
            set
            {
                estaDentroDeCelda = value;

                if (estaDentroDeCelda)
                {
                    EstablecerEstiloDePiezaDentroDeCelda();
                }
            }
        }

        public int FilaCorrecta { get; set; }

        public int ColumnaCorrecta { get; set; }

        public CroppedBitmap FuenteImagenRecortada { get; set; }

        public void EstablecerFuenteImagen(BitmapImage fuenteImagenOriginal, 
            Int32Rect areaRecorte)
        {
            FuenteImagenRecortada = new CroppedBitmap(fuenteImagenOriginal, areaRecorte);
            Imagen = new Image
            {
                Source = FuenteImagenRecortada,
                Width = Ancho,
                Height = Alto,
            };
        }

        public double ObtenerDiferenciaAnchoEntreImagenYBorde()
        {
            return borde.ActualWidth - Imagen.Width;
        }

        public double ObtenerDiferenciaAlturaEntreImagenYBorde()
        {
            return borde.ActualHeight - Imagen.Height;
        }

        public void EstablecerEstiloDePiezaSeleccionada()
        {
            borde.BorderBrush = Brushes.Red;
            borde.BorderThickness = new Thickness(4);
        }

        public void EstablecerEstiloDePiezaSinSeleccionar()
        {
            borde.BorderBrush = Brushes.White;
            borde.BorderThickness = new Thickness(2);
        }

        private void EstablecerEstiloDePiezaDentroDeCelda()
        {
            borde.BorderBrush = Brushes.Transparent;
            borde.BorderThickness = new Thickness(0);
        }
    }
}