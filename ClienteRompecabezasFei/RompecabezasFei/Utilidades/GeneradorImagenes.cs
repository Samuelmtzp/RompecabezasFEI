using Dominio;
using System;
using System.IO;
using System.Windows.Media.Imaging;

namespace RompecabezasFei.Utilidades
{
    public static class GeneradorImagenes
    {
        public static BitmapImage GenerarFuenteImagenAvatar(int numeroAvatar)
        {
            string rutaImagen = $"/Imagenes/Avatares/{numeroAvatar}.png";
            BitmapImage fuenteImagenAvatar = new BitmapImage();
            fuenteImagenAvatar.BeginInit();
            fuenteImagenAvatar.UriSource = new Uri(rutaImagen, UriKind.RelativeOrAbsolute);
            fuenteImagenAvatar.EndInit();

            return fuenteImagenAvatar;
        }

        public static BitmapImage GenerarFuenteImagenRompecabezas(int numeroImagenRompecabezas)
        {
            string rutaDirectorioBase = AppDomain.CurrentDomain.BaseDirectory;
            Directory.SetCurrentDirectory(Path.Combine(rutaDirectorioBase, "..\\..\\"));
            string directorioActual = Directory.GetCurrentDirectory();
            string rutaRelativaImagen = $"Imagenes\\Rompecabezas\\{numeroImagenRompecabezas}.png";
            string rutaAbsoluta = Path.Combine(directorioActual, rutaRelativaImagen);
            
            return new BitmapImage(new Uri(rutaAbsoluta, UriKind.Relative));
        }
    }
}