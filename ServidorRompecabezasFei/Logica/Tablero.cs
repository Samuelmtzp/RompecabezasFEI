using Datos;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.Serialization;

namespace Logica
{
    [DataContract]
    public class Tablero
    {
        public const int CantidadFilasDificultadFacil = 6;

        public const int CantidadFilasDificultadMedia = 8;

        public const int CantidadFilasDificultadDificil = 10;

        public const int CantidadColumnasDificultadFacil = 10;

        public const int CantidadColumnasDificultadMedia = 13;

        public const int CantidadColumnasDificultadDificil = 16;

        [DataMember]
        public int TotalFilas { get; private set; }

        [DataMember]
        public int TotalColumnas { get; private set; }

        [DataMember]
        public int NumeroImagenRompecabezas { get; set; }

        public ConcurrentDictionary<int, Pieza> Piezas { get; set; }

        public Tablero(DificultadPartida dificultad)
        {
            switch (dificultad)
            {
                case DificultadPartida.Facil:
                    TotalFilas = CantidadFilasDificultadFacil;
                    TotalColumnas = CantidadColumnasDificultadFacil;
                    break;

                case DificultadPartida.Medio:
                    TotalFilas = CantidadFilasDificultadMedia;
                    TotalColumnas = CantidadColumnasDificultadMedia;
                    break;

                case DificultadPartida.Dificil:
                    TotalFilas = CantidadFilasDificultadDificil;
                    TotalColumnas = CantidadColumnasDificultadDificil;
                    break;
            }

            Piezas = GenerarPiezasParaTablero(TotalFilas, TotalColumnas);
        }

        public bool EsRompecabezasCompletado()
        {
            bool resultado = false;
            var piezasSinAcomodar = from pieza in Piezas
                                    where !pieza.Value.EstaDentroDeCelda
                                    select pieza;

            if (!piezasSinAcomodar.Any())
            {
                resultado = true;
            }

            return resultado;
        }

        private ConcurrentDictionary<int, Pieza> GenerarPiezasParaTablero(
            int numeroFilas, int numeroColumnas)
        {
            ConcurrentDictionary<int, Pieza> piezas =
                new ConcurrentDictionary<int, Pieza>();
            int totalPiezas = numeroFilas * numeroColumnas;

            for (int numeroPieza = 1; numeroPieza <= totalPiezas; numeroPieza++)
            {
                Pieza pieza = new Pieza()
                {
                    NumeroPieza = numeroPieza,
                    EstaDentroDeCelda = false,
                    EstaBloqueada = false,
                    Puntaje = Pieza.PuntajeNormal,
                };
                piezas.TryAdd(numeroPieza, pieza);
            }

            return piezas;
        }
    }
}