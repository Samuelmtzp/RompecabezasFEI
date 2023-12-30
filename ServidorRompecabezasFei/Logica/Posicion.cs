using System.Runtime.Serialization;

namespace Logica
{
    [DataContract]
    public class Posicion
    {
        [DataMember]
        public double X { get; set; }

        [DataMember]
        public double Y { get; set; }
    }
}