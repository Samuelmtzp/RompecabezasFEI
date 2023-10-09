using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Registro
    {
        public Registro()
        {
        }

        public bool Registrar(Datos.Usuario usuarioRegistro, Datos.Jugador jugadorRegistro)
        {
            bool estadoRegistro = false;
            using (var contexto = new EntidadesRompecabezasFei())
            {
                Usuario nuevoUsuario = new Usuario()
                {
                    Correo = usuarioRegistro.Correo,
                    Contrasena = usuarioRegistro.Contrasena,
                };
                Jugador nuevoJugador = new Jugador()
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
