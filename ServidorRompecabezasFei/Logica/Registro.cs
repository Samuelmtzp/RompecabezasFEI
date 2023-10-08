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
    }
}
