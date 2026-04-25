using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.Entities.Admin
{
    public class Puesto_Seguro
    {
        public int IdPuesto { get; set; }
        public string? NombrePuesto { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal PorcentajeEmpleado { get; set; }
        public decimal MontoEmpleado { get; set; }
        public decimal PorcentajeEmpresa { get; set; }
        public decimal MontoEmpresa { get; set; }
    }
}
