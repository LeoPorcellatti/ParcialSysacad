using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormInicioSysacad
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            FormRegistrarAlumnos formularioRegistroAlumnos = new FormRegistrarAlumnos();
            formularioRegistroAlumnos.FormClosed += (s, args) =>
            {
                this.Enabled = true;
            };
            formularioRegistroAlumnos.Show();
            this.Enabled = false;
        }
    }
}
