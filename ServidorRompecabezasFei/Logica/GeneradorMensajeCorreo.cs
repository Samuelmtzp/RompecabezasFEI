using System;
using System.Net.Mail;
using System.Net;
using System.Text;
using log4net;
using Registros;
using System.Runtime.InteropServices;

namespace Logica
{
    public static class GeneradorMensajeCorreo
    {
        private static readonly ILog Log = Registrador.GetLogger();
        private static readonly int NumeroDePuerto = 587;
        private static readonly string Servidor = "smtp.gmail.com";

        public static bool EnviarMensaje(string encabezado, string correo, string asunto, 
            string mensaje)
        {
            bool resultado = true;
            SmtpClient clienteSmtp = new SmtpClient(Servidor, NumeroDePuerto)
            {
                EnableSsl = true
            };

            try
            {
                MailMessage mensajeCorreo = new MailMessage()
                {
                    From = new MailAddress(Properties.Configuration.Default.Correo, encabezado),
                    Subject = asunto,
                    Body = mensaje,
                    BodyEncoding = Encoding.UTF8,
                    IsBodyHtml = true
                };
                mensajeCorreo.To.Add(correo);

                clienteSmtp.Credentials = new NetworkCredential(
                    Properties.Configuration.Default.Correo, 
                    Properties.Configuration.Default.ContrasenaCorreo);
                clienteSmtp.EnableSsl = true;
                clienteSmtp.Send(mensajeCorreo);                
            }
            catch (ArgumentException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                resultado = false;
            }
            catch (SmtpException excepcion)
            {
                Registros.Registrador.EscribirRegistro(excepcion);
                resultado = false;
            }
            finally
            {
                clienteSmtp.Dispose();
            }
            return resultado;
        }
    }
}