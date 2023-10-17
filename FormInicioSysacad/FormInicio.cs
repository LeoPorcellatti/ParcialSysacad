using System.Configuration;
using LibreriaSysacad;
using Newtonsoft.Json;

namespace FormInicioSysacad
{
    public partial class FormInicio : Form
    {
        private List<Admin> administradores;
        private List<Alumno> alumnos;
        public FormInicio(List <Admin> admin)
        {
            InitializeComponent();         
            administradores = admin;

            string rutaAlumnosJson = ConfigurationManager.AppSettings["rutaAlumnosJson"];
            alumnos = ManejadorArchivos.DeserealizarArchivo<Alumno>(rutaAlumnosJson);
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {

            string correoIngresado = txtUsuario.Text;
            string claveIngresada = txtClave.Text;

            string tipoUsuario = ValidarCredenciales(correoIngresado, claveIngresada);
            if (tipoUsuario == "admin") 
            {
                FormAdmin formularioAdmin = new FormAdmin();
                formularioAdmin.FormClosed += (s, args) =>
                {
                    this.Enabled = true;
                };
                formularioAdmin.Show();
                this.Enabled = false;
                LimpiarCampos();
            }
            else if (tipoUsuario == "alumno")
            {
                FormAlumno formularioAlumno = new FormAlumno();
                formularioAlumno.FormClosed += (s, args) =>
                {
                    this.Enabled = true;
                };
                formularioAlumno.Show();
                this.Enabled = false;
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Datos incorrectos. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ValidarCredenciales(string correo, string clave)
        {
            if (administradores.Exists(admin => admin.Correo == correo && admin.Clave == clave))
            {
                return "admin";
            }
            else if (alumnos.Exists(alumno => alumno.Correo == correo && Clave.ValidatePassword(clave, alumno.Clave)))
            {
                return "alumno";
            }
            return "desconocido";
        }
        private void LimpiarCampos()
        {
            txtUsuario.Text = string.Empty;
            txtClave.Text = string.Empty;
        }
    }
}