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
            gridLibros = new DataGridView();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            FechaPublicacion = new DataGridViewTextBoxColumn();
            Disponible = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridLibros).BeginInit();
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
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(101, 46);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(183, 23);
            txtBuscar.TabIndex = 15;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(37, 48);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(54, 15);
            lblBuscar.TabIndex = 14;
            lblBuscar.Text = "BUSCAR:";
            // 
            // gridLibros
            // 
            gridLibros.AllowUserToAddRows = false;
            gridLibros.BackgroundColor = Color.White;
            gridLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridLibros.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar, Id, Titulo, Autor, Genero, FechaPublicacion, Disponible });
            gridLibros.Location = new Point(37, 78);
            gridLibros.Margin = new Padding(3, 2, 3, 2);
            gridLibros.Name = "gridLibros";
            gridLibros.RowHeadersWidth = 51;
            gridLibros.Size = new Size(858, 372);
            gridLibros.TabIndex = 13;
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
            // Titulo
            // 
            Titulo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Titulo.DataPropertyName = "Titulo";
            Titulo.HeaderText = "Titulo";
            Titulo.MinimumWidth = 6;
            Titulo.Name = "Titulo";
            // 
            // Autor
            // 
            Autor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Autor.DataPropertyName = "Autor";
            Autor.HeaderText = "Autor";
            Autor.MinimumWidth = 6;
            Autor.Name = "Autor";
            // 
            // Genero
            // 
            Genero.DataPropertyName = "Genero";
            Genero.HeaderText = "Genero";
            Genero.MinimumWidth = 6;
            Genero.Name = "Genero";
            Genero.Width = 120;
            // 
            // FechaPublicacion
            // 
            FechaPublicacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FechaPublicacion.DataPropertyName = "FechaPublicacion";
            FechaPublicacion.HeaderText = "Fecha de Publicacion";
            FechaPublicacion.MinimumWidth = 6;
            FechaPublicacion.Name = "FechaPublicacion";
            // 
            // Disponible
            // 
            Disponible.DataPropertyName = "Disponible";
            Disponible.HeaderText = "Disponible";
            Disponible.MinimumWidth = 6;
            Disponible.Name = "Disponible";
            Disponible.Width = 90;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 514);
            Controls.Add(btnAgregar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(gridLibros);
            Name = "frmEmpleados";
            Text = "frmEmpleados";
            ((System.ComponentModel.ISupportInitialize)gridLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private DataGridView gridLibros;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn FechaPublicacion;
        private DataGridViewTextBoxColumn Disponible;
    }
}