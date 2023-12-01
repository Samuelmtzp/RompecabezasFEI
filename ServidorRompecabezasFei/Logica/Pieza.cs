using System.Runtime.Serialization;

namespace Logica
{
    public class Pieza
    {
        public int NumeroPieza { get; set; }

        public bool EstaBloqueada { get; set; }

        public bool EstaDentroDeCelda { get; set; }

        public PuntajePieza ValorEnPuntaje { get; set; }
    }
}