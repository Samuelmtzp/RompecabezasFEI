using Datos;

namespace Logica
{
    public class Registro
    {
        public bool Registrar(CuentaJugador cuentaJugadorRegistro)
        {
            bool estadoRegistro = false;
            using (var contexto = new EntidadesRompecabezasFei())
            {
                Cuenta nuevaCuenta = new Cuenta()
                {
                    Correo = cuentaJugadorRegistro.Correo,
                    Contrasena = cuentaJugadorRegistro.Contrasena,
                };
                Jugador nuevoJugador = new Jugador()
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
