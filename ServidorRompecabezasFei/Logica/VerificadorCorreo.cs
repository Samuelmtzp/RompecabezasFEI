using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using log4net;
using System.Net;
using Registros;

namespace Logica
{
    public class VerificadorCorreo
    {
        public const string ENCABEZADO = "Rompecabezas FEI";
        public const string CUERPO = "Tu código de verificación es: ";
        private static readonly ILog Log = Registros.Registros.GetLogger();


        public bool EnviarValidacionCorreo(String correoDestino, String asunto, int codigoValidacion)
        {
            bool resultado = true;
            SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com", 587);

            try
            {
                MailMessage mensajeCorreo = new MailMessage()
                {
                    From = new MailAddress(Properties.Settings.Default.Email, ENCABEZADO),
                    Subject = asunto,
                    Body = $"{CUERPO} {codigoValidacion}",
                    BodyEncoding = Encoding.UTF8,
                    IsBodyHtml = true
                };
                mensajeCorreo.To.Add(correoDestino);

                clienteSmtp.Credentials = new NetworkCredential(Properties.Settings.Default.Email, Properties.Settings.Default.EmailPassword);
                clienteSmtp.EnableSsl = true;
                clienteSmtp.Send(mensajeCorreo);
            }
            catch (SmtpException ex)
            {
                Log.Error($"{ex.Message}");
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
