using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebaGeneradorMensajes
    {
        private TestContext instanciaContextoPrueba;

        public TestContext ContextoPrueba
        {
            get
            {
                return instanciaContextoPrueba;
            }
            set
            {
                instanciaContextoPrueba = value;
            }
        }

        [TestMethod]
        public void EnviarMensajeCorreoExito()
        {
            string encabezado = "ROMPEZABEZAS FEI";
            string correoDestino = "zs21013902@estudiantes.uv.mx";
            string asunto = "Código de verificación para concluir registro";
            string mensaje = "Tu código de verificación es: 561372";

            Logica.GeneradorMensajesCorreo generadorMensajesCorreo = new Logica.GeneradorMensajesCorreo();
            bool estado = generadorMensajesCorreo.EnviarMensaje(
                encabezado, correoDestino, asunto, mensaje);
            Assert.AreEqual(true, estado, "Mensaje enviado a correo electrónico");   
        }

        [TestMethod]
        public void EnviarMensajeCorreoFallo()
        {
            string encabezado = "";
            string correoDestino = "";
            string asunto = "";
            string mensaje = "";

            Logica.GeneradorMensajesCorreo generadorMensajesCorreo = new Logica.GeneradorMensajesCorreo();
            bool estado = generadorMensajesCorreo.EnviarMensaje(
                encabezado, correoDestino, asunto, mensaje);
            Assert.AreNotEqual(true, estado, "No se ha enviado el mensaje al correo electrónico");
        }
    }
}