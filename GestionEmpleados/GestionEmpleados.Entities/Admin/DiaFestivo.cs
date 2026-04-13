using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.Entities.Admin
{
    public class DiaFestivo
    {
        public int IdDiaFestivo { get; set; }
        public string? Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public bool SePagaDoble { get; set; }
        public bool Activo { get; set; } = true;
    }
}
