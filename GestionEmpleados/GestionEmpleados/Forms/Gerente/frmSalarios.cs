using GestionEmpleados.BL;
using GestionEmpleados.BL.Empresa;
using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

        private decimal SalarioOriginal = 0;
        private decimal ValorJornada = 0;

        private void CargarDatos(int idSelecciondo)
        {
            salarios = salariosBL.Salarios_ObtenerTodos(idSelecciondo, out string mensaje);
            lblPuesto.Text = salarios[0].Puesto.ToString();
            txtSalarioReal.Text = salarios[0].SalarioReal.ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));
            txtSalarioReportado.Text = salarios[0].SalarioReportado.ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));
            txtPrestamo.Text = salarios[0].RebajoDePrestamo.ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));
            txtSeguro.Text = salarios[0].Seguro.ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));
            txtValorHora.Text = salarios[0].ValorHora.ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));
            txtHorasTrabajadas.Text = salarios[0].HorasTrabajadas.ToString();
            txtHorasExtra.Text = salarios[0].HorasExtra.ToString();
            txtAdelantos.Text = salarios[0].Adelanto.ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));
            txtBonificaciones.Text = salarios[0].Bonificacion.ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));

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

            // Guardar el salario original una sola vez al buscar
            SalarioOriginal = salarios[0].SalarioReal
                            - salarios[0].RebajoDePrestamo
                            - salarios[0].Seguro
                            - salarios[0].Adelanto
                            + salarios[0].Bonificacion;
            ValorJornada = salarios[0].SalarioReal / 30;

            txtSalarioFinal.Text = SalarioOriginal.ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));
            txtValorJornada.Text = ValorJornada.ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (cmbEmpleados.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un empleado para pagar su salario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idEmpleado = (int)cmbEmpleados.SelectedValue;
            if (MessageBox.Show("¿Está seguro que desea pagar el salario de este empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Salario pagarSalario = new Salario()
                {
                    IdEmpleado = cmbEmpleados.SelectedItem as Empleado,
                    SalarioReal = decimal.TryParse(txtSalarioReal.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("es-CR"), out decimal salarioReal) ? salarioReal : 0,
                    SalarioPagado = decimal.TryParse(txtSalarioFinal.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("es-CR"), out decimal salarioFinal) ? salarioFinal : 0,
                    SalarioReportado = decimal.TryParse(txtSalarioReportado.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("es-CR"), out decimal salarioReportado) ? salarioReportado : 0,
                    Seguro = decimal.TryParse(txtSeguro.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("es-CR"), out decimal seguro) ? seguro : 0,
                    Adelanto = decimal.TryParse(txtAdelantos.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("es-CR"), out decimal adelantos) ? adelantos : 0,
                    RebajoDePrestamo = decimal.TryParse(txtPrestamo.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("es-CR"), out decimal prestamo) ? prestamo : 0,
                    HorasTrabajadas = decimal.TryParse(txtHorasTrabajadas.Text, out decimal horasTrabajadas) ? horasTrabajadas : 0,
                    HorasExtra = decimal.TryParse(txtHorasExtra.Text, out decimal horasExtras) ? horasExtras : 0,
                    ValorHora = decimal.TryParse(txtValorHora.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("es-CR"), out decimal valorHora) ? valorHora : 0,
                    DiasAusentes = int.TryParse(txtDiasAusentes.Text, out int diasAusentes) ? diasAusentes : 0,
                    DiasIncapacitados = int.TryParse(txtDiasIncapacitados.Text, out int diasIncapacitados) ? diasIncapacitados : 0,
                    DiasDobles = int.TryParse(txtDiasDobles.Text, out int diasDobles) ? diasDobles : 0,
                    Bonificacion = decimal.TryParse(txtBonificaciones.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("es-CR"), out decimal bonificaciones) ? bonificaciones : 0
                };

                if (salariosBL.Salarios_PagarSalario(pagarSalario, out string mensaje))
                {
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QuitarDatos();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void QuitarDatos()
        {
            lblPuesto.Text = "";
            txtSalarioReal.Text = "";
            txtPrestamo.Text = "";
            txtSeguro.Text = "";
            txtHorasTrabajadas.Text = "";
            txtHorasExtra.Text = "";
            txtAdelantos.Text = "";
            txtBonificaciones.Text = "";
            txtSalarioFinal.Text = "";
            cmbEmpleados.SelectedIndex = -1;
        }

        private void ActualizarSalarioFinal()
        {
            if (salarios == null) return;

            decimal.TryParse(txtBonificaciones.Text, NumberStyles.Currency,
                CultureInfo.CreateSpecificCulture("es-CR"), out decimal bonificaciones);

            decimal.TryParse(txtPrestamo.Text, NumberStyles.Currency,
                CultureInfo.CreateSpecificCulture("es-CR"), out decimal prestamo);

            // Salario original ya tiene el préstamo original descontado,
            // se ajusta con la diferencia del préstamo nuevo
            decimal diferenciaPrestamo = salarios[0].RebajoDePrestamo - prestamo;
            decimal diferenciaBonificaciones = bonificaciones - salarios[0].Bonificacion;
            decimal horasExtra = decimal.TryParse(txtHorasExtra.Text, out horasExtra) ? horasExtra : 0;
            decimal horasExtraValor = horasExtra * (salarios[0].ValorHora * 1.5m);
            decimal diasDobles = decimal.TryParse(txtDiasDobles.Text, out diasDobles) ? diasDobles : 0;
            decimal diasDoblesValor = diasDobles * ValorJornada;
            decimal diasIncapacitados = decimal.TryParse(txtDiasIncapacitados.Text, out diasIncapacitados) ? diasIncapacitados : 0;
            decimal diasIncapacitadosValor;
            decimal diasIncapacitadosExtra = 0;

            if (diasIncapacitados > 3)
            {
                diasIncapacitadosValor = 3 * (ValorJornada / 2);
                diasIncapacitadosExtra = diasIncapacitados - 3;
                diasIncapacitadosExtra = diasIncapacitadosExtra * ValorJornada;
            }
            else
            {
                diasIncapacitadosValor = diasIncapacitados * (ValorJornada / 2);
                diasIncapacitadosExtra = 0;
            }
            decimal diasAusentes = decimal.TryParse(txtDiasAusentes.Text, out diasAusentes) ? diasAusentes : 0;
            decimal diasAusentesValor = diasAusentes * ValorJornada;

            txtSalarioFinal.Text = (SalarioOriginal + diferenciaBonificaciones + diferenciaPrestamo + horasExtraValor + diasDoblesValor + diasIncapacitadosValor - diasIncapacitadosExtra - diasAusentesValor)
                .ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));
            txtSalarioReal.Text = (salarios[0].SalarioReal + horasExtraValor + diasDoblesValor + diasIncapacitadosValor - diasIncapacitadosExtra - diasAusentesValor).ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));
        }

        private void txtBonificaciones_TextChanged(object sender, EventArgs e)
        {
            ActualizarSalarioFinal();
        }

        private void txtPrestamo_TextChanged(object sender, EventArgs e)
        {
            ActualizarSalarioFinal();
        }

        private void txtPrestamo_Leave(object sender, EventArgs e)
        {
            decimal.TryParse(txtPrestamo.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("es-CR"), out decimal prestamo);
            txtPrestamo.Text = prestamo.ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));
        }

        private void txtBonificaciones_Leave(object sender, EventArgs e)
        {
            decimal.TryParse(txtBonificaciones.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("es-CR"), out decimal bonificaciones);
            txtBonificaciones.Text = bonificaciones.ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));
        }

        private void txtHorasExtra_TextChanged(object sender, EventArgs e)
        {
            ActualizarSalarioFinal();
            decimal.TryParse(txtHorasExtra.Text, out decimal horasExtra);
            decimal horasExtraValor = horasExtra * (salarios[0].ValorHora * 1.5m);
            txtSalarioReal.Text = (salarios[0].SalarioReal + horasExtraValor).ToString("C2", CultureInfo.CreateSpecificCulture("es-CR"));
        }

        private void txtDiasDobles_TextChanged(object sender, EventArgs e)
        {
            ActualizarSalarioFinal();
        }

        private void txtDiasIncapacitados_TextChanged(object sender, EventArgs e)
        {
            ActualizarSalarioFinal();
        }

        private void txtDiasAusentes_TextChanged(object sender, EventArgs e)
        {
            ActualizarSalarioFinal();
        }
    }
}
