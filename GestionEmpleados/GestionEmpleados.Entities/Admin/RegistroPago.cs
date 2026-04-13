using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.Entities.Admin
{
    public class RegistroPago
    {
        public int IdRegistroPago { get; set; }
        public Empleado? IdEmpleado { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Deducciones { get; set; }
        public decimal Monto { get; set; }
        public string? Detalle { get; set; }
    }
}
