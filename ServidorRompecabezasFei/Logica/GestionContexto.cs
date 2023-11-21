﻿using System.ServiceModel;

namespace Logica
{
    public class GestionContexto
    {
        public OperationContext ContextoIServicioSala { get; set; }

        public OperationContext ContextoIServicioAmistades { get; set; }
        
        public GestionContexto()
        {
            ContextoIServicioSala = null;
            ContextoIServicioAmistades = null;
        }
    }
}