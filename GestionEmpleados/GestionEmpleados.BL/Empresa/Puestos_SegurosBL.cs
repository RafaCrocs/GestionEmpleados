using GestionEmpleados.DAL.Empresa;
using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.BL.Empresa
{
    public class Puestos_SegurosBL
    {
        private Puestos_SegurosDAL puestos_SegurosDAL = new Puestos_SegurosDAL();

        public List<Puesto> Puestos_Seguros_ObtenerTodos()
        {
            return puestos_SegurosDAL.Puestos_Seguros_ObtenerTodos();
        }
        public bool Puestos_Seguros_Insertar(Puesto nuevoPuestoSeguro, out string mensaje)
        {
            return puestos_SegurosDAL.Puestos_Seguros_Insertar(nuevoPuestoSeguro, out mensaje);
        }

        public bool Puestos_Seguros_Editar(Puesto puestoSeguroEditado, out string mensaje)
        {
            return puestos_SegurosDAL.Puestos_Seguros_Editar(puestoSeguroEditado, out mensaje);
        }

        public bool Puestos_Seguros_Eliminar (int idPuesto, out string mensaje)
        {
            return puestos_SegurosDAL.Puestos_Seguros_Eliminar(idPuesto, out mensaje);
        }
    }
}
