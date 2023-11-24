using System;
using System.Windows;

namespace RompecabezasFei.Utilidades
{
    public static class GestionadorCodigoCorreo
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
            string mensajeBase = $"{mensaje} {CodigoGenerado}";
            bool resultado = Servicios.ServicioCorreo.EnviarMensajeACorreoElectronico(
                Properties.Resources.ETIQUETA_GENERAL_ROMPECABEZASFEI, correoDestino,
                asunto, mensajeBase);

            return resultado;
        }
    }
}