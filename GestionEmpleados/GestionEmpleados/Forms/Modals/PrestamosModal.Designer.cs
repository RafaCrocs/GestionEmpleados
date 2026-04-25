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
            lblDetalle = new Label();
            txtDetalle = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblSugerenciaDeRebajo = new Label();
            txtSugerenciaDeRebajo = new TextBox();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Location = new Point(47, 140);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(66, 15);
            lblEmpleado.TabIndex = 0;
            lblEmpleado.Text = "Empleado: ";
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(47, 167);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(346, 23);
            cmbEmpleados.TabIndex = 1;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(47, 229);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(193, 23);
            txtMonto.TabIndex = 2;
            txtMonto.Leave += txtMonto_Leave;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(47, 211);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(49, 15);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto: ";
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Location = new Point(47, 333);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(43, 15);
            lblDetalle.TabIndex = 5;
            lblDetalle.Text = "Detalle";
            // 
            // txtDetalle
            // 
            txtDetalle.Location = new Point(47, 363);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(346, 23);
            txtDetalle.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(218, 461);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 28);
            btnCancelar.TabIndex = 45;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(103, 461);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 28);
            btnAceptar.TabIndex = 44;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblSugerenciaDeRebajo
            // 
            lblSugerenciaDeRebajo.AutoSize = true;
            lblSugerenciaDeRebajo.Location = new Point(47, 273);
            lblSugerenciaDeRebajo.Name = "lblSugerenciaDeRebajo";
            lblSugerenciaDeRebajo.Size = new Size(123, 15);
            lblSugerenciaDeRebajo.TabIndex = 46;
            lblSugerenciaDeRebajo.Text = "Sugerencia de Rebajo:";
            // 
            // txtSugerenciaDeRebajo
            // 
            txtSugerenciaDeRebajo.Location = new Point(47, 291);
            txtSugerenciaDeRebajo.Name = "txtSugerenciaDeRebajo";
            txtSugerenciaDeRebajo.Size = new Size(193, 23);
            txtSugerenciaDeRebajo.TabIndex = 47;
            txtSugerenciaDeRebajo.Leave += txtSugerenciaDeRebajo_Leave;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 22F);
            lblTitulo.Location = new Point(47, 47);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(154, 50);
            lblTitulo.TabIndex = 48;
            lblTitulo.Text = "Prestamo";
            // 
            // PrestamosModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 551);
            Controls.Add(lblTitulo);
            Controls.Add(txtSugerenciaDeRebajo);
            Controls.Add(lblSugerenciaDeRebajo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDetalle);
            Controls.Add(lblDetalle);
            Controls.Add(lblMonto);
            Controls.Add(txtMonto);
            Controls.Add(cmbEmpleados);
            Controls.Add(lblEmpleado);
            Name = "PrestamosModal";
            Text = "PrestamosModal";
            Load += PrestamosModal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmpleado;
        private ComboBox cmbEmpleados;
        private TextBox txtMonto;
        private Label lblMonto;
        private Label lblDetalle;
        private TextBox txtDetalle;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblSugerenciaDeRebajo;
        private TextBox txtSugerenciaDeRebajo;
        private Label lblTitulo;
    }
}