using System.Security.Cryptography;
using System.Text;

namespace ExamenesUniversidad.Logica.Extensiones
{
    public static class StringExtensiones
    {
        public static string GenerarMD5(this string esteString)
        {
            using (MD5 md5 = MD5.Create())
            {
                var inputBytes = Encoding.UTF8.GetBytes(esteString);
                var hashBytes = md5.ComputeHash(inputBytes);
                var sb = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                return sb.ToString().ToLower();
            }
        }
    }
}
