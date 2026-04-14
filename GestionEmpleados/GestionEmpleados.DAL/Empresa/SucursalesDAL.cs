using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GestionEmpleados.DAL.Empresa
{
    public class SucursalesDAL
    {
        public List<Sucursal> Sucursales_ObtenerTodos()
        {
            string query = "SELECT * FROM Sucursales";
            List<Sucursal> lista = new List<Sucursal>();

            using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Sucursal nuevo = new Sucursal()
                        {
                            IdSucursal = Convert.ToInt32(reader["IdSucursal"]),
                            Nombre = reader["Nombre"].ToString(),
                            Direccion = reader["Direccion"].ToString(),
                            Telefono = reader["Telefono"].ToString(),
                            FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"])
                        };
                        lista.Add(nuevo);
                    }
                }

                conn.Close();
            }

            return lista;

        }
    }
}
