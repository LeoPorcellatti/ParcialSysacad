using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LibreriaSysacad
{
    public class ManejadorArchivos
    {
        public static void GenerarArchivoAdmin(string rutaAdminJson)
        {
            List<Admin> admins = InicializadorArchivos.InstanciarAdmin();
            string adminJson = SerealizarArchivo(admins);

            File.WriteAllText(rutaAdminJson, adminJson);
        }

        public static void GenerarArchivoAlumnos(string rutaAlumnosJson, List<Alumno> alumnos)
        {
            string alumnosJson = SerealizarArchivo(alumnos);
            File.WriteAllText(rutaAlumnosJson, alumnosJson);
        }

        public static void AgregarAlumnosAlArchivo(string rutaAlumnosJson, Alumno nuevoAlumno)
        {
            List<Alumno> alumnosActuales = new List<Alumno>();
            if (File.Exists(rutaAlumnosJson))
            {
                string alumnosContenidos = File.ReadAllText(rutaAlumnosJson);
                alumnosActuales = JsonConvert.DeserializeObject<List<Alumno>>(alumnosContenidos);
            }
            alumnosActuales.Add(nuevoAlumno);
            string listaDeAlumnosActual = SerealizarAlumnos(alumnosActuales);
            File.WriteAllText(rutaAlumnosJson, listaDeAlumnosActual);
        }

        public static List<T> DeserealizarArchivo<T>(string archivo) // PASAR ALUMNO, NO LISTA
        {
            List<T> listaDeserealizada = new List<T>();

            try
            {
                string json = File.ReadAllText(archivo);
                listaDeserealizada = JsonConvert.DeserializeObject<List<T>>(json);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("El archivo no existe.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió a un error al leer el archivo JSON: {ex.Message}");
            }
            return listaDeserealizada;
        }

        public static string SerealizarAlumnos(List<Alumno> listaAlumnos)
        {
            string json = JsonConvert.SerializeObject(listaAlumnos, Formatting.Indented);
            return json;
        }
        public static string SerealizarArchivo<T>(List<T> lista)
        {
            string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
            return json;
        }
    }
}
