using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.Entities.Admin
{
    public class Puesto
    {
        public int IdPuesto { get; set; }
        public string? Nombre { get; set; }
        public decimal? SalarioReportado { get; set; }
        public decimal? PorcentajeSeguro { get; set; }
        public decimal? Seguro { get; set; }
    }
}
