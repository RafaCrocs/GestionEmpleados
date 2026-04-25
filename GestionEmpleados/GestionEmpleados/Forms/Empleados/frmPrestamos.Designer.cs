namespace GestionEmpleados.Forms.Empleados
{
    partial class frmPrestamos
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
            btnLimpiarBuscador = new Button();
            cmbPuestos = new ComboBox();
            lblPuesto = new Label();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            gridPrestamos = new DataGridView();
            Eliminar = new DataGridViewButtonColumn();
            Editar = new DataGridViewButtonColumn();
            IdPrestamo = new DataGridViewTextBoxColumn();
            IdEmpleado = new DataGridViewTextBoxColumn();
            NombreEmpleado = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            SugerenciaDeRebajo = new DataGridViewTextBoxColumn();
            MontoRestante = new DataGridViewTextBoxColumn();
            MontoPagado = new DataGridViewTextBoxColumn();
            FechaInicio = new DataGridViewTextBoxColumn();
            Detalle = new DataGridViewTextBoxColumn();
            lblPrestamos = new Label();
            ((System.ComponentModel.ISupportInitialize)gridPrestamos).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(914, 171);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 22);
            btnAgregar.TabIndex = 35;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiarBuscador
            // 
            btnLimpiarBuscador.Location = new Point(336, 141);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.Size = new Size(61, 23);
            btnLimpiarBuscador.TabIndex = 34;
            btnLimpiarBuscador.Text = "Limpiar";
            btnLimpiarBuscador.UseVisualStyleBackColor = true;
            // 
            // cmbPuestos
            // 
            cmbPuestos.FormattingEnabled = true;
            cmbPuestos.Location = new Point(129, 141);
            cmbPuestos.Margin = new Padding(3, 2, 3, 2);
            cmbPuestos.Name = "cmbPuestos";
            cmbPuestos.Size = new Size(183, 23);
            cmbPuestos.TabIndex = 33;
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.Location = new Point(66, 142);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(46, 15);
            lblPuesto.TabIndex = 32;
            lblPuesto.Text = "Puesto:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(129, 169);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(183, 23);
            txtBuscar.TabIndex = 31;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(65, 175);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(54, 15);
            lblBuscar.TabIndex = 30;
            lblBuscar.Text = "BUSCAR:";
            // 
            // gridPrestamos
            // 
            gridPrestamos.AllowUserToAddRows = false;
            gridPrestamos.BackgroundColor = Color.White;
            gridPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPrestamos.Columns.AddRange(new DataGridViewColumn[] { Eliminar, Editar, IdPrestamo, IdEmpleado, NombreEmpleado, Monto, SugerenciaDeRebajo, MontoRestante, MontoPagado, FechaInicio, Detalle });
            gridPrestamos.Location = new Point(67, 208);
            gridPrestamos.Margin = new Padding(3, 2, 3, 2);
            gridPrestamos.Name = "gridPrestamos";
            gridPrestamos.RowHeadersWidth = 51;
            gridPrestamos.Size = new Size(959, 371);
            gridPrestamos.TabIndex = 29;
            gridPrestamos.CellContentClick += gridPrestamos_CellContentClick;
            gridPrestamos.CellFormatting += gridPrestamos_CellFormatting;
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
            // Editar
            // 
            Editar.HeaderText = "";
            Editar.Name = "Editar";
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            Editar.Width = 75;
            // 
            // IdPrestamo
            // 
            IdPrestamo.DataPropertyName = "IdPrestamo";
            IdPrestamo.HeaderText = "IdPrestamo";
            IdPrestamo.MinimumWidth = 6;
            IdPrestamo.Name = "IdPrestamo";
            IdPrestamo.Visible = false;
            IdPrestamo.Width = 125;
            // 
            // IdEmpleado
            // 
            IdEmpleado.DataPropertyName = "IdEmpleado";
            IdEmpleado.HeaderText = "IdEmpleado";
            IdEmpleado.Name = "IdEmpleado";
            IdEmpleado.Visible = false;
            // 
            // NombreEmpleado
            // 
            NombreEmpleado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombreEmpleado.DataPropertyName = "NombreEmpleado";
            NombreEmpleado.HeaderText = "Nombre";
            NombreEmpleado.Name = "NombreEmpleado";
            // 
            // Monto
            // 
            Monto.DataPropertyName = "Monto";
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            // 
            // SugerenciaDeRebajo
            // 
            SugerenciaDeRebajo.DataPropertyName = "SugerenciaDeRebajo";
            SugerenciaDeRebajo.HeaderText = "Sugerencia de Rebajo";
            SugerenciaDeRebajo.Name = "SugerenciaDeRebajo";
            // 
            // MontoRestante
            // 
            MontoRestante.DataPropertyName = "MontoRestante";
            MontoRestante.HeaderText = "MontoRestante";
            MontoRestante.Name = "MontoRestante";
            MontoRestante.Visible = false;
            // 
            // MontoPagado
            // 
            MontoPagado.DataPropertyName = "MontoPagado";
            MontoPagado.HeaderText = "MontoPagado";
            MontoPagado.Name = "MontoPagado";
            // 
            // FechaInicio
            // 
            FechaInicio.DataPropertyName = "FechaInicio";
            FechaInicio.HeaderText = "FechaInicio";
            FechaInicio.Name = "FechaInicio";
            // 
            // Detalle
            // 
            Detalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Detalle.DataPropertyName = "Detalle";
            Detalle.HeaderText = "Detalle";
            Detalle.MinimumWidth = 6;
            Detalle.Name = "Detalle";
            // 
            // lblPrestamos
            // 
            lblPrestamos.Font = new Font("Segoe UI", 22F);
            lblPrestamos.Location = new Point(67, 38);
            lblPrestamos.Name = "lblPrestamos";
            lblPrestamos.Size = new Size(181, 50);
            lblPrestamos.TabIndex = 36;
            lblPrestamos.Text = "Prestamos";
            // 
            // frmPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 590);
            Controls.Add(lblPrestamos);
            Controls.Add(btnAgregar);
            Controls.Add(btnLimpiarBuscador);
            Controls.Add(cmbPuestos);
            Controls.Add(lblPuesto);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(gridPrestamos);
            Name = "frmPrestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrestamos";
            Load += frmPrestamos_Load;
            ((System.ComponentModel.ISupportInitialize)gridPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnLimpiarBuscador;
        private ComboBox cmbPuestos;
        private Label lblPuesto;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private DataGridView gridPrestamos;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewButtonColumn Editar;
        private DataGridViewTextBoxColumn IdPrestamo;
        private DataGridViewTextBoxColumn IdEmpleado;
        private DataGridViewTextBoxColumn NombreEmpleado;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn SugerenciaDeRebajo;
        private DataGridViewTextBoxColumn MontoRestante;
        private DataGridViewTextBoxColumn MontoPagado;
        private DataGridViewTextBoxColumn FechaInicio;
        private DataGridViewTextBoxColumn Detalle;
        private Label lblPrestamos;
    }
}