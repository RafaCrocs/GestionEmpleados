namespace GestionEmpleados.Forms.Admin
{
    partial class frmPuestos_Seguros
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
            gridPuestos_Seguros = new DataGridView();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            IdPuesto = new DataGridViewTextBoxColumn();
            NombrePuesto = new DataGridViewTextBoxColumn();
            SalarioReportado = new DataGridViewTextBoxColumn();
            PorcentajeSeguro = new DataGridViewTextBoxColumn();
            Seguro = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            lblEmpleados = new Label();
            ((System.ComponentModel.ISupportInitialize)gridPuestos_Seguros).BeginInit();
            SuspendLayout();
            // 
            // gridPuestos_Seguros
            // 
            gridPuestos_Seguros.BackgroundColor = Color.White;
            gridPuestos_Seguros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPuestos_Seguros.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar, IdPuesto, NombrePuesto, SalarioReportado, PorcentajeSeguro, Seguro });
            gridPuestos_Seguros.Location = new Point(62, 182);
            gridPuestos_Seguros.Name = "gridPuestos_Seguros";
            gridPuestos_Seguros.Size = new Size(851, 308);
            gridPuestos_Seguros.TabIndex = 0;
            gridPuestos_Seguros.CellContentClick += gridPuestos_Seguros_CellContentClick;
            gridPuestos_Seguros.CellFormatting += gridPuestos_Seguros_CellFormatting;
            // 
            // Editar
            // 
            Editar.HeaderText = "";
            Editar.Name = "Editar";
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            Editar.Width = 75;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "";
            Eliminar.Name = "Eliminar";
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            Eliminar.Width = 75;
            // 
            // IdPuesto
            // 
            IdPuesto.DataPropertyName = "IdPuesto";
            IdPuesto.HeaderText = "IdPuesto";
            IdPuesto.MinimumWidth = 7;
            IdPuesto.Name = "IdPuesto";
            IdPuesto.Visible = false;
            // 
            // NombrePuesto
            // 
            NombrePuesto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombrePuesto.DataPropertyName = "Nombre";
            NombrePuesto.HeaderText = "Puesto";
            NombrePuesto.MinimumWidth = 7;
            NombrePuesto.Name = "NombrePuesto";
            // 
            // SalarioReportado
            // 
            SalarioReportado.DataPropertyName = "SalarioReportado";
            SalarioReportado.HeaderText = "SalarioReportado";
            SalarioReportado.Name = "SalarioReportado";
            SalarioReportado.Width = 150;
            // 
            // PorcentajeSeguro
            // 
            PorcentajeSeguro.DataPropertyName = "PorcentajeSeguro";
            PorcentajeSeguro.HeaderText = "Porcentaje de Seguro";
            PorcentajeSeguro.Name = "PorcentajeSeguro";
            PorcentajeSeguro.Width = 75;
            // 
            // Seguro
            // 
            Seguro.DataPropertyName = "Seguro";
            Seguro.HeaderText = "Total de Seguro";
            Seguro.Name = "Seguro";
            Seguro.Width = 150;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(824, 143);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(89, 24);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblEmpleados
            // 
            lblEmpleados.Font = new Font("Segoe UI", 22F);
            lblEmpleados.Location = new Point(62, 40);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(246, 48);
            lblEmpleados.TabIndex = 2;
            lblEmpleados.Text = "Lista de Puestos";
            // 
            // frmPuestos_Seguros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 529);
            Controls.Add(lblEmpleados);
            Controls.Add(btnAgregar);
            Controls.Add(gridPuestos_Seguros);
            Name = "frmPuestos_Seguros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPuestos_Seguros";
            Load += frmPuestos_Seguros_Load;
            ((System.ComponentModel.ISupportInitialize)gridPuestos_Seguros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridPuestos_Seguros;
        private Button btnAgregar;
        private Label lblEmpleados;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewTextBoxColumn IdPuesto;
        private DataGridViewTextBoxColumn NombrePuesto;
        private DataGridViewTextBoxColumn SalarioReportado;
        private DataGridViewTextBoxColumn PorcentajeSeguro;
        private DataGridViewTextBoxColumn Seguro;
    }
}