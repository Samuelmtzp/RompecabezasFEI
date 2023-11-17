using System;

namespace RompecabezasFei.Utilidades
{
    public class GestionadorCodigoCorreo
    {
        private const int MinimoNumeroAleatorio = 100000;
        private const int MaximoNumeroAleatorio = 1000000;
        private static string codigoGenerado;

        public static string CodigoGenerado
        {
            get { return codigoGenerado; }
            set { codigoGenerado = value; }
        }

        private static string GenerarNuevoCodigoConfirmacion()
        {
            Random generadorNumeroAleatorio = new Random();

            return generadorNumeroAleatorio.Next(MinimoNumeroAleatorio, 
                MaximoNumeroAleatorio).ToString();
        }

        public static bool EnviarNuevoCodigoDeVerificacionACorreo(string correoDestino, 
            string asunto, string mensaje)
        {
            codigoGenerado = GenerarNuevoCodigoConfirmacion();
            bool resultado = Servicios.ServicioCorreo.EnviarMensajeACorreoElectronico(
                Properties.Resources.ETIQUETA_GENERAL_ROMPECABEZASFEI, correoDestino,
                asunto, mensaje);

            return resultado;
        }
    }
}