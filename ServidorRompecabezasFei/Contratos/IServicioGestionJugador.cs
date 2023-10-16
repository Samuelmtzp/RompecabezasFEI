﻿using System;
using System.ServiceModel;
using Logica;

namespace Contratos
{
    [ServiceContract]
    public interface IServicioGestionJugador
    {

        [OperationContract]
        bool Registrar(Logica.CuentaJugador cuentaJugador);
        [OperationContract]
        bool ExisteCorreoElectronico(string correoElectronico);
        [OperationContract]
        bool ExisteNombreJugador(string nombreJugador);
        [OperationContract]
        Logica.CuentaJugador IniciarSesion(string nombreJugador, string contrasena);
        [OperationContract]
        bool EnviarValidacionCorreo(String correoDestino, String asunto, int codigoVerificacion);
        [OperationContract]
        int ObtenerNumeroPartidasJugadas(string nombreUsuario);
        [OperationContract]
        int ObtenerNumeroPartidasGanadas(string nombreUsuario);
    }
}
