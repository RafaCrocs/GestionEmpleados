using GestionEmpleados.BL.Admin;
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
    public partial class UsuarioModal : Form
    {
        public UsuarioModal()
        {
            InitializeComponent();
        }

        private RolesBL rolesBL = new RolesBL();
        private SucursalesBL sucursalesBL = new SucursalesBL();

        private List<Rol> roles = new List<Rol>();
        private List<Sucursal> sucursales = new List<Sucursal>();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Usuario NuevoUsuario { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Usuario UsuarioAEditar { get; set; }


        public UsuarioModal(Usuario usuarioAEditar = null)
        {
            InitializeComponent();
            UsuarioAEditar = usuarioAEditar;
        }

        private void CargarDatos()
        {
            if (UsuarioAEditar != null)
            {
                txtNombre.Text = UsuarioAEditar.Nombre;
                txtApellidos.Text = UsuarioAEditar.Apellidos;
                txtIdentificacion.Text = UsuarioAEditar.Identificacion;
                cmbRoles.SelectedValue = UsuarioAEditar.IdRol.IdRol;
                cmbSucursal.SelectedValue = UsuarioAEditar.IdSucursal.IdSucursal;
                txtCorreo.Text = UsuarioAEditar.Correo;
                txtContrasenna.Text = UsuarioAEditar.Contrasenna;
                chkActivo.Checked = UsuarioAEditar.Activo;
            }
        }

        private void CargarCombos()
        {
            roles = rolesBL.Roles_ObtenerTodos();
            cmbRoles.DataSource = roles;
            cmbRoles.DisplayMember = "Nombre";
            cmbRoles.ValueMember = "IdRol";

            sucursales = sucursalesBL.Sucursales_ObtenerTodos();
            cmbSucursal.DataSource = sucursales;
            cmbSucursal.DisplayMember = "Nombre";
            cmbSucursal.ValueMember = "IdSucursal";
        }

        private void UsuarioModal_Load(object sender, EventArgs e)
        {

            CargarCombos();
            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (UsuarioAEditar == null)
            {

                if (MessageBox.Show("Realmente deseas agregar al usuario?", "AGREGAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NuevoUsuario = new Usuario()
                    {
                        //Nombre = this.txtNombre.Text,
                        //Correo = this.txtCorreo.Text,
                        //Password = this.txtContrasenna.Text,
                        //Genero = (rdMasculino.Checked ? Utilities.Enums.Genero.M : Utilities.Enums.Genero.F),
                        //FechaNacimiento = dateFechaNacimiento.Value,
                        //TipoUsuarioSysId = Convert.ToInt16(cmbRoles.SelectedValue),
                        //Activo = chkActivo.Checked
                    };
                }
            }
            else
            {
                if (MessageBox.Show("Realmente deseas editar al usuario?", "EDITAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //UsuarioAEditar.Correo = this.txtCorreo.Text;
                    //UsuarioAEditar.Nombre = this.txtNombre.Text;
                    //UsuarioAEditar.Password = this.txtContrasenna.Text;
                    //UsuarioAEditar.Genero = (rdMasculino.Checked ? Utilities.Enums.Genero.M : Utilities.Enums.Genero.F);
                    //UsuarioAEditar.FechaNacimiento = dateFechaNacimiento.Value;
                    //UsuarioAEditar.TipoUsuarioSysId = Convert.ToInt16(cmbRoles.SelectedValue);
                    //UsuarioAEditar.Activo = chkActivo.Checked;

                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (UsuarioAEditar == null)
            {

                if (MessageBox.Show("Realmente deseas agregar al usuario?", "AGREGAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NuevoUsuario = new Usuario()
                    {
                        Nombre = this.txtNombre.Text,
                        Apellidos = this.txtApellidos.Text,
                        Identificacion = this.txtIdentificacion.Text,
                        IdRol = cmbRoles.SelectedItem as Rol,
                        IdSucursal = cmbSucursal.SelectedItem as Sucursal,
                        Correo = this.txtCorreo.Text,
                        Contrasenna = this.txtContrasenna.Text,
                        Activo = chkActivo.Checked
                    };
                }
            }
            else
            {
                if (MessageBox.Show("Realmente deseas editar al usuario?", "EDITAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UsuarioAEditar.Nombre = this.txtNombre.Text;
                    UsuarioAEditar.Apellidos = this.txtApellidos.Text;
                    UsuarioAEditar.Identificacion = this.txtIdentificacion.Text;
                    UsuarioAEditar.IdRol = cmbRoles.SelectedItem as Rol;
                    UsuarioAEditar.IdSucursal = cmbSucursal.SelectedItem as Sucursal;
                    UsuarioAEditar.Correo = this.txtCorreo.Text;
                    UsuarioAEditar.Contrasenna = this.txtContrasenna.Text;
                    UsuarioAEditar.Activo = chkActivo.Checked;

                }
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
