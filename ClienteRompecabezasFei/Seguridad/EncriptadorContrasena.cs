using System;
using System.Security.Cryptography;
using System.Text;

namespace Security
{
    public class EncriptadorContrasena
    {
        public static string CalcularHashSha512(string entrada)
        {
            var contrasenaEncriptada = "";
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] hash = sha512.ComputeHash(Encoding.UTF8.GetBytes(entrada));
                contrasenaEncriptada = BitConverter.ToString(hash)
                    .Replace("-", string.Empty)
                    .ToLowerInvariant();
            }
            return contrasenaEncriptada;
        }
    }
}
