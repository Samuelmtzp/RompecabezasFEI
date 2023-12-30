using Logica;
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

            bool estado = GeneradorMensajeCorreo.EnviarMensaje(
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

            bool estado = GeneradorMensajeCorreo.EnviarMensaje(
                encabezado, correoDestino, asunto, mensaje);
            Assert.AreNotEqual(true, estado, "No se ha enviado el mensaje al correo electrónico");
        }
    }
}