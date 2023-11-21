using System;
using System.Security.Cryptography;
using System.Text;

namespace Security
{
    public static class EncriptadorContrasena
    {
        public static string CalcularHashSha512(string entrada)
        {
            var contrasenaHasheada = "";

            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] hash = sha512.ComputeHash(Encoding.UTF8.GetBytes(entrada));
                contrasenaHasheada = BitConverter.ToString(hash)
                    .Replace("-", string.Empty)
                    .ToLowerInvariant();
            }

            return contrasenaHasheada;
        }
    }
}