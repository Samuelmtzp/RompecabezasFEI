using Logica;
using Logica.AccesoDatos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebaAutenticacion
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
        public void PruebaInicioSesionExito()
        {
            string nombreUsuario = "Sam";
            string contrasena = "537c35589388e5c4eff4a2568b5f27bf9937fc83bbdd168bcbd26b7bbd4fe" +
                "244c2ef82546217b4cbc1d54c3947654c8f04e70cc96b472d9d69fbc6250ee353dc";

            CuentaJugador cuentaJugadorEsperada = new CuentaJugador()
            {
                NombreJugador = "Sam",
                Correo = "zs21013902@estudiantes.uv.mx",
                Contrasena = "537c35589388e5c4eff4a2568b5f27bf9937fc83bbdd168bcbd26b7bbd4fe" + 
                "244c2ef82546217b4cbc1d54c3947654c8f04e70cc96b472d9d69fbc6250ee353dc",
                NumeroAvatar = 3,
            };
            CuentaJugador cuentaJugadorResultado = AccesoCuentaJugador.IniciarSesion(nombreUsuario,
                contrasena);

            Assert.AreEqual(cuentaJugadorEsperada.ToString(), cuentaJugadorResultado.ToString(),
                "Jugadores con mismos datos");
        }

        [TestMethod]
        public void PruebaInicioSesionFallo()
        {
            string nombreUsuario = "Sam";
            string contrasena = "";

            CuentaJugador jugadorEsperado = new CuentaJugador()
            {
                NombreJugador = "Sam",
                Correo = "zs21013902@estudiantes.uv.mx",
                Contrasena = "",
                NumeroAvatar = 3,
            };
            CuentaJugador jugadorResultado = AccesoCuentaJugador.IniciarSesion(nombreUsuario,
                contrasena);

            Assert.AreNotEqual(jugadorEsperado.ToString(), jugadorResultado.ToString(),
                "Jugadores con datos diferentes");
        }
    }
}