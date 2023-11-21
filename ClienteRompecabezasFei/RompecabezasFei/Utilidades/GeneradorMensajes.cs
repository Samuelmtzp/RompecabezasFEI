using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RompecabezasFei.Utilidades
{
    public static class GeneradorMensajes
    {
        public static void MostrarMensajeErrorConexionServidor()
        {
            MessageBox.Show(Properties.Resources.
                ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE, Properties.Resources.
                ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO,
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}