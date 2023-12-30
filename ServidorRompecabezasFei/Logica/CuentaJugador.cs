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

        // Contexto de operación para manejo de callbacks
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