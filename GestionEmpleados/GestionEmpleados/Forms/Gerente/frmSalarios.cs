using GestionEmpleados.BL;
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
    public partial class frmSalarios : Form
    {
        public frmSalarios()
        {
            InitializeComponent();
        }

        private EmpleadosBL empleadosBL = new EmpleadosBL();
        private List<Empleado> empleados;

        private SalariosBL salariosBL = new SalariosBL();
        private List<Salario> salarios;

        private void frmSalarios_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            empleados = empleadosBL.Empleados_ObtenerTodos();
            cmbEmpleados.DataSource = empleados;
            cmbEmpleados.DisplayMember = "NombreCompleto";
            cmbEmpleados.ValueMember = "IdEmpleado";
            cmbEmpleados.SelectedIndex = -1;
        }

        private void CargarDatos(int idSelecciondo)
        {
            salarios = salariosBL.Salarios_ObtenerTodos(idSelecciondo, out string mensaje);
            txtSalarioBase.Text = salarios[0].SalarioBase.ToString();
            txtPrestamo.Text = salarios[0].RebajoDePrestamo.ToString();
            txtSeguro.Text = salarios[0].Seguro.ToString();
            txtHorasTrabajadas.Text = salarios[0].HorasTrabajadas.ToString();
            txtHorasExtra.Text = salarios[0].HorasExtras.ToString();
            txtAdelantos.Text = salarios[0].Adelantos.ToString();
            lblSalarioFinal.Text = $"Salario Final: {salarios[0].Monto.ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"))}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbEmpleados.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un empleado para buscar sus salarios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int idEmpleado = (int)cmbEmpleados.SelectedValue;
            CargarDatos(idEmpleado);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (cmbEmpleados.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un empleado para pagar su salario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idEmpleado = (int)cmbEmpleados.SelectedValue;
            bool resultado = salariosBL.Salarios_PagarSalario(idEmpleado, out string mensaje);

            if (resultado)
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos(idEmpleado);
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
