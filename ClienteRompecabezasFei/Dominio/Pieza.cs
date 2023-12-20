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

        private bool esPiezaBloqueada;

        public int NumeroPieza { get; set; }
        
        public double Ancho { get; set; }

        public double Alto { get; set; }

        public double PosicionX { get; set; }

        public double PosicionY { get; set; }
        
        public Image Imagen { get; set; }
        
        public CroppedBitmap FuenteImagenRecortada { get; set; }

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

                if (estaDentroDeCelda && borde != null)
                {
                    EstablecerEstiloDePiezaColocada();
                }
            }
        }

        public bool EsPiezaBloqueada
        {
            get { return esPiezaBloqueada; }
            set
            {
                esPiezaBloqueada = value;

                if (borde != null)
                {
                    if (!esPiezaBloqueada)
                    {
                        EstablecerEstiloDePiezaSinBloquear();
                    }
                }
            }
        }

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

        public void EstablecerEstiloDePiezaBloqueadaPorJugadorActual()
        {
            borde.BorderBrush = Brushes.Red;
            borde.BorderThickness = new Thickness(4);
        }

        public void EstablecerEstiloDePiezaBloqueadaPorAdversario()
        {
            borde.BorderBrush = Brushes.Yellow;
            borde.BorderThickness = new Thickness(4);
        }

        public void EstablecerEstiloDePiezaSinBloquear()
        {
            borde.BorderBrush = Brushes.Black;
            borde.BorderThickness = new Thickness(2);
        }

        private void EstablecerEstiloDePiezaColocada()
        {
            borde.BorderBrush = Brushes.Transparent;
            borde.BorderThickness = new Thickness(0);
        }
    }
}