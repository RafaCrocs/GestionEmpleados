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
            gridEmpleados = new DataGridView();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            IdEmpleado = new DataGridViewTextBoxColumn();
            IdSucursal = new DataGridViewTextBoxColumn();
            Identificacion = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Contrasenna = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            FechaIngreso = new DataGridViewTextBoxColumn();
            FechaSalida = new DataGridViewTextBoxColumn();
            IdPuesto = new DataGridViewTextBoxColumn();
            Bonificacion = new DataGridViewTextBoxColumn();
            PagaSeguro = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btnLimpiarBuscador = new Button();
            cmbPuestos = new ComboBox();
            lblPuesto = new Label();
            ((System.ComponentModel.ISupportInitialize)gridEmpleados).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(784, 48);
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
            txtBuscar.Location = new Point(99, 56);
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
            lblBuscar.Location = new Point(35, 62);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(54, 15);
            lblBuscar.TabIndex = 14;
            lblBuscar.Text = "BUSCAR:";
            // 
            // gridEmpleados
            // 
            gridEmpleados.AllowUserToAddRows = false;
            gridEmpleados.BackgroundColor = Color.White;
            gridEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridEmpleados.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar, IdEmpleado, IdSucursal, Identificacion, Nombre, Apellidos, Telefono, Correo, Contrasenna, FechaNacimiento, FechaIngreso, FechaSalida, IdPuesto, Bonificacion, PagaSeguro, Estado });
            gridEmpleados.Location = new Point(37, 95);
            gridEmpleados.Margin = new Padding(3, 2, 3, 2);
            gridEmpleados.Name = "gridEmpleados";
            gridEmpleados.RowHeadersWidth = 51;
            gridEmpleados.Size = new Size(858, 372);
            gridEmpleados.TabIndex = 13;
            gridEmpleados.CellContentClick += gridEmpleados_CellContentClick;
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
            // IdEmpleado
            // 
            IdEmpleado.DataPropertyName = "IdEmpleado";
            IdEmpleado.HeaderText = "IdEmpleado";
            IdEmpleado.MinimumWidth = 6;
            IdEmpleado.Name = "IdEmpleado";
            IdEmpleado.Visible = false;
            IdEmpleado.Width = 125;
            // 
            // IdSucursal
            // 
            IdSucursal.DataPropertyName = "IdSucursal";
            IdSucursal.HeaderText = "IdSucursal";
            IdSucursal.Name = "IdSucursal";
            IdSucursal.Visible = false;
            // 
            // Identificacion
            // 
            Identificacion.DataPropertyName = "Identificacion";
            Identificacion.HeaderText = "Identificacion";
            Identificacion.Name = "Identificacion";
            Identificacion.Visible = false;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // Apellidos
            // 
            Apellidos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Apellidos.DataPropertyName = "Apellidos";
            Apellidos.HeaderText = "Apellidos";
            Apellidos.MinimumWidth = 6;
            Apellidos.Name = "Apellidos";
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Visible = false;
            Telefono.Width = 120;
            // 
            // Correo
            // 
            Correo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Correo.DataPropertyName = "Correo";
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            // 
            // Contrasenna
            // 
            Contrasenna.DataPropertyName = "Contrasenna";
            Contrasenna.HeaderText = "Contraseña";
            Contrasenna.Name = "Contrasenna";
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.DataPropertyName = "FechaNacimiento";
            FechaNacimiento.HeaderText = "FechaNacimiento";
            FechaNacimiento.MinimumWidth = 6;
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.Visible = false;
            FechaNacimiento.Width = 90;
            // 
            // FechaIngreso
            // 
            FechaIngreso.DataPropertyName = "FechaIngreso";
            FechaIngreso.HeaderText = "FechaIngreso";
            FechaIngreso.Name = "FechaIngreso";
            // 
            // FechaSalida
            // 
            FechaSalida.DataPropertyName = "FechaSalida";
            FechaSalida.HeaderText = "FechaSalida";
            FechaSalida.Name = "FechaSalida";
            FechaSalida.Visible = false;
            // 
            // IdPuesto
            // 
            IdPuesto.DataPropertyName = "IdPuesto";
            IdPuesto.HeaderText = "IdPuesto";
            IdPuesto.Name = "IdPuesto";
            IdPuesto.Visible = false;
            // 
            // Bonificacion
            // 
            Bonificacion.DataPropertyName = "Bonificacion";
            Bonificacion.HeaderText = "Bonificacion";
            Bonificacion.Name = "Bonificacion";
            Bonificacion.Visible = false;
            // 
            // PagaSeguro
            // 
            PagaSeguro.DataPropertyName = "PagaSeguro";
            PagaSeguro.HeaderText = "PagaSeguro";
            PagaSeguro.Name = "PagaSeguro";
            PagaSeguro.Visible = false;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // btnLimpiarBuscador
            // 
            btnLimpiarBuscador.Location = new Point(306, 28);
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
            cmbPuestos.Location = new Point(99, 28);
            cmbPuestos.Margin = new Padding(3, 2, 3, 2);
            cmbPuestos.Name = "cmbPuestos";
            cmbPuestos.Size = new Size(183, 23);
            cmbPuestos.TabIndex = 18;
            cmbPuestos.SelectedIndexChanged += cmbPuestos_SelectedIndexChanged;
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.Location = new Point(36, 29);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(46, 15);
            lblPuesto.TabIndex = 17;
            lblPuesto.Text = "Puesto:";
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 514);
            Controls.Add(btnLimpiarBuscador);
            Controls.Add(cmbPuestos);
            Controls.Add(lblPuesto);
            Controls.Add(btnAgregar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(gridEmpleados);
            Name = "frmEmpleados";
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
        private DataGridView gridEmpleados;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewTextBoxColumn IdEmpleado;
        private DataGridViewTextBoxColumn IdSucursal;
        private DataGridViewTextBoxColumn Identificacion;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Contrasenna;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn FechaIngreso;
        private DataGridViewTextBoxColumn FechaSalida;
        private DataGridViewTextBoxColumn IdPuesto;
        private DataGridViewTextBoxColumn Bonificacion;
        private DataGridViewTextBoxColumn PagaSeguro;
        private DataGridViewTextBoxColumn Estado;
        private Button btnLimpiarBuscador;
        private ComboBox cmbPuestos;
        private Label lblPuesto;
    }
}