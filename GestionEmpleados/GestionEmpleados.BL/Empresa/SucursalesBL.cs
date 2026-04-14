using GestionEmpleados.DAL.Admin;
using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Text;
using GestionEmpleados.DAL.Empresa;

namespace GestionEmpleados.BL.Empresa
{
    public class SucursalesBL
    {
        private SucursalesDAL sucursalesDAL = new SucursalesDAL();

        public List<Sucursal> Sucursales_ObtenerTodos()
        {
            return sucursalesDAL.Sucursales_ObtenerTodos();
        }
    }
}
