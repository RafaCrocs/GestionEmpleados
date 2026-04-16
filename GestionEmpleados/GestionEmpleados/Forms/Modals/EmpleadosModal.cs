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
    public partial class EmpleadosModal : Form
    {
        public EmpleadosModal(Empleado empleadoAEditar)
        {
            InitializeComponent();
            EmpleadoAEditar = empleadoAEditar;
        }

        public Empleado EmpleadoAEditar { get; }

        private SucursalesBL sucursalesBL = new SucursalesBL();
        private List<Sucursal> sucursales = new List<Sucursal>();
        private PuestosBL puestosBL = new PuestosBL();
        private List<Puesto> puestos = new List<Puesto>();

        public Empleado NuevoEmpleado;

        private void CargarDatos()
        {
            if (EmpleadoAEditar != null)
            {
                txtNombre.Text = EmpleadoAEditar.Nombre;
                txtApellidos.Text = EmpleadoAEditar.Apellidos;
                txtIdentificacion.Text = EmpleadoAEditar.Identificacion;
                cmbSucursal.SelectedValue = EmpleadoAEditar.IdSucursal.IdSucursal;
                txtTelefono.Text = EmpleadoAEditar.Telefono;
                txtCorreo.Text = EmpleadoAEditar.Correo;
                txtContrasenna.Text = EmpleadoAEditar.Contrasenna;
                cmbPuestos.SelectedValue = EmpleadoAEditar.IdPuesto.IdPuesto;
                dateFechaNacimiento.Value = EmpleadoAEditar.FechaNacimiento;
                txtBonificacion.Text = EmpleadoAEditar.Bonificacion.ToString();
                cmbEstado.SelectedItem = EmpleadoAEditar.Estado;
            }
        }

        private void CargarCombos()
        {
            sucursales = sucursalesBL.Sucursales_ObtenerTodos();
            cmbSucursal.DataSource = sucursales;
            cmbSucursal.DisplayMember = "Nombre";
            cmbSucursal.ValueMember = "IdSucursal";
            cmbSucursal.SelectedIndex = -1;

            puestos = puestosBL.Puestos_ObtenerTodos();
            cmbPuestos.DataSource = puestos;
            cmbPuestos.DisplayMember = "Nombre";
            cmbPuestos.ValueMember = "IdPuesto";
            cmbPuestos.SelectedIndex = -1;

            cmbEstado.DataSource = new List<string>() { "Activo", "Inactivo", "Vacaciones", "Incapacidad" };
        }

        private void EmpleadosModal_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" || 
                txtApellidos.Text.Trim() == "" ||
                txtIdentificacion.Text.Trim() == "" ||
                txtTelefono.Text.Trim() == "" ||
                txtCorreo.Text.Trim() == "" ||
                txtContrasenna.Text.Trim() == "" ||
                txtBonificacion.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!decimal.TryParse(txtBonificacion.Text, out decimal bonificacion))
            {
                MessageBox.Show("La bonificación debe ser un número decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbPuestos.SelectedIndex == -1 || cmbSucursal.SelectedIndex == -1)
            {
                MessageBox.Show("Asegurese seleccionar el Puesto y la Sucursal del empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            


            
            if (EmpleadoAEditar == null)
            {

                if (MessageBox.Show("Realmente deseas agregar al empleado?", "AGREGAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NuevoEmpleado = new Empleado()
                    {
                        Nombre = this.txtNombre.Text,
                        Apellidos = this.txtApellidos.Text,
                        Identificacion = this.txtIdentificacion.Text,
                        IdPuesto = cmbPuestos.SelectedItem as Puesto,
                        IdSucursal = cmbSucursal.SelectedItem as Sucursal,
                        FechaNacimiento = dateFechaNacimiento.Value,
                        Telefono = this.txtTelefono.Text,
                        Correo = this.txtCorreo.Text,
                        Contrasenna = this.txtContrasenna.Text,
                        Bonificacion = decimal.Parse(this.txtBonificacion.Text),
                        Estado = this.cmbEstado.SelectedItem.ToString()
                    };
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                if (MessageBox.Show("Realmente deseas editar al empleado?", "EDITAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EmpleadoAEditar.Nombre = this.txtNombre.Text;
                    EmpleadoAEditar.Apellidos = this.txtApellidos.Text;
                    EmpleadoAEditar.Identificacion = this.txtIdentificacion.Text;
                    EmpleadoAEditar.IdPuesto = cmbPuestos.SelectedItem as Puesto;
                    EmpleadoAEditar.IdSucursal = cmbSucursal.SelectedItem as Sucursal;
                    EmpleadoAEditar.FechaNacimiento = dateFechaNacimiento.Value;
                    EmpleadoAEditar.Telefono = this.txtTelefono.Text;
                    EmpleadoAEditar.Correo = this.txtCorreo.Text;
                    EmpleadoAEditar.Contrasenna = this.txtContrasenna.Text;
                    EmpleadoAEditar.Bonificacion = decimal.Parse(this.txtBonificacion.Text);
                    EmpleadoAEditar.Estado = this.cmbEstado.SelectedItem.ToString();
                    this.DialogResult = DialogResult.OK;
                };

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
