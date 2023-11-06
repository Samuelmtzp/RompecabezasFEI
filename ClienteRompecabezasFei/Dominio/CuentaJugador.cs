using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Dominio
{
    public class CuentaJugador
    {
        #region Atributos
        private int idJugador;
        private string nombreJugador;
        private short numeroAvatar;
        private int idCuenta;
        private string correo;
        private string contrasena;
        private string confirmacionContrasena;
        private bool esInvitado;
        private SolidColorBrush colorEstadoConectividad;
        private BitmapImage fuenteImagenAvatar;
        private static CuentaJugador cuentaJugadorActual; 
        #endregion

        #region Propiedades
        public int IdJugador 
        { 
            get { return idJugador; } 
            set { idJugador = value; } 
        }

        public string NombreJugador 
        { 
            get { return nombreJugador; } 
            set { nombreJugador = value; } 
        }
        
        public short NumeroAvatar
        {
            get { return numeroAvatar; }
            set { numeroAvatar = value; }
        }
        
        public int IdCuenta
        {
            get { return idCuenta; }
            set { idCuenta = value; }
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
        
        public string ConfirmacionContrasena
        {
            get { return confirmacionContrasena; }
            set { confirmacionContrasena = value; }
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

        public static CuentaJugador CuentaJugadorActual
        {
            get { return cuentaJugadorActual; }
            set { cuentaJugadorActual = value; }
        }
        #endregion
    }
}