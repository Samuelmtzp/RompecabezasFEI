using System.Runtime.Serialization;

namespace Logica
{
    [DataContract]
    public class CuentaJugador
    {
        #region Propiedades
        [DataMember]
        public int IdJugador { get; set; }

        [DataMember]
        public string NombreJugador { get; set; }

        [DataMember]
        public int NumeroAvatar { get; set; }
        
        [DataMember]
        public string Correo { get; set; }
        
        [DataMember]
        public string Contrasena { get; set; }

        [DataMember]
        public int Puntaje { get; set; }

        [DataMember]
        public EstadoConectividadJugador EstadoConectividad { get; set; }

        // Operaciones de contexto para interfaces de callbacks
        public GestionContexto OperacionesContexto { get; set; }
        #endregion

        #region Métodos
        public override string ToString()
        {
            return $"NombreJugador = {NombreJugador}\n" +
                $"NumeroAvatar = {NumeroAvatar}\n" +
                $"Correo = {Correo}\n" +
                $"Contrasena = {Contrasena}";
        }
        #endregion
    }
}