using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Controls;
using RompecabezasFei;
using Security;
using NUnit;
using Moq;
using System.Reflection;

namespace Pruebas
{
    [TestClass]
    public class PruebaEncriptarContrasena
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
        public void PruebaEncriptadorContrasena()
        {
            string contrasena = "Xhantusz17@";

            Assert.AreNotEqual(contrasena, EncriptadorContrasena.CalcularHashSha512(contrasena));
        }

        [TestMethod]
        public void PruebaActualizarInformacion()
        {
            var pageMock = new Mock<Page>();

            var nombreUsuarioActual = "Luis";
            var numeroAvatarActual = 3;

            var pagina = new PaginaActualizacionInformacion(nombreUsuarioActual, numeroAvatarActual);

            var nuevoNombreUsuario = "Angel";
            var nuevoNumeroAvatar = 9;

            var metodo = typeof(PaginaActualizacionInformacion).GetMethod("PruebaParaActualizarInformacion", BindingFlags.NonPublic | BindingFlags.Instance);
            metodo.Invoke(pagina, new object[] { nuevoNombreUsuario, nuevoNumeroAvatar });

            //Assert.AreEqual(nuevoNombreUsuario, pagina.Dominio.CuentaJugador.Actual.NombreJugador);
            //Assert.AreEqual(nuevoNumeroAvatar, pagina.Dominio.CuentaJugador.Actual.NumeroAvatar);

        }


    }
}
