using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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

        public Alumno() : base("", "")
        {

        }
        [JsonConstructor]
        
        public Alumno(int legajo, string nombre, string apellido, string correo, string clave, string direccion, string numeroDeTelefono, string dni) : base(correo, clave)
        {
            _legajo = legajo;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _numeroDeTelefono = numeroDeTelefono;
            _dni = dni;
        }

        // [JsonIgnore] > OCULTAR BOOL CAMBIO CLAVE
        public int Legajo { get { return _legajo; } set { _legajo = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public string Direccion { get { return _direccion; } set { _direccion = value; } }
        public string numeroDeTelefono { get { return _numeroDeTelefono; } set { _numeroDeTelefono = value; } }
        public string Dni { get { return _dni; } set { _dni = value; } }
    }
}

