using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.Entities.Admin
{
    public class Vacaciones
    {
        public int IdVacaciones { get; set; }
        public Empleado? IdEmpleado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal FactorSalario { get; set; }
        public bool Aprobadas { get; set; }
    }
}
