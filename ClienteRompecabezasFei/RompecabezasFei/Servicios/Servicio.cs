using RompecabezasFei.Utilidades;
using System;
using System.Net.Sockets;
using System.ServiceModel;

namespace RompecabezasFei.Servicios
{
    public abstract class Servicio
    {
        // Permite identificar el estado después de invocar un método de cualquier servicio
        public EstadoOperacion EstadoOperacion { get; set; }

        public void ManejarExcepcionDeServidor(Exception excepcionGeneral)
        {
            if (excepcionGeneral is EndpointNotFoundException excepcionA)
            {
                Registros.Registrador.EscribirRegistro(excepcionA);
            }
            else if (excepcionGeneral is CommunicationObjectFaultedException excepcionB)
            {
                Registros.Registrador.EscribirRegistro(excepcionB);
            }
            else if (excepcionGeneral is CommunicationObjectAbortedException excepcionC)
            {
                Registros.Registrador.EscribirRegistro(excepcionC);
            }
            else if (excepcionGeneral is CommunicationException excepcionD)
            {
                Registros.Registrador.EscribirRegistro(excepcionD);
            }
            else if (excepcionGeneral is TimeoutException excepcionE)
            {
                Registros.Registrador.EscribirRegistro(excepcionE);
            }
            else if (excepcionGeneral is InvalidOperationException excepcionF)
            {
                Registros.Registrador.EscribirRegistro(excepcionF);
            }
            else
            {
                Registros.Registrador.EscribirRegistro(excepcionGeneral);
            }

            GestorCuadroDialogo.MostrarError(
                Properties.Resources.ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE,
                Properties.Resources.ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO);            
            EstadoOperacion = EstadoOperacion.Error;
        }

        public abstract void AbrirConexion();

        public abstract void CerrarConexion();
    }
}