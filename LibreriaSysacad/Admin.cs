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
        private int _idAdmin;
        private string _nombre;
        private string _apellido;

        [JsonConstructor]
        public Admin(string correo, string clave) : base(correo, clave)
        {

        }
        public Admin(int idAdmin, string nombre, string apellido, string correo, string clave) : base(correo, clave)
        {
            _idAdmin = idAdmin;
            _nombre = nombre;
            _apellido = apellido;
        }

        public static Alumno RegistrarAlumno(int legajo, string nombre, string apellido, string dni, string direccion, string numeroDeTelefono, string correo, string clave, bool claveProvisoria)
        {
            Alumno nuevoAlumno = new Alumno(legajo, nombre, apellido, correo, clave, direccion, numeroDeTelefono, dni, claveProvisoria);
            return nuevoAlumno;
        }
    }
}

