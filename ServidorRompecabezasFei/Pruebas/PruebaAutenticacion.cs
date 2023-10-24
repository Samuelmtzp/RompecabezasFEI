using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pruebas
{
    [TestClass]
    public class PruebaAutenticacion
    {
        public PruebaAutenticacion()
        {
        }

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
            string nombreUsuario = "KrmaL";
            string contrasena = "537c35589388e5c4eff4a2568b5f27bf9937fc83bbdd168bcbd26b7bbd4fe2" +
                "44c2ef82546217b4cbc1d54c3947654c8f04e70cc96b472d9d69fbc6250ee353dc";

            Logica.Autenticacion servicioAutenticacion = new Logica.Autenticacion();

            Logica.CuentaJugador jugadorEsperado = new Logica.CuentaJugador()
            {
                IdJugador = 4,
                NombreJugador = "KrmaL",
                Correo = "zs21013902@estudiantes.uv.mx",
                Contrasena = "",
                IdCuenta = 4,
                NumeroAvatar = 1,
            };
            Logica.CuentaJugador jugadorResultado = servicioAutenticacion.IniciarSesion(nombreUsuario,
                contrasena);

            Assert.AreEqual(jugadorEsperado.ToString(), jugadorResultado.ToString(),
                "Jugadores con mismos datos");
        }

        [TestMethod]
        public void PruebaInicioSesionFallo()
        {
            string nombreUsuario = "KrmaL";
            string contrasena = "2342vcdxvzsd";

            Logica.Autenticacion servicioAutenticacion = new Logica.Autenticacion();

            Logica.CuentaJugador jugadorEsperado = new Logica.CuentaJugador()
            {
                IdJugador = 1,
                NombreJugador = "Sam",
                Correo = "smp_pz@gmail.com",
                Contrasena = "",
                IdCuenta = 1,
                NumeroAvatar = 1,
            };
            Logica.CuentaJugador jugadorResultado = servicioAutenticacion.IniciarSesion(nombreUsuario,
                contrasena);

            Assert.AreNotEqual(jugadorEsperado.ToString(), jugadorResultado.ToString(),
                "Jugadores con datos diferentes");
        }
    }
}