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
                                join usuarios in contexto.Usuario 
                                on jugadores.Usuario.IdUsuario equals usuarios.IdUsuario
                                where jugadores.NombreJugador == nombreJugador &&
                                usuarios.Contrasena == contrasena
                                select new Logica.Jugador
                                {
                                    IdJugador = jugadores.IdJugador,
                                    NumeroAvatar = jugadores.NumeroAvatar,
                                    NombreJugador = jugadores.NombreJugador, 
                                    IdUsuario = usuarios.IdUsuario,
                                    Correo = usuarios.Correo,
                                    Contrasena = ""
                                }).FirstOrDefault();
                if (cuentasJugador != null)
                {
                    jugador.IdJugador = cuentasJugador.IdJugador; 
                    jugador.NumeroAvatar = cuentasJugador.NumeroAvatar;
                    jugador.NombreJugador = cuentasJugador.NombreJugador;
                    jugador.Correo = cuentasJugador.Correo;
                    jugador.Contrasena = cuentasJugador.Contrasena;
                    jugador.IdUsuario = cuentasJugador.IdUsuario;
                }
            }
            return jugador;
        }
    }
}
