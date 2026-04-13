using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.Entities.Admin
{
    public class Adelanto
    {
        public int IdAdelanto { get; set; }
        public Empleado? IdEmpleado { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string? Detalle { get; set; }
    }
}
