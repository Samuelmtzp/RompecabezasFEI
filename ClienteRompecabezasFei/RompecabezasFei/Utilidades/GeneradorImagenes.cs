using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RompecabezasFei.Utilidades
{
    public class GeneradorImagenes
    {
        public static BitmapImage GenerarFuenteImagenAvatar(int numeroAvatar)
        {
            string rutaImagen = "/Imagenes/Avatares/";
            BitmapImage fuenteImagenAvatar = new BitmapImage();
            fuenteImagenAvatar.BeginInit();
            rutaImagen += numeroAvatar + ".png";
            fuenteImagenAvatar.UriSource = new Uri(rutaImagen, UriKind.RelativeOrAbsolute);
            fuenteImagenAvatar.EndInit();

            return fuenteImagenAvatar;
        }
    }
}
