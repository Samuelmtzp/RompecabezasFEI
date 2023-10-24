﻿using log4net;
using System;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace Logica
{
    public class GeneradorMensajesCorreo
    {
        public bool EnviarMensaje(string encabezado, string correoDestino, 
            string asunto, string mensaje)
        {
            bool resultado = true;
            int NumeroPuerto = 587;
            SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com", NumeroPuerto);
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

                clienteSmtp.Credentials = new NetworkCredential(Properties.Settings.Default.Email, Properties.Settings.Default.EmailPassword);
                clienteSmtp.EnableSsl = true;
                clienteSmtp.Send(mensajeCorreo);                
            }
            catch (SmtpException)
            {
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