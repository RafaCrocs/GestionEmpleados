using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GestionEmpleados.DAL.Empresa
{
    public class EmpleadosDAL
    {
        public List<Empleado> Empleados_ObtenerTodos()
        {
            string query = "SELECT * FROM Empleados";
            List<Empleado> lista = new List<Empleado>();

            using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Empleado nuevo = new Empleado()
                        {
                            IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                            IdSucursal = new Sucursal() { IdSucursal = Convert.ToInt32(reader["IdSucursal"]) },
                            Identificacion = reader["Identificacion"].ToString(),
                            Nombre = reader["Nombre"].ToString(),
                            Apellidos = reader["Apellidos"].ToString(),
                            Telefono = reader["Telefono"].ToString(),
                            Correo = reader["Correo"].ToString(),
                            Contrasenna = reader["Contrasenna"].ToString(),
                            FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                            FechaIngreso = Convert.ToDateTime(reader["FechaIngreso"]),
                            FechaSalida = reader["FechaSalida"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["FechaSalida"]),
                            IdPuesto = new Puesto() { IdPuesto = Convert.ToInt32(reader["IdPuesto"]) },
                            Bonificacion = Convert.ToDecimal(reader["Bonificacion"]),
                            PagaSeguro = Convert.ToBoolean(reader["PagaSeguro"]),
                            Estado = reader["Estado"].ToString()
                        };
                        lista.Add(nuevo);
                    }
                }

                conn.Close();
            }

            return lista;

        }

        public bool Empleados_Insertar(Empleado nuevoEmpleado, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
                using (SqlCommand cmd = new SqlCommand("SP_InsertarEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdSucursal", nuevoEmpleado.IdSucursal.IdSucursal);
                    cmd.Parameters.AddWithValue("@Identificacion", nuevoEmpleado.Identificacion);
                    cmd.Parameters.AddWithValue("@Nombre", nuevoEmpleado.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", nuevoEmpleado.Apellidos);
                    cmd.Parameters.AddWithValue("@Telefono", nuevoEmpleado.Telefono);
                    cmd.Parameters.AddWithValue("@Correo", nuevoEmpleado.Correo);
                    cmd.Parameters.AddWithValue("@Contrasenna", nuevoEmpleado.Contrasenna);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", nuevoEmpleado.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@IdPuesto", nuevoEmpleado.IdPuesto.IdPuesto);
                    cmd.Parameters.AddWithValue("@Bonificacion", nuevoEmpleado.Bonificacion);
                    cmd.Parameters.AddWithValue("@PagaSeguro", nuevoEmpleado.PagaSeguro);
                    cmd.Parameters.AddWithValue("@Estado", nuevoEmpleado.Estado);

                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                    

                }
            }
            catch(Exception ex)
            {
                mensaje = $"Error al insertar el empleado: {ex.Message}";
                resultado = false;
            }
            return resultado;
        }

        public bool Empleados_Editar(Empleado empleadoAEditar)
        {
            string query = @"UPDATE Empleados SET IdSucursal = @IdSucursal, Identificacion = @Identificacion, Nombre = @Nombre, Apellidos = @Apellidos, Telefono = @Telefono, Correo = @Correo, Contrasenna = @Contrasenna, FechaNacimiento = @FechaNacimiento, IdPuesto = @IdPuesto, Bonificacion = @Bonificacion, PagaSeguro = @PagaSeguro, Estado = @Estado
                             WHERE IdEmpleado = @IdEmpleado";
            bool resultado = false;
            using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@IdEmpleado", empleadoAEditar.IdEmpleado);
                cmd.Parameters.AddWithValue("@IdSucursal", empleadoAEditar.IdSucursal.IdSucursal);
                cmd.Parameters.AddWithValue("@Identificacion", empleadoAEditar.Identificacion);
                cmd.Parameters.AddWithValue("@Nombre", empleadoAEditar.Nombre);
                cmd.Parameters.AddWithValue("@Apellidos", empleadoAEditar.Apellidos);
                cmd.Parameters.AddWithValue("@Telefono", empleadoAEditar.Telefono);
                cmd.Parameters.AddWithValue("@Correo", empleadoAEditar.Correo);
                cmd.Parameters.AddWithValue("@Contrasenna", empleadoAEditar.Contrasenna);
                cmd.Parameters.AddWithValue("@FechaNacimiento", empleadoAEditar.FechaNacimiento);
                cmd.Parameters.AddWithValue("@IdPuesto", empleadoAEditar.IdPuesto.IdPuesto);
                cmd.Parameters.AddWithValue("@Bonificacion", empleadoAEditar.Bonificacion);
                cmd.Parameters.AddWithValue("@PagaSeguro", empleadoAEditar.PagaSeguro);
                cmd.Parameters.AddWithValue("@Estado", empleadoAEditar.Estado);
                conn.Open();
                resultado = cmd.ExecuteNonQuery() > 0;
                conn.Close();
                return resultado;
            }
        }

        public bool Empleados_Eliminar(int idEmpleado, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
                using (SqlCommand cmd = new SqlCommand("SP_EliminarEmpleado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();



                }
            }
            catch (Exception ex)
            {
                mensaje = $"Error al eliminar el empleado: {ex.Message}";
                resultado = false;
            }
            return resultado;
        }
    }
}
