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
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.Font = new Font("Segoe UI", 12F);
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(42, 141);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(317, 29);
            cmbEmpleados.TabIndex = 0;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 12F);
            lblEmpleado.Location = new Point(42, 107);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(86, 21);
            lblEmpleado.TabIndex = 2;
            lblEmpleado.Text = "Empleado: ";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 12F);
            lblMonto.Location = new Point(42, 177);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(63, 21);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto: ";
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("Segoe UI", 12F);
            lblDetalle.Location = new Point(42, 245);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(65, 21);
            lblDetalle.TabIndex = 4;
            lblDetalle.Text = "Detalle: ";
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Segoe UI", 12F);
            txtMonto.Location = new Point(42, 201);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(186, 29);
            txtMonto.TabIndex = 5;
            txtMonto.Leave += txtMonto_Leave;
            // 
            // txtDetalle
            // 
            txtDetalle.Font = new Font("Segoe UI", 12F);
            txtDetalle.Location = new Point(42, 269);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(277, 29);
            txtDetalle.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(187, 339);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 34);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 12F);
            btnAceptar.Location = new Point(72, 339);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(105, 34);
            btnAceptar.TabIndex = 42;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 22F);
            lblTitulo.Location = new Point(42, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(147, 50);
            lblTitulo.TabIndex = 44;
            lblTitulo.Text = "Adelanto";
            // 
            // AdelantoModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 446);
            Controls.Add(lblTitulo);
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
        private Label lblTitulo;
    }
}