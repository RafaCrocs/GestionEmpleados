namespace GestionEmpleados.Forms.Modals
{
    partial class EmpleadosModal
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
            cmbSucursal = new ComboBox();
            lblSucursal = new Label();
            txtIdentificacion = new TextBox();
            txtContrasenna = new TextBox();
            lblContraseña = new Label();
            lblPuesto = new Label();
            cmbPuestos = new ComboBox();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblBonificacion = new Label();
            txtBonificacion = new TextBox();
            lblTelefono = new Label();
            lblFechaNacimiento = new Label();
            dateFechaNacimiento = new DateTimePicker();
            btnMarcarSalida = new Button();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            lblTitulo = new Label();
            ckbSeguro = new CheckBox();
            lblSeguro = new Label();
            txtSeguro = new TextBox();
            label1 = new Label();
            txtSalarioReportado = new TextBox();
            label2 = new Label();
            txtPorcentajeSeguro = new TextBox();
            groupBox2 = new GroupBox();
            txtApellidos = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtTelefono = new TextBox();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            txtValorJornada = new TextBox();
            label9 = new Label();
            txtValorHora = new TextBox();
            label8 = new Label();
            txtSalarioReal = new TextBox();
            label7 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // cmbSucursal
            // 
            cmbSucursal.Font = new Font("Segoe UI", 12F);
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(136, 221);
            cmbSucursal.Margin = new Padding(3, 2, 3, 2);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(140, 29);
            cmbSucursal.TabIndex = 56;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Segoe UI", 12F);
            lblSucursal.Location = new Point(31, 219);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(69, 21);
            lblSucursal.TabIndex = 55;
            lblSucursal.Text = "Sucursal";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Font = new Font("Segoe UI", 12F);
            txtIdentificacion.Location = new Point(136, 132);
            txtIdentificacion.Margin = new Padding(3, 2, 3, 2);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(142, 29);
            txtIdentificacion.TabIndex = 53;
            // 
            // txtContrasenna
            // 
            txtContrasenna.Font = new Font("Segoe UI", 12F);
            txtContrasenna.Location = new Point(134, 314);
            txtContrasenna.Margin = new Padding(3, 2, 3, 2);
            txtContrasenna.Name = "txtContrasenna";
            txtContrasenna.PasswordChar = '*';
            txtContrasenna.Size = new Size(142, 29);
            txtContrasenna.TabIndex = 50;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 12F);
            lblContraseña.Location = new Point(25, 317);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(89, 21);
            lblContraseña.TabIndex = 49;
            lblContraseña.Text = "Contraseña";
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.Font = new Font("Segoe UI", 12F);
            lblPuesto.Location = new Point(6, 59);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(57, 21);
            lblPuesto.TabIndex = 47;
            lblPuesto.Text = "Puesto";
            // 
            // cmbPuestos
            // 
            cmbPuestos.Font = new Font("Segoe UI", 12F);
            cmbPuestos.FormattingEnabled = true;
            cmbPuestos.Location = new Point(169, 51);
            cmbPuestos.Margin = new Padding(3, 2, 3, 2);
            cmbPuestos.Name = "cmbPuestos";
            cmbPuestos.Size = new Size(140, 29);
            cmbPuestos.TabIndex = 46;
            cmbPuestos.SelectedIndexChanged += cmbPuestos_SelectedIndexChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 12F);
            txtCorreo.Location = new Point(134, 268);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(142, 29);
            txtCorreo.TabIndex = 45;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F);
            lblCorreo.Location = new Point(28, 271);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(58, 21);
            lblCorreo.TabIndex = 44;
            lblCorreo.Text = "Correo";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(561, 636);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 34);
            btnCancelar.TabIndex = 41;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 12F);
            btnAceptar.Location = new Point(446, 636);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(99, 34);
            btnAceptar.TabIndex = 40;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblBonificacion
            // 
            lblBonificacion.AutoSize = true;
            lblBonificacion.Font = new Font("Segoe UI", 12F);
            lblBonificacion.Location = new Point(44, 152);
            lblBonificacion.Name = "lblBonificacion";
            lblBonificacion.Size = new Size(97, 21);
            lblBonificacion.TabIndex = 57;
            lblBonificacion.Text = "Bonificacion:";
            // 
            // txtBonificacion
            // 
            txtBonificacion.Font = new Font("Segoe UI", 12F);
            txtBonificacion.Location = new Point(167, 149);
            txtBonificacion.Margin = new Padding(3, 2, 3, 2);
            txtBonificacion.Name = "txtBonificacion";
            txtBonificacion.Size = new Size(142, 29);
            txtBonificacion.TabIndex = 58;
            txtBonificacion.Leave += txtBonificacion_Leave;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 12F);
            lblTelefono.Location = new Point(593, 248);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(0, 21);
            lblTelefono.TabIndex = 59;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 12F);
            lblFechaNacimiento.Location = new Point(31, 372);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(155, 21);
            lblFechaNacimiento.TabIndex = 65;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // dateFechaNacimiento
            // 
            dateFechaNacimiento.Font = new Font("Segoe UI", 12F);
            dateFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateFechaNacimiento.Location = new Point(28, 396);
            dateFechaNacimiento.Name = "dateFechaNacimiento";
            dateFechaNacimiento.Size = new Size(200, 29);
            dateFechaNacimiento.TabIndex = 64;
            // 
            // btnMarcarSalida
            // 
            btnMarcarSalida.Font = new Font("Segoe UI", 12F);
            btnMarcarSalida.Location = new Point(880, 697);
            btnMarcarSalida.Margin = new Padding(3, 2, 3, 2);
            btnMarcarSalida.Name = "btnMarcarSalida";
            btnMarcarSalida.Size = new Size(213, 34);
            btnMarcarSalida.TabIndex = 66;
            btnMarcarSalida.Text = "Reportar Salida";
            btnMarcarSalida.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F);
            lblEstado.Location = new Point(85, 193);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(56, 21);
            lblEstado.TabIndex = 68;
            lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.Font = new Font("Segoe UI", 12F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(169, 190);
            cmbEstado.Margin = new Padding(3, 2, 3, 2);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(140, 29);
            cmbEstado.TabIndex = 69;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 22F);
            lblTitulo.Location = new Point(64, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(185, 50);
            lblTitulo.TabIndex = 70;
            lblTitulo.Text = "Empleado";
            // 
            // ckbSeguro
            // 
            ckbSeguro.AutoSize = true;
            ckbSeguro.Font = new Font("Segoe UI", 12F);
            ckbSeguro.Location = new Point(110, 224);
            ckbSeguro.Name = "ckbSeguro";
            ckbSeguro.Size = new Size(123, 25);
            ckbSeguro.TabIndex = 71;
            ckbSeguro.Text = "Paga Seguro?";
            ckbSeguro.UseVisualStyleBackColor = true;
            // 
            // lblSeguro
            // 
            lblSeguro.AutoSize = true;
            lblSeguro.Font = new Font("Segoe UI", 12F);
            lblSeguro.Location = new Point(8, 212);
            lblSeguro.Name = "lblSeguro";
            lblSeguro.Size = new Size(60, 21);
            lblSeguro.TabIndex = 72;
            lblSeguro.Text = "Seguro";
            // 
            // txtSeguro
            // 
            txtSeguro.Enabled = false;
            txtSeguro.Font = new Font("Segoe UI", 12F);
            txtSeguro.Location = new Point(169, 209);
            txtSeguro.Margin = new Padding(3, 2, 3, 2);
            txtSeguro.Name = "txtSeguro";
            txtSeguro.Size = new Size(142, 29);
            txtSeguro.TabIndex = 73;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 110);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 74;
            label1.Text = "Salario Reportado";
            // 
            // txtSalarioReportado
            // 
            txtSalarioReportado.Font = new Font("Segoe UI", 12F);
            txtSalarioReportado.Location = new Point(169, 104);
            txtSalarioReportado.Margin = new Padding(3, 2, 3, 2);
            txtSalarioReportado.Name = "txtSalarioReportado";
            txtSalarioReportado.Size = new Size(142, 29);
            txtSalarioReportado.TabIndex = 75;
            txtSalarioReportado.TextChanged += txtSalarioReportado_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(8, 161);
            label2.Name = "label2";
            label2.Size = new Size(157, 21);
            label2.TabIndex = 76;
            label2.Text = "Porcentaje de Seguro";
            // 
            // txtPorcentajeSeguro
            // 
            txtPorcentajeSeguro.Enabled = false;
            txtPorcentajeSeguro.Font = new Font("Segoe UI", 12F);
            txtPorcentajeSeguro.Location = new Point(171, 156);
            txtPorcentajeSeguro.Margin = new Padding(3, 2, 3, 2);
            txtPorcentajeSeguro.Name = "txtPorcentajeSeguro";
            txtPorcentajeSeguro.Size = new Size(62, 29);
            txtPorcentajeSeguro.TabIndex = 77;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtApellidos);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtIdentificacion);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtTelefono);
            groupBox2.Controls.Add(lblSucursal);
            groupBox2.Controls.Add(cmbSucursal);
            groupBox2.Controls.Add(lblCorreo);
            groupBox2.Controls.Add(dateFechaNacimiento);
            groupBox2.Controls.Add(lblFechaNacimiento);
            groupBox2.Controls.Add(txtCorreo);
            groupBox2.Controls.Add(lblContraseña);
            groupBox2.Controls.Add(txtContrasenna);
            groupBox2.Location = new Point(163, 112);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 499);
            groupBox2.TabIndex = 78;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Personal";
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Segoe UI", 12F);
            txtApellidos.Location = new Point(136, 83);
            txtApellidos.Margin = new Padding(3, 2, 3, 2);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(142, 29);
            txtApellidos.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(28, 51);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 42;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(136, 43);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(142, 29);
            txtNombre.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(31, 91);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 51;
            label4.Text = "Apellidos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(28, 173);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 59;
            label6.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(28, 132);
            label5.Name = "label5";
            label5.Size = new Size(102, 21);
            label5.TabIndex = 54;
            label5.Text = "Identificacion";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(136, 173);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(142, 29);
            txtTelefono.TabIndex = 60;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSeguro);
            groupBox1.Controls.Add(txtPorcentajeSeguro);
            groupBox1.Controls.Add(lblSeguro);
            groupBox1.Controls.Add(lblPuesto);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbPuestos);
            groupBox1.Controls.Add(txtSalarioReportado);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(622, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 271);
            groupBox1.TabIndex = 79;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Personal";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtValorJornada);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtValorHora);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtSalarioReal);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(lblBonificacion);
            groupBox3.Controls.Add(ckbSeguro);
            groupBox3.Controls.Add(txtBonificacion);
            groupBox3.Controls.Add(lblEstado);
            groupBox3.Controls.Add(cmbEstado);
            groupBox3.Location = new Point(622, 340);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(355, 271);
            groupBox3.TabIndex = 80;
            groupBox3.TabStop = false;
            groupBox3.Text = "Salario";
            // 
            // txtValorJornada
            // 
            txtValorJornada.Enabled = false;
            txtValorJornada.Font = new Font("Segoe UI", 12F);
            txtValorJornada.Location = new Point(168, 100);
            txtValorJornada.Margin = new Padding(3, 2, 3, 2);
            txtValorJornada.Name = "txtValorJornada";
            txtValorJornada.Size = new Size(142, 29);
            txtValorJornada.TabIndex = 77;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(12, 103);
            label9.Name = "label9";
            label9.Size = new Size(133, 21);
            label9.TabIndex = 76;
            label9.Text = "Valor de Jornada: ";
            // 
            // txtValorHora
            // 
            txtValorHora.Enabled = false;
            txtValorHora.Font = new Font("Segoe UI", 12F);
            txtValorHora.Location = new Point(167, 57);
            txtValorHora.Margin = new Padding(3, 2, 3, 2);
            txtValorHora.Name = "txtValorHora";
            txtValorHora.Size = new Size(142, 29);
            txtValorHora.TabIndex = 75;
            txtValorHora.Leave += txtValorHora_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(33, 57);
            label8.Name = "label8";
            label8.Size = new Size(112, 21);
            label8.TabIndex = 74;
            label8.Text = "Valor de Hora: ";
            // 
            // txtSalarioReal
            // 
            txtSalarioReal.Font = new Font("Segoe UI", 12F);
            txtSalarioReal.Location = new Point(167, 21);
            txtSalarioReal.Margin = new Padding(3, 2, 3, 2);
            txtSalarioReal.Name = "txtSalarioReal";
            txtSalarioReal.Size = new Size(142, 29);
            txtSalarioReal.TabIndex = 73;
            txtSalarioReal.TextChanged += txtSalarioReal_TextChanged;
            txtSalarioReal.Leave += txtSalarioReal_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(45, 24);
            label7.Name = "label7";
            label7.Size = new Size(99, 21);
            label7.TabIndex = 72;
            label7.Text = "Salario Real: ";
            // 
            // EmpleadosModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 754);
            Controls.Add(groupBox3);
            Controls.Add(lblTitulo);
            Controls.Add(btnMarcarSalida);
            Controls.Add(lblTelefono);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "EmpleadosModal";
            Text = "EmpleadosModal";
            Load += EmpleadosModal_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSucursal;
        private Label lblSucursal;
        private TextBox txtIdentificacion;
        private TextBox txtContrasenna;
        private Label lblContraseña;
        private Label lblPuesto;
        private ComboBox cmbPuestos;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblBonificacion;
        private TextBox txtBonificacion;
        private Label lblTelefono;
        private Label lblFechaNacimiento;
        private DateTimePicker dateFechaNacimiento;
        private Button btnMarcarSalida;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private Label lblTitulo;
        private CheckBox ckbSeguro;
        private Label lblSeguro;
        private TextBox txtSeguro;
        private Label label1;
        private TextBox txtSalarioReportado;
        private Label label2;
        private TextBox txtPorcentajeSeguro;
        private GroupBox groupBox2;
        private TextBox txtApellidos;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private Label label6;
        private Label label5;
        private TextBox txtTelefono;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private TextBox txtSalarioReal;
        private Label label7;
        private TextBox txtValorHora;
        private Label label8;
        private TextBox txtValorJornada;
        private Label label9;
    }
}