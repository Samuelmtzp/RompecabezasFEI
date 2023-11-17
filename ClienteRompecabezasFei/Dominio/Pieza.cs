using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Dominio
{
    public class Pieza : UIElement
    {
        private Image imagen;
        private Border borde;
        private double ancho;
        private double alto;
        private bool estaDentroDeCelda;
        private int filaCorrecta;
        private int columnaCorrecta;
        CroppedBitmap fuenteImagenRecortada;

        public Image Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public Border Borde
        {
            get { return borde; }
            set
            {
                borde = value;
                borde.Child = imagen;
            }
        }

        public double Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }

        public double Alto
        {
            get { return alto; }
            set { alto = value; }
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

        public int FilaCorrecta
        {
            get { return filaCorrecta; }
            set { filaCorrecta = value; }
        }

        public int ColumnaCorrecta
        {
            get { return columnaCorrecta; }
            set { columnaCorrecta = value; }
        }

        public void EstablecerFuenteImagen(BitmapImage fuenteImagenOriginal, 
            Int32Rect areaRecorte)
        {
            fuenteImagenRecortada = new CroppedBitmap(fuenteImagenOriginal, areaRecorte);
            imagen = new Image
            {
                Source = fuenteImagenRecortada,
                Width = ancho,
                Height = alto,
            };
        }

        public double ObtenerDiferenciaAnchoEntreImagenYBorde()
        {
            return Borde.ActualWidth - Imagen.Width;
        }

        public double ObtenerDiferenciaAlturaEntreImagenYBorde()
        {
            return Borde.ActualHeight - Imagen.Height;
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