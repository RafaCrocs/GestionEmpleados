using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.Entities.Admin
{
    public class RegistroPrestamo
    {
        public int IdRegistroPrestamo { get; set; }
        public int IdPrestamo { get; set; }
        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public decimal MontoPagado { get; set; }
        public DateTime Fecha { get; set; }
    }
}
