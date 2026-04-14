using GestionEmpleados.DAL.Admin;
using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.BL.Admin
{
    public class RolesBL
    {

        private  RolesDAL rolesDal = new RolesDAL();

        public List<Rol> Roles_ObtenerTodos()
        {
            return rolesDal.Roles_ObtenerTodos();
        }
    }
}
