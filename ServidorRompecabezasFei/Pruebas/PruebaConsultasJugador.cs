using Logica;
using Logica.AccesoDatos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity.Core;

namespace Pruebas
{
    [TestClass]
    public class PruebaConsultasJugador
    {
        private TestContext instanciaContextoPrueba;

        public TestContext ContextoPrueba
        {
            get { return instanciaContextoPrueba; }
            set { instanciaContextoPrueba = value; }
        }

        [TestMethod]
        [DataRow("Kendrick")]
        [DataRow("Drake")]
        public void ExisteNombreJugador_CuandoElNombreExiste_DebeIndicarExistencias(
            string nombreJugador)
        {
            bool existeNombreJugador;

            try
            {
                existeNombreJugador = AccesoJugador.ExisteNombreJugadorRegistrado(nombreJugador);
            }
            catch (EntityException)
            {
                existeNombreJugador = false;
            }

            Assert.AreEqual(true, existeNombreJugador);
        }

        [TestMethod]
        public void ExisteNombreJugadorFallo()
        {
            string nombreJugador = "";
            bool existeNombreJugador;

            try
            {
                existeNombreJugador = AccesoJugador.ExisteNombreJugadorRegistrado(nombreJugador);
            }
            catch (EntityException)
            {
                existeNombreJugador = false;
            }
            Assert.AreNotEqual(true, existeNombreJugador, "El nombre de jugador no existe");
        }

        [TestMethod]
        public void ExisteCorreoElectronicoExito()
        {
            string correoElectronico = "zs21013902@estudiantes.uv.mx";
            bool existeCorreo;

            try
            {
                existeCorreo = AccesoJugador.ExisteCorreoRegistrado(correoElectronico);
            }
            catch (EntityException)
            {
                existeCorreo = false;
            }
            Assert.AreEqual(true, existeCorreo, "El correo electrónico existe");
        }

        [TestMethod]
        public void ExisteCorreoElectronicoFallo()
        {
            string correoElectronico = "";
            bool existeCorreo;

            try
            {
                existeCorreo = AccesoJugador.ExisteCorreoRegistrado(correoElectronico);
            }
            catch (EntityException)
            {
                existeCorreo = false;
            }
            Assert.AreNotEqual(true, existeCorreo, "El correo electrónico no existe");
        }

        [TestMethod]
        public void ObtenerNumeroPartidasJugadasExito()
        {
            string nombreJugador = "Sam";
            int numeroPartidasJugadas = AccesoJugador.
                 ObtenerNumeroPartidasJugadasDeJugador(nombreJugador);
            Assert.AreEqual(0, numeroPartidasJugadas, "Se ha obtenido el número de partidas");
        }

        [TestMethod]
        public void ObtenerNumeroPartidasJugadasFallo()
        {
            string nombreJugador = "";
            int numeroPartidasJugadas = AccesoJugador.
                 ObtenerNumeroPartidasJugadasDeJugador(nombreJugador);
            Assert.AreNotEqual(10, numeroPartidasJugadas, "No se ha obtenido el número de partidas");
        }
    }
}
