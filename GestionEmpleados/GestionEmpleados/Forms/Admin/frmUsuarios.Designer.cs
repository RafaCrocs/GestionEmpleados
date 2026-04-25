namespace GestionEmpleados.Forms.Admin
{
    partial class frmUsuarios
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
            btnBuscar = new Button();
            cmbTipoUsuario = new ComboBox();
            lblTipoUsuario = new Label();
            btnAgregar = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            gridUsuarios = new DataGridView();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            IdSucursal = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            Identificacion = new DataGridViewTextBoxColumn();
            IdRol = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Contrasenna = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            Activo = new DataGridViewTextBoxColumn();
            lblListaUsuarios = new Label();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiarBuscador
            // 
            btnLimpiarBuscador.Location = new Point(408, 114);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.Size = new Size(61, 23);
            btnLimpiarBuscador.TabIndex = 16;
            btnLimpiarBuscador.Text = "Limpiar";
            btnLimpiarBuscador.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(320, 115);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 22);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Location = new Point(132, 115);
            cmbTipoUsuario.Margin = new Padding(3, 2, 3, 2);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(183, 23);
            cmbTipoUsuario.TabIndex = 14;
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Location = new Point(27, 115);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(90, 15);
            lblTipoUsuario.TabIndex = 13;
            lblTipoUsuario.Text = "Tipo de Usuario";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(996, 144);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 22);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(132, 145);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(183, 23);
            txtBuscar.TabIndex = 11;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(27, 145);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(54, 15);
            lblBuscar.TabIndex = 10;
            lblBuscar.Text = "BUSCAR:";
            // 
            // gridUsuarios
            // 
            gridUsuarios.AllowUserToAddRows = false;
            gridUsuarios.BackgroundColor = Color.White;
            gridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridUsuarios.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar, IdUsuario, IdSucursal, Nombre, Apellidos, Identificacion, IdRol, Correo, Contrasenna, FechaCreacion, Activo });
            gridUsuarios.Location = new Point(28, 172);
            gridUsuarios.Margin = new Padding(3, 2, 3, 2);
            gridUsuarios.Name = "gridUsuarios";
            gridUsuarios.RowHeadersWidth = 51;
            gridUsuarios.Size = new Size(1080, 372);
            gridUsuarios.TabIndex = 9;
            gridUsuarios.CellContentClick += gridUsuarios_CellContentClick;
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
            // IdUsuario
            // 
            IdUsuario.DataPropertyName = "IdUsuario";
            IdUsuario.HeaderText = "Id Usuario";
            IdUsuario.MinimumWidth = 6;
            IdUsuario.Name = "IdUsuario";
            IdUsuario.Visible = false;
            IdUsuario.Width = 125;
            // 
            // IdSucursal
            // 
            IdSucursal.DataPropertyName = "IdSucursal";
            IdSucursal.HeaderText = "IdSucursal";
            IdSucursal.Name = "IdSucursal";
            IdSucursal.Visible = false;
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
            Apellidos.Name = "Apellidos";
            // 
            // Identificacion
            // 
            Identificacion.DataPropertyName = "Identificacion";
            Identificacion.HeaderText = "Identificacion";
            Identificacion.Name = "Identificacion";
            // 
            // IdRol
            // 
            IdRol.DataPropertyName = "IdRol";
            IdRol.HeaderText = "Rol";
            IdRol.MinimumWidth = 6;
            IdRol.Name = "IdRol";
            IdRol.Visible = false;
            IdRol.Width = 125;
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
            Contrasenna.MinimumWidth = 6;
            Contrasenna.Name = "Contrasenna";
            Contrasenna.Visible = false;
            Contrasenna.Width = 125;
            // 
            // FechaCreacion
            // 
            FechaCreacion.DataPropertyName = "FechaCreacion";
            FechaCreacion.HeaderText = "FechaCreacion";
            FechaCreacion.MinimumWidth = 6;
            FechaCreacion.Name = "FechaCreacion";
            FechaCreacion.Visible = false;
            FechaCreacion.Width = 125;
            // 
            // Activo
            // 
            Activo.DataPropertyName = "Activo";
            Activo.HeaderText = "Activo";
            Activo.MinimumWidth = 6;
            Activo.Name = "Activo";
            Activo.Width = 80;
            // 
            // lblListaUsuarios
            // 
            lblListaUsuarios.Font = new Font("Segoe UI", 22F);
            lblListaUsuarios.Location = new Point(28, 47);
            lblListaUsuarios.Name = "lblListaUsuarios";
            lblListaUsuarios.Size = new Size(290, 52);
            lblListaUsuarios.TabIndex = 17;
            lblListaUsuarios.Text = "Lista de Usuarios";
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 620);
            Controls.Add(lblListaUsuarios);
            Controls.Add(btnLimpiarBuscador);
            Controls.Add(btnBuscar);
            Controls.Add(cmbTipoUsuario);
            Controls.Add(lblTipoUsuario);
            Controls.Add(btnAgregar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(gridUsuarios);
            Name = "frmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiarBuscador;
        private Button btnBuscar;
        private ComboBox cmbTipoUsuario;
        private Label lblTipoUsuario;
        private Button btnAgregar;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private DataGridView gridUsuarios;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn IdSucursal;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Identificacion;
        private DataGridViewTextBoxColumn IdRol;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Contrasenna;
        private DataGridViewTextBoxColumn FechaCreacion;
        private DataGridViewTextBoxColumn Activo;
        private Label lblListaUsuarios;
    }
}