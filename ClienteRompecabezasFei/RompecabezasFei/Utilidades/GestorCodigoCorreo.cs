using System;
using RompecabezasFei.Servicios;

namespace RompecabezasFei.Utilidades
{
    public static class GestorCodigoCorreo
    {
        private const int MinimoNumeroAleatorio = 100000;

        private const int MaximoNumeroAleatorio = 1000000;
        
        public static string CodigoGenerado { get; set; }

        private static string GenerarNuevoCodigoConfirmacion()
        {
            Random generadorNumeroAleatorio = new Random();

            return generadorNumeroAleatorio.Next(MinimoNumeroAleatorio, 
                MaximoNumeroAleatorio).ToString();
        }

        public static bool EnviarNuevoCodigoDeVerificacionACorreo(string correoDestino, 
            string asunto, string mensaje)
        {
            CodigoGenerado = GenerarNuevoCodigoConfirmacion();
            var servicioCorreo = new ServicioCorreo();
            bool esMensajeEnviado = false;
            
            if (servicioCorreo.EstadoOperacion == EstadoOperacion.Correcto)
            {
                esMensajeEnviado = servicioCorreo.EnviarMensajeACorreoElectronico(
                    Properties.Resources.ETIQUETA_GENERAL_ROMPECABEZASFEI, 
                    correoDestino, asunto, mensaje);

                if (servicioCorreo.EstadoOperacion == EstadoOperacion.Correcto && 
                    !esMensajeEnviado)
                {
                    GestorCuadroDialogo.MostrarAdvertencia(
                        Properties.Resources.ETIQUETA_CODIGO_MENSAJENOENVIADO,
                        Properties.Resources.ETIQUETA_CODIGO_CODIGONOENVIADO);
                }
            }

            return esMensajeEnviado;
        }
    }
}