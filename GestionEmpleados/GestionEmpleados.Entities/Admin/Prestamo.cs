using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.Entities.Admin
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public Empleado? IdEmpleado { get; set; }
        public decimal Monto { get; set; }
        public int Cuotas { get; set; }
        public DateTime? FechaInicio { get; set; } = DateTime.Now;
        public decimal MontoPagado { get; set; }
        public string? Detalle { get; set; }

    }
}
