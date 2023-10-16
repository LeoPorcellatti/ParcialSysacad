using LibreriaSysacad;
using Newtonsoft.Json;
using System.Configuration;

namespace FormInicioSysacad
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            string rutaAdminJson = ConfigurationManager.AppSettings["rutaAdminJson"];
            string rutaAlumnosJson = ConfigurationManager.AppSettings["rutaAlumnosJson"];

            List<Admin> administradores = InicializadorArchivos.InicializarArchivoAdmin(rutaAdminJson);
            InicializadorArchivos.InicializarArchivoAlumnos(rutaAlumnosJson);
            
            Application.Run(new FormInicio(administradores));              
        }
    }
}