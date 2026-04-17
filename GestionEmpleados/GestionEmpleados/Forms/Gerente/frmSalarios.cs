using GestionEmpleados.BL;
using GestionEmpleados.BL.Empresa;
using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void frmSalarios_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            empleados = empleadosBL.Empleados_ObtenerTodos();
            cmbEmpleados.DataSource = empleados;
            cmbEmpleados.DisplayMember = "NombreCompleto";
            cmbEmpleados.SelectedIndex = -1;

        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpleados.SelectedIndex != -1)
            {
                var empleadoSeleccionado = (Empleado)cmbEmpleados.SelectedItem;
                salariosBL.Salarios_ObtenerTodos(empleadoSeleccionado.IdEmpleado, out string mensaje);

            }
        }
    }
}
