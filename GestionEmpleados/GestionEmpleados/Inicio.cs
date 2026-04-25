using System;
using GestionEmpleados.Forms.Admin;
using GestionEmpleados.Forms.Empleados;
using GestionEmpleados.Entities.Admin;
using System.Windows.Forms;
using GestionEmpleados.Forms.Gerente;

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
        private void PrestamosSubMenuItem_Click(object sender, EventArgs e)
        {
            frmPrestamos menuPrestamos = new frmPrestamos();
            menuPrestamos.ShowDialog(this);
        }
        private void pagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalarios menuSalarios = new frmSalarios();
            menuSalarios.ShowDialog(this);
        }
        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPuestos_Seguros menuPuestosSeguros = new frmPuestos_Seguros();
            menuPuestosSeguros.ShowDialog(this);
        }
        private void historialDeSalariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorialPagos menuHistorialPagos = new frmHistorialPagos();
            menuHistorialPagos.ShowDialog(this);
        }
        private void historialPrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroPrestamos menuRegistroPrestamos = new frmRegistroPrestamos();
            menuRegistroPrestamos.ShowDialog(this);
        }
        #endregion eventos

    }
}
