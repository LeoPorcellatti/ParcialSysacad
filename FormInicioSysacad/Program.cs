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

            if (!File.Exists(rutaAdminJson))
            {
                ManejadorArchivos.GenerarArchivoAdmin(rutaAdminJson);
            }

            string jsonAdministradores = File.ReadAllText(rutaAdminJson);
            var adminObjects = JsonConvert.DeserializeObject<List<object>>(jsonAdministradores);
            List <Admin> administradores = adminObjects.Select(obj =>
            {
                var adminProps = JsonConvert.DeserializeAnonymousType(obj.ToString(), new { Correo = "", Clave = "" });
                return new Admin(adminProps.Correo, adminProps.Clave);
            }).ToList();

            Application.Run(new FormInicio(administradores));              
        }
    }
}