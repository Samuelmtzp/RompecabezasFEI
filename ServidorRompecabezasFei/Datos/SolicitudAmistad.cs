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
    
    public partial class SolicitudAmistad
    {
        public int Estado { get; set; }
        public string FechaEnvioSolicitud { get; set; }
        public int IdJugadorOrigen { get; set; }
        public int IdJugadorDestino { get; set; }
    
        public virtual Jugador JugadorOrigen { get; set; }
        public virtual Jugador JugadorDestino { get; set; }
    }
}
