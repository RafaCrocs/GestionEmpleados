using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.Entities.Admin
{
    public class Puesto
    {
        public int IdPuesto { get; set; }
        public string? Descripcion { get; set; }
        public decimal SalarioBase { get; set; }
    }
}
