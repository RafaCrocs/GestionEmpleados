using GestionEmpleados.BL.Empresa;
using GestionEmpleados.DAL.Empresa;
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

namespace GestionEmpleados.Forms.Empleados
{
    public partial class frmAdelantos : Form
    {
        public frmAdelantos()
        {
            InitializeComponent();
        }
        private AdelantosBL adelantosBL = new AdelantosBL();
        private List<Adelanto> adelantos;

        public Adelanto NuevoAdelanto;
        public Adelanto AdelantoAEditar;

        private void CargarAdelantos()
        {
            adelantos = adelantosBL.Adelantos_ObtenerTodos();
            gridAdelantos.DataSource = adelantos;
        }
        private void frmAdelantos_Load(object sender, EventArgs e)
        {
            CargarAdelantos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AdelantoModal modal = new AdelantoModal();
            modal.ShowDialog();
            if (modal.DialogResult == DialogResult.OK)
            {
                if (adelantosBL.Adelantos_Insertar(modal.NuevoAdelanto, out string mensaje))
                {
                    MessageBox.Show("Su adelanto ha sido agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Ha ocurrido un problema: {mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            CargarAdelantos();

        }

        private void gridAdelantos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idSeleccionado = Convert.ToInt32(gridAdelantos.Rows[e.RowIndex].Cells[1].Value);

            if (gridAdelantos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                var adelantoSeleccionado = adelantos[e.RowIndex];
                var confirmacion = MessageBox.Show($"¿Está seguro que desea eliminar el adelanto de {adelantoSeleccionado.NombreEmpleado} por C{adelantoSeleccionado.Monto}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmacion == DialogResult.Yes)
                {
                    if (adelantosBL.Adelantos_Eliminar(idSeleccionado))
                    {
                        MessageBox.Show("Adelanto eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    CargarAdelantos();
                }
            }
        }

        private void gridAdelantos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(gridAdelantos.Columns[e.ColumnIndex].Name == "Monto")
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
