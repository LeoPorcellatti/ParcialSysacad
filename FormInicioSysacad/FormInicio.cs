using System.Configuration;
using LibreriaSysacad;
using Newtonsoft.Json;

namespace FormInicioSysacad
{
    public partial class FormInicio : Form
    {
        private List<Admin> administradores;
        public FormInicio(List <Admin> admin)
        {
            InitializeComponent();         
            administradores = admin;
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {

            string correoIngresado = txtUsuario.Text;
            string claveIngresada = txtClave.Text;

            bool credencialesCorrectas = ValidarCredenciales(correoIngresado, claveIngresada);

            if (credencialesCorrectas)
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
            else
            {
                MessageBox.Show("Datos incorrectos. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarCredenciales(string correo, string clave)
        {
            return administradores.Exists(admin => admin.Correo == correo && admin.Clave == clave);
        }

        private void LimpiarCampos()
        {
            txtUsuario.Text = string.Empty;
            txtClave.Text = string.Empty;
        }
    }
}