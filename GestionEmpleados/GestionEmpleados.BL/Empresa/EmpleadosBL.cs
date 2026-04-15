using System;
using System.Collections.Generic;
using System.Text;
using GestionEmpleados.DAL.Empresa;
using GestionEmpleados.Entities.Admin;

namespace GestionEmpleados.BL.Empresa
{
    public class EmpleadosBL
    {
        private EmpleadosDAL empleadosDAL = new EmpleadosDAL();

        public List<Entities.Admin.Empleado> Empleados_ObtenerTodos()
        {
            return empleadosDAL.Empleados_ObtenerTodos();
        }
        
        public bool Empleados_Insertar(Empleado nuevo, out string mensaje)
        {
            return empleadosDAL.Empleados_Insertar(nuevo, out mensaje);
        }
        
        public bool Empleados_Editar(Empleado editado)
        {
            return empleadosDAL.Empleados_Editar(editado);
        }
        public bool Empleados_Eliminar(int idEmpleado)
        {
            return empleadosDAL.Empleados_Eliminar(idEmpleado);
        }
    }
}
