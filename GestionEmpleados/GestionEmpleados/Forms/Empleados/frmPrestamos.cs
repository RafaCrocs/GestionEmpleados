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

namespace GestionEmpleados.Forms.Empleados
{
    public partial class frmPrestamos : Form
    {
        public frmPrestamos()
        {
            InitializeComponent();
        }
        public Prestamo NuevoPrestamo;
        public Prestamo PrestamoAEditar;

        private PrestamosBL prestamosBL = new PrestamosBL();
        private List<Prestamo> prestamos;

        private void CargarGrid()
        {
            prestamos = prestamosBL.Prestamos_ObtenerTodos();
            gridPrestamos.DataSource = prestamos;
        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PrestamosModal modal = new PrestamosModal();
            if (modal.ShowDialog() == DialogResult.OK)
            {
                if (prestamosBL.Prestamos_Insertar(modal.NuevoPrestamo, out string mensaje))
                {
                    MessageBox.Show("Préstamo agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show($"Error al agregar el préstamo: {mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CargarGrid();
            }
        }

        private void gridPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;


            int idSleccionado = Convert.ToInt32(gridPrestamos.Rows[e.RowIndex].Cells[2].Value);

            if (gridPrestamos.Columns[e.ColumnIndex].Name == "Editar")
            {
                PrestamoAEditar = new Prestamo()
                {
                    IdPrestamo = idSleccionado,
                    IdEmpleado = (Empleado)gridPrestamos.Rows[e.RowIndex].Cells["IdEmpleado"].Value,
                    Monto = Convert.ToDecimal(gridPrestamos.Rows[e.RowIndex].Cells["Monto"].Value),
                    SugerenciaDeRebajo = Convert.ToDecimal(gridPrestamos.Rows[e.RowIndex].Cells["SugerenciaDeRebajo"].Value),
                    FechaInicio = Convert.ToDateTime(gridPrestamos.Rows[e.RowIndex].Cells["FechaInicio"].Value),
                    MontoRestante = Convert.ToDecimal(gridPrestamos.Rows[e.RowIndex].Cells["MontoRestante"].Value),
                    MontoPagado = Convert.ToDecimal(gridPrestamos.Rows[e.RowIndex].Cells["MontoPagado"].Value),
                    Detalle = gridPrestamos.Rows[e.RowIndex].Cells["Detalle"].Value.ToString()
                };
                PrestamosModal modal = new PrestamosModal(PrestamoAEditar);
                modal.ShowDialog(this);
                if (modal.DialogResult == DialogResult.OK)
                {
                    if (prestamosBL.Prestamos_Editar(modal.PrestamoAEditar, out string mensaje))
                    {
                        MessageBox.Show("Préstamo actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Error al actualizar el préstamo: {mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    CargarGrid();
                }

            }
            else if (gridPrestamos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("Estas seguro que quieres eliminar el Prestamo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int idSeleccionado = Convert.ToInt32(gridPrestamos.Rows[e.RowIndex].Cells[2].Value);
                    if (prestamosBL.Prestamos_Eliminar(idSeleccionado, out string mensaje))
                    {
                        MessageBox.Show("Préstamo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Error al eliminar el préstamo: {mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    CargarGrid();
                }
            }
        }

        private void gridPrestamos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(gridPrestamos.Columns[e.ColumnIndex].Name == "Monto" ||
               gridPrestamos.Columns[e.ColumnIndex].Name == "MontoRestante" ||
               gridPrestamos.Columns[e.ColumnIndex].Name == "SugerenciaDeRebajo" ||
               gridPrestamos.Columns[e.ColumnIndex].Name == "MontoPagado")
            {
                if (e.Value != null)
                {
                    e.Value = Convert.ToDecimal(e.Value).ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
