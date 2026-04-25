namespace GestionEmpleados.Forms.Modals
{
    partial class Puestos_SegurosModal
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
            btnAgregar = new Button();
            lblNombrePuesto = new Label();
            textBox1 = new TextBox();
            txtSalarioBase = new TextBox();
            lblSalarioBase = new Label();
            btnCancelar = new Button();
            lblPorcentajeEmpleado = new Label();
            txtPorcentajeEmpleado = new TextBox();
            txtMontoEmpleado = new TextBox();
            lblTitulo = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(123, 505);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 42);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblNombrePuesto
            // 
            lblNombrePuesto.AutoSize = true;
            lblNombrePuesto.Font = new Font("Segoe UI", 12F);
            lblNombrePuesto.Location = new Point(100, 135);
            lblNombrePuesto.Name = "lblNombrePuesto";
            lblNombrePuesto.Size = new Size(147, 21);
            lblNombrePuesto.TabIndex = 1;
            lblNombrePuesto.Text = "Nombre del Puesto:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(100, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 29);
            textBox1.TabIndex = 2;
            // 
            // txtSalarioBase
            // 
            txtSalarioBase.Font = new Font("Segoe UI", 12F);
            txtSalarioBase.Location = new Point(100, 242);
            txtSalarioBase.Name = "txtSalarioBase";
            txtSalarioBase.Size = new Size(281, 29);
            txtSalarioBase.TabIndex = 3;
            txtSalarioBase.TextChanged += txtSalarioBase_TextChanged;
            txtSalarioBase.Leave += txtSalarioBase_Leave;
            // 
            // lblSalarioBase
            // 
            lblSalarioBase.AutoSize = true;
            lblSalarioBase.Font = new Font("Segoe UI", 12F);
            lblSalarioBase.Location = new Point(100, 211);
            lblSalarioBase.Name = "lblSalarioBase";
            lblSalarioBase.Size = new Size(138, 21);
            lblSalarioBase.TabIndex = 4;
            lblSalarioBase.Text = "Salario Reportado:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(246, 505);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 42);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblPorcentajeEmpleado
            // 
            lblPorcentajeEmpleado.AutoSize = true;
            lblPorcentajeEmpleado.Font = new Font("Segoe UI", 12F);
            lblPorcentajeEmpleado.Location = new Point(29, 377);
            lblPorcentajeEmpleado.Name = "lblPorcentajeEmpleado";
            lblPorcentajeEmpleado.Size = new Size(212, 21);
            lblPorcentajeEmpleado.TabIndex = 6;
            lblPorcentajeEmpleado.Text = "Porcentaje del Empleado:    %";
            // 
            // txtPorcentajeEmpleado
            // 
            txtPorcentajeEmpleado.Font = new Font("Segoe UI", 12F);
            txtPorcentajeEmpleado.Location = new Point(239, 374);
            txtPorcentajeEmpleado.Name = "txtPorcentajeEmpleado";
            txtPorcentajeEmpleado.Size = new Size(61, 29);
            txtPorcentajeEmpleado.TabIndex = 7;
            txtPorcentajeEmpleado.TextChanged += txtPorcentajeEmpleado_TextChanged;
            // 
            // txtMontoEmpleado
            // 
            txtMontoEmpleado.Enabled = false;
            txtMontoEmpleado.Font = new Font("Segoe UI", 12F);
            txtMontoEmpleado.Location = new Point(318, 374);
            txtMontoEmpleado.Name = "txtMontoEmpleado";
            txtMontoEmpleado.Size = new Size(113, 29);
            txtMontoEmpleado.TabIndex = 10;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 22F);
            lblTitulo.Location = new Point(34, 37);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(117, 50);
            lblTitulo.TabIndex = 45;
            lblTitulo.Text = "Puesto";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(23, 303);
            label1.Name = "label1";
            label1.Size = new Size(147, 50);
            label1.TabIndex = 46;
            label1.Text = "Seguro";
            // 
            // Puestos_SegurosModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 626);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(txtMontoEmpleado);
            Controls.Add(txtPorcentajeEmpleado);
            Controls.Add(lblPorcentajeEmpleado);
            Controls.Add(btnCancelar);
            Controls.Add(lblSalarioBase);
            Controls.Add(txtSalarioBase);
            Controls.Add(textBox1);
            Controls.Add(lblNombrePuesto);
            Controls.Add(btnAgregar);
            Name = "Puestos_SegurosModal";
            Text = "PuestosModal";
            Load += Puestos_SegurosModal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label lblNombrePuesto;
        private TextBox textBox1;
        private TextBox txtSalarioBase;
        private Label lblSalarioBase;
        private Button btnCancelar;
        private Label lblPorcentajeEmpleado;
        private TextBox txtPorcentajeEmpleado;
        private TextBox txtMontoEmpleado;
        private Label lblTitulo;
        private Label label1;
    }
}