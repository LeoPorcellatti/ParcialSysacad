using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace LibreriaSysacad
{    
    public class Alumno : Usuario
    {
        private int _legajo;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _numeroDeTelefono;
        private string _dni;
        private bool _claveProvisoria;

        public Alumno() : base("", "")
        {

        }
        [JsonConstructor]
        
        public Alumno(int legajo, string nombre, string apellido, string correo, string clave, string direccion, string numeroDeTelefono, string dni, bool claveProvisoria) : base(correo, clave)
        {
            _legajo = legajo;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _numeroDeTelefono = numeroDeTelefono;
            _dni = dni;
            _claveProvisoria = claveProvisoria;
        }

        public static bool ExisteDniAlumno(List<Alumno> alumnos, string dni)
        {
            return alumnos.Any(alu => alu.Dni == dni);
        }

        public static bool ExisteCorreoAlumno(List<Alumno> alumnos, string correo)
        {
            return alumnos.Any(alu => alu.Correo == correo);
        }

        public int Legajo { get { return _legajo; } set { _legajo = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public string Direccion { get { return _direccion; } set { _direccion = value; } }
        public string numeroDeTelefono { get { return _numeroDeTelefono; } set { _numeroDeTelefono = value; } }
        public string Dni { get { return _dni; } set { _dni = value; } }
        [JsonIgnore]
        public bool ClaveProvisoria { get { return _claveProvisoria; } set { _claveProvisoria = value; } }
    }
}

