using System.Windows.Media;

namespace Dominio
{
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
