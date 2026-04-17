namespace GestionEmpleados
{
    partial class Login
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
            cbxVerContrasenna = new CheckBox();
            txtContrasenna = new TextBox();
            txtIdentificacion = new TextBox();
            lblContrasenna = new Label();
            lblIdentificacion = new Label();
            btnLogin = new Button();
            btnEntrada = new Button();
            btnSalida = new Button();
            SuspendLayout();
            // 
            // cbxVerContrasenna
            // 
            cbxVerContrasenna.AutoSize = true;
            cbxVerContrasenna.Location = new Point(138, 127);
            cbxVerContrasenna.Name = "cbxVerContrasenna";
            cbxVerContrasenna.Size = new Size(105, 19);
            cbxVerContrasenna.TabIndex = 9;
            cbxVerContrasenna.Text = "Ver Contraseña";
            cbxVerContrasenna.UseVisualStyleBackColor = true;
            cbxVerContrasenna.CheckedChanged += cbxVerContrasenna_CheckedChanged;
            // 
            // txtContrasenna
            // 
            txtContrasenna.Location = new Point(138, 94);
            txtContrasenna.Margin = new Padding(3, 2, 3, 2);
            txtContrasenna.MaxLength = 16;
            txtContrasenna.Name = "txtContrasenna";
            txtContrasenna.PlaceholderText = "Ingrese su Contraseña";
            txtContrasenna.Size = new Size(192, 23);
            txtContrasenna.TabIndex = 7;
            txtContrasenna.TextAlign = HorizontalAlignment.Center;
            txtContrasenna.UseSystemPasswordChar = true;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(138, 53);
            txtIdentificacion.Margin = new Padding(3, 2, 3, 2);
            txtIdentificacion.MaxLength = 128;
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.PlaceholderText = "Ingrese su Identificacion";
            txtIdentificacion.Size = new Size(192, 23);
            txtIdentificacion.TabIndex = 5;
            txtIdentificacion.TextAlign = HorizontalAlignment.Center;
            // 
            // lblContrasenna
            // 
            lblContrasenna.AutoSize = true;
            lblContrasenna.Location = new Point(60, 94);
            lblContrasenna.Name = "lblContrasenna";
            lblContrasenna.Size = new Size(70, 15);
            lblContrasenna.TabIndex = 8;
            lblContrasenna.Text = "Contraseña:";
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(45, 56);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(82, 15);
            lblIdentificacion.TabIndex = 6;
            lblIdentificacion.Text = "Identificacion:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(290, 239);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(192, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnEntrada
            // 
            btnEntrada.Location = new Point(132, 164);
            btnEntrada.Margin = new Padding(3, 2, 3, 2);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(96, 34);
            btnEntrada.TabIndex = 10;
            btnEntrada.Text = "Entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnSalida
            // 
            btnSalida.Location = new Point(234, 164);
            btnSalida.Margin = new Padding(3, 2, 3, 2);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(96, 34);
            btnSalida.TabIndex = 11;
            btnSalida.Text = "Salida";
            btnSalida.UseVisualStyleBackColor = true;
            btnSalida.Click += btnSalida_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 289);
            Controls.Add(btnSalida);
            Controls.Add(btnEntrada);
            Controls.Add(cbxVerContrasenna);
            Controls.Add(txtContrasenna);
            Controls.Add(txtIdentificacion);
            Controls.Add(lblContrasenna);
            Controls.Add(lblIdentificacion);
            Controls.Add(btnLogin);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbxVerContrasenna;
        private TextBox txtContrasenna;
        private TextBox txtIdentificacion;
        private Label lblContrasenna;
        private Label lblIdentificacion;
        private Button btnLogin;
        private Button btnEntrada;
        private Button btnSalida;
    }
}