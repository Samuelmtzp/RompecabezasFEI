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
                                });
                if (cuentasJugador.Any())
                {
                    jugador.IdJugador = cuentasJugador.First().IdJugador; 
                    jugador.NumeroAvatar = cuentasJugador.First().NumeroAvatar;
                    jugador.NombreJugador = cuentasJugador.First().NombreJugador;
                    jugador.Correo = cuentasJugador.First().Correo;
                    jugador.Contrasena = cuentasJugador.First().Contrasena;
                    jugador.IdUsuario = cuentasJugador.First().IdUsuario;
                }
            }
            return jugador;
        }
    }
}
