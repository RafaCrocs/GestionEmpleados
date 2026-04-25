using GestionEmpleados.DAL.Empresa;
using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.BL.Empresa
{
    public class RegistroPagosBL
    {
        private RegistroPagosDAL registroPagosDAL = new RegistroPagosDAL();

        public List<RegistroPago> RegistroPagos_ObtenerTodos(out string mensaje, RegistroPago idSeleccionado = null, DateTime? fecha = null)
        {
            return registroPagosDAL.ObtenerRegistrosPagos(out mensaje, idSeleccionado, fecha);
        }
    }
}
