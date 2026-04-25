namespace GestionEmpleados.Forms.Empleados
{
    partial class frmEmpleados
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
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            btnLimpiarBuscador = new Button();
            cmbPuestos = new ComboBox();
            lblPuesto = new Label();
            lblEmpleados = new Label();
            gridEmpleados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridEmpleados).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1053, 159);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 22);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(121, 159);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(183, 23);
            txtBuscar.TabIndex = 15;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(57, 165);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(54, 15);
            lblBuscar.TabIndex = 14;
            lblBuscar.Text = "BUSCAR:";
            // 
            // btnLimpiarBuscador
            // 
            btnLimpiarBuscador.Location = new Point(328, 131);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.Size = new Size(61, 23);
            btnLimpiarBuscador.TabIndex = 20;
            btnLimpiarBuscador.Text = "Limpiar";
            btnLimpiarBuscador.UseVisualStyleBackColor = true;
            btnLimpiarBuscador.Click += btnLimpiarBuscador_Click;
            // 
            // cmbPuestos
            // 
            cmbPuestos.FormattingEnabled = true;
            cmbPuestos.Location = new Point(121, 131);
            cmbPuestos.Margin = new Padding(3, 2, 3, 2);
            cmbPuestos.Name = "cmbPuestos";
            cmbPuestos.Size = new Size(183, 23);
            cmbPuestos.TabIndex = 18;
            cmbPuestos.SelectedIndexChanged += cmbPuestos_SelectedIndexChanged;
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.Location = new Point(58, 132);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(46, 15);
            lblPuesto.TabIndex = 17;
            lblPuesto.Text = "Puesto:";
            // 
            // lblEmpleados
            // 
            lblEmpleados.Font = new Font("Segoe UI", 22F);
            lblEmpleados.Location = new Point(57, 40);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(285, 50);
            lblEmpleados.TabIndex = 30;
            lblEmpleados.Text = "Lista de Empleados";
            // 
            // gridEmpleados
            // 
            gridEmpleados.BackgroundColor = SystemColors.Control;
            gridEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridEmpleados.Location = new Point(57, 221);
            gridEmpleados.Name = "gridEmpleados";
            gridEmpleados.ReadOnly = true;
            gridEmpleados.Size = new Size(1107, 364);
            gridEmpleados.TabIndex = 31;
            gridEmpleados.CellContentClick += gridEmpleados_CellContentClick;
            gridEmpleados.CellFormatting += gridEmpleados_CellFormatting;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 616);
            Controls.Add(gridEmpleados);
            Controls.Add(lblEmpleados);
            Controls.Add(btnLimpiarBuscador);
            Controls.Add(cmbPuestos);
            Controls.Add(lblPuesto);
            Controls.Add(btnAgregar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Name = "frmEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEmpleados";
            Load += frmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)gridEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Button btnLimpiarBuscador;
        private ComboBox cmbPuestos;
        private Label lblPuesto;
        private Label lblEmpleados;
        private DataGridView gridEmpleados;
    }
}