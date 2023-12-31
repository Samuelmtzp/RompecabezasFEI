using System.Runtime.Serialization;
using System.ServiceModel;

namespace Logica
{
    [DataContract]
    public class CuentaJugador
    {
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
        public bool EsInvitado { get; set; }

        [DataMember]
        public Enumeraciones.EstadoJugador Estado { get; set; }

        // Este OperationContext está reservado para mantener el canal de comunicación
        // necesario durante todo el tiempo de vida del jugador
        public OperationContext ContextoOperacionConexion { get; set; }

        // Este OperationContext puede utilizarse para manejo de interfaces de callbacks que
        // no requieran mantener la conexión del jugador durante todo su tiempo de vida
        public OperationContext ContextoOperacion { get; set; }
        
        public override string ToString()
        {
            return $"NombreJugador = {NombreJugador}\n" +
                $"NumeroAvatar = {NumeroAvatar}\n" +
                $"Correo = {Correo}\n" +
                $"Contrasena = {Contrasena}";
        }        
    }
}