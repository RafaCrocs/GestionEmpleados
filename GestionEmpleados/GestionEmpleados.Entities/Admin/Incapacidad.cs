using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.Entities.Admin
{
    public class Incapacidad
    {
        public int IdIncapacidad { get; set; }
        public Empleado? IdEmpleado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string? TipoIncapacidad { get; set; }
        public int DiasAPagar { get; set; }
        public int DiasPagados { get; set; }
        public decimal FactorSalario { get; set; }

    }
}
