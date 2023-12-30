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
            var servicio = new ServicioCorreo();
            
            bool esMensajeEnviado = servicio.EnviarMensajeACorreoElectronico(
                Properties.Resources.ETIQUETA_GENERAL_ROMPECABEZASFEI, 
                correoDestino, asunto, mensaje);

            switch (servicio.EstadoOperacion) 
            {
                case EstadoOperacion.Correcto:
                    
                    if (!esMensajeEnviado)
                    {
                        GestorCuadroDialogo.MostrarError(
                            "No fue posible enviar el código de verificación al correo, por favor, vuelve a intentarlo", 
                            "Error al enviar el código de verificación");
                    }

                    break;
            }

            return esMensajeEnviado;
        }
    }
}