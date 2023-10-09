using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibreriaSysacad
{
    public class Admin : Usuario
    {
        private string _idAdmin;
        private string _nombre;
        private string _apellido;

        public Admin(string correo, string clave) : base(correo, clave)
        {

        }
        public Admin(string idAdmin, string nombre, string apellido, string correo, string clave) : base(correo, clave)
        {
            _idAdmin = idAdmin;
            _nombre = nombre;
            _apellido = apellido;
        }
        public static List<Admin> InstanciarAdmin()
        {

            Admin adminPrincipal = new Admin("admin@admin.com", "12345");
            List<Admin> admins = new List<Admin>
            {
                adminPrincipal
            };

            return admins;
        }
        public static Alumno RegistrarAlumno(int legajo, string nombre, string apellido, string dni, string direccion, string numeroDeTelefono, string correo, string clave)
        {
            Alumno nuevoAlumno = new Alumno(legajo, nombre, apellido, correo, clave, direccion, numeroDeTelefono, dni);
            return nuevoAlumno;
        }
    }
}

