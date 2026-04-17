namespace GestionEmpleados.Forms.Modals
{
    partial class PrestamosModal
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
            cmbEmpleados = new ComboBox();
            txtMonto = new TextBox();
            lblMonto = new Label();
            lblCuotas = new Label();
            lblDetalle = new Label();
            numCuotas = new NumericUpDown();
            txtDetalle = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)numCuotas).BeginInit();
            SuspendLayout();
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Location = new Point(43, 66);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(66, 15);
            lblEmpleado.TabIndex = 0;
            lblEmpleado.Text = "Empleado: ";
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(43, 93);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(346, 23);
            cmbEmpleados.TabIndex = 1;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(43, 155);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(193, 23);
            txtMonto.TabIndex = 2;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(43, 137);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(49, 15);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto: ";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(43, 198);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(47, 15);
            lblCuotas.TabIndex = 4;
            lblCuotas.Text = "Cuotas:";
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Location = new Point(43, 259);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(43, 15);
            lblDetalle.TabIndex = 5;
            lblDetalle.Text = "Detalle";
            // 
            // numCuotas
            // 
            numCuotas.Location = new Point(43, 216);
            numCuotas.Name = "numCuotas";
            numCuotas.Size = new Size(66, 23);
            numCuotas.TabIndex = 7;
            // 
            // txtDetalle
            // 
            txtDetalle.Location = new Point(43, 289);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(346, 23);
            txtDetalle.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(214, 387);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 28);
            btnCancelar.TabIndex = 45;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(99, 387);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 28);
            btnAceptar.TabIndex = 44;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // PrestamosModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 472);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDetalle);
            Controls.Add(numCuotas);
            Controls.Add(lblDetalle);
            Controls.Add(lblCuotas);
            Controls.Add(lblMonto);
            Controls.Add(txtMonto);
            Controls.Add(cmbEmpleados);
            Controls.Add(lblEmpleado);
            Name = "PrestamosModal";
            Text = "PrestamosModal";
            Load += PrestamosModal_Load;
            ((System.ComponentModel.ISupportInitialize)numCuotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmpleado;
        private ComboBox cmbEmpleados;
        private TextBox txtMonto;
        private Label lblMonto;
        private Label lblCuotas;
        private Label lblDetalle;
        private NumericUpDown numCuotas;
        private TextBox txtDetalle;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}