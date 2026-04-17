using GestionEmpleados.DAL.Empresa;
using GestionEmpleados.Entities.Admin;
using System.Collections.Generic;

namespace GestionEmpleados.BL.Empresa
{
    public class AdelantosBL
    {
        private AdelantosDAL adelantosDAL = new AdelantosDAL();

        public List<Adelanto> Adelantos_ObtenerTodos()
        {
            return adelantosDAL.Adelantos_ObtenerTodos();
        }

        public bool Adelantos_Insertar(Adelanto nuevo, out string mensaje)
        {
            return adelantosDAL.Adelantos_Insertar(nuevo, out mensaje);
        }

        public bool Adelantos_Editar(Adelanto adelanto, out string mensaje)
        {
            return adelantosDAL.Adelantos_Editar(adelanto, out mensaje);
        }

        public bool Adelantos_Eliminar(int idAdelanto)
        {
            return adelantosDAL.Adelantos_Eliminar(idAdelanto);
        }
    }
}