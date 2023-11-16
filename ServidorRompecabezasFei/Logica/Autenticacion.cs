using Datos;
using System.Linq;

namespace Logica
{
    public class Autenticacion
    {
        public CuentaJugador IniciarSesion(string nombreJugador, string contrasena)
        {
            CuentaJugador cuentaJugador = null;
            
            using (var contexto = new EntidadesRompecabezasFei())
            {
                var cuentasObtenidas = from jugador in contexto.Jugador 
                                       join cuenta in contexto.Cuenta 
                                       on jugador.Cuenta.Correo 
                                       equals cuenta.Correo
                                       where jugador.NombreJugador == nombreJugador && 
                                       cuenta.Contrasena == contrasena 
                                       select new CuentaJugador
                                       {
                                           IdJugador = jugador.IdJugador,
                                           NumeroAvatar = jugador.NumeroAvatar,
                                           NombreJugador = jugador.NombreJugador, 
                                           Correo = cuenta.Correo,
                                           Contrasena = cuenta.Contrasena
                                       };

                if (cuentasObtenidas.Any())
                {
                    cuentaJugador = new CuentaJugador
                    {
                        NumeroAvatar = cuentasObtenidas.First().NumeroAvatar,
                        NombreJugador = cuentasObtenidas.First().NombreJugador,
                        Correo = cuentasObtenidas.First().Correo,
                        Contrasena = cuentasObtenidas.First().Contrasena,
                    };
                }
            }

            return cuentaJugador;
        }
    }
}