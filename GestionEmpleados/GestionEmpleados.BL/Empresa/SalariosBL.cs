using GestionEmpleados.DAL.Empresa;
using GestionEmpleados.Entities.Admin;
using System.Collections.Generic;

namespace GestionEmpleados.BL
{
    public class SalariosBL
    {
        private readonly SalariosDAL salariosDAL = new();

        public List<Salario> Salarios_ObtenerTodos(int idEmpleado, out string mensaje)
        {
            return salariosDAL.Salarios_ObtenerTodos(idEmpleado, out mensaje);
        }

        public bool Salarios_PagarSalario(Salario salario, out string mensaje)
        {
            return salariosDAL.Salarios_PagarSalario(salario, out mensaje);
        }
    }
}