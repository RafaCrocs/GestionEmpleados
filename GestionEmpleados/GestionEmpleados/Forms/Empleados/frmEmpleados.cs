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
            gridEmpleados.AutoGenerateColumns = false;
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

        private void ConfigurarColumnas()
        {
            gridEmpleados.Columns.Clear();

            gridEmpleados.Columns.Add(new DataGridViewButtonColumn { Name = "Editar", HeaderText = "", Text = "Editar", UseColumnTextForButtonValue = true });
            gridEmpleados.Columns.Add(new DataGridViewButtonColumn { Name = "Eliminar", HeaderText = "", Text = "Eliminar", UseColumnTextForButtonValue = true });

            // Columna visible (índice 2, usada para obtener idSeleccionado)
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "IdEmpleado", DataPropertyName = "IdEmpleado", HeaderText = "ID", Visible = false });

            // Columnas ocultas necesarias para edición
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "IdSucursal", DataPropertyName = "IdSucursal", Visible = false });
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "Identificacion", DataPropertyName = "Identificacion", Visible = false });
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", DataPropertyName = "Nombre", Visible = false });
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "Apellidos", DataPropertyName = "Apellidos", Visible = false });
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "Telefono", DataPropertyName = "Telefono", Visible = false });
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "Correo", DataPropertyName = "Correo", Visible = false });
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "Contrasenna", DataPropertyName = "Contrasenna", Visible = false });
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "FechaNacimiento", DataPropertyName = "FechaNacimiento", Visible = false });
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "FechaIngreso", DataPropertyName = "FechaIngreso", Visible = false });
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "FechaSalida", DataPropertyName = "FechaSalida", Visible = false });
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "IdPuesto", DataPropertyName = "IdPuesto", Visible = false });
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "SalarioReal", DataPropertyName = "SalarioReal", Visible = false });
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "SalarioReportado", DataPropertyName = "SalarioReportado", Visible = false });
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "Seguro", DataPropertyName = "Seguro", Visible = false });

            // Columnas visibles
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "NombreCompleto", DataPropertyName = "NombreCompleto", HeaderText = "Nombre Empleado", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "NombrePuesto", DataPropertyName = "NombrePuesto", HeaderText = "Puesto" });
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "ValorHora", DataPropertyName = "ValorHora", HeaderText = "Valor Hora" });
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "Bonificacion", DataPropertyName = "Bonificacion", HeaderText = "Bonificacion" });
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "PagaSeguro", DataPropertyName = "PagaSeguro", HeaderText = "Paga Seguro?" });
            gridEmpleados.Columns.Add(new DataGridViewTextBoxColumn { Name = "Estado", DataPropertyName = "Estado", HeaderText = "Estado" });
        }
        #endregion Metodos

        #region Eventos
        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            gridEmpleados.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            ConfigurarColumnas();
            CargarCombos();
            cargarGrid();
        }
        #endregion Eventos

        private void gridEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idSeleccionado = Convert.ToInt32(gridEmpleados.Rows[e.RowIndex].Cells["IdEmpleado"].Value);
            if (gridEmpleados.Columns[e.ColumnIndex].Name == "Editar")
            {
                empleadoAEditar = new Empleado()
                {
                    IdEmpleado = idSeleccionado,
                    IdSucursal = gridEmpleados.Rows[e.RowIndex].Cells["IdSucursal"].Value as Sucursal,
                    Identificacion = gridEmpleados.Rows[e.RowIndex].Cells["Identificacion"].Value?.ToString(),
                    Nombre = gridEmpleados.Rows[e.RowIndex].Cells["Nombre"].Value?.ToString(),
                    Apellidos = gridEmpleados.Rows[e.RowIndex].Cells["Apellidos"].Value?.ToString(),
                    Telefono = gridEmpleados.Rows[e.RowIndex].Cells["Telefono"].Value?.ToString(),
                    Correo = gridEmpleados.Rows[e.RowIndex].Cells["Correo"].Value?.ToString(),
                    Contrasenna = gridEmpleados.Rows[e.RowIndex].Cells["Contrasenna"].Value?.ToString(),
                    FechaNacimiento = Convert.ToDateTime(gridEmpleados.Rows[e.RowIndex].Cells["FechaNacimiento"].Value),
                    FechaIngreso = Convert.ToDateTime(gridEmpleados.Rows[e.RowIndex].Cells["FechaIngreso"].Value),
                    FechaSalida = gridEmpleados.Rows[e.RowIndex].Cells["FechaSalida"].Value != null
                                        ? Convert.ToDateTime(gridEmpleados.Rows[e.RowIndex].Cells["FechaSalida"].Value)
                                        : null,
                    IdPuesto = gridEmpleados.Rows[e.RowIndex].Cells["IdPuesto"].Value as Puesto,
                    SalarioReal = gridEmpleados.Rows[e.RowIndex].Cells["SalarioReal"].Value != null ? Convert.ToDecimal(gridEmpleados.Rows[e.RowIndex].Cells["SalarioReal"].Value) : 0,
                    SalarioReportado = gridEmpleados.Rows[e.RowIndex].Cells["SalarioReportado"].Value != null ? Convert.ToDecimal(gridEmpleados.Rows[e.RowIndex].Cells["SalarioReportado"].Value) : 0,
                    Seguro = gridEmpleados.Rows[e.RowIndex].Cells["Seguro"].Value != null ? Convert.ToDecimal(gridEmpleados.Rows[e.RowIndex].Cells["Seguro"].Value) : 0,
                    ValorHora = gridEmpleados.Rows[e.RowIndex].Cells["ValorHora"].Value != null ? Convert.ToDecimal(gridEmpleados.Rows[e.RowIndex].Cells["ValorHora"].Value) : 0,
                    Bonificacion = gridEmpleados.Rows[e.RowIndex].Cells["Bonificacion"].Value != null ? Convert.ToDecimal(gridEmpleados.Rows[e.RowIndex].Cells["Bonificacion"].Value) : 0,
                    PagaSeguro = Convert.ToBoolean(gridEmpleados.Rows[e.RowIndex].Cells["PagaSeguro"].Value),
                    Estado = gridEmpleados.Rows[e.RowIndex].Cells["Estado"].Value?.ToString()
                };

                EmpleadosModal modal = new EmpleadosModal(empleadoAEditar);
                modal.ShowDialog(this);
                if (modal.DialogResult == DialogResult.OK)
                    if (empleadosBL.Empleados_Editar(modal.EmpleadoAEditar, out string mensaje))
                    {
                        MessageBox.Show("Su empleado ha sido Editado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarGrid();
                    }
                    else
                    {
                        MessageBox.Show($"Ha ocurrido un problema: {mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else if (gridEmpleados.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("Realmente deseas eliminar al empleado?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (empleadosBL.Empleados_Eliminar(idSeleccionado, out string mensaje))
                    {
                        MessageBox.Show("Su empleado ha sido eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarGrid();
                    }
                    else
                    {
                        MessageBox.Show($"Ha ocurrido un problema: {mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
                    cargarGrid();
                }
                else
                {
                    MessageBox.Show($"Ha ocurrido un problema: {mensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void gridEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(gridEmpleados.Columns[e.ColumnIndex].Name == "PagaSeguro" && e.Value != null)
            {
                bool pagaSeguro = Convert.ToBoolean(e.Value);
                e.Value = pagaSeguro ? "Sí" : "No";
                e.FormattingApplied = true;
            }
            if((gridEmpleados.Columns[e.ColumnIndex].Name == "ValorHora" || gridEmpleados.Columns[e.ColumnIndex].Name =="Bonificacion") && e.Value != null)
            {
                decimal valorHora = Convert.ToDecimal(e.Value);
                e.Value = valorHora.ToString("C2", new System.Globalization.CultureInfo("es-CR"));
                e.FormattingApplied = true;
            }
        }
    }
}
