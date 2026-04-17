namespace GestionEmpleados.Forms.Modals
{
    partial class AdelantoModal
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
            cmbEmpleados = new ComboBox();
            lblEmpleado = new Label();
            lblMonto = new Label();
            lblDetalle = new Label();
            txtMonto = new TextBox();
            txtDetalle = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(44, 93);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(317, 23);
            cmbEmpleados.TabIndex = 0;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Location = new Point(44, 65);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(66, 15);
            lblEmpleado.TabIndex = 2;
            lblEmpleado.Text = "Empleado: ";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(44, 135);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(49, 15);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto: ";
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Location = new Point(44, 203);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(49, 15);
            lblDetalle.TabIndex = 4;
            lblDetalle.Text = "Detalle: ";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(44, 153);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 5;
            // 
            // txtDetalle
            // 
            txtDetalle.Location = new Point(44, 221);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(277, 23);
            txtDetalle.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(187, 329);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 28);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(72, 329);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 28);
            btnAceptar.TabIndex = 42;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // AdelantoModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDetalle);
            Controls.Add(txtMonto);
            Controls.Add(lblDetalle);
            Controls.Add(lblMonto);
            Controls.Add(lblEmpleado);
            Controls.Add(cmbEmpleados);
            Name = "AdelantoModal";
            Text = "AdelantoModal";
            Load += AdelantoModal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEmpleados;
        private Label lblEmpleado;
        private Label lblMonto;
        private Label lblDetalle;
        private TextBox txtMonto;
        private TextBox txtDetalle;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}