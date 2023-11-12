using System.ServiceModel;

namespace Logica
{
    public class GestionContexto
    {
        private OperationContext contextoIServicioJuego;
        private OperationContext contextoIServicioGestionJugador;
        private OperationContext contextoIServicioAmistades;

        public GestionContexto()
        {
            contextoIServicioJuego = null;
            contextoIServicioGestionJugador = null;
            contextoIServicioAmistades = null;
        }

        public OperationContext ContextoIServicioJuego
        {
            get { return contextoIServicioJuego; }
            set { contextoIServicioJuego = value; }
        }

        public OperationContext ContextoIServicioGestionJugador
        {
            get { return contextoIServicioGestionJugador; }
            set { contextoIServicioGestionJugador = value; }
        }

        public OperationContext ContextoIServicioAmistades
        {
            get { return contextoIServicioAmistades; }
            set { contextoIServicioAmistades = value; }
        }
    }
}
