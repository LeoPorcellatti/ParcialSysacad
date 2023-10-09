using System.Configuration;
using LibreriaSysacad;
using Newtonsoft.Json;

namespace FormInicioSysacad
{
    public partial class FormInicio : Form
    {
        private List<Admin> administradores;
        public FormInicio()
        {
            InitializeComponent();

            string rutaAdminJson = ConfigurationManager.AppSettings["rutaAdminJson"];
            if (!File.Exists(rutaAdminJson))
            {
                ManejadorDeArchivos.GenerarArchivoAdmin(rutaAdminJson);
            }

            string jsonAdministradores = File.ReadAllText(rutaAdminJson);
            var adminObjects = JsonConvert.DeserializeObject<List<object>>(jsonAdministradores);
            administradores = adminObjects.Select(obj =>
            {
                var adminProps = JsonConvert.DeserializeAnonymousType(obj.ToString(), new { Correo = "", Clave = "" });
                return new Admin(adminProps.Correo, adminProps.Clave);
            }).ToList();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {

            string correoIngresado = txtUsuario.Text;
            string claveIngresada = txtClave.Text;

            bool credencialesCorrectas = ValidarCredenciales(correoIngresado, claveIngresada);

            if (credencialesCorrectas)
            {
                FormAdmin formularioAdmin = new FormAdmin();
                formularioAdmin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos incorrectos. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarCredenciales(string correo, string clave)
        {
            return administradores.Exists(admin => admin.Correo == correo && admin.Clave == clave);
        }
    }
}