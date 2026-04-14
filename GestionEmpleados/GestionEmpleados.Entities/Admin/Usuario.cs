using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.Entities.Admin
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public Sucursal? IdSucursal { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? Identificacion { get; set; }
        public Rol? IdRol { get; set; }
        public string? Correo { get; set; }
        public string? Contrasenna { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; } = true;
    }
}
    