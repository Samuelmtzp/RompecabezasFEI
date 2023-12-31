using RompecabezasFei.Utilidades;
using System;
using System.Net.Sockets;
using System.ServiceModel;

namespace RompecabezasFei.Servicios
{
    public class Servicio
    {
        // Permite identificar el estado después de invocar un método de cualquier servicio
        public EstadoOperacion EstadoOperacion { get; set; }

        public void ManejarExcepcionDeServidor(Exception excepcionGeneral, 
            bool cerrarSesion)
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
            else if (excepcionGeneral is SocketException excepcionD)
            {
                Registros.Registrador.EscribirRegistro(excepcionD);
            }
            else if (excepcionGeneral is TimeoutException excepcionE)
            {
                Registros.Registrador.EscribirRegistro(excepcionE);
            }
            else
            {
                Registros.Registrador.EscribirRegistro(excepcionGeneral);
            }

            GestorCuadroDialogo.MostrarError(
                Properties.Resources.ETIQUETA_ERRORCONEXIONSERVIDOR_MENSAJE,
                Properties.Resources.ETIQUETA_ERRORCONEXIONSERVIDOR_TITULO);            
            EstadoOperacion = EstadoOperacion.Error;

            if (cerrarSesion)
            {
                VentanaPrincipal.CerrarSesion(false);
            }
        }
    }
}