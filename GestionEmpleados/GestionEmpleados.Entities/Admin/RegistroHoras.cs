using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.Entities.Admin
{
    public class RegistroHoras
    {
        public int IdRegistroHoras { get; set; }
        public Empleado? IdEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraEntrada { get; set; } = DateTime.Now;
        public DateTime HoraSalida { get; set; }
        public decimal HorasTrabajadas { get; set; }
    }
}
