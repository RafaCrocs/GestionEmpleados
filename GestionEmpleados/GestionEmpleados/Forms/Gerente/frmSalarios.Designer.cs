namespace GestionEmpleados.Forms.Gerente
{
    partial class frmSalarios
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
            lblEmpleado = new Label();
            txtAdelantos = new TextBox();
            cmbEmpleados = new ComboBox();
            lblAdelanto = new Label();
            lblPrestamo = new Label();
            txtPrestamo = new TextBox();
            lblSeguro = new Label();
            txtSeguro = new TextBox();
            lblBonificaciones = new Label();
            txtBonificaciones = new TextBox();
            lblHoras = new Label();
            txtHorasTrabajadas = new TextBox();
            lblHorasExtra = new Label();
            txtHorasExtra = new TextBox();
            btnBuscar = new Button();
            lblSalarioFinal = new Label();
            lblSalarioBase = new Label();
            txtSalarioBase = new TextBox();
            btnPagar = new Button();
            SuspendLayout();
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Location = new Point(48, 62);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(66, 15);
            lblEmpleado.TabIndex = 0;
            lblEmpleado.Text = "Empleado: ";
            // 
            // txtAdelantos
            // 
            txtAdelantos.Enabled = false;
            txtAdelantos.Location = new Point(242, 213);
            txtAdelantos.Name = "txtAdelantos";
            txtAdelantos.Size = new Size(100, 23);
            txtAdelantos.TabIndex = 1;
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(48, 90);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(269, 23);
            cmbEmpleados.TabIndex = 2;
            // 
            // lblAdelanto
            // 
            lblAdelanto.AutoSize = true;
            lblAdelanto.Location = new Point(242, 195);
            lblAdelanto.Name = "lblAdelanto";
            lblAdelanto.Size = new Size(63, 15);
            lblAdelanto.TabIndex = 3;
            lblAdelanto.Text = "Adelantos:";
            // 
            // lblPrestamo
            // 
            lblPrestamo.AutoSize = true;
            lblPrestamo.Location = new Point(242, 265);
            lblPrestamo.Name = "lblPrestamo";
            lblPrestamo.Size = new Size(60, 15);
            lblPrestamo.TabIndex = 4;
            lblPrestamo.Text = "Prestamo:";
            // 
            // txtPrestamo
            // 
            txtPrestamo.Enabled = false;
            txtPrestamo.Location = new Point(242, 283);
            txtPrestamo.Name = "txtPrestamo";
            txtPrestamo.Size = new Size(144, 23);
            txtPrestamo.TabIndex = 5;
            // 
            // lblSeguro
            // 
            lblSeguro.AutoSize = true;
            lblSeguro.Location = new Point(451, 145);
            lblSeguro.Name = "lblSeguro";
            lblSeguro.Size = new Size(47, 15);
            lblSeguro.TabIndex = 6;
            lblSeguro.Text = "Seguro:";
            // 
            // txtSeguro
            // 
            txtSeguro.Enabled = false;
            txtSeguro.Location = new Point(451, 173);
            txtSeguro.Name = "txtSeguro";
            txtSeguro.Size = new Size(171, 23);
            txtSeguro.TabIndex = 7;
            // 
            // lblBonificaciones
            // 
            lblBonificaciones.AutoSize = true;
            lblBonificaciones.Location = new Point(451, 229);
            lblBonificaciones.Name = "lblBonificaciones";
            lblBonificaciones.Size = new Size(87, 15);
            lblBonificaciones.TabIndex = 8;
            lblBonificaciones.Text = "Bonificaciones:";
            // 
            // txtBonificaciones
            // 
            txtBonificaciones.Enabled = false;
            txtBonificaciones.Location = new Point(451, 247);
            txtBonificaciones.Name = "txtBonificaciones";
            txtBonificaciones.Size = new Size(171, 23);
            txtBonificaciones.TabIndex = 9;
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Location = new Point(48, 133);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(100, 15);
            lblHoras.TabIndex = 10;
            lblHoras.Text = "Horas Trabajadas:";
            // 
            // txtHorasTrabajadas
            // 
            txtHorasTrabajadas.Enabled = false;
            txtHorasTrabajadas.Location = new Point(48, 164);
            txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            txtHorasTrabajadas.Size = new Size(100, 23);
            txtHorasTrabajadas.TabIndex = 11;
            // 
            // lblHorasExtra
            // 
            lblHorasExtra.AutoSize = true;
            lblHorasExtra.Location = new Point(48, 220);
            lblHorasExtra.Name = "lblHorasExtra";
            lblHorasExtra.Size = new Size(69, 15);
            lblHorasExtra.TabIndex = 12;
            lblHorasExtra.Text = "Horas Extra:";
            // 
            // txtHorasExtra
            // 
            txtHorasExtra.Enabled = false;
            txtHorasExtra.Location = new Point(48, 247);
            txtHorasExtra.Name = "txtHorasExtra";
            txtHorasExtra.Size = new Size(100, 23);
            txtHorasExtra.TabIndex = 13;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(334, 90);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblSalarioFinal
            // 
            lblSalarioFinal.AutoSize = true;
            lblSalarioFinal.Font = new Font("Segoe UI", 22F);
            lblSalarioFinal.Location = new Point(48, 312);
            lblSalarioFinal.Name = "lblSalarioFinal";
            lblSalarioFinal.Size = new Size(0, 41);
            lblSalarioFinal.TabIndex = 15;
            // 
            // lblSalarioBase
            // 
            lblSalarioBase.AutoSize = true;
            lblSalarioBase.Location = new Point(242, 133);
            lblSalarioBase.Name = "lblSalarioBase";
            lblSalarioBase.Size = new Size(72, 15);
            lblSalarioBase.TabIndex = 16;
            lblSalarioBase.Text = "Salario Base:";
            // 
            // txtSalarioBase
            // 
            txtSalarioBase.Enabled = false;
            txtSalarioBase.Location = new Point(242, 151);
            txtSalarioBase.Name = "txtSalarioBase";
            txtSalarioBase.Size = new Size(144, 23);
            txtSalarioBase.TabIndex = 17;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(565, 447);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(133, 45);
            btnPagar.TabIndex = 18;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // frmSalarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 542);
            Controls.Add(btnPagar);
            Controls.Add(txtSalarioBase);
            Controls.Add(lblSalarioBase);
            Controls.Add(lblSalarioFinal);
            Controls.Add(btnBuscar);
            Controls.Add(txtHorasExtra);
            Controls.Add(lblHorasExtra);
            Controls.Add(txtHorasTrabajadas);
            Controls.Add(lblHoras);
            Controls.Add(txtBonificaciones);
            Controls.Add(lblBonificaciones);
            Controls.Add(txtSeguro);
            Controls.Add(lblSeguro);
            Controls.Add(txtPrestamo);
            Controls.Add(lblPrestamo);
            Controls.Add(lblAdelanto);
            Controls.Add(cmbEmpleados);
            Controls.Add(txtAdelantos);
            Controls.Add(lblEmpleado);
            Name = "frmSalarios";
            Text = "frmSalarios";
            Load += frmSalarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmpleado;
        private TextBox txtAdelantos;
        private ComboBox cmbEmpleados;
        private Label lblAdelanto;
        private Label lblPrestamo;
        private TextBox txtPrestamo;
        private Label lblSeguro;
        private TextBox txtSeguro;
        private Label lblBonificaciones;
        private TextBox txtBonificaciones;
        private Label lblHoras;
        private TextBox txtHorasTrabajadas;
        private Label lblHorasExtra;
        private TextBox txtHorasExtra;
        private Button btnBuscar;
        private Label lblSalarioFinal;
        private Label lblSalarioBase;
        private TextBox txtSalarioBase;
        private Button btnPagar;
    }
}