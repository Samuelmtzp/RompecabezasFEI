using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Logica
{
    [DataContract]
    public class CuentaJugador
    {
        public const int NumeroAvatarInvitado = 0;

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
        public ConectividadJugador EstadoConectividad { get; set; }

        // Contexto de operación para interfaces de callbacks
        public OperationContext ContextoOperacion { get; set; }
        
        public object ObtenerCanalDeCallback()
        {
            object interfaz = null;

            if (ContextoOperacion != null)
            {
                interfaz = ContextoOperacion.GetCallbackChannel<object>();
            }

            return interfaz;
        }

        public override string ToString()
        {
            return $"NombreJugador = {NombreJugador}\n" +
                $"NumeroAvatar = {NumeroAvatar}\n" +
                $"Correo = {Correo}\n" +
                $"Contrasena = {Contrasena}";
        }        
    }
}