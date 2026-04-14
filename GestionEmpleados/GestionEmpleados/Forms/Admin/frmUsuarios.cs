using GestionEmpleados.BL.Admin;
using GestionEmpleados.Entities.Admin;
using GestionEmpleados.Forms.Modals;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionEmpleados.Forms.Admin
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        #region Variables
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private UsuariosBL usuariosBL = new UsuariosBL();
        private Usuario usuarioAEditar;
        #endregion Variables
        #region Metodos
        private void CargarGrid()
        {
            listaUsuarios = usuariosBL.Usuarios_ObtenerTodos();
            gridUsuarios.DataSource = listaUsuarios;
        }
        #endregion Metodos

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void gridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idSeleccionado = Convert.ToInt32(gridUsuarios.Rows[e.RowIndex].Cells[2].Value);
            if (gridUsuarios.Columns[e.ColumnIndex].Name == "Editar")
            {
                usuarioAEditar = new Usuario()
                {
                    IdUsuario = idSeleccionado,
                    IdSucursal = (Sucursal)gridUsuarios.Rows[e.RowIndex].Cells["IdSucursal"].Value,
                    Nombre = gridUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString(),
                    Apellidos = gridUsuarios.Rows[e.RowIndex].Cells["Apellidos"].Value.ToString(),
                    Identificacion = gridUsuarios.Rows[e.RowIndex].Cells["Identificacion"].Value.ToString(),
                    IdRol = (Rol)gridUsuarios.Rows[e.RowIndex].Cells["IdRol"].Value,
                    Correo = gridUsuarios.Rows[e.RowIndex].Cells["Correo"].Value.ToString(),
                    Contrasenna = gridUsuarios.Rows[e.RowIndex].Cells["Contrasenna"].Value.ToString(),
                    FechaCreacion = Convert.ToDateTime(gridUsuarios.Rows[e.RowIndex].Cells["FechaCreacion"].Value),
                    Activo = Convert.ToBoolean(gridUsuarios.Rows[e.RowIndex].Cells["Activo"].Value)
                };

                UsuarioModal modal = new UsuarioModal(usuarioAEditar);
                modal.ShowDialog(this);
                if (modal.DialogResult == DialogResult.OK)
                    if (usuariosBL.Usuarios_Actualizar(modal.UsuarioAEditar))
                    {
                        MessageBox.Show("Su usuario ha sido Editado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            }
            else if (gridUsuarios.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("Realmente deseas eliminar al usuario?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    usuariosBL.Usuarios_Eliminar(idSeleccionado);
                    CargarGrid();
                }
            }
            CargarGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            UsuarioModal modal = new UsuarioModal();
            modal.ShowDialog(this);
            if (modal.DialogResult == DialogResult.OK)
            {
                if (usuariosBL.Usuarios_Insertar(modal.NuevoUsuario))
                {
                    MessageBox.Show("Su usuario ha sido agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Su usuario no ha sido insertado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            CargarGrid();
        }
    }
}
