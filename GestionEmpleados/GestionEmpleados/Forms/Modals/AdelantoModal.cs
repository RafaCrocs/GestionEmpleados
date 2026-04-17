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
    public partial class AdelantoModal : Form
    {
        public AdelantoModal(Adelanto adelantoAEditar = null)
        {
            InitializeComponent();
            AdelantoAEditar = adelantoAEditar;
        }

        public Adelanto NuevoAdelanto;
        public Adelanto AdelantoAEditar;

        private EmpleadosBL empleadosBL = new EmpleadosBL();
        private List<Empleado> empleados;

        private void CargarCombo()
        {
            empleados = empleadosBL.Empleados_ObtenerTodos();
            cmbEmpleados.DataSource = empleados;
            cmbEmpleados.DisplayMember = "NombreCompleto";
            cmbEmpleados.ValueMember = "IdEmpleado";
            cmbEmpleados.SelectedIndex = -1;
        }

        private void CargarDatos()
        {
            if (AdelantoAEditar != null)
            {
                cmbEmpleados.SelectedValue = AdelantoAEditar.IdEmpleado.IdEmpleado;
                txtMonto.Text = AdelantoAEditar.Monto.ToString("F2");
                txtDetalle.Text = AdelantoAEditar.Detalle;
            }
        }

        private void AdelantoModal_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtMonto.Text == "" || !decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                MessageBox.Show("Ingrese un monto válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbEmpleados.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (AdelantoAEditar != null)
            {
                if(MessageBox.Show("Realmente deseas editar el adelanto?", "EDITAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AdelantoAEditar.IdEmpleado = cmbEmpleados.SelectedItem as Empleado;
                    AdelantoAEditar.Monto = monto;
                    AdelantoAEditar.Detalle = txtDetalle.Text;
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                if(MessageBox.Show("Realmente deseas agregar el adelanto?", "AGREGAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NuevoAdelanto = new Adelanto
                    {
                        IdEmpleado = cmbEmpleados.SelectedItem as Empleado,
                        Monto = monto,
                        Detalle = txtDetalle.Text
                    };
                    this.DialogResult = DialogResult.OK;
                }
            }

        }
    }
}
