namespace Logica
{
    public class Pieza
    {
        public const int PuntajeNormal = 100;

        public const int PuntajeVacio = 0;

        public int NumeroPieza { get; set; }

        public bool EstaBloqueada { get; set; }

        public bool EstaDentroDeCelda { get; set; }

        public int Puntaje { get; set; }
    }
}