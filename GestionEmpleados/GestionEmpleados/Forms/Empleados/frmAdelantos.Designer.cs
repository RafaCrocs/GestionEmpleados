namespace GestionEmpleados.Forms.Empleados
{
    partial class frmAdelantos
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
            btnLimpiarBuscador = new Button();
            cmbPuestos = new ComboBox();
            lblPuesto = new Label();
            btnAgregar = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            gridEmpleados = new DataGridView();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            IdAdelanto = new DataGridViewTextBoxColumn();
            IdEmpleado = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Detalle = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridEmpleados).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiarBuscador
            // 
            btnLimpiarBuscador.Location = new Point(327, 62);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.Size = new Size(61, 23);
            btnLimpiarBuscador.TabIndex = 27;
            btnLimpiarBuscador.Text = "Limpiar";
            btnLimpiarBuscador.UseVisualStyleBackColor = true;
            // 
            // cmbPuestos
            // 
            cmbPuestos.FormattingEnabled = true;
            cmbPuestos.Location = new Point(120, 62);
            cmbPuestos.Margin = new Padding(3, 2, 3, 2);
            cmbPuestos.Name = "cmbPuestos";
            cmbPuestos.Size = new Size(183, 23);
            cmbPuestos.TabIndex = 26;
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.Location = new Point(57, 63);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(46, 15);
            lblPuesto.TabIndex = 25;
            lblPuesto.Text = "Puesto:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(805, 82);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 22);
            btnAgregar.TabIndex = 24;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(120, 90);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(183, 23);
            txtBuscar.TabIndex = 23;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(56, 96);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(54, 15);
            lblBuscar.TabIndex = 22;
            lblBuscar.Text = "BUSCAR:";
            // 
            // gridEmpleados
            // 
            gridEmpleados.AllowUserToAddRows = false;
            gridEmpleados.BackgroundColor = Color.White;
            gridEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridEmpleados.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar, IdAdelanto, IdEmpleado, Monto, Fecha, Detalle });
            gridEmpleados.Location = new Point(58, 129);
            gridEmpleados.Margin = new Padding(3, 2, 3, 2);
            gridEmpleados.Name = "gridEmpleados";
            gridEmpleados.RowHeadersWidth = 51;
            gridEmpleados.Size = new Size(858, 372);
            gridEmpleados.TabIndex = 21;
            // 
            // Editar
            // 
            Editar.HeaderText = "";
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            Editar.Width = 75;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "";
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            Eliminar.Width = 75;
            // 
            // IdAdelanto
            // 
            IdAdelanto.DataPropertyName = "IdAdelanto";
            IdAdelanto.HeaderText = "IdAdelanto";
            IdAdelanto.MinimumWidth = 6;
            IdAdelanto.Name = "IdAdelanto";
            IdAdelanto.Visible = false;
            IdAdelanto.Width = 125;
            // 
            // IdEmpleado
            // 
            IdEmpleado.DataPropertyName = "IdEmpleado";
            IdEmpleado.HeaderText = "IdEmpleado";
            IdEmpleado.Name = "IdEmpleado";
            // 
            // Monto
            // 
            Monto.DataPropertyName = "Monto";
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            // 
            // Fecha
            // 
            Fecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Fecha.DataPropertyName = "Fecha";
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            // 
            // Detalle
            // 
            Detalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Detalle.DataPropertyName = "Detalle";
            Detalle.HeaderText = "Detalle";
            Detalle.MinimumWidth = 6;
            Detalle.Name = "Detalle";
            // 
            // frmAdelantos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 548);
            Controls.Add(btnLimpiarBuscador);
            Controls.Add(cmbPuestos);
            Controls.Add(lblPuesto);
            Controls.Add(btnAgregar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(gridEmpleados);
            Name = "frmAdelantos";
            Text = "frmAdelantos";
            ((System.ComponentModel.ISupportInitialize)gridEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiarBuscador;
        private ComboBox cmbPuestos;
        private Label lblPuesto;
        private Button btnAgregar;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private DataGridView gridEmpleados;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewTextBoxColumn IdAdelanto;
        private DataGridViewTextBoxColumn IdEmpleado;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Detalle;
    }
}