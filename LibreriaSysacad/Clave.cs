using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSysacad
{
    public class Clave
    {
        public static string GenerarClaves()
        {
            string clave = string.Empty;
            int longitudClave = 8;
            Random random = new Random();

            char[] codigo = new char[longitudClave];
            for (int i = 0; i < longitudClave; i++)
            {
                int valorAscii = random.Next(41, 126);
                codigo[i] = (char)valorAscii;
            }
            clave = new string (codigo);
            return clave;
        }

        public static string GetHash(string password)
        {
            var hash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 8);

            return hash;
        }

        public static bool ValidatePassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(password, hash);
        }
    }
}
