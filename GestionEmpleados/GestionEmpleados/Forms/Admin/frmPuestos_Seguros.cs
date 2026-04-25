using GestionEmpleados.BL.Empresa;
using GestionEmpleados.Entities.Admin;
using GestionEmpleados.Forms.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace GestionEmpleados.Forms.Admin
{
    public partial class frmPuestos_Seguros : Form
    {
        public frmPuestos_Seguros()
        {
            InitializeComponent();
        }

        private Puestos_SegurosBL puestos_segurosBL = new Puestos_SegurosBL();
        public List<Puesto> ListaPuestos_Seguros = new List<Puesto>();
        public Puesto editarPuestoSeguro = new Puesto();


        private void CargarGrid()
        {
            ListaPuestos_Seguros = puestos_segurosBL.Puestos_Seguros_ObtenerTodos();
            gridPuestos_Seguros.DataSource = ListaPuestos_Seguros;
        }
        private void frmPuestos_Seguros_Load(object sender, EventArgs e)
        {
            gridPuestos_Seguros.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            gridPuestos_Seguros.RowTemplate.Height = 30;
            CargarGrid();
        }

        private void gridPuestos_Seguros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridPuestos_Seguros.Columns[e.ColumnIndex].Name == "SalarioReportado" ||
        gridPuestos_Seguros.Columns[e.ColumnIndex].Name == "Seguro")
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDecimal(e.Value).ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));
                    e.FormattingApplied = true;
                }
            }

            if (gridPuestos_Seguros.Columns[e.ColumnIndex].Name == "PorcentajeEmpleado" ||
        gridPuestos_Seguros.Columns[e.ColumnIndex].Name == "PorcentajeEmpresa")
            {
                if (e.Value != null)
                {
                    e.Value = $"{e.Value}%";
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Puestos_SegurosModal modal = new Puestos_SegurosModal();
            modal.ShowDialog(this);
            if (modal.DialogResult == DialogResult.OK)
            {
                if (puestos_segurosBL.Puestos_Seguros_Insertar(modal.nuevoPuesto, out string mensaje))
                {
                    MessageBox.Show("Puesto Seguro agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gridPuestos_Seguros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0) { return; }

            if (gridPuestos_Seguros.Columns[e.ColumnIndex].Name == "Editar")
            {
                Puesto puestoSeleccionado = (Puesto)gridPuestos_Seguros.Rows[e.RowIndex].DataBoundItem;
                editarPuestoSeguro = new Puesto
                {
                    IdPuesto = puestoSeleccionado.IdPuesto,
                    Nombre = puestoSeleccionado.Nombre
                };
                Puestos_SegurosModal modal = new Puestos_SegurosModal(editarPuestoSeguro);
                modal.ShowDialog(this);
                if (modal.DialogResult == DialogResult.OK)
                {
                    if (puestos_segurosBL.Puestos_Seguros_Editar(modal.EditarPuesto, out string mensaje))
                    {
                        MessageBox.Show("Puesto Seguro editado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (gridPuestos_Seguros.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Puesto puestoSeleccionado = (Puesto)gridPuestos_Seguros.Rows[e.RowIndex].DataBoundItem;
                if (MessageBox.Show($"¿Está seguro de eliminar el puesto seguro '{puestoSeleccionado.Nombre}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (puestos_segurosBL.Puestos_Seguros_Eliminar(puestoSeleccionado.IdPuesto, out string mensaje))
                    {
                        MessageBox.Show("Puesto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
