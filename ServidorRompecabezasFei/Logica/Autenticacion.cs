using Datos;
using System.Linq;

namespace Logica
{
    public class Autenticacion
    {
        public Logica.Jugador IniciarSesion(string nombreJugador, string contrasena)
        {
            Logica.Jugador jugador = new Logica.Jugador();
            using (var contexto = new EntidadesRompecabezasFei())
            {
                var cuentasJugador = (from jugadores in contexto.Jugador
                                from usuarios in contexto.Usuario
                                where jugadores.NombreJugador == nombreJugador &&
                                usuarios.Jugador == jugadores &&
                                usuarios.Contrasena == contrasena
                                select jugadores);
                if (cuentasJugador.Any())
                {
                    jugador.IdJugador = cuentasJugador.First().IdJugador; 
                    jugador.NumeroAvatar = cuentasJugador.First().NumeroAvatar;
                    jugador.NombreJugador = cuentasJugador.First().NombreJugador;
                }
                var cuentasUsuario = (from jugadores in contexto.Jugador
                                      from usuarios in contexto.Usuario
                                      where jugadores.NombreJugador == nombreJugador &&
                                      usuarios.Jugador == jugadores &&
                                      usuarios.Contrasena == contrasena
                                      select usuarios);
                if (cuentasUsuario.Any())
                {
                    jugador.Correo = cuentasUsuario.First().Correo;
                    jugador.Contrasena = cuentasUsuario.First().Contrasena;
                    jugador.IdUsuario = cuentasUsuario.First().IdUsuario;
                }
            }
            return jugador;
        }
    }
}
