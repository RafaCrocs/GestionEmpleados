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
            txtUsuario = new TextBox();
            lblContrasenna = new Label();
            lblNombre = new Label();
            btnLogin = new Button();
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
            // 
            // txtContrasenna
            // 
            txtContrasenna.Location = new Point(138, 94);
            txtContrasenna.Margin = new Padding(3, 2, 3, 2);
            txtContrasenna.MaxLength = 16;
            txtContrasenna.Name = "txtContrasenna";
            txtContrasenna.PlaceholderText = "ingrese su password";
            txtContrasenna.Size = new Size(192, 23);
            txtContrasenna.TabIndex = 7;
            txtContrasenna.TextAlign = HorizontalAlignment.Center;
            txtContrasenna.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(138, 53);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.MaxLength = 128;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "ingrese su usuario";
            txtUsuario.Size = new Size(192, 23);
            txtUsuario.TabIndex = 5;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // lblContrasenna
            // 
            lblContrasenna.AutoSize = true;
            lblContrasenna.Location = new Point(60, 94);
            lblContrasenna.Name = "lblContrasenna";
            lblContrasenna.Size = new Size(67, 15);
            lblContrasenna.TabIndex = 8;
            lblContrasenna.Text = "Contraseña";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(60, 58);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(47, 15);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Usuario";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(138, 162);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(192, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 274);
            Controls.Add(cbxVerContrasenna);
            Controls.Add(txtContrasenna);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasenna);
            Controls.Add(lblNombre);
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
        private TextBox txtUsuario;
        private Label lblContrasenna;
        private Label lblNombre;
        private Button btnLogin;
    }
}