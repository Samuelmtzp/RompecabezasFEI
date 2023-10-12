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

            Logica.Jugador jugadorEsperado = new Logica.Jugador()
            {
                IdJugador = 4,
                NombreJugador = "KrmaL",
                Correo = "samuel__martinez@hotmail.com",
                Contrasena = "",
                IdUsuario = 4,
                NumeroAvatar = 1,
            };
            Logica.Jugador jugadorResultado = servicioAutenticacion.IniciarSesion(nombreUsuario,
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

            Logica.Jugador jugadorEsperado = new Logica.Jugador()
            {
                IdJugador = 1,
                NombreJugador = "Sam",
                Correo = "smp_pz@gmail.com",
                Contrasena = "",
                IdUsuario = 1,
                NumeroAvatar = 1,
            };
            Logica.Jugador jugadorResultado = servicioAutenticacion.IniciarSesion(nombreUsuario,
                contrasena);

            Assert.AreNotEqual(jugadorEsperado.ToString(), jugadorResultado.ToString(),
                "Jugadores con datos diferentes");

        }

        //[TestMethod]
        //public void TestUpdatePlayerPasswordSuccess()
        //{
        //    string password = "dca06bc0c345b4da28521920b59492b505b1f9c40becfda89b4689b2cffb903986f36ed36a24c3213acf10025d6bff116898dea14a28d2db259bc0ecb331b75e";
        //    string email = "nothanks364@outlook.com";

        //    Authentication authentication = new Authentication();

        //    var result = authentication.UpdatePlayerPassword(password, email);

        //    Assert.IsTrue(result, $"Contraseña actualizada");
        //}

        //[TestMethod]
        //public void TestUpdatePlayerPasswordFailure()
        //{
        //    string password = "3c9909afec25354d551dae21590bb26e38d53f2173b8d3dc3eee4c047e7ab1c1eb8b85103e3be7ba613b31bb5c9c36214dc9f14a42fd7a2fdb84856bca5c44c2";
        //    string email = "nothanks";

        //    Authentication authentication = new Authentication();

        //    var result = authentication.UpdatePlayerPassword(password, email);

        //    Assert.IsFalse(result, "Contraseña NO Actualizada");
        //}

        //[TestMethod]
        //public void TestUpdatePlayerNicknameSuccess()
        //{
        //    string nickname = "Panther";
        //    string updatedNickname = "Licuadora";

        //    Authentication authentication = new Authentication();

        //    var result = authentication.UpdatePlayerNickname(nickname, updatedNickname);

        //    Assert.IsTrue(result, $"Nickname actualizado");
        //}

        //[TestMethod]
        //public void TestUpdatePlayerNicknameFailure()
        //{
        //    string nickname = "";
        //    string updatedNickname = "UsuarioInexistente";

        //    Authentication authentication = new Authentication();

        //    var result = authentication.UpdatePlayerNickname(nickname, updatedNickname);

        //    Assert.IsFalse(result, $"Nickname NO actualizado");
        //}

        //[TestMethod]
        //public void TestSaveImageSuccess()
        //{
        //    int playerId = 1;
        //    string image = "nina";

        //    Authentication authentication = new Authentication();

        //    var result = authentication.SaveImage(image, playerId);

        //    Assert.IsTrue(result, $"Imagen guardada");
        //}

        //[TestMethod]
        //public void TestImageSaveFailure()
        //{
        //    int playerId = 1;
        //    string image = "ola";

        //    Authentication authentication = new Authentication();

        //    var result = authentication.SaveImage(image, playerId);

        //    Assert.IsFalse(result, $"Imagen NO guardada");
        //}
    }
}