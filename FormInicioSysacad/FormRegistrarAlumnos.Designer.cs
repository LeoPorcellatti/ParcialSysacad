namespace FormInicioSysacad
{
    partial class FormRegistrarAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            btnVolver = new Button();
            btnRegistrar = new Button();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtCorreo = new TextBox();
            txtNumeroDeTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            chkClaveProvisoria = new CheckBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(chkClaveProvisoria);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtNumeroDeTelefono);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(txtDni);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 488);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSlateGray;
            panel3.Controls.Add(btnVolver);
            panel3.Controls.Add(btnRegistrar);
            panel3.Location = new Point(0, 395);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 93);
            panel3.TabIndex = 17;
            // 
            // btnVolver
            // 
            btnVolver.BackgroundImage = Properties.Resources.btnpng;
            btnVolver.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnVolver.ForeColor = SystemColors.ControlText;
            btnVolver.Image = Properties.Resources.btnpng;
            btnVolver.Location = new Point(14, 20);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(127, 57);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegistrar.Image = Properties.Resources.btnpng;
            btnRegistrar.Location = new Point(634, 20);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(127, 57);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._2940653;
            pictureBox3.Location = new Point(605, 168);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(135, 117);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(105, 321);
            label7.Name = "label7";
            label7.Size = new Size(63, 19);
            label7.TabIndex = 12;
            label7.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(105, 280);
            label6.Name = "label6";
            label6.Size = new Size(81, 19);
            label6.TabIndex = 11;
            label6.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(105, 236);
            label5.Name = "label5";
            label5.Size = new Size(90, 19);
            label5.TabIndex = 10;
            label5.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(105, 196);
            label4.Name = "label4";
            label4.Size = new Size(36, 19);
            label4.TabIndex = 9;
            label4.Text = "Dni";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(105, 157);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 8;
            label3.Text = "Apellido";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = SystemColors.InactiveCaption;
            txtCorreo.Cursor = Cursors.IBeam;
            txtCorreo.Location = new Point(246, 317);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(320, 23);
            txtCorreo.TabIndex = 7;
            // 
            // txtNumeroDeTelefono
            // 
            txtNumeroDeTelefono.BackColor = SystemColors.InactiveCaption;
            txtNumeroDeTelefono.Cursor = Cursors.IBeam;
            txtNumeroDeTelefono.Location = new Point(246, 276);
            txtNumeroDeTelefono.Name = "txtNumeroDeTelefono";
            txtNumeroDeTelefono.Size = new Size(320, 23);
            txtNumeroDeTelefono.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = SystemColors.InactiveCaption;
            txtDireccion.Cursor = Cursors.IBeam;
            txtDireccion.Location = new Point(246, 232);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(320, 23);
            txtDireccion.TabIndex = 5;
            // 
            // txtDni
            // 
            txtDni.BackColor = SystemColors.InactiveCaption;
            txtDni.Cursor = Cursors.IBeam;
            txtDni.Location = new Point(246, 192);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(320, 23);
            txtDni.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = SystemColors.InactiveCaption;
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Location = new Point(246, 153);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(320, 23);
            txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.InactiveCaption;
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(246, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(320, 23);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(105, 121);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 100);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.utn;
            pictureBox1.Location = new Point(689, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.utn;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Terminator Two", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(121, 37);
            label1.Name = "label1";
            label1.Size = new Size(537, 21);
            label1.TabIndex = 0;
            label1.Text = "FORMULARIO DE REGISTRO DE ALUMNOS";
            // 
            // chkClaveProvisoria
            // 
            chkClaveProvisoria.AutoSize = true;
            chkClaveProvisoria.Checked = true;
            chkClaveProvisoria.CheckState = CheckState.Checked;
            chkClaveProvisoria.Cursor = Cursors.Hand;
            chkClaveProvisoria.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            chkClaveProvisoria.Location = new Point(317, 356);
            chkClaveProvisoria.Name = "chkClaveProvisoria";
            chkClaveProvisoria.Size = new Size(172, 23);
            chkClaveProvisoria.TabIndex = 18;
            chkClaveProvisoria.Text = "Clave Provisoria";
            chkClaveProvisoria.UseVisualStyleBackColor = true;
            // 
            // FormRegistrarAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 512);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FormRegistrarAlumnos";
            Text = "FormRegistrarAlumnos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox txtCorreo;
        private TextBox txtNumeroDeTelefono;
        private TextBox txtDireccion;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label6;
        private Button button1;
        private PictureBox pictureBox3;
        private Button btnRegistrar;
        private Button btnVolver;
        private Panel panel3;
        private CheckBox chkClaveProvisoria;
    }
}