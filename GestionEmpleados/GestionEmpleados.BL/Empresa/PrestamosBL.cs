using System;
using System.Collections.Generic;
using System.Text;
using GestionEmpleados.DAL.Empresa;
using GestionEmpleados.Entities.Admin;

namespace GestionEmpleados.BL.Empresa
{
    public class PrestamosBL
    {

        private PrestamosDAL prestamosDAL = new PrestamosDAL();

        public List<Prestamo> Prestamos_ObtenerTodos()
        {
            return prestamosDAL.Prestamos_ObtenerTodos();
        }

        public bool Prestamos_Insertar(Prestamo nuevoPrestamo, out string mensaje)
        {
            return prestamosDAL.Prestamos_Insertar(nuevoPrestamo, out mensaje);
        }

        public bool Prestamos_Editar(Prestamo prestamoEditar, out string mensaje)
        {
            return prestamosDAL.Prestamos_Editar(prestamoEditar, out mensaje);
        }
         public bool Prestamos_Eliminar(int idPrestamo, out string mensaje)
        {
            return prestamosDAL.Prestamos_Eliminar(idPrestamo, out mensaje);
        }
    }
}
