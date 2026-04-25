using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GestionEmpleados.DAL.Empresa
{
    public class RegistroPrestamosDAL
    {

        public List<RegistroPrestamo> Registro_Prestamos_ObtenerTodos()
        {
            List<RegistroPrestamo> prestamos = new List<RegistroPrestamo>();

            using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from VW_RegistroPrestamos", conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RegistroPrestamo registroPrestamos = new RegistroPrestamo()
                            {
                                IdRegistroPrestamo = Convert.ToInt32(reader["IdRegistro"]),
                                IdPrestamo = Convert.ToInt32(reader["IdPrestamo"]),
                                IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                                NombreEmpleado = reader["NombreEmpleado"].ToString(),
                                MontoPagado = Convert.ToDecimal(reader["MontoPagado"]),
                                Fecha = Convert.ToDateTime(reader["Fecha"])
                            };
                            prestamos.Add(registroPrestamos);
                        }
                    }
                }
            }
            return prestamos;
        }
    }
}
