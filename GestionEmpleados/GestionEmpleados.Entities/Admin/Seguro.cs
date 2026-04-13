using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.Entities.Admin
{
    public class Seguro
    {
        public int IdSeguro { get; set; }
        public Puesto? IdPuesto { get; set; }
        public decimal? Monto { get; set; }
    }
}
