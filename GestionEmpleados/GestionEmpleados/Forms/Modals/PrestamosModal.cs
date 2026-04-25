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
                txtMonto.Text = PrestamoAEditar.Monto.ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));
                txtSugerenciaDeRebajo.Text = PrestamoAEditar.SugerenciaDeRebajo.ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));
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
            if (cmbEmpleados.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMonto.Text == "" || !decimal.TryParse(txtMonto.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("es-CR"), out decimal monto))
            {
                MessageBox.Show("Ingrese un monto válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtDetalle.Text == "")
            {
                MessageBox.Show("Ingrese un detalle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PrestamoAEditar == null)
            {
                if (MessageBox.Show("¿Desea crear un nuevo préstamo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NuevoPrestamo = new Prestamo
                    {
                        IdEmpleado = cmbEmpleados.SelectedItem as Empleado,
                        Monto = txtMonto.Text == "" ? 0 : decimal.Parse(txtMonto.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("es-CR")),
                        SugerenciaDeRebajo = txtSugerenciaDeRebajo.Text == "" ? 0 : decimal.Parse(txtSugerenciaDeRebajo.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("es-CR")),
                        Detalle = txtDetalle.Text
                    };
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                if (MessageBox.Show("¿Desea guardar los cambios al préstamo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PrestamoAEditar.IdEmpleado = cmbEmpleados.SelectedItem as Empleado;
                    PrestamoAEditar.Monto = monto;
                    PrestamoAEditar.SugerenciaDeRebajo = txtSugerenciaDeRebajo.Text == "" ? 0 : decimal.Parse(txtSugerenciaDeRebajo.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("es-CR"));
                    PrestamoAEditar.Detalle = txtDetalle.Text;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            txtMonto.Text = decimal.TryParse(txtMonto.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("es-CR"), out decimal monto) ? monto.ToString("C2", CultureInfo.CreateSpecificCulture("es-CR")) : "";
        }

        private void txtSugerenciaDeRebajo_Leave(object sender, EventArgs e)
        {
            txtSugerenciaDeRebajo.Text = decimal.TryParse(txtSugerenciaDeRebajo.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("es-CR"), out decimal sugerencia) ? sugerencia.ToString("C2", CultureInfo.CreateSpecificCulture("es-CR")) : "";
        }
    }
}
