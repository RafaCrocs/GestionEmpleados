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
                cargarInfoPuesto();
                dateFechaNacimiento.Value = EmpleadoAEditar.FechaNacimiento;
                txtSalarioReal.Text = EmpleadoAEditar.SalarioReal.ToString("C", new CultureInfo("es-CR"));
                txtValorHora.Text = EmpleadoAEditar.ValorHora.ToString("C", new CultureInfo("es-CR"));
                txtBonificacion.Text = EmpleadoAEditar.Bonificacion.ToString("C", new CultureInfo("es-CR"));
                cmbEstado.SelectedItem = EmpleadoAEditar.Estado;
                txtSalarioReportado.Text = EmpleadoAEditar.SalarioReportado.ToString("C", new CultureInfo("es-CR"));
                txtSeguro.Text = EmpleadoAEditar.Seguro.ToString("C", new CultureInfo("es-CR"));
                if (EmpleadoAEditar.PagaSeguro)
                {
                    ckbSeguro.Checked = true;
                }
                ;

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
            cmbPuestos.SelectedIndexChanged -= cmbPuestos_SelectedIndexChanged;
            CargarCombos();
            CargarDatos();
            cmbPuestos.SelectedIndexChanged += cmbPuestos_SelectedIndexChanged;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" ||
                txtApellidos.Text.Trim() == "" ||
                txtIdentificacion.Text.Trim() == "" ||
                txtTelefono.Text.Trim() == "" ||
                txtCorreo.Text.Trim() == "" ||
                txtContrasenna.Text.Trim() == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtBonificacion.Text, NumberStyles.Currency, new CultureInfo("es-CR"), out decimal bonificacion) && txtBonificacion.Text != "")
            {
                MessageBox.Show("La bonificación debe ser un número decimal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbPuestos.SelectedIndex == -1 || cmbSucursal.SelectedIndex == -1)
            {
                MessageBox.Show("Asegurese seleccionar el Puesto y la Sucursal del empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtBonificacion.Text == "")
            {
                txtBonificacion.Text = "0";
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
                        SalarioReal = decimal.Parse(this.txtSalarioReal.Text, NumberStyles.Currency, new CultureInfo("es-CR")),
                        SalarioReportado = decimal.Parse(this.txtSalarioReportado.Text, NumberStyles.Currency, new CultureInfo("es-CR")),
                        ValorHora = decimal.Parse(this.txtValorHora.Text, NumberStyles.Currency, new CultureInfo("es-CR")),
                        Bonificacion = decimal.Parse(this.txtBonificacion.Text, NumberStyles.Currency, new CultureInfo("es-CR")),
                        Estado = this.cmbEstado.SelectedItem.ToString(),
                        Seguro = decimal.TryParse(this.txtSeguro.Text, NumberStyles.Currency, new CultureInfo("es-CR"), out decimal seguro) ? seguro : 0,
                        PagaSeguro = ckbSeguro.Checked
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
                    EmpleadoAEditar.ValorHora = decimal.Parse(this.txtValorHora.Text, NumberStyles.Currency, new CultureInfo("es-CR"));
                    EmpleadoAEditar.SalarioReal = decimal.Parse(this.txtSalarioReal.Text, NumberStyles.Currency, new CultureInfo("es-CR"));
                    EmpleadoAEditar.SalarioReportado = decimal.Parse(this.txtSalarioReportado.Text, NumberStyles.Currency, new CultureInfo("es-CR"));
                    EmpleadoAEditar.Bonificacion = decimal.Parse(this.txtBonificacion.Text, NumberStyles.Currency, new CultureInfo("es-CR"));
                    EmpleadoAEditar.Estado = this.cmbEstado.SelectedItem.ToString();
                    EmpleadoAEditar.Seguro = decimal.TryParse(txtSeguro.Text, NumberStyles.Currency, new CultureInfo("es-CR"), out decimal seguro) ? seguro : 0;
                    EmpleadoAEditar.PagaSeguro = ckbSeguro.Checked;
                    this.DialogResult = DialogResult.OK;
                }
                ;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPuestos.SelectedIndex == -1)
            {
                txtSalarioReportado.Text = "N/A";
                txtPorcentajeSeguro.Text = "N/A";
                txtSeguro.Text = "N/A";
                return;
            }

            cargarInfoPuesto();
        }

        private void cargarInfoPuesto()
        {
            if (EmpleadoAEditar == null)
            {
                Puesto seleccionado = puestos[cmbPuestos.SelectedIndex];
                txtSalarioReportado.Text = seleccionado.SalarioReportado.HasValue ? seleccionado.SalarioReportado.Value.ToString("C", new CultureInfo("es-CR")) : "N/A";
                txtPorcentajeSeguro.Text = seleccionado.PorcentajeSeguro.HasValue ? seleccionado.PorcentajeSeguro.Value.ToString() : "N/A";
                txtSeguro.Text = seleccionado.Seguro.HasValue ? seleccionado.Seguro.Value.ToString("C", new CultureInfo("es-CR")) : "N/A";
            }
            Puesto selecciiondo = puestos[cmbPuestos.SelectedIndex];
            txtPorcentajeSeguro.Text = selecciiondo.PorcentajeSeguro.HasValue ? selecciiondo.PorcentajeSeguro.Value.ToString() : "N/A";
        }

        private void txtSalarioReal_Leave(object sender, EventArgs e)
        {
            txtSalarioReal.Text = decimal.TryParse(
                txtSalarioReal.Text, 
                NumberStyles.Currency, 
                new CultureInfo("es-CR"), 
                out decimal salarioReal)
                ? salarioReal.ToString("C", new CultureInfo("es-CR"))
                : "N/A";
        }

        private void txtValorHora_Leave(object sender, EventArgs e)
        {
            txtValorHora.Text = decimal.TryParse(txtValorHora.Text, NumberStyles.Currency, new CultureInfo("es-CR"), out decimal valorHora) ? valorHora.ToString("C", new CultureInfo("es-CR")) : "N/A";
        }

        private void txtBonificacion_Leave(object sender, EventArgs e)
        {
            txtBonificacion.Text = decimal.TryParse(txtBonificacion.Text, NumberStyles.Currency, new CultureInfo("es-CR"), out decimal bonificacion) ? bonificacion.ToString("C", new CultureInfo("es-CR")) : "N/A";
        }

        private void txtSalarioReportado_TextChanged(object sender, EventArgs e)
        {
            decimal.TryParse(txtSalarioReportado.Text, NumberStyles.Currency, new CultureInfo("es-CR"), out decimal salarioReportado);
            decimal.TryParse(txtPorcentajeSeguro.Text, out decimal porcentajeSeguro);
            txtSeguro.Text = (salarioReportado * porcentajeSeguro / 100).ToString("C", new CultureInfo("es-CR"));
        }

        private void txtSalarioReal_TextChanged(object sender, EventArgs e)
        {
            decimal.TryParse(txtSalarioReal.Text, NumberStyles.Currency, new CultureInfo("es-CR"), out decimal salarioReal);
            decimal ValorHoraCalculado = salarioReal / 240;
            txtValorHora.Text = ValorHoraCalculado.ToString("C", new CultureInfo("es-CR"));
            decimal ValorJornadaCalculado = salarioReal/30;
            txtValorJornada.Text = ValorJornadaCalculado.ToString("C", new CultureInfo("es-CR"));
        }
    }
}
