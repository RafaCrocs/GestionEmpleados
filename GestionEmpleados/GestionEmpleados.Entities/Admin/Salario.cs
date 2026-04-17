using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.Entities.Admin
{
    public class Salario
    {
        public int IdSalario { get; set; }
        public Empleado? IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public decimal Adelantos { get; set; }
        public decimal RebajoDePrestamo { get; set; }
        public decimal Seguro { get; set; }
        public decimal HorasTrabajadas { get; set; }
        public decimal TotalHorasExtras { get; set; } = 0;
        public DateTime FechaPago { get; set; }
        public decimal Deducciones { get; set; }
        public decimal Monto { get; set; }
        public string? Detalle { get; set; }
    }
}
