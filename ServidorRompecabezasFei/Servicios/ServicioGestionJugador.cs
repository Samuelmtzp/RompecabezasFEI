using Contratos;
using Datos;
using Logica;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
    public partial class ServicioGestionJugador : IServicioGestionJugador
    {
        public bool Registrar(Logica.Jugador jugador)
        {
            var estadoRegistro = false;
            try
            {
                Registro registro = new Registro();
                Logica.Jugador jugadorRegistro = new Logica.Jugador()
                {
                    NombreJugador = jugador.NombreJugador,
                    NumeroAvatar = jugador.NumeroAvatar,
                    Contrasena = jugador.Contrasena,
                    Correo = jugador.Correo,
                };

                estadoRegistro = registro.Registrar(jugadorRegistro);
            }
            catch (EntityException excepcionEntidad)
            {
                Console.WriteLine($"{excepcionEntidad.Message}");
            }
            return estadoRegistro;
        }

        public bool ExisteCorreoElectronico(string correoElectronico)
        {
            Registro registro = new Registro();
            var estadoRegistro = false;

            try
            {
                estadoRegistro = registro.ExisteCorreoElectronico(correoElectronico);
            }
            catch (EntityException)
            {
            }
            return estadoRegistro;
        }

        public bool ExisteNombreUsuario(string nombreUsuario)
        {
            Registro registro = new Registro();
            var estadoRegistro = false;

            try
            {
                estadoRegistro = registro.ExisteNombreJugador(nombreUsuario);
            }
            catch (EntityException)
            {
            }
            return estadoRegistro;
        }

        public Logica.Jugador IniciarSesion(string nombreUsuario, string contrasena)
        {
            Logica.Jugador jugador = new Logica.Jugador();
            try
            {
                var cliente = new Autenticacion();
                jugador = cliente.IniciarSesion(nombreUsuario, contrasena);
            }
            catch (EntityException)
            {
            }
            return jugador;
        }
    }
}
