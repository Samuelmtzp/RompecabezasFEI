using System.Runtime.Serialization;

namespace Logica
{
    [DataContract]
    public class CuentaJugador
    {
        #region Atributos
        private int idJugador;
        private string nombreJugador;
        private int numeroAvatar;
        private string correo;
        private string contrasena;
        private int puntaje;
        private EstadoConectividadJugador estadoConectividad;
        private GestionContexto operacionesContexto;
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
        public int NumeroAvatar
        {
            get { return numeroAvatar; }
            set { numeroAvatar = value; }
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

        [DataMember]
        public int Puntaje
        {
            get { return puntaje; }
            set { puntaje = value; }
        }

        [DataMember]
        public EstadoConectividadJugador EstadoConectividad
        {
            get { return estadoConectividad; }
            set { estadoConectividad = value; }
        }

        // Operaciones de contexto para interfaces de callbacks
        public GestionContexto OperacionesContexto
        {
            get { return operacionesContexto; }
            set { operacionesContexto = value; }
        }
        #endregion

        #region Métodos
        public override string ToString()
        {
            return $"NombreJugador = {nombreJugador}\n" +
                $"NumeroAvatar = {numeroAvatar}\n" +
                $"Correo = {correo}\n" +
                $"Contrasena = {contrasena}";
        }
        #endregion
    }
}
