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
            lblSalarioBase = new Label();
            txtSalarioReal = new TextBox();
            btnPagar = new Button();
            lblPuesto = new Label();
            txtSalarioFinal = new TextBox();
            lblSalarioFinal = new Label();
            lblTitulo = new Label();
            label1 = new Label();
            txtSalarioReportado = new TextBox();
            label2 = new Label();
            txtValorHora = new TextBox();
            label3 = new Label();
            txtDiasIncapacitados = new TextBox();
            txtDiasAusentes = new TextBox();
            label4 = new Label();
            txtDiasDobles = new TextBox();
            label5 = new Label();
            txtValorJornada = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 12F);
            lblEmpleado.Location = new Point(87, 129);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(86, 21);
            lblEmpleado.TabIndex = 0;
            lblEmpleado.Text = "Empleado: ";
            // 
            // txtAdelantos
            // 
            txtAdelantos.Enabled = false;
            txtAdelantos.Font = new Font("Segoe UI", 12F);
            txtAdelantos.Location = new Point(633, 274);
            txtAdelantos.Name = "txtAdelantos";
            txtAdelantos.Size = new Size(100, 29);
            txtAdelantos.TabIndex = 1;
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.Font = new Font("Segoe UI", 12F);
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(86, 163);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(269, 29);
            cmbEmpleados.TabIndex = 2;
            // 
            // lblAdelanto
            // 
            lblAdelanto.AutoSize = true;
            lblAdelanto.Font = new Font("Segoe UI", 12F);
            lblAdelanto.Location = new Point(633, 252);
            lblAdelanto.Name = "lblAdelanto";
            lblAdelanto.Size = new Size(82, 21);
            lblAdelanto.TabIndex = 3;
            lblAdelanto.Text = "Adelantos:";
            // 
            // lblPrestamo
            // 
            lblPrestamo.AutoSize = true;
            lblPrestamo.Font = new Font("Segoe UI", 12F);
            lblPrestamo.Location = new Point(633, 335);
            lblPrestamo.Name = "lblPrestamo";
            lblPrestamo.Size = new Size(79, 21);
            lblPrestamo.TabIndex = 4;
            lblPrestamo.Text = "Prestamo:";
            // 
            // txtPrestamo
            // 
            txtPrestamo.Font = new Font("Segoe UI", 12F);
            txtPrestamo.Location = new Point(633, 359);
            txtPrestamo.Name = "txtPrestamo";
            txtPrestamo.Size = new Size(144, 29);
            txtPrestamo.TabIndex = 5;
            txtPrestamo.TextChanged += txtPrestamo_TextChanged;
            txtPrestamo.Leave += txtPrestamo_Leave;
            // 
            // lblSeguro
            // 
            lblSeguro.AutoSize = true;
            lblSeguro.Font = new Font("Segoe UI", 12F);
            lblSeguro.Location = new Point(844, 251);
            lblSeguro.Name = "lblSeguro";
            lblSeguro.Size = new Size(63, 21);
            lblSeguro.TabIndex = 6;
            lblSeguro.Text = "Seguro:";
            // 
            // txtSeguro
            // 
            txtSeguro.Enabled = false;
            txtSeguro.Font = new Font("Segoe UI", 12F);
            txtSeguro.Location = new Point(844, 279);
            txtSeguro.Name = "txtSeguro";
            txtSeguro.Size = new Size(171, 29);
            txtSeguro.TabIndex = 7;
            // 
            // lblBonificaciones
            // 
            lblBonificaciones.AutoSize = true;
            lblBonificaciones.Font = new Font("Segoe UI", 12F);
            lblBonificaciones.Location = new Point(844, 335);
            lblBonificaciones.Name = "lblBonificaciones";
            lblBonificaciones.Size = new Size(112, 21);
            lblBonificaciones.TabIndex = 8;
            lblBonificaciones.Text = "Bonificaciones:";
            // 
            // txtBonificaciones
            // 
            txtBonificaciones.Font = new Font("Segoe UI", 12F);
            txtBonificaciones.Location = new Point(844, 359);
            txtBonificaciones.Name = "txtBonificaciones";
            txtBonificaciones.Size = new Size(171, 29);
            txtBonificaciones.TabIndex = 9;
            txtBonificaciones.TextChanged += txtBonificaciones_TextChanged;
            txtBonificaciones.Leave += txtBonificaciones_Leave;
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Segoe UI", 12F);
            lblHoras.Location = new Point(86, 248);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(132, 21);
            lblHoras.TabIndex = 10;
            lblHoras.Text = "Horas Trabajadas:";
            // 
            // txtHorasTrabajadas
            // 
            txtHorasTrabajadas.Font = new Font("Segoe UI", 12F);
            txtHorasTrabajadas.Location = new Point(86, 272);
            txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            txtHorasTrabajadas.Size = new Size(100, 29);
            txtHorasTrabajadas.TabIndex = 11;
            // 
            // lblHorasExtra
            // 
            lblHorasExtra.AutoSize = true;
            lblHorasExtra.Font = new Font("Segoe UI", 12F);
            lblHorasExtra.Location = new Point(86, 322);
            lblHorasExtra.Name = "lblHorasExtra";
            lblHorasExtra.Size = new Size(92, 21);
            lblHorasExtra.TabIndex = 12;
            lblHorasExtra.Text = "Horas Extra:";
            // 
            // txtHorasExtra
            // 
            txtHorasExtra.Font = new Font("Segoe UI", 12F);
            txtHorasExtra.Location = new Point(86, 346);
            txtHorasExtra.Name = "txtHorasExtra";
            txtHorasExtra.Size = new Size(100, 29);
            txtHorasExtra.TabIndex = 13;
            txtHorasExtra.TextChanged += txtHorasExtra_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F);
            btnBuscar.Location = new Point(382, 163);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(92, 29);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblSalarioBase
            // 
            lblSalarioBase.AutoSize = true;
            lblSalarioBase.Font = new Font("Segoe UI", 12F);
            lblSalarioBase.Location = new Point(421, 248);
            lblSalarioBase.Name = "lblSalarioBase";
            lblSalarioBase.Size = new Size(95, 21);
            lblSalarioBase.TabIndex = 16;
            lblSalarioBase.Text = "Salario Real:";
            // 
            // txtSalarioReal
            // 
            txtSalarioReal.Enabled = false;
            txtSalarioReal.Font = new Font("Segoe UI", 12F);
            txtSalarioReal.Location = new Point(421, 272);
            txtSalarioReal.Name = "txtSalarioReal";
            txtSalarioReal.Size = new Size(144, 29);
            txtSalarioReal.TabIndex = 17;
            // 
            // btnPagar
            // 
            btnPagar.Font = new Font("Segoe UI", 12F);
            btnPagar.Location = new Point(603, 607);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(133, 45);
            btnPagar.TabIndex = 18;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.Font = new Font("Segoe UI", 10F);
            lblPuesto.Location = new Point(87, 195);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(0, 19);
            lblPuesto.TabIndex = 19;
            // 
            // txtSalarioFinal
            // 
            txtSalarioFinal.Enabled = false;
            txtSalarioFinal.Font = new Font("Segoe UI", 15F);
            txtSalarioFinal.Location = new Point(88, 574);
            txtSalarioFinal.Name = "txtSalarioFinal";
            txtSalarioFinal.Size = new Size(268, 34);
            txtSalarioFinal.TabIndex = 20;
            // 
            // lblSalarioFinal
            // 
            lblSalarioFinal.AutoSize = true;
            lblSalarioFinal.Font = new Font("Segoe UI", 12F);
            lblSalarioFinal.Location = new Point(88, 550);
            lblSalarioFinal.Name = "lblSalarioFinal";
            lblSalarioFinal.Size = new Size(98, 21);
            lblSalarioFinal.TabIndex = 21;
            lblSalarioFinal.Text = "Salario Final:";
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 22F);
            lblTitulo.Location = new Point(48, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(285, 50);
            lblTitulo.TabIndex = 31;
            lblTitulo.Text = "Pago de Salario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(421, 335);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 32;
            label1.Text = "Salario Reportado:";
            // 
            // txtSalarioReportado
            // 
            txtSalarioReportado.Enabled = false;
            txtSalarioReportado.Font = new Font("Segoe UI", 12F);
            txtSalarioReportado.Location = new Point(421, 359);
            txtSalarioReportado.Name = "txtSalarioReportado";
            txtSalarioReportado.Size = new Size(144, 29);
            txtSalarioReportado.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(88, 392);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 34;
            label2.Text = "Valor Hora:";
            // 
            // txtValorHora
            // 
            txtValorHora.Enabled = false;
            txtValorHora.Font = new Font("Segoe UI", 12F);
            txtValorHora.Location = new Point(86, 416);
            txtValorHora.Name = "txtValorHora";
            txtValorHora.Size = new Size(100, 29);
            txtValorHora.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(242, 322);
            label3.Name = "label3";
            label3.Size = new Size(141, 21);
            label3.TabIndex = 36;
            label3.Text = "Dias Incapacitados:";
            // 
            // txtDiasIncapacitados
            // 
            txtDiasIncapacitados.Font = new Font("Segoe UI", 12F);
            txtDiasIncapacitados.Location = new Point(242, 346);
            txtDiasIncapacitados.Name = "txtDiasIncapacitados";
            txtDiasIncapacitados.Size = new Size(100, 29);
            txtDiasIncapacitados.TabIndex = 37;
            txtDiasIncapacitados.TextChanged += txtDiasIncapacitados_TextChanged;
            // 
            // txtDiasAusentes
            // 
            txtDiasAusentes.Font = new Font("Segoe UI", 12F);
            txtDiasAusentes.Location = new Point(242, 272);
            txtDiasAusentes.Name = "txtDiasAusentes";
            txtDiasAusentes.Size = new Size(100, 29);
            txtDiasAusentes.TabIndex = 39;
            txtDiasAusentes.TextChanged += txtDiasAusentes_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(242, 248);
            label4.Name = "label4";
            label4.Size = new Size(110, 21);
            label4.TabIndex = 38;
            label4.Text = "Dias Ausentes:";
            // 
            // txtDiasDobles
            // 
            txtDiasDobles.Font = new Font("Segoe UI", 12F);
            txtDiasDobles.Location = new Point(242, 416);
            txtDiasDobles.Name = "txtDiasDobles";
            txtDiasDobles.Size = new Size(100, 29);
            txtDiasDobles.TabIndex = 41;
            txtDiasDobles.TextChanged += txtDiasDobles_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(242, 392);
            label5.Name = "label5";
            label5.Size = new Size(95, 21);
            label5.TabIndex = 40;
            label5.Text = "Dias Dobles:";
            // 
            // txtValorJornada
            // 
            txtValorJornada.Enabled = false;
            txtValorJornada.Font = new Font("Segoe UI", 12F);
            txtValorJornada.Location = new Point(88, 476);
            txtValorJornada.Name = "txtValorJornada";
            txtValorJornada.Size = new Size(100, 29);
            txtValorJornada.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(90, 452);
            label6.Name = "label6";
            label6.Size = new Size(108, 21);
            label6.TabIndex = 42;
            label6.Text = "Valor Jornada:";
            // 
            // frmSalarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 753);
            Controls.Add(txtValorJornada);
            Controls.Add(label6);
            Controls.Add(txtDiasDobles);
            Controls.Add(label5);
            Controls.Add(txtDiasAusentes);
            Controls.Add(label4);
            Controls.Add(txtDiasIncapacitados);
            Controls.Add(label3);
            Controls.Add(txtValorHora);
            Controls.Add(label2);
            Controls.Add(txtSalarioReportado);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(lblSalarioFinal);
            Controls.Add(txtSalarioFinal);
            Controls.Add(lblPuesto);
            Controls.Add(btnPagar);
            Controls.Add(txtSalarioReal);
            Controls.Add(lblSalarioBase);
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
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label lblSalarioBase;
        private TextBox txtSalarioReal;
        private Button btnPagar;
        private Label lblPuesto;
        private TextBox txtSalarioFinal;
        private Label lblSalarioFinal;
        private Label lblTitulo;
        private Label label1;
        private TextBox txtSalarioReportado;
        private Label label2;
        private TextBox txtValorHora;
        private Label label3;
        private TextBox txtDiasIncapacitados;
        private TextBox txtDiasAusentes;
        private Label label4;
        private TextBox txtDiasDobles;
        private Label label5;
        private TextBox txtValorJornada;
        private Label label6;
    }
}