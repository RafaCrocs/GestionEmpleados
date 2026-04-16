using GestionEmpleados.BL.Admin;
using GestionEmpleados.BL.Empresa;
using GestionEmpleados.DAL.Admin;
using GestionEmpleados.Entities.Admin;
using GestionEmpleados.Forms.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionEmpleados.Forms.Empleados
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }
        #region Variables
        private List<Empleado> listaEmpleados = new List<Empleado>();
        private EmpleadosBL empleadosBL = new EmpleadosBL();
        private List<Puesto> listaPuestos = new List<Puesto>();
        private PuestosBL puestosBL = new PuestosBL();

        public Empleado empleadoAEditar;

        public Empleado NuevoEmpleado;
        #endregion Variables

        #region Metodos
        private void cargarGrid()
        {
            listaEmpleados = empleadosBL.Empleados_ObtenerTodos();
            gridEmpleados.DataSource = listaEmpleados;

        }

        private void CargarCombos()
        {
            listaPuestos = puestosBL.Puestos_ObtenerTodos();
            cmbPuestos.DataSource = listaPuestos;
            cmbPuestos.DisplayMember = "Nombre";
            cmbPuestos.ValueMember = "IdPuesto";
            cmbPuestos.SelectedIndex = -1;
        }
        #endregion Metodos

        #region Eventos
        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            CargarCombos();
            cargarGrid();
        }
        #endregion Eventos

        private void gridEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idSeleccionado = Convert.ToInt32(gridEmpleados.Rows[e.RowIndex].Cells[2].Value);
            if (gridEmpleados.Columns[e.ColumnIndex].Name == "Editar")
            {
                empleadoAEditar = new Empleado()
                {
                    IdEmpleado = idSeleccionado,
                    IdSucursal = (Sucursal)gridEmpleados.Rows[e.RowIndex].Cells["IdSucursal"].Value,
                    Identificacion = gridEmpleados.Rows[e.RowIndex].Cells["Identificacion"].Value.ToString(),
                    Nombre = gridEmpleados.Rows[e.RowIndex].Cells["Nombre"].Value.ToString(),
                    Apellidos = gridEmpleados.Rows[e.RowIndex].Cells["Apellidos"].Value.ToString(),
                    Telefono = gridEmpleados.Rows[e.RowIndex].Cells["Telefono"].Value.ToString(),
                    Correo = gridEmpleados.Rows[e.RowIndex].Cells["Correo"].Value.ToString(),
                    Contrasenna = gridEmpleados.Rows[e.RowIndex].Cells["Contrasenna"].Value.ToString(),
                    FechaNacimiento = Convert.ToDateTime(gridEmpleados.Rows[e.RowIndex].Cells["FechaNacimiento"].Value),
                    FechaIngreso = Convert.ToDateTime(gridEmpleados.Rows[e.RowIndex].Cells["FechaIngreso"].Value),
                    FechaSalida = gridEmpleados.Rows[e.RowIndex].Cells["FechaSalida"].Value == null ? null : (DateTime?)Convert.ToDateTime(gridEmpleados.Rows[e.RowIndex].Cells["FechaSalida"].Value),
                    IdPuesto = (Puesto)gridEmpleados.Rows[e.RowIndex].Cells["IdPuesto"].Value,
                    Bonificacion = Convert.ToDecimal(gridEmpleados.Rows[e.RowIndex].Cells["Bonificacion"].Value),
                    PagaSeguro = Convert.ToBoolean(gridEmpleados.Rows[e.RowIndex].Cells["PagaSeguro"].Value),
                    Estado = gridEmpleados.Rows[e.RowIndex].Cells["Estado"].Value.ToString()
                };

                EmpleadosModal modal = new EmpleadosModal(empleadoAEditar);
                modal.ShowDialog(this);
                if (modal.DialogResult == DialogResult.OK)
                    if (empleadosBL.Empleados_Editar(modal.EmpleadoAEditar))
                    {
                        MessageBox.Show("Su empleado ha sido Editado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            }
            else if (gridEmpleados.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("Realmente deseas eliminar al empleado?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (empleadosBL.Empleados_Eliminar(idSeleccionado, out string mensaje))
                    {
                        MessageBox.Show("Su empleado ha sido eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show($"Ha ocurrido un problema: {mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cargarGrid();
                    }
                }
                cargarGrid();
            }
        }
            

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EmpleadosModal modal = new EmpleadosModal(null);
            modal.ShowDialog(this);
            if (modal.DialogResult == DialogResult.OK)
            {
                if (empleadosBL.Empleados_Insertar(modal.NuevoEmpleado, out string mensaje))
                {
                    MessageBox.Show("Su empleado ha sido agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Ha ocurrido un problema: {mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            cargarGrid();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length >= 3)
            {
                var listaFiltrada = listaEmpleados.Where(x => (x.Nombre ?? "").ToLower().Contains((txtBuscar.Text).ToLower())
                                                        || (x.Apellidos ?? "").ToLower().Contains((txtBuscar.Text).ToLower())
                                                        || (x.Identificacion ?? "").ToLower().Contains((txtBuscar.Text).ToLower())).ToList();
                gridEmpleados.DataSource = listaFiltrada;
            }
            else
            {
                gridEmpleados.DataSource = listaEmpleados;
            }
        }

        

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            cmbPuestos.SelectedIndex = -1;
            cargarGrid();
        }

        private void cmbPuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPuestos.SelectedIndex != -1)
            {
                var listaFiltrada = listaEmpleados.Where(x => x.IdPuesto?.IdPuesto == Convert.ToInt32(cmbPuestos.SelectedValue)).ToList();
                gridEmpleados.DataSource = listaFiltrada;
            }
            else
            {
                gridEmpleados.DataSource = listaEmpleados;
            }
        }
    }
}
