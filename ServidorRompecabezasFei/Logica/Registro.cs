using Datos;
using System.Linq;

namespace Logica
{
    public class Registro
    {
        public Registro()
        {
        }

        public bool Registrar(Logica.CuentaJugador cuentaJugadorRegistro)
        {
            bool estadoRegistro = false;
            using (var contexto = new EntidadesRompecabezasFei())
            {
                Datos.Cuenta nuevaCuenta = new Datos.Cuenta()
                {
                    Correo = cuentaJugadorRegistro.Correo,
                    Contrasena = cuentaJugadorRegistro.Contrasena,
                };
                Datos.Jugador nuevoJugador = new Datos.Jugador()
                {
                    NombreJugador = cuentaJugadorRegistro.NombreJugador,
                    NumeroAvatar = cuentaJugadorRegistro.NumeroAvatar,
                };

                contexto.Jugador.Add(nuevoJugador);
                contexto.Cuenta.Add(nuevaCuenta);
                nuevoJugador.Cuenta = nuevaCuenta;
                nuevaCuenta.Jugador = nuevoJugador;

                estadoRegistro = contexto.SaveChanges() > 0;
            }
            return estadoRegistro;
        }

        
    }
}
