namespace GestionEmpleados.Forms.Empleados
{
    partial class frmRegistroPrestamos
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
            gridRegistroPrestamos = new DataGridView();
            IdRegistroPrestamo = new DataGridViewTextBoxColumn();
            IdPrestamo = new DataGridViewTextBoxColumn();
            IdEmpleado = new DataGridViewTextBoxColumn();
            NombreEmpleado = new DataGridViewTextBoxColumn();
            MontoPagado = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridRegistroPrestamos).BeginInit();
            SuspendLayout();
            // 
            // gridRegistroPrestamos
            // 
            gridRegistroPrestamos.BackgroundColor = SystemColors.Control;
            gridRegistroPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRegistroPrestamos.Columns.AddRange(new DataGridViewColumn[] { IdRegistroPrestamo, IdPrestamo, IdEmpleado, NombreEmpleado, MontoPagado, Fecha });
            gridRegistroPrestamos.Location = new Point(41, 132);
            gridRegistroPrestamos.Name = "gridRegistroPrestamos";
            gridRegistroPrestamos.Size = new Size(688, 290);
            gridRegistroPrestamos.TabIndex = 0;
            gridRegistroPrestamos.CellFormatting += gridRegistroPrestamos_CellFormatting;
            // 
            // IdRegistroPrestamo
            // 
            IdRegistroPrestamo.DataPropertyName = "IdRegistroPrestamo";
            IdRegistroPrestamo.HeaderText = "IdRegistroPrestamo";
            IdRegistroPrestamo.Name = "IdRegistroPrestamo";
            IdRegistroPrestamo.Visible = false;
            // 
            // IdPrestamo
            // 
            IdPrestamo.DataPropertyName = "IdPrestamo";
            IdPrestamo.HeaderText = "IdPrestamo";
            IdPrestamo.Name = "IdPrestamo";
            IdPrestamo.Visible = false;
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
            NombreEmpleado.HeaderText = "NombreEmpleado";
            NombreEmpleado.Name = "NombreEmpleado";
            // 
            // MontoPagado
            // 
            MontoPagado.DataPropertyName = "MontoPagado";
            MontoPagado.HeaderText = "MontoPagado";
            MontoPagado.Name = "MontoPagado";
            MontoPagado.Width = 150;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // frmRegistroPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridRegistroPrestamos);
            Name = "frmRegistroPrestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegistroPrestamos";
            Load += frmRegistroPrestamos_Load;
            ((System.ComponentModel.ISupportInitialize)gridRegistroPrestamos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridRegistroPrestamos;
        private DataGridViewTextBoxColumn IdRegistroPrestamo;
        private DataGridViewTextBoxColumn IdPrestamo;
        private DataGridViewTextBoxColumn IdEmpleado;
        private DataGridViewTextBoxColumn NombreEmpleado;
        private DataGridViewTextBoxColumn MontoPagado;
        private DataGridViewTextBoxColumn Fecha;
    }
}