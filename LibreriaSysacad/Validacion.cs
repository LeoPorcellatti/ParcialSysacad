using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibreriaSysacad
{
    public class Validacion
    {

        public static bool ValidarVacio(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return false;
            }
            return true;
        }

        public static bool ValidarString(string texto)
        {
            if (!ValidarVacio(texto))
            {
                return false;
            }
            return Regex.IsMatch(texto, @"^[a-zA-Z]+$");
        }

        public static bool ValidarCorreo(string correo)
        {
            if(!ValidarVacio(correo))
            {
                return false;
            }
            return Regex.IsMatch(correo, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$");
        }

        public static bool ValidarDni(string dni)
        {
            if(!ValidarVacio(dni))
            {
                return false;
            }

            return Regex.IsMatch(dni, @"\d{8}$");
        }

        public static bool ValidarTelefono(string numeroDeTelefono)
        {
            if (!ValidarVacio(numeroDeTelefono))
            {
                return false;
            }
            return Regex.IsMatch(numeroDeTelefono, @"^\d{8,10}$");
        }

        public static bool ValidarCasillasVaciasAlumno(
            string nombre, 
            string apellido, 
            string dni, 
            string direccion, 
            string numeroDeTelefono, 
            string correo
            )
        {
            if (!ValidarVacio(nombre) || !ValidarVacio(apellido) || !ValidarVacio(dni) || !ValidarVacio(direccion) ||
            !ValidarVacio(numeroDeTelefono) || !ValidarVacio(correo))
            {
                return false;
            }
            return true;
        }        
    }
}
