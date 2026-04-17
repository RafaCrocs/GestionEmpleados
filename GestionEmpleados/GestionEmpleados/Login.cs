using GestionEmpleados.BL.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestionEmpleados.Entities.Admin;
using GestionEmpleados.BL.Empresa;

namespace GestionEmpleados
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private UsuariosBL usuariosBL = new UsuariosBL();
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private EmpleadosBL empleadosBL = new EmpleadosBL();
        private List<Empleado> listaEmpleados = new List<Empleado>();
        private RegistroHorasBL registroHorasBL = new RegistroHorasBL();
        #region Metodos
        private void CargarUsuarios()
        {
            listaUsuarios = usuariosBL.Usuarios_ObtenerTodos();
            
        }

        private void CargarEmpleados()
        {
            listaEmpleados = empleadosBL.Empleados_ObtenerTodos();
        }
        #endregion Metodos

        #region Eventos


        private void btnLogin_Click(object sender, EventArgs e)
        {
            CargarUsuarios();


            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (listaUsuarios[i].Identificacion == txtIdentificacion.Text && listaUsuarios[i].Contrasenna == txtContrasenna.Text)
                {
                    txtIdentificacion.Text = "";
                    txtContrasenna.Text = "";
                    Inicio inicio = new Inicio(listaUsuarios[i]);
                    inicio.ShowDialog();
                    return;
                }

                else
                {
                    MessageBox.Show("Identificacion o contraseña incorrectos, por favor intente de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasenna.Text = "";
                    txtIdentificacion.Text = string.Empty;
                    txtIdentificacion.Focus();
                    return;
                }
            }

        }
        private void cbxVerContrasenna_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxVerContrasenna.Checked)
            {
                txtContrasenna.UseSystemPasswordChar = false;
            }
            else
            {
                txtContrasenna.UseSystemPasswordChar = true;
            }
        }
        #endregion Eventos

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                if (listaEmpleados[i].Identificacion == txtIdentificacion.Text && listaEmpleados[i].Contrasenna == txtContrasenna.Text)
                {
                    if (registroHorasBL.RegistrarEntradaSalida(listaEmpleados[i].IdEmpleado, "Entrada", out string mensaje))
                    {
                        MessageBox.Show(mensaje, "Registro de horas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;
                }
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
            for(int i = 0; i < listaEmpleados.Count; i++)
            {
                if (listaEmpleados[i].Identificacion == txtIdentificacion.Text && listaEmpleados[i].Contrasenna == txtContrasenna.Text)
                {
                    if (registroHorasBL.RegistrarEntradaSalida(listaEmpleados[i].IdEmpleado, "Salida", out string mensaje))
                    {
                        MessageBox.Show(mensaje, "Registro de horas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;
                }
            }
        }
    }
}
