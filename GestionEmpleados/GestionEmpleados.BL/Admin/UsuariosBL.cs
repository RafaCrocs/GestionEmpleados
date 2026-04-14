using System;
using System.Collections.Generic;
using System.Text;
using GestionEmpleados.DAL.Admin;
using GestionEmpleados.Entities.Admin;

namespace GestionEmpleados.BL.Admin
{
    public class UsuariosBL
    {
        private UsuariosDAL usuariosDAL = new UsuariosDAL();

        public List<Usuario> Usuarios_ObtenerTodos()
        {
            return usuariosDAL.Usuarios_ObtenerTodos();
        }

        public bool Usuarios_Insertar(Usuario nuevo)
        {
            return usuariosDAL.Usuarios_Insertar(nuevo);
        }

        public bool Usuarios_Actualizar(Usuario actualizado)
        {
            return usuariosDAL.Usuarios_Actualizar(actualizado);
        }

        public bool Usuarios_Eliminar(int idUsuario)
        {
            return usuariosDAL.Usuarios_Eliminar(idUsuario);
        }
    }
}
