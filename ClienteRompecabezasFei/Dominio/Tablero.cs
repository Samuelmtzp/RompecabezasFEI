using System.Collections.Generic;
using System.Linq;

namespace Dominio
{
    public class Tablero
    {
        private double anchoDeCelda;
        private double alturaDeCelda;
        private int totalFilas;
        private int totalColumnas;
        private int numeroImagenRompecabezas;
        private List<Pieza> piezas;
        private List<Celda> celdas;

        public double AnchoDeCelda
        {
            get { return anchoDeCelda; }
            set { anchoDeCelda = value; }
        }

        public double AlturaDeCelda
        {
            get { return alturaDeCelda; }
            set { alturaDeCelda = value; }
        }

        public int TotalFilas
        {
            get { return totalFilas; }
            set { totalFilas = value; }
        }

        public int TotalColumnas
        {
            get { return totalColumnas; }
            set { totalColumnas = value; }
        }

        public int NumeroImagenRompecabezas
        {
            get { return numeroImagenRompecabezas; }
            set { numeroImagenRompecabezas = value; }
        }

        public List<Pieza> Piezas
        {
            get { return piezas; }
            set { piezas = value; }
        }

        public List<Celda> Celdas
        {
            get { return celdas; }
            set { celdas = value; }
        }

        public bool EsRompecabezasCompletado()
        {
            bool esJuegoCompletado = false;
            var piezasSinAcomodar = from pieza in piezas
                                    where pieza.EstaDentroDeCelda == false
                                    select pieza;

            if (piezasSinAcomodar.Count() == 0)
            {
                esJuegoCompletado = true;
            }

            return esJuegoCompletado;
        }
    }
}