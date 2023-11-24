using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Logica
{
    [DataContract]
    public class Pieza
    {
        [DataMember]
        public int NumeroPieza { get; set; }

        [DataMember]
        public bool EstaDentroDeCelda { get; set; }        
    }
}