using GestionEmpleados.DAL.Empresa;
using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.BL.Empresa
{
    public class RegistroPrestamosBL
    {
        private RegistroPrestamosDAL registroPrestamosDAL = new RegistroPrestamosDAL();

        public List<RegistroPrestamo> ObtenerRegistroPrestamos()
        {
            return registroPrestamosDAL.Registro_Prestamos_ObtenerTodos();
        }
    }
}
