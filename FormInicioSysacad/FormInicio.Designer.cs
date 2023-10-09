namespace FormInicioSysacad
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnInicioSesion = new Button();
            txtClave = new TextBox();
            txtUsuario = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnInicioSesion);
            panel1.Controls.Add(txtClave);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(173, 285);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(173, 189);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.Cursor = Cursors.Hand;
            btnInicioSesion.Font = new Font("Terminator Two", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnInicioSesion.Location = new Point(299, 348);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(118, 53);
            btnInicioSesion.TabIndex = 5;
            btnInicioSesion.Text = "Iniciar Sesión";
            btnInicioSesion.UseVisualStyleBackColor = true;
            btnInicioSesion.Click += btnInicioSesion_Click;
            // 
            // txtClave
            // 
            txtClave.BackColor = SystemColors.InactiveCaption;
            txtClave.Cursor = Cursors.IBeam;
            txtClave.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.Location = new Point(212, 285);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(336, 26);
            txtClave.TabIndex = 4;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.InactiveCaption;
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(212, 189);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(336, 26);
            txtUsuario.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(334, 244);
            label4.Name = "label4";
            label4.Size = new Size(70, 24);
            label4.TabIndex = 2;
            label4.Text = "Clave";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(323, 145);
            label3.Name = "label3";
            label3.Size = new Size(94, 24);
            label3.TabIndex = 1;
            label3.Text = "Usuario";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(30, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(708, 88);
            panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.utn;
            pictureBox2.Location = new Point(637, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.utn;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Terminator Two", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(240, 39);
            label2.Name = "label2";
            label2.Size = new Size(196, 29);
            label2.TabIndex = 1;
            label2.Text = "(SYSACAD)";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Terminator Two", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(182, 12);
            label1.Name = "label1";
            label1.Size = new Size(363, 27);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA ACADEMICO ";
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FormInicio";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtUsuario;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtClave;
        private Button btnInicioSesion;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}