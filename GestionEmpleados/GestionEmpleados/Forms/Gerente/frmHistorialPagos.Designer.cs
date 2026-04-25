namespace GestionEmpleados.Forms.Gerente
{
    partial class frmHistorialPagos
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
            gridHistorialPagos = new DataGridView();
            IdPago = new DataGridViewTextBoxColumn();
            IdEmpleado = new DataGridViewTextBoxColumn();
            NombreEmpleado = new DataGridViewTextBoxColumn();
            HorasTrabajadas = new DataGridViewTextBoxColumn();
            HorasExtra = new DataGridViewTextBoxColumn();
            DiasAusentes = new DataGridViewTextBoxColumn();
            DiasIncapacitados = new DataGridViewTextBoxColumn();
            DiasDobles = new DataGridViewTextBoxColumn();
            Seguro = new DataGridViewTextBoxColumn();
            Adelanto = new DataGridViewTextBoxColumn();
            Prestamo = new DataGridViewTextBoxColumn();
            Bonificacion = new DataGridViewTextBoxColumn();
            SalarioReal = new DataGridViewTextBoxColumn();
            SalarioPagado = new DataGridViewTextBoxColumn();
            SalarioReportado = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            lblBuscarNombre = new Label();
            txtNombre = new TextBox();
            lblBuscarFecha = new Label();
            dateBusquedaFecha = new DateTimePicker();
            btnRestablecerBusqueda = new Button();
            ((System.ComponentModel.ISupportInitialize)gridHistorialPagos).BeginInit();
            SuspendLayout();
            // 
            // gridHistorialPagos
            // 
            gridHistorialPagos.BackgroundColor = SystemColors.Window;
            gridHistorialPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridHistorialPagos.Columns.AddRange(new DataGridViewColumn[] { IdPago, IdEmpleado, NombreEmpleado, HorasTrabajadas, HorasExtra, DiasAusentes, DiasIncapacitados, DiasDobles, Seguro, Adelanto, Prestamo, Bonificacion, SalarioReal, SalarioPagado, SalarioReportado, Fecha });
            gridHistorialPagos.Location = new Point(38, 205);
            gridHistorialPagos.Name = "gridHistorialPagos";
            gridHistorialPagos.Size = new Size(1495, 464);
            gridHistorialPagos.TabIndex = 0;
            gridHistorialPagos.CellFormatting += gridHistorialPagos_CellFormatting;
            // 
            // IdPago
            // 
            IdPago.DataPropertyName = "IdRegistroPago";
            IdPago.HeaderText = "IdPago";
            IdPago.Name = "IdPago";
            IdPago.Visible = false;
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
            NombreEmpleado.HeaderText = "Nombre del Empleado";
            NombreEmpleado.Name = "NombreEmpleado";
            // 
            // HorasTrabajadas
            // 
            HorasTrabajadas.DataPropertyName = "HorasTrabajadas";
            HorasTrabajadas.HeaderText = "Horas Trabajadas";
            HorasTrabajadas.Name = "HorasTrabajadas";
            HorasTrabajadas.Width = 50;
            // 
            // HorasExtra
            // 
            HorasExtra.DataPropertyName = "HorasExtra";
            HorasExtra.HeaderText = "Horas Extra";
            HorasExtra.Name = "HorasExtra";
            HorasExtra.Width = 50;
            // 
            // DiasAusentes
            // 
            DiasAusentes.DataPropertyName = "DiasAusentes";
            DiasAusentes.HeaderText = "DiasAusentes";
            DiasAusentes.Name = "DiasAusentes";
            // 
            // DiasIncapacitados
            // 
            DiasIncapacitados.DataPropertyName = "DiasIncapacitados";
            DiasIncapacitados.HeaderText = "DiasIncapacitados";
            DiasIncapacitados.Name = "DiasIncapacitados";
            // 
            // DiasDobles
            // 
            DiasDobles.DataPropertyName = "DiasDobles";
            DiasDobles.HeaderText = "DiasDobles";
            DiasDobles.Name = "DiasDobles";
            // 
            // Seguro
            // 
            Seguro.DataPropertyName = "Seguro";
            Seguro.HeaderText = "Seguro";
            Seguro.Name = "Seguro";
            // 
            // Adelanto
            // 
            Adelanto.DataPropertyName = "Adelanto";
            Adelanto.HeaderText = "Adelanto";
            Adelanto.Name = "Adelanto";
            // 
            // Prestamo
            // 
            Prestamo.DataPropertyName = "Prestamo";
            Prestamo.HeaderText = "Rebajo de Prestamo";
            Prestamo.Name = "Prestamo";
            // 
            // Bonificacion
            // 
            Bonificacion.DataPropertyName = "Bonificacion";
            Bonificacion.HeaderText = "Bonificacion Pagada";
            Bonificacion.Name = "Bonificacion";
            // 
            // SalarioReal
            // 
            SalarioReal.DataPropertyName = "SalarioReal";
            SalarioReal.HeaderText = "Salario Real";
            SalarioReal.Name = "SalarioReal";
            // 
            // SalarioPagado
            // 
            SalarioPagado.DataPropertyName = "SalarioPagado";
            SalarioPagado.HeaderText = "Salario Pagado";
            SalarioPagado.Name = "SalarioPagado";
            // 
            // SalarioReportado
            // 
            SalarioReportado.DataPropertyName = "SalarioReportado";
            SalarioReportado.HeaderText = "Salario Reportado";
            SalarioReportado.Name = "SalarioReportado";
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            Fecha.HeaderText = "Fecha de Pago";
            Fecha.Name = "Fecha";
            // 
            // lblBuscarNombre
            // 
            lblBuscarNombre.AutoSize = true;
            lblBuscarNombre.Font = new Font("Segoe UI", 12F);
            lblBuscarNombre.Location = new Point(38, 66);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(149, 21);
            lblBuscarNombre.TabIndex = 1;
            lblBuscarNombre.Text = "Buscar por Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(193, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(306, 29);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblBuscarFecha
            // 
            lblBuscarFecha.AutoSize = true;
            lblBuscarFecha.Font = new Font("Segoe UI", 12F);
            lblBuscarFecha.Location = new Point(39, 109);
            lblBuscarFecha.Name = "lblBuscarFecha";
            lblBuscarFecha.Size = new Size(131, 21);
            lblBuscarFecha.TabIndex = 3;
            lblBuscarFecha.Text = "Buscar por Fecha:";
            // 
            // dateBusquedaFecha
            // 
            dateBusquedaFecha.Font = new Font("Segoe UI", 12F);
            dateBusquedaFecha.Format = DateTimePickerFormat.Short;
            dateBusquedaFecha.Location = new Point(193, 103);
            dateBusquedaFecha.Name = "dateBusquedaFecha";
            dateBusquedaFecha.Size = new Size(104, 29);
            dateBusquedaFecha.TabIndex = 4;
            dateBusquedaFecha.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnRestablecerBusqueda
            // 
            btnRestablecerBusqueda.Font = new Font("Segoe UI", 12F);
            btnRestablecerBusqueda.Location = new Point(39, 154);
            btnRestablecerBusqueda.Name = "btnRestablecerBusqueda";
            btnRestablecerBusqueda.Size = new Size(177, 29);
            btnRestablecerBusqueda.TabIndex = 5;
            btnRestablecerBusqueda.Text = "Restablecer Busqueda";
            btnRestablecerBusqueda.UseVisualStyleBackColor = true;
            btnRestablecerBusqueda.Click += btnRestablecerBusqueda_Click;
            // 
            // frmHistorialPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1581, 780);
            Controls.Add(btnRestablecerBusqueda);
            Controls.Add(dateBusquedaFecha);
            Controls.Add(lblBuscarFecha);
            Controls.Add(txtNombre);
            Controls.Add(lblBuscarNombre);
            Controls.Add(gridHistorialPagos);
            Name = "frmHistorialPagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHistorialPagos";
            Load += frmHistorialPagos_Load;
            ((System.ComponentModel.ISupportInitialize)gridHistorialPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridHistorialPagos;
        private Label lblBuscarNombre;
        private TextBox txtNombre;
        private Label lblBuscarFecha;
        private DateTimePicker dateBusquedaFecha;
        private Button btnRestablecerBusqueda;
        private DataGridViewTextBoxColumn IdPago;
        private DataGridViewTextBoxColumn IdEmpleado;
        private DataGridViewTextBoxColumn NombreEmpleado;
        private DataGridViewTextBoxColumn HorasTrabajadas;
        private DataGridViewTextBoxColumn HorasExtra;
        private DataGridViewTextBoxColumn DiasAusentes;
        private DataGridViewTextBoxColumn DiasIncapacitados;
        private DataGridViewTextBoxColumn DiasDobles;
        private DataGridViewTextBoxColumn Seguro;
        private DataGridViewTextBoxColumn Adelanto;
        private DataGridViewTextBoxColumn Prestamo;
        private DataGridViewTextBoxColumn Bonificacion;
        private DataGridViewTextBoxColumn SalarioReal;
        private DataGridViewTextBoxColumn SalarioPagado;
        private DataGridViewTextBoxColumn SalarioReportado;
        private DataGridViewTextBoxColumn Fecha;
    }
}