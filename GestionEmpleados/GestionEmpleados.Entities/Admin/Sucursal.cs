using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace GestionEmpleados.Entities.Admin
{
    public class Sucursal
    {
        public int IdSucursal { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
