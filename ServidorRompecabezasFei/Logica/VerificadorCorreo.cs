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
        public const string DISPLAY_NAME = "Rompecabezas FEI";
        public const string BODY = "Tu código de verificación es: ";
        private static readonly ILog Log = Registros.Registros.GetLogger();


        public bool EnviarValidacionCorreo(String toEmail, String affair, int validationCode)
        {
            bool result = true;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            try
            {
                MailMessage mailMessage = new MailMessage()
                {
                    From = new MailAddress(Properties.Settings.Default.Email, DISPLAY_NAME),
                    Subject = affair,
                    Body = $"{BODY} {validationCode}",
                    BodyEncoding = Encoding.UTF8,
                    IsBodyHtml = true
                };
                mailMessage.To.Add(toEmail);

                smtpClient.Credentials = new NetworkCredential(Properties.Settings.Default.Email, Properties.Settings.Default.EmailPassword);
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
            }
            catch (SmtpException ex)
            {
                Log.Error($"{ex.Message}");
                result = false;
            }
            finally
            {
                smtpClient.Dispose();
            }
            return result;
        }
    }
}
