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
    
    public partial class Cuenta
    {
        public int IdCuenta { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
    
        public virtual Jugador Jugador { get; set; }
    }
}
