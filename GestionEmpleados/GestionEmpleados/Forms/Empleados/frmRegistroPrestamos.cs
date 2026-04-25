using GestionEmpleados.BL.Empresa;
using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace GestionEmpleados.Forms.Empleados
{
    public partial class frmRegistroPrestamos : Form
    {
        public frmRegistroPrestamos()
        {
            InitializeComponent();
        }

        private RegistroPrestamosBL registroPrestamosBL = new RegistroPrestamosBL();
        private List<RegistroPrestamo> listaregistroPrestamos;

        private void cargarGrid()
        {
            listaregistroPrestamos = registroPrestamosBL.ObtenerRegistroPrestamos();
            gridRegistroPrestamos.DataSource = listaregistroPrestamos;
        }
        private void frmRegistroPrestamos_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void gridRegistroPrestamos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridRegistroPrestamos.Columns[e.ColumnIndex].Name == "MontoPagado")
            {
                if (e.Value != null)
                {
                    decimal monto = Convert.ToDecimal(e.Value);
                    e.Value = monto.ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
