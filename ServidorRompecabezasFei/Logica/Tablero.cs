using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Logica
{
    [DataContract]
    public class Tablero
    {
        private DificultadPartida dificultad;

        public const int NumeroFilasDificultadFacil = 6;

        public const int NumeroFilasDificultadMedia = 8;

        public const int NumeroFilasDificultadDificil = 10;

        public const int NumeroColumnasDificultadFacil = 10;

        public const int NumeroColumnasDificultadMedia = 13;

        public const int NumeroColumnasDificultadDificil = 16;

        [DataMember]
        public int TotalFilas { get; private set; }

        [DataMember]
        public int TotalColumnas { get; private set; }

        [DataMember]
        public int NumeroImagenRompecabezas { get; set; }

        [DataMember]
        public List<Pieza> Piezas { get; set; }

        [DataMember]
        public DificultadPartida Dificultad
        {
            get { return dificultad; }
            set
            {
                dificultad = value;

                switch (dificultad)
                {
                    case DificultadPartida.Facil:
                        TotalFilas = NumeroFilasDificultadFacil;
                        TotalColumnas = NumeroColumnasDificultadFacil;
                        break;
                    case DificultadPartida.Medio:
                        TotalFilas = NumeroFilasDificultadMedia;
                        TotalColumnas = NumeroColumnasDificultadMedia;
                        break;
                    case DificultadPartida.Dificil:
                        TotalFilas = NumeroFilasDificultadDificil;
                        TotalColumnas = NumeroColumnasDificultadDificil;
                        break;
                }
            }
        }

        public bool EsRompecabezasCompletado()
        {
            bool resultado = false;
            var piezasSinAcomodar = from pieza in Piezas
                                    where !pieza.EstaDentroDeCelda
                                    select pieza;

            if (piezasSinAcomodar.Any())
            {
                resultado = true;
            }

            return resultado;
        }
    }
}