using System.Collections.Generic;
using System.Linq;

namespace Dominio
{
    public class Tablero
    {
        public double AnchoDeCelda { get; set; }

        public double AlturaDeCelda { get; set; }

        public List<Pieza> Piezas { get; set; }

        public List<Celda> Celdas { get; set; }

        public int TotalFilas { get; set; }

        public int TotalColumnas { get; set; }
    }
}