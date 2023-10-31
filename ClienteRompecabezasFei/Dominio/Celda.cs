using System.Windows.Shapes;

namespace Dominio
{
    public class Celda
    {
        private Rectangle area;
        private int fila;
        private int columna;

        public Rectangle Area
        {
            get { return area; }
            set { area = value; }
        }

        public int Fila
        {
            get { return fila; }
            set { fila = value; }
        }

        public int Columna
        {
            get { return columna; }
            set { columna = value; }
        }
    }
}