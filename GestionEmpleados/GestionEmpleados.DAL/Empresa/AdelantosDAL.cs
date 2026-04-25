using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace GestionEmpleados.DAL.Empresa
{
    public class AdelantosDAL
    {
        public List<Adelanto> Adelantos_ObtenerTodos()
        {
            string query = "SELECT * FROM VW_AdelantosEmpleados ORDER BY IdAdelanto DESC";

            List<Adelanto> lista = new List<Adelanto>();
            try
            {
                using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Adelanto adelanto = new Adelanto()
                            {
                                IdAdelanto = Convert.ToInt32(reader["IdAdelanto"]),
                                IdEmpleado = new Empleado()
                                {
                                    IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                                    Nombre = reader["Nombre"].ToString()
                                },
                                Monto   = Convert.ToDecimal(reader["Monto"]),
                                Fecha   = Convert.ToDateTime(reader["Fecha"]),
                                Detalle = reader["Detalle"].ToString()
                            };
                            lista.Add(adelanto);
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lista;
        }

        public bool Adelantos_Insertar(Adelanto nuevoAdelanto, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
                using (SqlCommand cmd = new SqlCommand("SP_InsertarAdelanto", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdEmpleado", nuevoAdelanto.IdEmpleado.IdEmpleado);
                    cmd.Parameters.AddWithValue("@NombreEmpleado", nuevoAdelanto.NombreEmpleado);
                    cmd.Parameters.AddWithValue("@Monto", nuevoAdelanto.Monto);
                    cmd.Parameters.AddWithValue("@Detalle", nuevoAdelanto.Detalle);

                    cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
                    mensaje   = cmd.Parameters["@Mensaje"].Value?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                mensaje   = $"Error al insertar el adelanto: {ex.Message}";
                resultado = false;
            }
            return resultado;
        }

        public bool Adelantos_Editar(Adelanto adelantoAEditar, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
                using (SqlCommand cmd = new SqlCommand("SP_EditarAdelanto", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdAdelanto", adelantoAEditar.IdAdelanto);
                    cmd.Parameters.AddWithValue("@IdEmpleado", adelantoAEditar.IdEmpleado?.IdEmpleado);
                    cmd.Parameters.AddWithValue("@NombreEmpleado", adelantoAEditar.NombreEmpleado);
                    cmd.Parameters.AddWithValue("@Monto", adelantoAEditar.Monto);
                    cmd.Parameters.AddWithValue("@Fecha", adelantoAEditar.Fecha);
                    cmd.Parameters.AddWithValue("@Detalle", adelantoAEditar.Detalle);

                    cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
                    mensaje   = cmd.Parameters["@Mensaje"].Value?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                mensaje   = $"Error al editar el adelanto: {ex.Message}";
                resultado = false;
            }
            return resultado;
        }

        public bool Adelantos_Eliminar(int idAdelanto)
        {
            string query = "DELETE FROM Adelantos WHERE IdAdelanto = @IdAdelanto";
            bool resultado = false;
            using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@IdAdelanto", idAdelanto);
                conn.Open();
                resultado = cmd.ExecuteNonQuery() > 0;
                conn.Close();
                return resultado;
            }
        }
    }
}
