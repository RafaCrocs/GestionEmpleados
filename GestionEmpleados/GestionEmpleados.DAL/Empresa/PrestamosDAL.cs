using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GestionEmpleados.DAL.Empresa
{
    public class PrestamosDAL
    {
        public List<Prestamo> Prestamos_ObtenerTodos()
        {
            string query = @"select
	                        a.IdPrestamo,
                            a.IdEmpleado,
	                        e.Nombre + ' ' + e.Apellidos + ' ' + e.Identificacion AS NombreEmpleado,
	                        a.Monto,
                            a.Cuotas,
	                        a.MontoRestante,
	                        a.CuotasRestantes,
                            a.MontoAPagarPorCuota,
	                        a.MontoPagado,
	                        a.FechaInicio,
	                        a.Detalle
	                        from Prestamos a
                        inner join Empleados e on a.IdEmpleado = e.IdEmpleado
                        order by a.IdPrestamo desc";

            List<Prestamo> lista = new List<Prestamo>();
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
                            Prestamo prestamo = new Prestamo()
                            {
                                IdPrestamo = Convert.ToInt32(reader["IdPrestamo"]),
                                IdEmpleado = new Empleado()
                                {
                                    IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                                    Nombre = reader["NombreEmpleado"].ToString()
                                },
                                Monto = Convert.ToDecimal(reader["Monto"]),
                                Cuotas = Convert.ToInt32(reader["Cuotas"]),
                                MontoRestante = Convert.ToDecimal(reader["MontoRestante"]),
                                CuotasRestantes = Convert.ToInt32(reader["CuotasRestantes"]),
                                MontoAPagarPorCuota = Convert.ToDecimal(reader["MontoAPagarPorCuota"]),
                                MontoPagado = Convert.ToDecimal(reader["MontoPagado"]),
                                FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                                Detalle = reader["Detalle"].ToString()
                            };
                            lista.Add(prestamo);
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

        public bool Prestamos_Insertar(Prestamo nuevoPrestamo, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
                using (SqlCommand cmd = new SqlCommand("SP_InsertarPrestamo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdEmpleado", nuevoPrestamo.IdEmpleado.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Monto", nuevoPrestamo.Monto);
                    cmd.Parameters.AddWithValue("@Cuotas", nuevoPrestamo.Cuotas);
                    cmd.Parameters.AddWithValue("@Detalle", nuevoPrestamo.Detalle);

                    cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
                    mensaje = cmd.Parameters["@Mensaje"].Value?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                mensaje = $"Error al insertar el prestamo: {ex.Message}";
                resultado = false;
            }
            return resultado;
        }

        public bool Prestamos_Editar(Prestamo prestamoEditar, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
                using (SqlCommand cmd = new SqlCommand("SP_EditarPrestamo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdPrestamo", prestamoEditar.IdPrestamo);
                    cmd.Parameters.AddWithValue("@Monto", prestamoEditar.Monto);
                    cmd.Parameters.AddWithValue("@Cuotas", prestamoEditar.Cuotas);
                    cmd.Parameters.AddWithValue("@Detalle", prestamoEditar.Detalle);
                    cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
                    mensaje = cmd.Parameters["@Mensaje"].Value?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                mensaje = $"Error al editar el prestamo: {ex.Message}";
                resultado = false;
            }
            return resultado;
        }

        public bool Prestamos_Eliminar(int idPrestamo, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
                using (SqlCommand cmd = new SqlCommand("SP_EliminarPrestamo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdPrestamo", idPrestamo);
                    cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
                    mensaje = cmd.Parameters["@Mensaje"].Value?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                mensaje = $"Error al eliminar el prestamo: {ex.Message}";
                resultado = false;
            }
            return resultado;
        }
    }
}
