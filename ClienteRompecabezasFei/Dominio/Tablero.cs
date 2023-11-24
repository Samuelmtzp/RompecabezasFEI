using System.Collections.Generic;
using System.Linq;

namespace Dominio
{
    public class Tablero
    {
        public double AnchoDeCelda { get; set; }

        public double AlturaDeCelda { get; set; }

        public int TotalFilas { get; set; }

        public int TotalColumnas { get; set; }

        public int NumeroImagenRompecabezas { get; set; }

        public List<Pieza> Piezas { get; set; }

        public List<Celda> Celdas { get; set; }

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