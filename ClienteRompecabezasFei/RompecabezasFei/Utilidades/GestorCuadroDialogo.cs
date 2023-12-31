using System.Windows;

namespace RompecabezasFei.Utilidades
{
    public static class GestorCuadroDialogo
    {
        public static MessageBoxResult MostrarPreguntaNormal(string mensaje, string titulo)
        {
            return MessageBox.Show(mensaje, titulo, MessageBoxButton.YesNo, 
                MessageBoxImage.Question);
        }

        public static MessageBoxResult MostrarPreguntaConAdvertencia(string mensaje, 
            string titulo)
        {
            return MessageBox.Show(mensaje, titulo, MessageBoxButton.YesNo,
                MessageBoxImage.Warning);
        }

        public static void MostrarAdvertencia(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButton.OK,
                MessageBoxImage.Warning);
        }

        public static void MostrarError(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButton.OK,
                MessageBoxImage.Error);
        }

        public static void MostrarInformacion(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButton.OK,
                MessageBoxImage.Information);
        }        
    }
}