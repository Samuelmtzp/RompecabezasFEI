//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class ResultadoPartida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ResultadoPartida()
        {
            this.Puntaje = 0;
        }
    
        public string NombreJugador { get; set; }
        public int Puntaje { get; set; }
        public bool EsGanador { get; set; }
        public int NumeroPartida { get; set; }
        public string CodigoSala { get; set; }
    
        public virtual Jugador Jugador { get; set; }
        public virtual Partida Partida { get; set; }
    }
}
