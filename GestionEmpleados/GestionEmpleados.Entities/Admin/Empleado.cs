using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmpleados.Entities.Admin
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public Sucursal? IdSucursal { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string NombreCompleto => $"{Nombre} {Apellidos} {Identificacion}";
        public string? Identificacion { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public string? Contrasenna { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaSalida { get; set; }
        public Puesto? IdPuesto { get; set; }
        public string NombrePuesto => IdPuesto != null ? IdPuesto.Nombre : string.Empty;
        public string NombreSucursal => IdSucursal != null ? IdSucursal.Nombre : string.Empty;
        public decimal SalarioReal { get; set; }
        public decimal SalarioReportado { get; set; }
        public decimal Bonificacion { get; set; }
        public decimal Seguro { get; set; }
        public bool PagaSeguro { get; set; }
        public decimal ValorHora { get; set; }
        public string? Estado { get; set; }
    }
}
