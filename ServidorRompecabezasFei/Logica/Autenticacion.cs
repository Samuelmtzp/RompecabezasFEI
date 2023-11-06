using Datos;
using System.Linq;

namespace Logica
{
    public class Autenticacion
    {
        public CuentaJugador IniciarSesion(string nombreJugador, string contrasena)
        {
            CuentaJugador cuentaJugador = new CuentaJugador();
            
            using (var contexto = new EntidadesRompecabezasFei())
            {
                var cuentasObtenidas = from jugador in contexto.Jugador 
                                       join cuenta in contexto.Cuenta 
                                       on jugador.Cuenta.IdCuenta 
                                       equals cuenta.IdCuenta
                                       where jugador.NombreJugador == nombreJugador && 
                                       cuenta.Contrasena == contrasena 
                                       select new Logica.CuentaJugador
                                       {
                                           IdJugador = jugador.IdJugador,
                                           NumeroAvatar = jugador.NumeroAvatar,
                                           NombreJugador = jugador.NombreJugador, 
                                           IdCuenta = cuenta.IdCuenta,
                                           Correo = cuenta.Correo,
                                           Contrasena = cuenta.Contrasena
                                       };

                if (cuentasObtenidas.Any())
                {
                    cuentaJugador.IdJugador = cuentasObtenidas.First().IdJugador; 
                    cuentaJugador.NumeroAvatar = cuentasObtenidas.First().NumeroAvatar;
                    cuentaJugador.NombreJugador = cuentasObtenidas.First().NombreJugador;
                    cuentaJugador.Correo = cuentasObtenidas.First().Correo;
                    cuentaJugador.Contrasena = cuentasObtenidas.First().Contrasena;
                    cuentaJugador.IdCuenta = cuentasObtenidas.First().IdCuenta;
                }
            }

            return cuentaJugador;
        }
    }
}
