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
    
    public partial class Partida
    {
        public int IdPartida { get; set; }
        public short Dificultad { get; set; }
        public int SalaIdSala { get; set; }
    
        public virtual Sala Sala { get; set; }
    }
}
