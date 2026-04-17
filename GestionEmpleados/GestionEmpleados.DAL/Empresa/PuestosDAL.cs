using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GestionEmpleados.DAL.Empresa
{
    public class PuestosDAL
    {
        public List<Puesto> Puestos_ObtenerTodos()
        {
            string query = "SELECT * FROM Puestos";
            List<Puesto> lista = new List<Puesto>();

            using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Puesto nuevo = new Puesto()
                        {
                            IdPuesto = Convert.ToInt32(reader["IdPuesto"]),
                            Nombre = reader["Nombre"].ToString(),
                            SalarioBase = Convert.ToDecimal(reader["SalarioBase"])
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
