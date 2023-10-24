using Contratos;
using Datos;
using Logica;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;

namespace Servicios
{
    #region IServicioGestionJugador
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, 
        InstanceContextMode = InstanceContextMode.Single)]
    public partial class ServicioRompecabezasFei : IServicioGestionJugador
    {
        public bool Registrar(CuentaJugador cuentaJugador)
        {
            Registro registro = new Registro();
            bool estadoRegistro;
            try
            {
                CuentaJugador cuentaJugadorRegistro = new CuentaJugador()
                {
                    NombreJugador = cuentaJugador.NombreJugador,
                    NumeroAvatar = cuentaJugador.NumeroAvatar,
                    Contrasena = cuentaJugador.Contrasena,
                    Correo = cuentaJugador.Correo,
                };
                estadoRegistro = registro.Registrar(cuentaJugadorRegistro);
            }
            catch (EntityException)
            {
                estadoRegistro = false;
            }
            return estadoRegistro;
        }

        public bool ExisteNombreJugador(string nombreJugador)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            bool existeNombreJugador;
            try
            {
                existeNombreJugador = consultasJugador.ExisteNombreJugador(nombreJugador);
            }
            catch (EntityException)
            {
                existeNombreJugador = false;
            }
            return existeNombreJugador;
        }     
        
        public bool ExisteCorreoElectronico(string correoElectronico)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            bool existeCorreo;
            try
            {
                existeCorreo = consultasJugador.ExisteCorreoElectronico(correoElectronico);
            }
            catch (EntityException)
            {
                existeCorreo = false;
            }
            return existeCorreo;
        }

        public CuentaJugador IniciarSesion(string nombreUsuario, string contrasena)
        {
            CuentaJugador cuentaJugador = new CuentaJugador();
            try
            {
                Autenticacion autenticacion = new Autenticacion();
                cuentaJugador = autenticacion.IniciarSesion(nombreUsuario, contrasena);
            }
            catch (EntityException)
            {
            }
            return cuentaJugador;
        }

        public bool EnviarMensajeCorreo(string encabezado, string correoDestino, 
            string asunto, string mensaje)
        {
            GeneradorMensajesCorreo generadorMensajesCorreo = new GeneradorMensajesCorreo();
            bool estado = generadorMensajesCorreo.EnviarMensaje(encabezado, correoDestino, asunto, mensaje);
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
    #endregion

    #region IServicioJuego
    public partial class ServicioRompecabezasFei : IServicioJuego
    {
        private List<Logica.Sala> salasActivas = new List<Logica.Sala>();        

        public bool NuevaSala(string nombreAnfitrion, string idSala)
        {
            Logica.Sala nuevaSala = new Logica.Sala()
            {
                IdSala = idSala,
                NombreAnfitrion = nombreAnfitrion,
                ContadorJugadoresActuales = 0,
                Jugadores = new List<CuentaJugador>()
            };
            salasActivas.Add(nuevaSala);
            return true;
        }

        public bool ExisteSalaDisponible(string idSala)
        {
            bool disponibilidadSala = false;
            Logica.Sala salaEncontrada = salasActivas.
                FirstOrDefault(sala => sala.IdSala.Equals(idSala));
            if (salaEncontrada != null)
            {
                if (salaEncontrada.ContadorJugadoresActuales < 4)
                {
                    disponibilidadSala = true;
                }
            }
            return disponibilidadSala;
        }

        public void ConectarCuentaJugadorASala(string nombreJugador, string idSala, 
            string mensajeBienvenida)
        {
            CuentaJugador cuentaJugador = new CuentaJugador()
            {
                NombreJugador = nombreJugador,
                ContextoOperacion = OperationContext.Current,
            };

            Logica.Sala salaEncontrada = salasActivas.FirstOrDefault(sala => 
                sala.IdSala.Equals(idSala));
            
            if (salaEncontrada.ExisteCupoJugadores())
            {
                EnviarMensajeDeSala(nombreJugador, idSala, mensajeBienvenida);
            }
            salaEncontrada.Jugadores.Add(cuentaJugador);
            salaEncontrada.ContadorJugadoresActuales++;
        }

        public void DesconectarCuentaJugadorDeSala(string nombreJugador, string idSala, 
            string mensajeDespedida)
        {
            CuentaJugador cuentaJugadorEncontrada = null;
            Logica.Sala salaEncontrada = salasActivas.FirstOrDefault(sala => 
                sala.IdSala.Equals(idSala));

            if (salaEncontrada != null)
            {
                cuentaJugadorEncontrada = salaEncontrada.Jugadores.
                    FirstOrDefault(cuentaJugador => cuentaJugador.NombreJugador.
                    Equals(nombreJugador));
            }

            if (cuentaJugadorEncontrada != null)
            {
                salaEncontrada.Jugadores.Remove(cuentaJugadorEncontrada);
                salaEncontrada.ContadorJugadoresActuales--;
                if (salaEncontrada.EstaVacia())
                {
                    salasActivas.Remove(salaEncontrada);
                }
                else
                {
                    EnviarMensajeDeSala(nombreJugador, idSala, mensajeDespedida);
                }
            }
        }

        public void EnviarMensajeDeSala(string nombreJugador, string idSala, string mensaje)
        {
            Logica.Sala salaEncontrada = salasActivas.FirstOrDefault(sala => 
                sala.IdSala.Equals(idSala));
            foreach (CuentaJugador cuentaJugador in salaEncontrada.Jugadores)
            {
                string horaActual = DateTime.Now.ToShortTimeString();
                string mensajeFinal = horaActual + $" {nombreJugador}: {mensaje}";
                cuentaJugador.ContextoOperacion.GetCallbackChannel<IServicioJuegoCallback>().
                    MensajeDeSalaCallBack(mensajeFinal);
            }
        }

        public string GenerarCodigoParaNuevaSala()
        {
            return Guid.NewGuid().ToString();
        }
    }
    #endregion
}
