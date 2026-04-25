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
    public partial class Puestos_SegurosModal : Form
    {
        public Puestos_SegurosModal(Puesto editarPuestoSeguro = null)
        {
            InitializeComponent();
            EditarPuesto = editarPuestoSeguro;
        }
        public Puesto nuevoPuesto;
        public Puesto EditarPuesto { get; private set; }


        public static System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CreateSpecificCulture("es-CR");

        private void txtPorcentajeEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSalarioBase.Text) || string.IsNullOrWhiteSpace(txtPorcentajeEmpleado.Text))
            {
                txtMontoEmpleado.Text = "0.00";
                return;
            }
            if (txtPorcentajeEmpleado.Text.Contains(","))
            {
                MessageBox.Show("El porcentaje no puede contener comas. Use punto (.) para decimales.", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPorcentajeEmpleado.Text = txtPorcentajeEmpleado.Text.Replace(",", ".");
                return;
            }
            decimal.TryParse(txtSalarioBase.Text, System.Globalization.NumberStyles.Currency, culture, out decimal salarioBase);
            decimal.TryParse(txtPorcentajeEmpleado.Text, out decimal porcentajeEmpleado);
            decimal montoEmpleado = salarioBase * porcentajeEmpleado / 100;
            txtMontoEmpleado.Text = montoEmpleado.ToString("C2", culture);
        }

        private void txtSalarioBase_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSalarioBase.Text))
            {
                txtSalarioBase.Text = "0.00";
                return;
            }

            if (decimal.TryParse(
                    txtSalarioBase.Text,
                    System.Globalization.NumberStyles.Currency,
                    culture,
                    out decimal salario))
            {
                txtSalarioBase.Text = salario.ToString("C2", culture);
            }
            else
            {
                MessageBox.Show(
                    "El valor ingresado no es un número válido.",
                    "Formato Incorrecto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtSalarioBase.Text = "";
            }
        }

        private void txtSalarioBase_TextChanged(object sender, EventArgs e)
        {
            txtPorcentajeEmpleado.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (EditarPuesto != null)
            {
                if (MessageBox.Show("¿Está seguro de modificar este puesto?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EditarPuesto.Nombre = textBox1.Text.Trim();
                    EditarPuesto.SalarioReportado = decimal.TryParse(txtSalarioBase.Text, System.Globalization.NumberStyles.Currency, culture, out decimal salario) ? salario : (decimal?)null;
                    EditarPuesto.PorcentajeSeguro = decimal.TryParse(txtPorcentajeEmpleado.Text, out decimal porcentajeEmpleado) ? porcentajeEmpleado : (decimal?)null;
                }
                return;
            }

            if (MessageBox.Show("¿Está seguro de agregar este puesto?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nuevoPuesto = new Puesto()
                {
                    Nombre = textBox1.Text.Trim(),
                    SalarioReportado = decimal.TryParse(txtSalarioBase.Text, System.Globalization.NumberStyles.Currency, culture, out decimal salario) ? salario : (decimal?)null,
                    PorcentajeSeguro = decimal.TryParse(txtPorcentajeEmpleado.Text, out decimal porcentajeEmpleado) ? porcentajeEmpleado : (decimal?)null
                };
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Puestos_SegurosModal_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            if (EditarPuesto != null)
            {
                textBox1.Text = EditarPuesto.Nombre;
                btnAgregar.Text = "GUARDAR";
            }
        }
    }
}
