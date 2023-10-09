using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Autenticacion
    {
        public Datos.Jugador iniciarSesion(string nombreJugador, string contrasena)
        {
            Datos.Jugador jugador = new Datos.Jugador();
            using (var contexto = new EntidadesRompecabezasFei())
            {
                var cuentas = (from jugadores in contexto.Jugador
                               from usuarios in contexto.Usuario
                                where jugadores.NombreJugador == nombreJugador && 
                                jugadores.Usuario == usuarios &&
                                usuarios.Contrasena == contrasena
                                select jugadores);
                if (cuentas.Any())
                {
                    jugador.NumeroAvatar = cuentas.First().NumeroAvatar;
                    jugador.Usuario = cuentas.First().Usuario;
                    jugador.NombreJugador = cuentas.First().NombreJugador;
                    jugador.IdJugador = cuentas.First().IdJugador;
                }
            }
            return jugador;
        }
    }
}
