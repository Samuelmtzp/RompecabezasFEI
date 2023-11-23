using Contratos;
using Datos;
using Logica;
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
    public partial class ServicioRompecabezasFei : IServicioJugador
    {
        public bool Registrar(CuentaJugador cuentaJugador)
        {
            Registro registro = new Registro();
            bool operacionRealizada = false;

            try
            {                
                operacionRealizada = registro.Registrar(cuentaJugador);
            }
            catch (EntityException)
            {

            }

            return operacionRealizada;
        }

        public bool ActualizarInformacion(string nombreAnterior,
            string nuevoNombre, int nuevoNumeroAvatar)
        {
            Registro registro = new Registro();
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = registro.ActualizarInformacion(nombreAnterior, 
                    nuevoNombre, nuevoNumeroAvatar);
            }
            catch (EntityException)
            {

            }
            
            return operacionRealizada;
        }

        public bool ActualizarContrasena(string correo, string contrasena)
        {
            Registro registro = new Registro();
            bool operacionRealizada = false;
            
            try
            {
                operacionRealizada = registro.ActualizarContrasena(correo, contrasena);
            }
            catch (EntityException)
            {

            }

            return operacionRealizada;
        }

        public bool ExisteNombreJugador(string nombreJugador)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            bool hayExistencias = false;
            
            try
            {
                hayExistencias = consultasJugador.ExisteNombreJugador(nombreJugador);
            }
            catch (EntityException)
            {

            }

            return hayExistencias;
        }               

        public CuentaJugador IniciarSesion(string nombreJugador, string contrasena)
        {
            CuentaJugador cuentaRecuperada = null;
            
            if (ExisteNombreJugador(nombreJugador) && 
                !jugadoresConectados.ContainsKey(nombreJugador))
            {
                try
                {
                    Autenticacion autenticacion = new Autenticacion();
                    cuentaRecuperada = autenticacion.IniciarSesion(nombreJugador, contrasena);

                    if (cuentaRecuperada != null)
                    {
                        cuentaRecuperada.EstadoConectividad = EstadoConectividadJugador.Conectado;
                        cuentaRecuperada.OperacionesContexto = new GestionContexto();
                        CuentaJugador cuentaAutenticada = new CuentaJugador
                        {
                            IdJugador = cuentaRecuperada.IdJugador,
                            NombreJugador = cuentaRecuperada.NombreJugador,
                            NumeroAvatar = cuentaRecuperada.NumeroAvatar,
                            EstadoConectividad = cuentaRecuperada.EstadoConectividad,
                            OperacionesContexto = cuentaRecuperada.OperacionesContexto,
                        };
                        jugadoresConectados[cuentaRecuperada.NombreJugador] = cuentaAutenticada;
                        NotificarConexionJugadorAOtrosJugadores(cuentaRecuperada.NombreJugador,
                            cuentaRecuperada.EstadoConectividad);
                    }
                }
                catch (EntityException)
                {

                }
            }

            return cuentaRecuperada;
        }

        public bool CerrarSesion(string nombreJugador)
        {
            bool operacionRealizada = false;

            if (jugadoresConectados.ContainsKey(nombreJugador))
            {
                operacionRealizada = jugadoresConectados.Remove(nombreJugador); 
                    NotificarConexionJugadorAOtrosJugadores(
                    nombreJugador, EstadoConectividadJugador.Desconectado);                
            }

            return operacionRealizada;
        }
    }
    #endregion

    public partial class ServicioRompecabezasFei : IServicioCorreo
    {
        public bool ExisteCorreoElectronico(string correoElectronico)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = consultasJugador.ExisteCorreoElectronico(
                    correoElectronico);
            }
            catch (EntityException)
            {

            }

            return operacionRealizada;
        }

        public bool EnviarMensajeCorreo(string encabezado, string correoDestino,
            string asunto, string mensaje)
        {
            GeneradorMensajesCorreo generadorMensajesCorreo = new GeneradorMensajesCorreo();
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = generadorMensajesCorreo.EnviarMensaje(
                    encabezado, correoDestino, asunto, mensaje);
            }
            catch (EntityException)
            {

            }

            return operacionRealizada;
        }
    }


    #region IServicioSala
    public partial class ServicioRompecabezasFei : IServicioSala
    {
        private readonly List<Logica.Sala> salasActivas = new List<Logica.Sala>();

        public bool CrearNuevaSala(string nombreAnfitrion, string codigoSala)
        {
            GestionSala gestionSala = new GestionSala();
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = gestionSala.CrearNuevaSala(
                    nombreAnfitrion, codigoSala);
            }
            catch (EntityException)
            {

            }

            if (operacionRealizada)
            {
                Logica.Sala salaConectada = new Logica.Sala()
                {
                    CodigoSala = codigoSala,
                    NombreAnfitrion = nombreAnfitrion,
                    ContadorJugadoresActuales = 0,
                    Jugadores = new List<CuentaJugador>()
                };
                salasActivas.Add(salaConectada);
            }

            return operacionRealizada;
        }

        public bool ExisteSalaDisponible(string codigoSala)
        {
            bool hayExistencias = false;
            Logica.Sala salaEncontrada = salasActivas.First(
                sala => sala.CodigoSala.Equals(codigoSala));
            
            if (!string.IsNullOrEmpty(salaEncontrada.CodigoSala) &&
                salaEncontrada.ContadorJugadoresActuales < Logica.Sala.MaximoJugadores)
            {
                hayExistencias = true;
            }

            return hayExistencias;
        }

        public void ConectarCuentaJugadorASala(string nombreJugador, string codigoSala, 
            string mensajeBienvenida)
        {
            if (jugadoresConectados.ContainsKey(nombreJugador))
            {
                jugadoresConectados[nombreJugador].OperacionesContexto.
                    ContextoIServicioSala = OperationContext.Current;
                Logica.Sala salaEncontrada = salasActivas.First(sala => 
                    sala.CodigoSala.Equals(codigoSala));

                if (!string.IsNullOrEmpty(salaEncontrada.CodigoSala) &&
                    salaEncontrada.ContadorJugadoresActuales < Logica.Sala.MaximoJugadores)
                {
                    EnviarMensajeDeSala(nombreJugador, codigoSala, mensajeBienvenida);
                    NotificarNuevoJugadorConectadoASala(
                        jugadoresConectados[nombreJugador], codigoSala);
                }

                salaEncontrada.Jugadores.Add(jugadoresConectados[nombreJugador]);
                salaEncontrada.ContadorJugadoresActuales++;
            }
        }

        public void ActualizarOperacionContextoSala(string nombreJugador, string codigoSala)
        {
            CuentaJugador cuentaJugadorEncontrada = null;
            Logica.Sala salaEncontrada = salasActivas.First(sala =>
                sala.CodigoSala.Equals(codigoSala));

            if (!string.IsNullOrEmpty(salaEncontrada.CodigoSala))
            {
                cuentaJugadorEncontrada = salaEncontrada.Jugadores.
                    First(cuentaJugador =>
                    cuentaJugador.NombreJugador == nombreJugador);
            }

            if (cuentaJugadorEncontrada != null && !string.IsNullOrEmpty(
                cuentaJugadorEncontrada.NombreJugador))
            {
                if (jugadoresConectados.ContainsKey(nombreJugador))
                {
                    jugadoresConectados[nombreJugador].OperacionesContexto.
                        ContextoIServicioSala = OperationContext.Current;
                }
            }
        }

        public void DesconectarCuentaJugadorDeSala(string nombreJugador, 
            string codigoSala, string mensajeDespedida)
        {
            CuentaJugador cuentaJugadorEncontrada = null;
            Logica.Sala salaEncontrada = salasActivas.First(sala => 
                sala.CodigoSala.Equals(codigoSala));

            if (!string.IsNullOrEmpty(salaEncontrada.CodigoSala))
            {
                cuentaJugadorEncontrada = salaEncontrada.Jugadores.
                    First(cuentaJugador =>
                    cuentaJugador.NombreJugador == nombreJugador);                
            }

            if (cuentaJugadorEncontrada != null && !string.IsNullOrEmpty(
                cuentaJugadorEncontrada.NombreJugador))
            {
                if (jugadoresConectados.ContainsKey(nombreJugador))
                {
                    jugadoresConectados[nombreJugador].OperacionesContexto.
                        ContextoIServicioSala = null;
                }

                salaEncontrada.Jugadores.Remove(cuentaJugadorEncontrada);
                salaEncontrada.ContadorJugadoresActuales--;
                
                if (salaEncontrada.EstaVacia())
                {
                    salasActivas.Remove(salaEncontrada);
                }
                else
                {
                    EnviarMensajeDeSala(nombreJugador, codigoSala, mensajeDespedida);
                    NotificarJugadorDesconectadoDeSala(nombreJugador, codigoSala);                    
                }
            }
        }

        public void EnviarMensajeDeSala(string nombreJugador, string codigoSala, 
            string mensaje)
        {
            Logica.Sala salaEncontrada = salasActivas.First(sala => 
                sala.CodigoSala.Equals(codigoSala));
            
            if (!string.IsNullOrEmpty(salaEncontrada.CodigoSala))
            {
                foreach (GestionContexto gestionadorContextoJugador in 
                    salaEncontrada.Jugadores.Select(cuentaJugador => 
                    cuentaJugador.OperacionesContexto))
                {
                    string horaActual = DateTime.Now.ToShortTimeString();
                    string mensajeFinal = horaActual + $" {nombreJugador}: {mensaje}";

                    if (gestionadorContextoJugador.ContextoIServicioSala != null)
                    {
                        gestionadorContextoJugador.ContextoIServicioSala.
                            GetCallbackChannel<IServicioSalaCallback>().
                            MostrarMensajeDeSala(mensajeFinal);
                    }
                }
            }
        }

        private void NotificarNuevoJugadorConectadoASala(CuentaJugador nuevoJugador, 
            string codigoSala)
        {
            Logica.Sala salaEncontrada = salasActivas.First(sala =>
                sala.CodigoSala.Equals(codigoSala));

            if (!string.IsNullOrEmpty(salaEncontrada.CodigoSala))
            {
                foreach (CuentaJugador jugador in salaEncontrada.Jugadores)
                {
                    jugador.OperacionesContexto.ContextoIServicioSala.GetCallbackChannel<
                        IServicioSalaCallback>().NotificarNuevoJugadorConectadoEnSala(
                        nuevoJugador);
                }
            }
        }

        private void NotificarJugadorDesconectadoDeSala(string nombreJugador, 
            string codigoSala)
        {
            Logica.Sala salaEncontrada = salasActivas.First(sala =>
                sala.CodigoSala.Equals(codigoSala));

            if (!string.IsNullOrEmpty(salaEncontrada.CodigoSala))
            {
                foreach (CuentaJugador jugador in salaEncontrada.Jugadores)
                {
                    jugador.OperacionesContexto.ContextoIServicioSala.GetCallbackChannel<
                        IServicioSalaCallback>().NotificarJugadorDesconectadoDeSala(
                        nombreJugador);
                }
            }
        }

        public string GenerarCodigoParaNuevaSala()
        {
            return Guid.NewGuid().ToString();
        }

        public List<CuentaJugador> ObtenerJugadoresConectadosEnSala(string codigoSala)
        {
            List<CuentaJugador> jugadoresEnSala = new List<CuentaJugador>();
            Logica.Sala salaEncontrada = salasActivas.First(sala =>
                sala.CodigoSala.Equals(codigoSala));

            if (!string.IsNullOrEmpty(salaEncontrada.CodigoSala))
            {
                jugadoresEnSala = salaEncontrada.Jugadores;
            }

            return jugadoresEnSala;
        }
    }
    #endregion

    #region IServicioAmistades
    public partial class ServicioRompecabezasFei : IServicioAmistades
    {
        private readonly Dictionary<string, CuentaJugador> jugadoresConectados =
            new Dictionary<string, CuentaJugador>();

        private void NotificarConexionJugadorAOtrosJugadores(string nombreJugador,
            EstadoConectividadJugador estado)
        {
            foreach (CuentaJugador cuenta in jugadoresConectados.Values)
            {
                if (ExisteAmistadConJugador(nombreJugador, cuenta.NombreJugador) &&
                    EsJugadorSuscritoANotififacionesDeAmistades(cuenta.NombreJugador))
                {
                    cuenta.OperacionesContexto.ContextoIServicioAmistades.
                        GetCallbackChannel<IServicioAmistadesCallback>().
                        NotificarEstadoConectividadDeJugador(nombreJugador, estado);
                }
            }
        }

        public List<CuentaJugador> ObtenerAmigosDeJugador(string nombreJugador)
        {
            GestionAmistades gestionAmistades = new GestionAmistades();
            List<CuentaJugador> cuentasJugador = null;

            try
            {
                cuentasJugador = gestionAmistades.ObtenerAmigosDeJugador(nombreJugador);
            }
            catch (EntityException)
            {

            }

            if (cuentasJugador != null)
            {
                cuentasJugador = AgregarEstadoConectividadACuentasDeJugador(cuentasJugador);
            }

            return cuentasJugador;
        }

        private List<CuentaJugador> AgregarEstadoConectividadACuentasDeJugador(
            List<CuentaJugador> cuentasJugador)
        {
            List<CuentaJugador> cuentasConEstadoConectividad = new List<CuentaJugador>();

            foreach (CuentaJugador cuenta in cuentasJugador)
            {
                if (jugadoresConectados.ContainsKey(cuenta.NombreJugador))
                {
                    cuenta.EstadoConectividad = jugadoresConectados[cuenta.NombreJugador].
                        EstadoConectividad;
                }
                else
                {
                    cuenta.EstadoConectividad = EstadoConectividadJugador.Desconectado;
                }

                cuentasConEstadoConectividad.Add(cuenta);
            }

            return cuentasConEstadoConectividad;
        }

        public List<CuentaJugador> ObtenerJugadoresConSolicitudPendiente(string nombreJugador)
        {
            GestionAmistades gestionAmistades = new GestionAmistades();
            List<CuentaJugador> cuentasJugador = null;

            try
            {
                cuentasJugador = gestionAmistades.
                    ObtenerJugadoresConSolicitudPendiente(nombreJugador);
            }
            catch (EntityException)
            {

            }

            if (cuentasJugador != null)
            {
                cuentasJugador = AgregarEstadoConectividadACuentasDeJugador(cuentasJugador);
            }

            return cuentasJugador;
        }

        public bool EnviarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            bool operacionRealizada = false; 
            GestionAmistades gestionAmistades = new GestionAmistades();

            try
            {
                operacionRealizada = gestionAmistades.EnviarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException)
            {

            }

            if (operacionRealizada && EsJugadorSuscritoANotififacionesDeAmistades(
                nombreJugadorDestino))
            {
                jugadoresConectados[nombreJugadorDestino].OperacionesContexto.
                    ContextoIServicioAmistades.GetCallbackChannel<IServicioAmistadesCallback>().
                    NotificarSolicitudAmistadEnviada(jugadoresConectados[nombreJugadorOrigen]);
            }

            return operacionRealizada;
        }

        public bool AceptarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            bool operacionRealizada = false;
            GestionAmistades gestionAmistades = new GestionAmistades();
                
            try
            {
                operacionRealizada = gestionAmistades.AceptarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException)
            {

            }

            if (operacionRealizada && EsJugadorSuscritoANotififacionesDeAmistades(
                nombreJugadorOrigen))
            {
                jugadoresConectados[nombreJugadorOrigen].OperacionesContexto.
                    ContextoIServicioAmistades.GetCallbackChannel<IServicioAmistadesCallback>().
                    NotificarSolicitudAmistadAceptada(jugadoresConectados[nombreJugadorDestino]);
            }

            return operacionRealizada;
        }

        public bool EliminarAmistadEntreJugadores(string nombreJugadorA,
            string nombreJugadorB)
        {
            bool operacionRealizada = false;
            GestionAmistades gestionAmistades = new GestionAmistades();

            try
            {
                operacionRealizada = gestionAmistades.EliminarAmistadEntreJugadores(
                    nombreJugadorA, nombreJugadorB);
            }
            catch (EntityException)
            {

            }

            if (operacionRealizada && EsJugadorSuscritoANotififacionesDeAmistades(
                nombreJugadorB))
            {
                jugadoresConectados[nombreJugadorB].OperacionesContexto.
                    ContextoIServicioAmistades.GetCallbackChannel<IServicioAmistadesCallback>().
                    NotificarAmistadEliminada(nombreJugadorA);
            }

            return operacionRealizada;
        }

        public bool RechazarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            GestionAmistades gestionAmistades = new GestionAmistades();
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = gestionAmistades.EliminarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException)
            {

            }

            return operacionRealizada;
        }

        public bool ExisteSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            GestionAmistades gestionAmistades = new GestionAmistades();
            bool hayExistencias = false;

            try
            {
                hayExistencias = gestionAmistades.ExisteSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException)
            {

            }

            return hayExistencias;
        }

        public bool ExisteAmistadConJugador(string nombreJugadorA, string nombreJugadorB)
        {
            GestionAmistades gestionAmistades = new GestionAmistades();
            bool hayExistencias = false;

            try
            {
                hayExistencias = gestionAmistades.ExisteAmistadConJugador(
                    nombreJugadorA, nombreJugadorB);
            }
            catch (EntityException)
            {

            }

            return hayExistencias;
        }

        public bool SuscribirJugadorANotificacionesAmistades(string nombreJugador)
        {
            bool operacionRealizada = false;

            if (!EsJugadorSuscritoANotififacionesDeAmistades(nombreJugador))
            {
                jugadoresConectados[nombreJugador].OperacionesContexto.
                    ContextoIServicioAmistades = OperationContext.Current;
                operacionRealizada = true;
            }

            return operacionRealizada;
        }        

        public bool DesuscribirJugadorDeNotificacionesAmistades(string nombreJugador)
        {
            bool operacionRealizada = false;

            if (EsJugadorSuscritoANotififacionesDeAmistades(nombreJugador))
            {
                jugadoresConectados[nombreJugador].OperacionesContexto.
                    ContextoIServicioAmistades = null;
                operacionRealizada = true;
            }

            return operacionRealizada;
        }

        public bool EsJugadorSuscritoANotififacionesDeAmistades(string nombreJugador)
        {
            bool hayCoincidencias = false;

            if (jugadoresConectados.ContainsKey(nombreJugador) &&
                jugadoresConectados[nombreJugador].OperacionesContexto.
                ContextoIServicioAmistades != null)
            {
                hayCoincidencias = true;
            }

            return hayCoincidencias;
        }
    }
    #endregion

    #region IServicioPartida
    public partial class ServicioRompecabezasFei : IServicioPartida
    {
        private Dictionary<string, Logica.Partida> partidasActivas =
            new Dictionary<string, Logica.Partida>();

        public bool CrearNuevaPartida(string codigoSala, DificultadPartida dificultad)
        {
            GestionPartida gestionPartida = new GestionPartida();
            bool operacionRealizada = false;
            
            try
            {
                operacionRealizada = gestionPartida.CrearNuevaPartida(codigoSala, dificultad);
            }
            catch (EntityException)
            {

            }

            if (operacionRealizada)
            {
                Logica.Sala salaEncontrada = salasActivas.Where(sala => 
                    sala.CodigoSala == codigoSala).First();

                if (!string.IsNullOrEmpty(salaEncontrada.CodigoSala) && 
                    !partidasActivas.ContainsKey(codigoSala))
                {
                    Logica.Partida partidaActiva = new Logica.Partida();
                    
                    partidasActivas.Add(codigoSala, partidaActiva);

                    foreach (CuentaJugador jugador in salaEncontrada.Jugadores)
                    {
                        if (jugador.NombreJugador != salaEncontrada.NombreAnfitrion)
                        {
                            jugador.OperacionesContexto.ContextoIServicioPartida.
                                GetCallbackChannel<IServicioSalaCallback>().
                                NotificarCreacionDePartida();
                        }
                    }
                }
            }

            return operacionRealizada;
        }

        public bool IniciarPartida(string codigoSala, int numeroImagenRompecabezas)
        {
            bool operacionRealizada = false;

            if (partidasActivas.ContainsKey(codigoSala))
            {
                GestionPartida gestionPartida = new GestionPartida();
                partidasActivas[codigoSala].Tablero = gestionPartida.
                    GenerarNuevoTablero(partidasActivas[codigoSala].DificultadPartida, 
                    numeroImagenRompecabezas);

                Logica.Sala salaEncontrada = salasActivas.Where(sala =>
                    sala.CodigoSala == codigoSala).First();

                if (!string.IsNullOrEmpty(salaEncontrada.CodigoSala))
                {
                    foreach (CuentaJugador jugador in salaEncontrada.Jugadores)
                    {
                        jugador.OperacionesContexto.ContextoIServicioPartida.
                            GetCallbackChannel<IServicioPartidaCallback>().
                            MostrarTablero(partidasActivas[codigoSala].Tablero);
                    }

                    operacionRealizada = true;
                }
            }

            return operacionRealizada;
        }

        public bool FinalizarPartida(string codigoSala)
        {
            // Para cada jugador de la sala, notificar que la partida finalizó y
            // registrar sus resultados en la partida en la base de datos
            // Eliminar del diccionario la partida actual de la sala

            //GestionPartida gestionPartida = new GestionPartida();
            //bool operacionRealizada = false;

            //try
            //{
            //    operacionRealizada = gestionPartida.FinalizarPartida(
            //        codigoSala, cuentaJugador, esGanador);
            //}
            //catch (EntityException)
            //{

            //}

            //return operacionRealizada;
            throw new NotImplementedException();
        }

        public void CambiarPosicionDePieza(string codigoSala, string nombreJugador, int numeroPieza, 
            double posicionX, double posicionY)
        {
            // mover la pieza de lugar y notificar a los demás jugadores,
            // pero menos al jugador que realizó el movimiento


            throw new NotImplementedException();
        }
        
        public void MarcarPiezaComoCorrecta(string codigoSala, int numeroPieza, string nombreJugador)
        {
            // marcar como correcta la pieza, y agregar puntos al jugador que realizó el movimiento

            throw new NotImplementedException();
        }

        public bool ExpulsarJugador(string codigoSala, string nombreJugador)
        {
            // eliminar de la sala al jugador a expulsar y notificar a los demás jugadores
            // agregar a alguien más como anfitrión de la sala

            throw new NotImplementedException();
        }        

        public int ObtenerNumeroPartidasJugadas(string nombreJugador)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            int numeroPartidasJugadas = 0;

            try
            {
                numeroPartidasJugadas = consultasJugador.
                    ObtenerNumeroPartidasJugadasDeJugador(nombreJugador);
            }
            catch (EntityException)
            {

            }

            return numeroPartidasJugadas;
        }

        public int ObtenerNumeroPartidasGanadas(string nombreJugador)
        {
            ConsultasJugador consultasJugador = new ConsultasJugador();
            int numeroPartidasGanadas = 0;

            try
            {
                numeroPartidasGanadas = consultasJugador.
                    ObtenerNumeroPartidasGanadas(nombreJugador);
            }
            catch (EntityException)
            {

            }

            return numeroPartidasGanadas;
        }

        public void BloquearPieza(string codigoSala, int numeroPieza)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}