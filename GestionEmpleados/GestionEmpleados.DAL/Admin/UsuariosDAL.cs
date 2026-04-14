using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using GestionEmpleados.Entities.Admin;

namespace GestionEmpleados.DAL.Admin
{
    public class UsuariosDAL
    {
        public List<Usuario> Usuarios_ObtenerTodos()
        {
            string query = "SELECT * FROM Usuarios";
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuario nuevo = new Usuario()
                        {
                            IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                            IdSucursal = new Sucursal { IdSucursal = Convert.ToInt32(reader["IdSucursal"]) },
                            Nombre = reader["Nombre"].ToString(),
                            Apellidos = reader["Apellidos"].ToString(),
                            Identificacion = reader["Identificacion"].ToString(),
                            IdRol = new Rol { IdRol = Convert.ToInt32(reader["IdRol"]) },
                            Correo = reader["Correo"].ToString(),
                            Contrasenna = reader["Contrasenna"].ToString(),
                            FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]),
                            Activo = Convert.ToBoolean(reader["Activo"])
                        };
                        lista.Add(nuevo);
                    }
                }

                conn.Close();
            }

            return lista;

        }

        public bool Usuarios_Insertar(Usuario nuevo)
        {
            string query = @"INSERT INTO Usuarios 
                            (IdSucursal, Nombre, Apellidos, Identificacion, IdRol, Correo, Contrasenna, Activo)
                           VALUES 
                            (@IdSucursal, @Nombre, @Apellidos, @Identificacion, @IdRol, @Correo, @Contrasenna, @Activo)";

            bool resultado = false;

            using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@IdSucursal", nuevo.IdSucursal.IdSucursal);
                cmd.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
                cmd.Parameters.AddWithValue("@Apellidos", nuevo.Apellidos);
                cmd.Parameters.AddWithValue("@Identificacion", nuevo.Identificacion);
                cmd.Parameters.AddWithValue("@IdRol", nuevo.IdRol.IdRol);
                cmd.Parameters.AddWithValue("@Correo", nuevo.Correo);
                cmd.Parameters.AddWithValue("@Contrasenna", nuevo.Contrasenna);
                cmd.Parameters.AddWithValue("@Activo", nuevo.Activo);
                conn.Open();
                resultado = cmd.ExecuteNonQuery() > 0;
                conn.Close();
                return resultado;
            }
        }

        public bool Usuarios_Actualizar(Usuario actualizado)
        {
            string query = @"UPDATE Usuarios SET 
                            IdSucursal = @IdSucursal, 
                            Nombre = @Nombre, 
                            Apellidos = @Apellidos, 
                            Identificacion = @Identificacion, 
                            IdRol = @IdRol, 
                            Correo = @Correo, 
                            Contrasenna = @Contrasenna,
                            Activo = @Activo
                           WHERE IdUsuario = @IdUsuario";
            bool resultado = false;
            using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@IdSucursal", actualizado.IdSucursal.IdSucursal);
                cmd.Parameters.AddWithValue("@Nombre", actualizado.Nombre);
                cmd.Parameters.AddWithValue("@Apellidos", actualizado.Apellidos);
                cmd.Parameters.AddWithValue("@Identificacion", actualizado.Identificacion);
                cmd.Parameters.AddWithValue("@IdRol", actualizado.IdRol.IdRol);
                cmd.Parameters.AddWithValue("@Correo", actualizado.Correo);
                cmd.Parameters.AddWithValue("@Contrasenna", actualizado.Contrasenna);
                cmd.Parameters.AddWithValue("@Activo", actualizado.Activo);
                cmd.Parameters.AddWithValue("@IdUsuario", actualizado.IdUsuario);
                conn.Open();
                resultado = cmd.ExecuteNonQuery() > 0;
                conn.Close();
                return resultado;
            }
        }

        public bool Usuarios_Eliminar(int idUsuario)
        {
            string query = "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";
            bool resultado = false;
            using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                conn.Open();
                resultado = cmd.ExecuteNonQuery() > 0;
                conn.Close();
                return resultado;
            }
        }
    }
}
