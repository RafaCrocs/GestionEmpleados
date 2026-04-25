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
        public string Puesto { get; set; }
        public decimal SalarioReal { get; set; }
        public decimal SalarioPagado { get; set; }
        public decimal SalarioReportado { get; set; }
        public decimal Adelanto { get; set; }
        public decimal RebajoDePrestamo { get; set; }
        public decimal Seguro { get; set; }
        public decimal HorasTrabajadas { get; set; }
        public decimal HorasExtra { get; set; }
        public decimal ValorHora { get; set; }
        public int DiasAusentes { get; set; }
        public int DiasIncapacitados { get; set; }
        public int DiasDobles { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Bonificacion { get; set; }
        public string? Detalle { get; set; }
    }
}
