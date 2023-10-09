using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSysacad
{
    public class Claves
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
    }
}
