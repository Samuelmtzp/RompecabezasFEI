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
using Registros;
using log4net;
using log4net.Repository.Hierarchy;

namespace Servicios
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
    public partial class ServicioRompecabezasFei : IServicioGestionJugador
    {
        public bool Registrar(Logica.CuentaJugador cuentaJugador)
        {
            bool estadoRegistro = false;
            try
            {
                Registro registro = new Registro();
                Logica.CuentaJugador cuentaJugadorRegistro = new Logica.CuentaJugador()
                {
                    NombreJugador = cuentaJugador.NombreJugador,
                    NumeroAvatar = cuentaJugador.NumeroAvatar,
                    Contrasena = cuentaJugador.Contrasena,
                    Correo = cuentaJugador.Correo,
                };

                estadoRegistro = registro.Registrar(cuentaJugadorRegistro);
            }
            catch (EntityException excepcionEntidad)
            {
                Console.WriteLine($"{excepcionEntidad.Message}");
            }
            return estadoRegistro;
        }

        public bool ExisteNombreJugador(string nombreJugador)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            bool existeNombreJugador = false;

            try
            {
                existeNombreJugador = consultasJugador.ExisteNombreJugador(nombreJugador);
            }
            catch (EntityException)
            {
            }
            return existeNombreJugador;
        }     
        
        public bool ExisteCorreoElectronico(string correoElectronico)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            bool existeCorreo = false;

            try
            {
                existeCorreo = consultasJugador.ExisteCorreoElectronico(correoElectronico);
            }
            catch (EntityException)
            {
            }
            return existeCorreo;
        }

        public Logica.CuentaJugador IniciarSesion(string nombreUsuario, string contrasena)
        {
            Logica.CuentaJugador jugador = new Logica.CuentaJugador();
            try
            {
                Autenticacion cliente = new Autenticacion();
                jugador = cliente.IniciarSesion(nombreUsuario, contrasena);
            }
            catch (EntityException)
            {
            }
            return jugador;
        }

        public bool EnviarValidacionCorreo(string correoDestino, string asunto, int codigoVerificacion)
        {
            VerificadorCorreo cliente = new VerificadorCorreo();
            bool estado = cliente.EnviarValidacionCorreo(correoDestino, asunto, codigoVerificacion);
            return estado;
        }

        public int ObtenerNumeroPartidasJugadas(string nombreJugador)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            int numeroPartidasJugadas = consultasJugador.
                ObtenerNumeroPartidasJugadas(nombreJugador);
            return numeroPartidasJugadas;
        }

        public int ObtenerNumeroPartidasGanadas(string nombreJugador)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            int numeroPartidasGanadas = consultasJugador.
                ObtenerNumeroPartidasGanadas(nombreJugador);
            return numeroPartidasGanadas;
        }        
    }
}
