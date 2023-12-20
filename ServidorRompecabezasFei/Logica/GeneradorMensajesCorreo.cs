using System;
using System.Net.Mail;
using System.Net;
using System.Text;
using log4net;
using Registros;
using System.Runtime.InteropServices;

namespace Logica
{
    public static class GeneradorMensajesCorreo
    {
        private static readonly ILog Log = Registrador.GetLogger();

        public static bool EnviarMensaje(string encabezado, string correoDestino, 
            string asunto, string mensaje)
        {
            bool resultado = true;
            int NumeroPuerto = 587;
            SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com", NumeroPuerto)
            {
                EnableSsl = true
            };

            try
            {
                MailMessage mensajeCorreo = new MailMessage()
                {
                    From = new MailAddress(Properties.Settings.Default.Email, encabezado),
                    Subject = asunto,
                    Body = mensaje,
                    BodyEncoding = Encoding.UTF8,
                    IsBodyHtml = true
                };
                mensajeCorreo.To.Add(correoDestino);

                clienteSmtp.Credentials = new NetworkCredential(
                    Properties.Settings.Default.Email, 
                    Properties.Settings.Default.EmailPassword);
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
