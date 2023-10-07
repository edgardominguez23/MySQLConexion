namespace MySQLConexion
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnConectar = new Button();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            txtHost = new TextBox();
            txtBaseDatos = new TextBox();
            txtPuerto = new TextBox();
            dgvDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 44);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 95);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 147);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "Host:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 197);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 3;
            label4.Text = "Base de datos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 249);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 4;
            label5.Text = "Puerto:";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(165, 328);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(227, 34);
            btnConectar.TabIndex = 5;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(165, 44);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(227, 31);
            txtUsuario.TabIndex = 6;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(165, 92);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(227, 31);
            txtContrasena.TabIndex = 7;
            // 
            // txtHost
            // 
            txtHost.Location = new Point(165, 144);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(227, 31);
            txtHost.TabIndex = 8;
            // 
            // txtBaseDatos
            // 
            txtBaseDatos.Location = new Point(165, 191);
            txtBaseDatos.Name = "txtBaseDatos";
            txtBaseDatos.Size = new Size(227, 31);
            txtBaseDatos.TabIndex = 9;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(165, 243);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(227, 31);
            txtPuerto.TabIndex = 10;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(450, 44);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 62;
            dgvDatos.RowTemplate.Height = 33;
            dgvDatos.Size = new Size(576, 318);
            dgvDatos.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 403);
            Controls.Add(dgvDatos);
            Controls.Add(txtPuerto);
            Controls.Add(txtBaseDatos);
            Controls.Add(txtHost);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(btnConectar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnConectar;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private TextBox txtHost;
        private TextBox txtBaseDatos;
        private TextBox txtPuerto;
        private DataGridView dgvDatos;
    }
}