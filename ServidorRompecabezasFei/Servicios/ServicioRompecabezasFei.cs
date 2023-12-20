using Contratos;
using Datos;
using Logica;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceModel;

namespace Servicios
{
    #region IServicioGestionJugador
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,
        InstanceContextMode = InstanceContextMode.Single)]
    public partial class ServicioRompecabezasFei : IServicioJugador
    {
        private static readonly object bloqueoInicioSesion = new object();

        public bool Registrar(CuentaJugador cuentaJugador)
        {
            bool operacionRealizada = false;

            try
            {                
                operacionRealizada = Registro.Registrar(cuentaJugador);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return operacionRealizada;
        }

        public bool ActualizarInformacion(string nombreAnterior,
            string nuevoNombre, int nuevoNumeroAvatar)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = Registro.ActualizarInformacion(nombreAnterior, 
                    nuevoNombre, nuevoNumeroAvatar);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }
            
            return operacionRealizada;
        }

        public bool ActualizarContrasena(string correo, string contrasena)
        {
            bool operacionRealizada = false;
            
            try
            {
                operacionRealizada = Registro.ActualizarContrasena(correo, contrasena);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return operacionRealizada;
        }

        public bool ExisteNombreJugador(string nombreJugador)
        {
            bool hayExistencias = false;
            
            try
            {
                hayExistencias = ConsultasJugador.ExisteNombreJugador(nombreJugador);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return hayExistencias;
        }

        public CuentaJugador IniciarSesion(string nombreJugador, string contrasena)
        {
            CuentaJugador cuentaRecuperada = null;
            
            lock (bloqueoInicioSesion)
            {
                if (ExisteNombreJugador(nombreJugador) && 
                    !jugadoresConectados.ContainsKey(nombreJugador))
                {
                    try
                    {
                        cuentaRecuperada = Autenticacion.IniciarSesion(nombreJugador, contrasena);

                        if (cuentaRecuperada != null)
                        {
                            cuentaRecuperada.ContextoOperacion = null;
                            jugadoresConectados.TryAdd(cuentaRecuperada.NombreJugador, cuentaRecuperada);
                            NotificarEstadoConectividad(cuentaRecuperada.NombreJugador, 
                                ConectividadJugador.Disponible);
                        }
                    }
                    catch (EntityException)
                    {

                    }
                }
            }

            return cuentaRecuperada;
        }

        public bool CerrarSesion(string nombreJugador)
        {
            bool operacionRealizada = jugadoresConectados.TryRemove(nombreJugador, out _); 
                NotificarEstadoConectividad(
                nombreJugador, ConectividadJugador.Desconectado);

            return operacionRealizada;
        }
    }
    #endregion

    #region IServicioCorreo 
    public partial class ServicioRompecabezasFei : IServicioCorreo
    {
        public bool ExisteCorreoElectronico(string correoElectronico)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = ConsultasJugador.ExisteCorreoElectronico(
                    correoElectronico);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return operacionRealizada;
        }

        public bool EnviarMensajeCorreo(string encabezado, string correoDestino,
            string asunto, string mensaje)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = GeneradorMensajesCorreo.EnviarMensaje(
                    encabezado, correoDestino, asunto, mensaje);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return operacionRealizada;
        }
    }
    #endregion

    #region IServicioInvitaciones
    public partial class ServicioRompecabezasFei : IServicioInvitaciones
    {
        public void SuscribirJugadorAInvitacionesDeSala(string nombreJugador)
        {
            jugadoresConectados[nombreJugador].ContextoOperacion = 
                OperationContext.Current;
        }
        
        public void DesuscribirJugadorDeInvitacionesDeSala(string nombreJugador)
        {
            jugadoresConectados[nombreJugador].ContextoOperacion = null;
        }
    }
    #endregion

    #region IServicioSala
    public partial class ServicioRompecabezasFei : IServicioSala
    {
        private readonly ConcurrentDictionary<string, Logica.Sala> salasActivas = 
            new ConcurrentDictionary<string, Logica.Sala>();

        public bool CrearNuevaSala(string nombreAnfitrion, string codigoSala)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = GestionSala.CrearNuevaSala(codigoSala);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            if (operacionRealizada)
            {
                Logica.Sala nuevaSala = new Logica.Sala()
                {                        
                    Estado = EstadoSala.ConCupoDisponible,
                    CodigoSala = codigoSala,
                    NombreAnfitrion = nombreAnfitrion,
                    ContadorJugadores = 0,
                    Jugadores = new ConcurrentDictionary<string, CuentaJugador>()
                };
                salasActivas.TryAdd(codigoSala, nuevaSala);
            }

            return operacionRealizada;
        }

        public bool ExisteSalaDisponible(string codigoSala)
        {
            bool existeSala = false;
            
            if (salasActivas.ContainsKey(codigoSala) &&
                salasActivas[codigoSala].Estado == EstadoSala.ConCupoDisponible)
            {
                existeSala = true;
            }

            return existeSala;
        }

        public void ConectarJugadorASala(string nombreNuevoJugador, string codigoSala, 
            string mensajeBienvenida)
        {
            if (salasActivas[codigoSala].Estado == EstadoSala.ConCupoDisponible)
            {
                bool esInvitado = !jugadoresConectados.ContainsKey(nombreNuevoJugador);
                CuentaJugador nuevoJugador = new CuentaJugador
                {
                    NombreJugador = nombreNuevoJugador,
                    EsInvitado = esInvitado,
                    NumeroAvatar = esInvitado ? CuentaJugador.NumeroAvatarInvitado : 
                        jugadoresConectados[nombreNuevoJugador].NumeroAvatar,
                    ContextoOperacion = OperationContext.Current,
                };
                
                if (!esInvitado)
                {
                    jugadoresConectados[nombreNuevoJugador].EstadoConectividad =
                        ConectividadJugador.NoDisponible;
                    NotificarEstadoConectividad(nombreNuevoJugador,
                        ConectividadJugador.NoDisponible);
                    nuevoJugador.IdJugador = jugadoresConectados[nombreNuevoJugador].IdJugador;
                }

                foreach (var jugador in salasActivas[codigoSala].Jugadores.Values)
                {
                    if (jugador.ObtenerCanalDeCallback() is IServicioSalaCallback)
                    {
                        jugador.ContextoOperacion.GetCallbackChannel<IServicioSalaCallback>().
                            NotificarNuevoJugadorConectadoEnSala(nuevoJugador);
                    }
                }
                
                if (!salasActivas[codigoSala].EstaVacia())
                {
                    EnviarMensajeDeSala(nombreNuevoJugador, codigoSala, mensajeBienvenida);
                }

                salasActivas[codigoSala].Jugadores.TryAdd(nombreNuevoJugador, nuevoJugador);
                salasActivas[codigoSala].ContadorJugadores++;

                if (salasActivas[codigoSala].ContadorJugadores == 
                    Logica.Sala.MaximoJugadoresPorSala)
                {
                    salasActivas[codigoSala].Estado = EstadoSala.ConCupoNoDisponible;
                }
            }
        }

        public void RefrescarSesionEnSala(string nombreJugador, string codigoSala)
        {
            salasActivas[codigoSala].Jugadores[nombreJugador].ContextoOperacion = 
                OperationContext.Current;
        }

        public void DesconectarJugadorDeSala(string nombreJugadorDesconexion, 
            string codigoSala, string mensajeDespedida)
        {
            if (!salasActivas[codigoSala].Jugadores[nombreJugadorDesconexion].EsInvitado)
            {
                jugadoresConectados[nombreJugadorDesconexion].EstadoConectividad =
                    ConectividadJugador.Disponible;
                NotificarEstadoConectividad(nombreJugadorDesconexion, 
                    ConectividadJugador.Disponible);
            }

            salasActivas[codigoSala].Jugadores.TryRemove(nombreJugadorDesconexion, out _);
            salasActivas[codigoSala].ContadorJugadores--;
                
            if (salasActivas[codigoSala].EstaVacia())
            {
                salasActivas.TryRemove(codigoSala, out _);
            }
            else
            {
                foreach (var jugador in salasActivas[codigoSala].Jugadores.Values)
                {
                    if (jugador.ObtenerCanalDeCallback() is IServicioSalaCallback)
                    {
                        jugador.ContextoOperacion.GetCallbackChannel
                            <IServicioSalaCallback>().NotificarJugadorDesconectadoDeSala(
                            nombreJugadorDesconexion);
                    }
                }

                EnviarMensajeDeSala(nombreJugadorDesconexion, codigoSala, mensajeDespedida);
                salasActivas[codigoSala].Estado = EstadoSala.ConCupoDisponible;
            }
        }

        public void EnviarMensajeDeSala(string nombreJugador, string codigoSala, string mensaje)
        {
            foreach (var jugador in salasActivas[codigoSala].Jugadores.Values)
            {
                if (jugador.ObtenerCanalDeCallback() is IServicioSalaCallback)
                {
                    jugador.ContextoOperacion.GetCallbackChannel<IServicioSalaCallback>().
                        MostrarMensajeDeSala(DateTime.Now.ToShortTimeString() + 
                        $" {nombreJugador}: {mensaje}");
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
            
            foreach (var jugador in salasActivas[codigoSala].Jugadores.Values)
            {
                jugadoresEnSala.Add(jugador);
            }

            return jugadoresEnSala;
        }

        public bool ConvertirAJugadorEnAnfitrionDeSala(string nombreAntiguoAnfitrion, 
            string nombreNuevoAnfitrion, string codigoSala)
        {
            bool resultado = false;
            salasActivas[codigoSala].NombreAnfitrion = nombreNuevoAnfitrion;

            if (salasActivas[codigoSala].Jugadores[nombreAntiguoAnfitrion].
                ObtenerCanalDeCallback() is IServicioSalaCallback)
            {
                salasActivas[codigoSala].Jugadores[nombreAntiguoAnfitrion].
                    ContextoOperacion.GetCallbackChannel<IServicioSalaCallback>().
                    MostrarFuncionesDeAnfitrion();
            }

            return resultado;
        }

        public void InvitarAJugadorASala(string nombreJugador, string nombreAnfitrion, 
            string codigoSala)
        {
            if (jugadoresConectados[nombreJugador].ObtenerCanalDeCallback() 
                is IServicioInvitacionesCallback)
            {
                jugadoresConectados[nombreJugador].ContextoOperacion.
                    GetCallbackChannel<IServicioInvitacionesCallback>().
                    MostrarInvitacionDeSala(nombreAnfitrion, codigoSala);
            }
        }
    }
    #endregion

    #region IServicioAmistades
    public partial class ServicioRompecabezasFei : IServicioAmistades
    {
        private readonly ConcurrentDictionary<string, CuentaJugador> jugadoresConectados =
            new ConcurrentDictionary<string, CuentaJugador>();

        private void NotificarEstadoConectividad(string nombreJugador,
            ConectividadJugador estado)
        {
            foreach (CuentaJugador jugador in jugadoresConectados.Values)
            {
                if (ExisteAmistadConJugador(nombreJugador, jugador.NombreJugador))
                {
                    if (jugador.ObtenerCanalDeCallback() is IServicioAmistadesCallback)
                    {
                        jugador.ContextoOperacion.GetCallbackChannel
                            <IServicioAmistadesCallback>().
                            NotificarEstadoConectividadDeJugador(nombreJugador, estado);
                    }
                }
            }
        }

        public List<CuentaJugador> ObtenerAmigosDeJugador(string nombreJugador)
        {
            List<CuentaJugador> cuentasJugador = null;

            try
            {
                cuentasJugador = GestionAmistades.ObtenerAmigosDeJugador(nombreJugador);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
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
                    cuenta.EstadoConectividad = ConectividadJugador.Desconectado;
                }

                cuentasConEstadoConectividad.Add(cuenta);
            }

            return cuentasConEstadoConectividad;
        }

        public List<CuentaJugador> ObtenerJugadoresConSolicitudPendiente(string nombreJugador)
        {
            List<CuentaJugador> cuentasJugador = null;

            try
            {
                cuentasJugador = GestionAmistades.ObtenerJugadoresConSolicitudPendiente(
                    nombreJugador);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
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

            try
            {
                operacionRealizada = GestionAmistades.EnviarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            if (operacionRealizada)
            {
                if (jugadoresConectados[nombreJugadorDestino].ObtenerCanalDeCallback() 
                    is IServicioAmistadesCallback)
                {
                    jugadoresConectados[nombreJugadorDestino].ContextoOperacion.
                        GetCallbackChannel<IServicioAmistadesCallback>().
                        NotificarSolicitudAmistadEnviada(
                        jugadoresConectados[nombreJugadorOrigen]);
                }
            }

            return operacionRealizada;
        }

        public bool AceptarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            bool operacionRealizada = false;
                
            try
            {
                operacionRealizada = GestionAmistades.AceptarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            if (operacionRealizada)
            {
                if (jugadoresConectados[nombreJugadorOrigen].
                    ObtenerCanalDeCallback() is IServicioAmistadesCallback)
                {
                    jugadoresConectados[nombreJugadorOrigen].ContextoOperacion.
                        GetCallbackChannel<IServicioAmistadesCallback>().
                        NotificarSolicitudAmistadAceptada(
                        jugadoresConectados[nombreJugadorDestino]);
                }
            }

            return operacionRealizada;
        }

        public bool EliminarAmistadEntreJugadores(string nombreJugadorA,
            string nombreJugadorB)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = GestionAmistades.EliminarAmistadEntreJugadores(
                    nombreJugadorA, nombreJugadorB);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            if (operacionRealizada)
            {
                if (jugadoresConectados[nombreJugadorB].ObtenerCanalDeCallback()
                    is IServicioAmistadesCallback)
                {
                    jugadoresConectados[nombreJugadorB].ContextoOperacion.
                        GetCallbackChannel<IServicioAmistadesCallback>().
                        NotificarAmistadEliminada(nombreJugadorA);
                }
            }

            return operacionRealizada;
        }

        public bool RechazarSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            bool operacionRealizada = false;

            try
            {
                operacionRealizada = GestionAmistades.EliminarSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return operacionRealizada;
        }

        public bool ExisteSolicitudDeAmistad(string nombreJugadorOrigen, 
            string nombreJugadorDestino)
        {
            bool hayExistencias = false;

            try
            {
                hayExistencias = GestionAmistades.ExisteSolicitudDeAmistad(
                    nombreJugadorOrigen, nombreJugadorDestino);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return hayExistencias;
        }

        public bool ExisteAmistadConJugador(string nombreJugadorA, string nombreJugadorB)
        {
            bool hayExistencias = false;

            try
            {
                hayExistencias = GestionAmistades.ExisteAmistadConJugador(
                    nombreJugadorA, nombreJugadorB);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return hayExistencias;
        }

        public void SuscribirJugadorANotificacionesDeAmistades(string nombreJugador)
        {
            jugadoresConectados[nombreJugador].ContextoOperacion = 
                OperationContext.Current;
        }        

        public void DesuscribirJugadorDeNotificacionesDeAmistades(string nombreJugador)
        {
            jugadoresConectados[nombreJugador].ContextoOperacion = null;
        }
    }
    #endregion

    #region IServicioPartida
    public partial class ServicioRompecabezasFei : IServicioPartida
    {
        private readonly ConcurrentDictionary<string, Logica.Partida> partidasActivas =
            new ConcurrentDictionary<string, Logica.Partida>();

        private static object bloqueoDePieza = new object();

        public bool CrearNuevaPartida(string codigoSala, DificultadPartida dificultad, 
            int numeroImagen)
        {
            bool operacionRealizada = false;
            
            try
            {
                operacionRealizada = GestionPartida.CrearNuevaPartida(codigoSala, dificultad);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            if (operacionRealizada)
            {
                var nuevaPartida = new Logica.Partida
                {
                    Tablero = new Tablero(),
                    Puntajes = new ConcurrentDictionary<string, int>(),
                };
                nuevaPartida.Dificultad = dificultad;
                nuevaPartida.Tablero.NumeroImagenRompecabezas = numeroImagen;
                nuevaPartida.Tablero.Piezas = GestionPartida.GenerarPiezasParaTablero(
                    nuevaPartida.Tablero.TotalFilas, nuevaPartida.Tablero.TotalColumnas);
                partidasActivas.TryAdd(codigoSala, nuevaPartida);

                foreach (var jugador in salasActivas[codigoSala].Jugadores.Values)
                {
                    partidasActivas[codigoSala].Puntajes.TryAdd(jugador.NombreJugador, 0);

                    if (jugador.NombreJugador != salasActivas[codigoSala].NombreAnfitrion &&
                        jugador.ObtenerCanalDeCallback() is IServicioSalaCallback)
                    {
                        jugador.ContextoOperacion.GetCallbackChannel
                            <IServicioSalaCallback>().NotificarCreacionDePartida();
                    }
                }
            }

            return operacionRealizada;
        }

        public void ConectarJugadorAPartida(string codigoSala, string nombreJugador)
        {
            salasActivas[codigoSala].Jugadores[nombreJugador].ContextoOperacion = 
                OperationContext.Current;
        }

        public void DesconectarJugadorDePartida(string codigoSala, 
            string nombreJugadorDesconexion)
        {
            salasActivas[codigoSala].Jugadores.TryRemove(nombreJugadorDesconexion, out _);

            foreach (var jugador in salasActivas[codigoSala].Jugadores.Values)
            {
                if (jugador.ObtenerCanalDeCallback() is IServicioPartidaCallback)
                {
                    jugador.ContextoOperacion.GetCallbackChannel
                        <IServicioPartidaCallback>().
                        NotificarJugadorDesconectadoDePartida(nombreJugadorDesconexion);
                }
            }
        }

        public void IniciarPartida(string codigoSala)
        {
            foreach (var jugador in salasActivas[codigoSala].Jugadores.Values)
            {
                if (jugador.ObtenerCanalDeCallback() is IServicioPartidaCallback)
                {
                    jugador.ContextoOperacion.GetCallbackChannel
                        <IServicioPartidaCallback>().
                        NotificarInicioDePartida(partidasActivas[codigoSala].Tablero);
                }
            }
        }

        private bool FinalizarPartida(string codigoSala)
        {
            bool operacionRealizada = false;
            int puntajeMaximo = partidasActivas[codigoSala].Puntajes.Values.Max();
            var nombresDeJugadoresConPuntajeMaximo = partidasActivas[codigoSala].
                Puntajes.Where(puntajeDeJugador => 
                puntajeDeJugador.Value == puntajeMaximo).
                Select(puntajeDeJugador => puntajeDeJugador.Key).ToList();

            foreach (var jugador in salasActivas[codigoSala].Jugadores.Values)
            {
                if (!jugador.EsInvitado)
                {
                    bool esGanador = nombresDeJugadoresConPuntajeMaximo.Count == 1 &&
                        jugador.NombreJugador == nombresDeJugadoresConPuntajeMaximo.First();
                    jugador.Puntaje = partidasActivas[codigoSala].Puntajes[jugador.NombreJugador];

                    try
                    {
                        operacionRealizada = GestionPartida.FinalizarPartida(codigoSala, 
                            jugador, esGanador);
                    }
                    catch (EntityException)
                    {

                    }
                }
            }

            partidasActivas.TryRemove(codigoSala, out _);
            operacionRealizada = true;

            return operacionRealizada;
        }

        public void BloquearPieza(string codigoSala, int numeroPieza, string nombreJugador)
        {
            lock (bloqueoDePieza)
            {
                if (!partidasActivas[codigoSala].Tablero.Piezas[numeroPieza].EstaBloqueada)
                {
                    partidasActivas[codigoSala].Tablero.Piezas[numeroPieza].EstaBloqueada = true;

                    foreach (var jugador in salasActivas[codigoSala].Jugadores.Values)
                    {
                        jugador.ContextoOperacion.GetCallbackChannel
                            <IServicioPartidaCallback>().
                            NotificarBloqueoDePieza(numeroPieza, nombreJugador);
                    }
                }
            }
        }

        public void DesbloquearPieza(string codigoSala, int numeroPieza, string nombreJugador)
        {
            partidasActivas[codigoSala].Tablero.Piezas[numeroPieza].EstaBloqueada = false;

            foreach (var jugador in salasActivas[codigoSala].Jugadores.Values)
            {
                jugador.ContextoOperacion.GetCallbackChannel
                    <IServicioPartidaCallback>().
                    NotificarDesbloqueoDePieza(numeroPieza, nombreJugador);
            }
        }

        public void ColocarPieza(string codigoSala, int numeroPieza, string nombreJugador, 
            double posicionX, double posicionY)
        {
            var puntaje = (int)partidasActivas[codigoSala].Tablero.
                Piezas[numeroPieza].ValorEnPuntaje;
            partidasActivas[codigoSala].Puntajes[nombreJugador] += puntaje;
            partidasActivas[codigoSala].Tablero.Piezas[numeroPieza].
                EstaDentroDeCelda = true;
            bool esRompecabezasCompletado = partidasActivas[codigoSala].
                Tablero.EsRompecabezasCompletado();

            if (esRompecabezasCompletado)
            {
                FinalizarPartida(codigoSala);
            }

            foreach (var jugador in salasActivas[codigoSala].Jugadores.Values)
            {
                jugador.ContextoOperacion.GetCallbackChannel
                    <IServicioPartidaCallback>().
                    NotificarColocacionDePieza(numeroPieza, nombreJugador, 
                    puntaje, posicionX, posicionY);

                if (esRompecabezasCompletado)
                {
                    jugador.ContextoOperacion.
                        GetCallbackChannel<IServicioPartidaCallback>().
                        NotificarFinDePartida();
                }
            }
        }      

        public int ObtenerNumeroPartidasJugadas(string nombreJugador)
        {
            int numeroPartidasJugadas = 0;

            try
            {
                numeroPartidasJugadas = ConsultasJugador.
                    ObtenerNumeroPartidasJugadasDeJugador(nombreJugador);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return numeroPartidasJugadas;
        }

        public int ObtenerNumeroPartidasGanadas(string nombreJugador)
        {
            int numeroPartidasGanadas = 0;

            try
            {
                numeroPartidasGanadas = ConsultasJugador.
                    ObtenerNumeroPartidasGanadas(nombreJugador);
            }
            catch (EntityException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
            }

            return numeroPartidasGanadas;
        }

        public void ExpulsarAJugadorDePartida(string nombreJugadorExpulsion, string codigoSala)
        {
            salasActivas[codigoSala].Jugadores.TryRemove(nombreJugadorExpulsion, out _);

            foreach (var jugador in salasActivas[codigoSala].Jugadores.Values)
            {
                salasActivas[codigoSala].Jugadores[jugador.NombreJugador].
                    ContextoOperacion.GetCallbackChannel<IServicioPartidaCallback>().
                    NotificarJugadorDesconectadoDePartida(nombreJugadorExpulsion);
            }
        }
    }
    #endregion
}