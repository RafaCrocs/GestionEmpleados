using System;
using GestionEmpleados.Forms.Admin;
using GestionEmpleados.Forms.Empleados;
using GestionEmpleados.Entities.Admin;
using System.Windows.Forms;

namespace GestionEmpleados
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private static Usuario? UsuarioActual;

        public Inicio(Usuario usuario)
        {
            InitializeComponent();
            UsuarioActual = usuario;
        }

        #region eventos
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
        private void AdelantosSubMenuItem_Click(object sender, EventArgs e)
        {
            frmAdelantos menuAdelantos = new frmAdelantos();
            menuAdelantos.ShowDialog(this);
        }
        #endregion eventos

    }
}
