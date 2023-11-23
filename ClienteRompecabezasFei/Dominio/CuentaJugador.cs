using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Dominio
{
    public class CuentaJugador
    {
        public string NombreJugador { get; set; }

        public int NumeroAvatar { get; set; }
        
        public string Correo { get; set; }
        
        public string Contrasena { get; set; }
        
        public bool EsInvitado { get; set; }
        
        public int Puntaje { get; set; }
        
        public SolidColorBrush ColorEstadoConectividad { get; set; }
        
        public BitmapImage FuenteImagenAvatar { get; set; }
        
        public static CuentaJugador Actual { get; set; }
    }
}