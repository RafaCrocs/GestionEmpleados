using System;

namespace GestionEmpleados.DAL
{
    public class CadenaConexion
    {
        public static string Cadena { get; } = "Server=localhost\\SQLEXPRESS;Database=GestionEmpleados;Integrated Security=True;TrustServerCertificate=true;";
    }
}
