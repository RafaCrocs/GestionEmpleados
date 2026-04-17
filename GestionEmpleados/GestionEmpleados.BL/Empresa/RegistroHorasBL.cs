using GestionEmpleados.DAL.Empresa;
using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.BL.Empresa
{
    public class RegistroHorasBL
    {

        private RegistroHorasDAL registroHorasDAL = new RegistroHorasDAL();

        public bool RegistrarEntradaSalida(int idEmpleado, string tipoRegistro, out string mensaje)
        {
            return registroHorasDAL.RegistroHoras_RegistrarEntradaSalida(idEmpleado, tipoRegistro, out mensaje);
        }

    }
}
