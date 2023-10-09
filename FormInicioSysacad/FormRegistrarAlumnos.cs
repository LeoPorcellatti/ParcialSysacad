﻿using LibreriaSysacad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormInicioSysacad
{
    public partial class FormRegistrarAlumnos : Form
    {
        private List<Alumno> alumnos;
        string rutaAlumnosJson = ConfigurationManager.AppSettings["rutaAlumnosJson"];
        public FormRegistrarAlumnos()
        {
            InitializeComponent();
            alumnos = ManejadorDeArchivos.DeserealizarArchivo<Alumno>(rutaAlumnosJson);
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            string direccion = txtDireccion.Text;
            string numeroDeTelefono = txtNumeroDeTelefono.Text;
            string correo = txtCorreo.Text;
            string clave = Claves.GenerarClaves();

            if (!Validaciones.ValidarCasillasVaciasAlumno(nombre, apellido, dni, direccion, numeroDeTelefono, correo))
            {
                MessageBox.Show("Revisa los casilleros incompletos.");
                return;
            }
            if (!Validaciones.ValidarDni(dni))
            {
                MessageBox.Show("Ingrese los 8 Dígitos de su DNI.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Validaciones.ValidarTelefono(numeroDeTelefono))
            {
                MessageBox.Show("Revise el número de teléfono ingresado, el mismo debe contar con entre 8 y 10 dígitos", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Validaciones.ExisteDniAlumno(alumnos, dni))
            {
                MessageBox.Show("DNI ya existente", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Validaciones.ExisteCorreoAlumno(alumnos, correo))
            {
                MessageBox.Show("Correo ya existente", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int legajo = ObtenerUltimoLegajo();

            Alumno nuevoAlumno = Admin.RegistrarAlumno(legajo, nombre, apellido, dni, direccion, numeroDeTelefono, correo, clave);
            alumnos.Add(nuevoAlumno);

            ManejadorDeArchivos.GenerarArchivoAlumnos(rutaAlumnosJson, nuevoAlumno);

            MessageBox.Show("Alumno registrado exitosamente.");

            DialogResult respuesta = MessageBox.Show("¿Dese cargar otro alumno?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                LimpiarCampos();
            }
            else
            {
                this.Close();
            }
        }
        private int ObtenerUltimoLegajo()
        {
            if (alumnos.Count == 0)
            {
                return 1;
            }
            else
            {
                int ultimoLegajo = alumnos.Max(alumno => alumno.Legajo);
                return ultimoLegajo + 1;
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtNumeroDeTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
        }
    }
}
