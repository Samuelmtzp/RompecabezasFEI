﻿using Logica;
using System.Collections.Generic;
using System.ServiceModel;

namespace Contratos
{
    [ServiceContract(CallbackContract = typeof(IServicioInvitacionesCallback))]
    public interface IServicioInvitaciones
    {
        [OperationContract(IsOneWay = true)]
        void ActivarInvitacionesDeSala(string nombreJugador);

        [OperationContract(IsOneWay = true)]
        void DesactivarInvitacionesDeSala(string nombreJugador);        
    }

    [ServiceContract]
    public interface IServicioInvitacionesCallback
    {
        [OperationContract(IsOneWay = true)]
        void MostrarInvitacionDeSala(string nombreJugador, string codigoSala);        
    }
}