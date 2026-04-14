using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GestionEmpleados.DAL.Admin
{
    public class RolesDAL
    {
        public List<Rol> Roles_ObtenerTodos()
        {
            string query = "SELECT * FROM Roles";
            List<Rol> lista = new List<Rol>();

            using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Rol nuevo = new Rol()
                        {
                            IdRol = Convert.ToInt32(reader["IdRol"]),
                            Nombre = reader["Nombre"].ToString(),
                            Descripcion = reader["Descripcion"].ToString()
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
