namespace Logica
{
    public static class Bloqueador
    {
        public static readonly object BloqueoParaBloquearPieza = new object();
        
        public static readonly object BloqueoParaRegistrarJugador = new object();
        
        public static readonly object BloqueoParaIniciarSesionComoJugador = new object();
        
        public static readonly object BloqueoParaIniciarSesionComoInvitado = new object();

        public static readonly object BloqueoParaAceptarSolicitudDeAmistad = new object();
        
        public static readonly object BloqueoParaColocarPieza = new object();
        
        public static readonly object BloqueoParaUnirseASala = new object();
        
        public static readonly object BloqueoParaActualizarNombreJugador = new object();
        
        public static readonly object BloqueoParaCerrarSesion = new object();
    }
}