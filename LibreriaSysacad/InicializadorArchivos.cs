using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSysacad
{
    public class InicializadorArchivos
    {
        public static List<Admin> InicializarArchivoAdmin(string rutaAdminJson)
        {
            if (!File.Exists(rutaAdminJson))
            {
                ManejadorArchivos.GenerarArchivoAdmin(rutaAdminJson);
            }
            string jsonAdministradores = File.ReadAllText(rutaAdminJson);
            var adminObjects = JsonConvert.DeserializeObject<List<Admin>>(jsonAdministradores);

            return adminObjects;
        }

        public static void InicializarArchivoAlumnos(string rutaAlumnosJson)
        {
            if(!File.Exists(rutaAlumnosJson))
            {
                List<Alumno> alumnos = new List<Alumno>();
                ManejadorArchivos.GenerarArchivoAlumnos(rutaAlumnosJson, alumnos);
            }            
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
        public static List<Alumno> InstanciarAlumno()
        {
            List<Alumno> alumnos = new List<Alumno>();
            return alumnos;
        }
    }
}
