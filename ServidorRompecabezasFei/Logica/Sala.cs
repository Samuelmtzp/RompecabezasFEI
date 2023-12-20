using Datos;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Logica
{
    [DataContract]
    public class Sala
    {
        public const int MaximoJugadoresPorSala = 4;

        public const int MinimoJugadoresParaIniciarPartida = 2;

        [DataMember]
        public EstadoSala Estado { get; set; }

        [DataMember]
        public string CodigoSala { get; set; }

        [DataMember]
        public string NombreAnfitrion { get; set; }
        
        [DataMember]
        public int ContadorJugadores { get; set; }
        
        [DataMember]
        public ConcurrentDictionary<string, CuentaJugador> Jugadores { get; set; }

        public bool EstaVacia()
        {
            return ContadorJugadores == 0;
        }
    }
}