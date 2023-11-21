using System.Collections.Generic;
using System.Linq;

namespace Dominio
{
    public class Tablero
    {
        private Dificultad dificultad;

        public double AnchoDeCelda { get; set; }

        public double AlturaDeCelda { get; set; }

        public int TotalFilas { get; set; }

        public int TotalColumnas { get; set; }

        public int NumeroImagenRompecabezas { get; set; }

        public List<Pieza> Piezas { get; set; }

        public List<Celda> Celdas { get; set; }

        public Dificultad Dificultad
        {
            get { return dificultad; }
            set 
            { 
                dificultad = value;

                switch (dificultad)
                {
                    case Dificultad.Facil:
                        TotalFilas = 6;
                        TotalColumnas = 10;
                        break;
                    case Dificultad.Medio:
                        TotalFilas = 8;
                        TotalColumnas = 13;
                        break;
                    case Dificultad.Dificil:
                        TotalFilas = 10;
                        TotalColumnas = 16;
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