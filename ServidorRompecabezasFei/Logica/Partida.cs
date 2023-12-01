using Datos;
using System.Collections.Concurrent;

namespace Logica
{
    public class Partida
    {
        private DificultadPartida dificultad;

        public Tablero Tablero { get; set; }

        public ConcurrentDictionary<string, int> Puntajes { get; set; }

        public DificultadPartida Dificultad
        {
            get { return dificultad; }
            set
            {
                dificultad = value;

                if (Tablero != null)
                {
                    switch (dificultad)
                    {
                        case DificultadPartida.Facil:
                            Tablero.TotalFilas = Tablero.CantidadFilasDificultadFacil;
                            Tablero.TotalColumnas = Tablero.CantidadColumnasDificultadFacil;
                            break;
                        case DificultadPartida.Medio:
                            Tablero.TotalFilas = Tablero.CantidadFilasDificultadMedia;
                            Tablero.TotalColumnas = Tablero.CantidadColumnasDificultadMedia;
                            break;
                        case DificultadPartida.Dificil:
                            Tablero.TotalFilas = Tablero.CantidadFilasDificultadDificil;
                            Tablero.TotalColumnas = Tablero.CantidadColumnasDificultadDificil;
                            break;
                    }
                }
            }
        }
    }
}