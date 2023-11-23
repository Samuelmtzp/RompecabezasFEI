using Datos;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Logica
{
    [DataContract]
    public class Sala
    {
        public const int MaximoJugadores = 4;

        public const int MinimoJugadores = 2;

        [DataMember]
        public EstadoSala Estado { get; set; }

        [DataMember]
        public string CodigoSala { get; set; }

        [DataMember]
        public string NombreAnfitrion { get; set; }
        
        [DataMember]
        public int ContadorJugadoresActuales { get; set; }
        
        [DataMember]
        public List<CuentaJugador> Jugadores { get; set; }

        public bool EstaVacia()
        {
            return ContadorJugadoresActuales == 0;
        }
    }
}