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
    
    public partial class Cuenta
    {
        public int IdCuenta { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
    
        public virtual Jugador Jugador { get; set; }
    }
}
