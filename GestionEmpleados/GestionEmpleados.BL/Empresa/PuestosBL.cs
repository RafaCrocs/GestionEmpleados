using GestionEmpleados.DAL.Empresa;
using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.BL.Empresa
{
    public class PuestosBL
    {
        private PuestosDAL puestosDAL = new PuestosDAL();

        public List<Puesto> Puestos_ObtenerTodos()
        {
            return puestosDAL.Puestos_ObtenerTodos();
        }
    }
}
