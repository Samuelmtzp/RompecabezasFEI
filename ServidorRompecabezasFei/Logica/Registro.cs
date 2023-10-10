using Datos;
using System.Linq;

namespace Logica
{
    public class Registro
    {
        public Registro()
        {
        }

        public bool Registrar(Logica.Jugador jugadorRegistro )
        {
            bool estadoRegistro = false;
            using (var contexto = new EntidadesRompecabezasFei())
            {
                Datos.Usuario nuevoUsuario = new Datos.Usuario()
                {
                    Correo = jugadorRegistro.Correo,
                    Contrasena = jugadorRegistro.Contrasena,
                };
                Datos.Jugador nuevoJugador = new Datos.Jugador()
                {
                    NombreJugador = jugadorRegistro.NombreJugador,
                    NumeroAvatar = jugadorRegistro.NumeroAvatar,
                };

                contexto.Jugador.Add(nuevoJugador);
                contexto.Usuario.Add(nuevoUsuario);
                nuevoJugador.Usuario = nuevoUsuario;
                nuevoUsuario.Jugador = nuevoJugador;

                estadoRegistro = contexto.SaveChanges() > 0;
            }
            return estadoRegistro;
        }

        public bool ExisteNombreJugador(string nombreJugador)
        {
            bool resultado = false;
            using (var contexto = new EntidadesRompecabezasFei())
            {
                var cuentasJugador = (from jugadores in contexto.Jugador
                               where jugadores.NombreJugador == nombreJugador
                                select jugadores).Count();
                if (cuentasJugador > 0)
                {
                    resultado = true;
                }
            }
            return resultado;
        }

        public bool ExisteNombreUsuario(string nombreJugador)
        {
            bool resultado = false;
            using (var contexto = new EntidadesRompecabezasFei())
            {
                var cuentasJugador = (from jugadores in contexto.Jugador
                                      where jugadores.NombreJugador == nombreJugador
                                      select jugadores).Count();
                if (cuentasJugador > 0)
                {
                    resultado = true;
                }
            }
            return resultado;
        }

        public bool ExisteCorreoElectronico(string correoElectronico)
        {
            bool resultado = false;
            using (var contexto = new EntidadesRompecabezasFei())
            {
                var cuentasUsuario = (from usuarios in contexto.Usuario
                                      where usuarios.Correo == correoElectronico
                                      select usuarios).Count();
                if (cuentasUsuario > 0)
                {
                    resultado = true;
                }
            }
            return resultado;
        }
    }
}
