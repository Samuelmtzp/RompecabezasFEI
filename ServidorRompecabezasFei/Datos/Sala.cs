//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sala
    {
        public int IdSala { get; set; }
        public int Codigo { get; set; }
        public int MaximoJugadores { get; set; }
        public int MinimoJugadores { get; set; }
        public int IdAnfitrion { get; set; }
    
        public virtual Jugador Anfitrion { get; set; }
    }
}
