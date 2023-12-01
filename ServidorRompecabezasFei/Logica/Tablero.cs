using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

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
        public int TotalFilas { get; set; }

        [DataMember]
        public int TotalColumnas { get; set; }

        [DataMember]
        public int NumeroImagenRompecabezas { get; set; }

        public ConcurrentDictionary<int, Pieza> Piezas { get; set; }

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
    }
}