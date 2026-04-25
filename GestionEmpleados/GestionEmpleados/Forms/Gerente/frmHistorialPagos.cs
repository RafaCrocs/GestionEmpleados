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

namespace GestionEmpleados.Forms.Gerente
{
    public partial class frmHistorialPagos : Form
    {
        public frmHistorialPagos()
        {
            InitializeComponent();
        }

        private RegistroPagosBL registroPagosBL = new RegistroPagosBL();
        private List<RegistroPago> registroPagos = new List<RegistroPago>();

        private void CargarGridCompleto()
        {
            registroPagos = registroPagosBL.RegistroPagos_ObtenerTodos(out string mensaje);
            gridHistorialPagos.DataSource = registroPagos;
        }

        private void frmHistorialPagos_Load(object sender, EventArgs e)
        {
            CargarGridCompleto();
        }

        private void gridHistorialPagos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridHistorialPagos.Columns[e.ColumnIndex].Name == "SalarioReal" ||
                gridHistorialPagos.Columns[e.ColumnIndex].Name == "SalarioPagado" ||
                gridHistorialPagos.Columns[e.ColumnIndex].Name == "SalarioReportado" ||
                gridHistorialPagos.Columns[e.ColumnIndex].Name == "Seguro" ||
                gridHistorialPagos.Columns[e.ColumnIndex].Name == "Adelanto" ||
                gridHistorialPagos.Columns[e.ColumnIndex].Name == "Prestamo" ||
                gridHistorialPagos.Columns[e.ColumnIndex].Name == "Bonificacion")
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDecimal(e.Value).ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));
                    e.FormattingApplied = true;
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length >= 3)
            {
                var listaFiltrada = registroPagos.Where(x => (x.NombreEmpleado ?? "").ToLower().Contains((txtNombre.Text).ToLower())).ToList();
                gridHistorialPagos.DataSource = listaFiltrada;
            }
            else
            {
                gridHistorialPagos.DataSource = registroPagos;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            registroPagos = registroPagosBL.RegistroPagos_ObtenerTodos(out string mensaje, null, dateBusquedaFecha.Value);
            gridHistorialPagos.DataSource = registroPagos;
        }

        private void btnRestablecerBusqueda_Click(object sender, EventArgs e)
        {
            registroPagos = registroPagosBL.RegistroPagos_ObtenerTodos(out string mensaje);
            gridHistorialPagos.DataSource = registroPagos;
            dateBusquedaFecha.Value = DateTime.Now;
        }
    }
}
