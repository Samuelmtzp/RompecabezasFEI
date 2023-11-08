using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Dominio
{
    public class CuentaJugador
    {
        #region Atributos
        private string nombreJugador;
        private int numeroAvatar;
        private string correo;
        private string contrasena;
        private bool esInvitado;
        private SolidColorBrush colorEstadoConectividad;
        private BitmapImage fuenteImagenAvatar;
        private static CuentaJugador cuentaJugadorActual; 
        #endregion

        #region Propiedades

        public string NombreJugador 
        { 
            get { return nombreJugador; } 
            set { nombreJugador = value; } 
        }
        
        public int NumeroAvatar
        {
            get { return numeroAvatar; }
            set { numeroAvatar = value; }
        }
        
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        
        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        
        public bool EsInvitado
        {
            get { return esInvitado; }
            set { esInvitado = value; }
        }

        public SolidColorBrush ColorEstadoConectividad
        {
            get { return colorEstadoConectividad; }
            set { colorEstadoConectividad = value; }
        }

        public BitmapImage FuenteImagenAvatar
        {
            get { return fuenteImagenAvatar; }
            set { fuenteImagenAvatar = value; }
        }

        public static CuentaJugador Actual
        {
            get { return cuentaJugadorActual; }
            set { cuentaJugadorActual = value; }
        }
        #endregion
    }
}