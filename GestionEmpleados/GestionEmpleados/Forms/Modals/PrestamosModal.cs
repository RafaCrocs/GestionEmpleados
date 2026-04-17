using GestionEmpleados.BL.Empresa;
using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionEmpleados.Forms.Modals
{
    public partial class PrestamosModal : Form
    {
        public PrestamosModal(Prestamo prestamoAEditar = null)
        {
            InitializeComponent();
            PrestamoAEditar = prestamoAEditar;
        }

        public Prestamo NuevoPrestamo;
        public Prestamo PrestamoAEditar;

        private EmpleadosBL empleadosBL = new EmpleadosBL();
        private List<Empleado> empleados;

        private void CargarEmpleados()
        {
            empleados = empleadosBL.Empleados_ObtenerTodos();
            cmbEmpleados.DataSource = empleados;
            cmbEmpleados.DisplayMember = "NombreCompleto";
            cmbEmpleados.ValueMember = "IdEmpleado";
            cmbEmpleados.SelectedIndex = -1;
        }

        private void CargarDatos()
        {
            if (PrestamoAEditar != null)
            {
                cmbEmpleados.SelectedValue = PrestamoAEditar.IdEmpleado.IdEmpleado;
                txtMonto.Text = PrestamoAEditar.Monto.ToString("F2");
                numCuotas.Value = PrestamoAEditar.Cuotas;
                txtDetalle.Text = PrestamoAEditar.Detalle;
            }
        }

        private void PrestamosModal_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(cmbEmpleados.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtMonto.Text == "" || !decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                MessageBox.Show("Ingrese un monto válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(numCuotas.Value <= 0)
            {
                MessageBox.Show("Ingrese un número de cuotas válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtDetalle.Text == "")
            {
                MessageBox.Show("Ingrese un detalle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(PrestamoAEditar == null)
            {
                if (MessageBox.Show("¿Desea crear un nuevo préstamo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NuevoPrestamo = new Prestamo
                    {
                        IdEmpleado = cmbEmpleados.SelectedItem as Empleado,
                        Monto = monto,
                        Cuotas = Convert.ToInt32(numCuotas.Value),
                        Detalle = txtDetalle.Text
                    };
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                if(MessageBox.Show("¿Desea guardar los cambios al préstamo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PrestamoAEditar.IdEmpleado = cmbEmpleados.SelectedItem as Empleado;
                    PrestamoAEditar.Monto = monto;
                    PrestamoAEditar.Cuotas = Convert.ToInt32(numCuotas.Value);
                    PrestamoAEditar.Detalle = txtDetalle.Text;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
