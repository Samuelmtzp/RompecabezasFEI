using System.Runtime.Serialization;
using System.Xml.Linq;

namespace Logica
{
    [DataContract]
    public class Jugador
    {
        #region Atributos
        private int idJugador;
        private string nombreJugador;
        private short numeroAvatar;
        private int idUsuario;
        private string correo;
        private string contrasena;
        #endregion

        #region Propiedades
        [DataMember]
        public int IdJugador
        {
            get { return idJugador; }
            set { idJugador = value; }
        }
        [DataMember]
        public string NombreJugador
        {
            get { return nombreJugador; }
            set { nombreJugador = value; }
        }
        [DataMember]
        public short NumeroAvatar
        {
            get { return numeroAvatar; }
            set { numeroAvatar = value; }
        }
        [DataMember]
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        [DataMember]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        [DataMember]
        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        #endregion

        public override string ToString()
        {
            return $"NombreJugador = {nombreJugador}\n" +
                $"NumeroAvatar = {numeroAvatar}\n" +
                $"Correo = {correo}\n" +
                $"Contrasena = {contrasena}";
        }
    }
}
