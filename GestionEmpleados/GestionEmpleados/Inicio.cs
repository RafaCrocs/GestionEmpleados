using System;
using GestionEmpleados.Forms.Admin;
using GestionEmpleados.Forms.Empleados;

namespace GestionEmpleados
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void usuariosSysSubMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios menuUsuarios = new frmUsuarios();
            menuUsuarios.ShowDialog(this);
        }

        private void EmpleadosSubMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados menuEmpleados = new frmEmpleados();
            menuEmpleados.ShowDialog(this);
        }
    }
}
