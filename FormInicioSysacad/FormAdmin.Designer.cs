namespace FormInicioSysacad
{
    partial class FormAdmin
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
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnCerrarSesion = new Button();
            btnRegistros = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 426);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Terminator Two", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(413, 13);
            label2.Name = "label2";
            label2.Size = new Size(132, 21);
            label2.TabIndex = 2;
            label2.Text = "SYSACAD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Terminator Two", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(357, 48);
            label1.Name = "label1";
            label1.Size = new Size(258, 21);
            label1.TabIndex = 1;
            label1.Text = "FORMULARIO ADMIN";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(btnCerrarSesion);
            panel2.Controls.Add(btnRegistros);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 426);
            panel2.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackgroundImage = Properties.Resources.btnpng;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = Color.MidnightBlue;
            btnCerrarSesion.Location = new Point(0, 376);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(194, 50);
            btnCerrarSesion.TabIndex = 1;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnRegistros
            // 
            btnRegistros.BackgroundImage = Properties.Resources.btnpng;
            btnRegistros.Cursor = Cursors.Hand;
            btnRegistros.Dock = DockStyle.Top;
            btnRegistros.FlatStyle = FlatStyle.Flat;
            btnRegistros.Font = new Font("Consolas", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegistros.ForeColor = Color.MidnightBlue;
            btnRegistros.Location = new Point(0, 0);
            btnRegistros.Name = "btnRegistros";
            btnRegistros.Size = new Size(194, 50);
            btnRegistros.TabIndex = 0;
            btnRegistros.Text = "Registrar Alumnos";
            btnRegistros.UseVisualStyleBackColor = true;
            btnRegistros.Click += btnRegistros_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FormAdmin";
            Text = "FormAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button btnRegistros;
        private Button btnCerrarSesion;
    }
}