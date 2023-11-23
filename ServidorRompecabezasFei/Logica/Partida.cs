using Datos;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Logica
{
    public class Partida
    {
        public Tablero Tablero { get; set; }

        public DificultadPartida DificultadPartida { get; set; }

        public Dictionary<string, int> PuntajesDeJugador { get; set; }
    }
}
