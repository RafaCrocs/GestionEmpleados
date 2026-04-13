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
            Id = new DataGridViewTextBoxColumn();
            TipoUsuarioSysId = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Activo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiarBuscador
            // 
            btnLimpiarBuscador.Location = new Point(411, 45);
            btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            btnLimpiarBuscador.Size = new Size(61, 23);
            btnLimpiarBuscador.TabIndex = 16;
            btnLimpiarBuscador.Text = "Limpiar";
            btnLimpiarBuscador.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(323, 46);
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
            cmbTipoUsuario.Location = new Point(135, 46);
            cmbTipoUsuario.Margin = new Padding(3, 2, 3, 2);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(183, 23);
            cmbTipoUsuario.TabIndex = 14;
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Location = new Point(30, 46);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(90, 15);
            lblTipoUsuario.TabIndex = 13;
            lblTipoUsuario.Text = "Tipo de Usuario";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(757, 76);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 22);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(135, 76);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(183, 23);
            txtBuscar.TabIndex = 11;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(30, 76);
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
            gridUsuarios.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar, Id, TipoUsuarioSysId, Nombre, Correo, Genero, FechaNacimiento, FechaCreacion, Password, Activo });
            gridUsuarios.Location = new Point(30, 106);
            gridUsuarios.Margin = new Padding(3, 2, 3, 2);
            gridUsuarios.Name = "gridUsuarios";
            gridUsuarios.RowHeadersWidth = 51;
            gridUsuarios.Size = new Size(838, 372);
            gridUsuarios.TabIndex = 9;
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
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 125;
            // 
            // TipoUsuarioSysId
            // 
            TipoUsuarioSysId.DataPropertyName = "TipoUsuarioSysId";
            TipoUsuarioSysId.HeaderText = "TipoUsuarioSysId";
            TipoUsuarioSysId.MinimumWidth = 6;
            TipoUsuarioSysId.Name = "TipoUsuarioSysId";
            TipoUsuarioSysId.Visible = false;
            TipoUsuarioSysId.Width = 125;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // Correo
            // 
            Correo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Correo.DataPropertyName = "Correo";
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            // 
            // Genero
            // 
            Genero.DataPropertyName = "Genero";
            Genero.HeaderText = "Genero";
            Genero.MinimumWidth = 6;
            Genero.Name = "Genero";
            Genero.Width = 80;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FechaNacimiento.DataPropertyName = "FechaNacimiento";
            FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            FechaNacimiento.MinimumWidth = 6;
            FechaNacimiento.Name = "FechaNacimiento";
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
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.Visible = false;
            Password.Width = 125;
            // 
            // Activo
            // 
            Activo.DataPropertyName = "Activo";
            Activo.HeaderText = "Activo";
            Activo.MinimumWidth = 6;
            Activo.Name = "Activo";
            Activo.Visible = false;
            Activo.Width = 125;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 521);
            Controls.Add(btnLimpiarBuscador);
            Controls.Add(btnBuscar);
            Controls.Add(cmbTipoUsuario);
            Controls.Add(lblTipoUsuario);
            Controls.Add(btnAgregar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(gridUsuarios);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn TipoUsuarioSysId;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn FechaCreacion;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Activo;
    }
}