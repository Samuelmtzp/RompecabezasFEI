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
    #endregion

    #region IServicioJuego
    public partial class ServicioRompecabezasFei : IServicioJuego
    {
        private List<Logica.Sala> salasActivas = new List<Logica.Sala>();        

        public bool NuevaSala(string nombreAnfitrion, string idSala)
        {
            var nuevaSala = new Logica.Sala()
            {
                IdSala = idSala,
                NombreAnfitrion = nombreAnfitrion,
                ContadorJugadoresActuales = 0,
                Jugadores = new List<Logica.CuentaJugador>(),
            };
            salasActivas.Add(nuevaSala);
            return true;
        }

        public void ConectarCuentaJugadorASala(string nombreJugador, string idSala)
        {
            Logica.CuentaJugador jugador = new Logica.CuentaJugador()
            {
                NombreJugador = nombreJugador,
                ContextoOperacion = OperationContext.Current,
            };

            Logica.Sala salaEncontrada = 
                salasActivas.FirstOrDefault(sala => sala.IdSala.Equals(idSala));
            if (salaEncontrada.Jugadores.Count() > 0)
            {
                EnviarMensaje(nombreJugador, idSala, $"{nombreJugador} se ha unido a la sala!");
            }
            salaEncontrada.Jugadores.Add(jugador);
            salaEncontrada.ContadorJugadoresActuales++;
        }

        public void DesconectarCuentaJugadorDeSala(string nombreJugador, string idSala)
        {
            Logica.CuentaJugador cuentaJugadorEncontrada = null;
            Logica.Sala salaEncontrada = 
                salasActivas.FirstOrDefault(sala => sala.IdSala.Equals(idSala));

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
                if (salaEncontrada.Jugadores.Count() == 0)
                {
                    salasActivas.Remove(salaEncontrada);
                }
                else
                {
                    EnviarMensaje(nombreJugador, idSala, $"{nombreJugador} ha abandonado la sala!");
                }
            }
        }

        public void EnviarMensaje(string nombreJugador, string idSala, string mensaje)
        {
            Logica.Sala salaEncontrada = salasActivas.
                FirstOrDefault(sala => sala.IdSala.Equals(idSala));
            foreach (Logica.CuentaJugador cuentaJugador in salaEncontrada.Jugadores)
            {
                string horaActual = DateTime.Now.ToShortTimeString();
                Logica.CuentaJugador cuentaJugadorEncontrada = salaEncontrada.Jugadores.
                    FirstOrDefault(jugador => jugador.NombreJugador.Equals(nombreJugador));
                if (cuentaJugadorEncontrada != null)
                {
                    horaActual += $" {cuentaJugadorEncontrada.NombreJugador}: ";
                }
                mensaje = horaActual + mensaje;
                cuentaJugador.ContextoOperacion.GetCallbackChannel<IServicioJuegoCallback>().
                    MensajeCallBack(mensaje);
            }
        }

        public string GenerarCodigoParaNuevaSala()
        {
            String idSala = Guid.NewGuid().ToString();            
            return idSala;
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
    }
    #endregion
}
