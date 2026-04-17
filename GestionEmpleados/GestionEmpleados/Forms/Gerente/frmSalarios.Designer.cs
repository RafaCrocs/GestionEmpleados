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
            textBox1 = new TextBox();
            cmbEmpleados = new ComboBox();
            lblAdelanto = new Label();
            lblPrestamo = new Label();
            txtPrestamo = new TextBox();
            lblSeguro = new Label();
            textBox2 = new TextBox();
            lblBonificaciones = new Label();
            txtBonificaciones = new TextBox();
            lblHoras = new Label();
            txtHorasTrabajadas = new TextBox();
            lblHorasExtra = new Label();
            txtHorasExtra = new TextBox();
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
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(358, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(48, 90);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(269, 23);
            cmbEmpleados.TabIndex = 2;
            cmbEmpleados.SelectedIndexChanged += cmbEmpleados_SelectedIndexChanged;
            // 
            // lblAdelanto
            // 
            lblAdelanto.AutoSize = true;
            lblAdelanto.Location = new Point(358, 62);
            lblAdelanto.Name = "lblAdelanto";
            lblAdelanto.Size = new Size(63, 15);
            lblAdelanto.TabIndex = 3;
            lblAdelanto.Text = "Adelantos:";
            // 
            // lblPrestamo
            // 
            lblPrestamo.AutoSize = true;
            lblPrestamo.Location = new Point(358, 119);
            lblPrestamo.Name = "lblPrestamo";
            lblPrestamo.Size = new Size(60, 15);
            lblPrestamo.TabIndex = 4;
            lblPrestamo.Text = "Prestamo:";
            // 
            // txtPrestamo
            // 
            txtPrestamo.Enabled = false;
            txtPrestamo.Location = new Point(358, 150);
            txtPrestamo.Name = "txtPrestamo";
            txtPrestamo.Size = new Size(144, 23);
            txtPrestamo.TabIndex = 5;
            // 
            // lblSeguro
            // 
            lblSeguro.AutoSize = true;
            lblSeguro.Location = new Point(568, 71);
            lblSeguro.Name = "lblSeguro";
            lblSeguro.Size = new Size(47, 15);
            lblSeguro.TabIndex = 6;
            lblSeguro.Text = "Seguro:";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(568, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 7;
            // 
            // lblBonificaciones
            // 
            lblBonificaciones.AutoSize = true;
            lblBonificaciones.Location = new Point(568, 155);
            lblBonificaciones.Name = "lblBonificaciones";
            lblBonificaciones.Size = new Size(87, 15);
            lblBonificaciones.TabIndex = 8;
            lblBonificaciones.Text = "Bonificaciones:";
            // 
            // txtBonificaciones
            // 
            txtBonificaciones.Enabled = false;
            txtBonificaciones.Location = new Point(568, 173);
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
            // frmSalarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 542);
            Controls.Add(txtHorasExtra);
            Controls.Add(lblHorasExtra);
            Controls.Add(txtHorasTrabajadas);
            Controls.Add(lblHoras);
            Controls.Add(txtBonificaciones);
            Controls.Add(lblBonificaciones);
            Controls.Add(textBox2);
            Controls.Add(lblSeguro);
            Controls.Add(txtPrestamo);
            Controls.Add(lblPrestamo);
            Controls.Add(lblAdelanto);
            Controls.Add(cmbEmpleados);
            Controls.Add(textBox1);
            Controls.Add(lblEmpleado);
            Name = "frmSalarios";
            Text = "frmSalarios";
            Load += frmSalarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmpleado;
        private TextBox textBox1;
        private ComboBox cmbEmpleados;
        private Label lblAdelanto;
        private Label lblPrestamo;
        private TextBox txtPrestamo;
        private Label lblSeguro;
        private TextBox textBox2;
        private Label lblBonificaciones;
        private TextBox txtBonificaciones;
        private Label lblHoras;
        private TextBox txtHorasTrabajadas;
        private Label lblHorasExtra;
        private TextBox txtHorasExtra;
    }
}