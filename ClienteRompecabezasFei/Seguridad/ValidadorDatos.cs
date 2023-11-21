using System;
using System.Text.RegularExpressions;

namespace Seguridad
{
    public class ValidadorDatos
    {
        private const int MaximoCaracteresContrasena = 45;
        private const int MaximoCaracteresCorreo = 65;
        private const int MaximoCaracteresNombreJugador = 15;
        private const int MilisegundosMaximosParaExpresionRegular = 100;
        private const string PatronContrasena = "^(?=\\w*\\d)(?=\\w*[A-Z])(?=\\w*[a-z])\\S{8,}$";
        private const string PatronNombreJugador = @"^[a-zA-Z0-9]+(?:\s[a-zA-Z0-9]+)?$";
        private const string PatronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        public static bool ExisteLongitudExcedidaEnContrasena(string contrasena)
        {
            bool camposExcedidos = false;

            if (contrasena.Length > MaximoCaracteresContrasena)
            {
                camposExcedidos = true;
            }

            return camposExcedidos;
        }

        public static bool ExisteLongitudExcedidaEnCorreo(string correo)
        {
            bool camposExcedidos = false;

            if (correo.Length > MaximoCaracteresCorreo)
            {
                camposExcedidos = true;
            }

            return camposExcedidos;
        }

        public static bool ExisteLongitudExcedidaEnNombreJugador(string nombreJugador)
        {
            bool camposExcedidos = false;

            if (nombreJugador.Length > MaximoCaracteresNombreJugador)
            {
                camposExcedidos = true;
            }

            return camposExcedidos;
        }

        public static bool ExistenCaracteresInvalidosParaContrasena(string contrasena)
        {
            bool contrasenaInvalida = false;

            if (Regex.IsMatch(contrasena, PatronContrasena, RegexOptions.None,
                TimeSpan.FromMilliseconds(MilisegundosMaximosParaExpresionRegular)) == false)
            {
                contrasenaInvalida = true;
            }

            return contrasenaInvalida;
        }

        public static bool ExistenCaracteresInvalidosParaNombreJugador(string nombreJugador)
        {
            bool resultado = false;

            if (Regex.IsMatch(nombreJugador, PatronNombreJugador, RegexOptions.None,
                TimeSpan.FromMilliseconds(MilisegundosMaximosParaExpresionRegular)) == false)
            {
                resultado = true;
            }

            return resultado;
        }

        public static bool ExistenCaracteresInvalidosParaCorreo(string correo)
        {
            bool resultado = false;

            if (Regex.IsMatch(correo, PatronCorreo, RegexOptions.None, 
                TimeSpan.FromMilliseconds(MilisegundosMaximosParaExpresionRegular)) == false)
            {
                resultado = true;
            }

            return resultado;
        }

        public static bool EsCadenaVacia(string cadena)
        {
            bool resultado = false;

            if (string.IsNullOrWhiteSpace(cadena))
            {
                resultado = true;
            }

            return resultado;
        }

        public static bool ExisteCoincidenciaEnCadenas(string cadenaA, string cadenaB)
        {
            bool resultado = false;

            if (cadenaA == cadenaB)
            {
                resultado = true;
            }

            return resultado;
        }
    }
}
