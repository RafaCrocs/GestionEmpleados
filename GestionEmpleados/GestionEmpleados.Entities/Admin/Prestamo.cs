using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.Entities.Admin
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public Empleado? IdEmpleado { get; set; }
        public string NombreEmpleado => IdEmpleado != null ? $"{IdEmpleado.Nombre} {IdEmpleado.Apellidos} {IdEmpleado.Identificacion}" : null;
        public decimal Monto { get; set; }
        public decimal SugerenciaDeRebajo { get; set; }
        public DateTime? FechaInicio { get; set; }
        public decimal MontoRestante { get; set; }
        public decimal MontoPagado { get; set; }
        public string? Detalle { get; set; }

    }
}
