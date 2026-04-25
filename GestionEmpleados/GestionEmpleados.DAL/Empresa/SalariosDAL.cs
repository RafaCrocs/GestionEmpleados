using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace GestionEmpleados.DAL.Empresa
{
    public class SalariosDAL
    {
        public List<Salario> Salarios_ObtenerTodos(int idEmpleado, out string mensaje)
        {
            var lista = new List<Salario>();
            mensaje = string.Empty;

            try
            {
                using SqlConnection conn = new(CadenaConexion.Cadena);
                using SqlCommand cmd = new("SP_VerDeduccionesEmpleado", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Salario
                    {
                        IdEmpleado = new Empleado { IdEmpleado = reader.GetInt32(reader.GetOrdinal("IdEmpleado")) },
                        NombreEmpleado = reader.GetString(reader.GetOrdinal("NombreEmpleado")),
                        Puesto = reader.GetString(reader.GetOrdinal("Puesto")),
                        SalarioReal = reader.GetDecimal(reader.GetOrdinal("SalarioReal")),
                        SalarioReportado = reader.GetDecimal(reader.GetOrdinal("SalarioReportado")),
                        Adelanto = reader.GetDecimal(reader.GetOrdinal("TotalAdelantos")),
                        RebajoDePrestamo = reader.GetDecimal(reader.GetOrdinal("Rebajo_de_Prestamo")),
                        Seguro = reader.GetDecimal(reader.GetOrdinal("Seguro")),
                        ValorHora = reader.GetDecimal(reader.GetOrdinal("ValorHora")),
                        HorasTrabajadas = reader.GetDecimal(reader.GetOrdinal("HorasTrabajadas")),
                        HorasExtra = reader.GetDecimal(reader.GetOrdinal("HorasExtra")),
                        Bonificacion = reader.GetDecimal(reader.GetOrdinal("Bonificacion")),
                    });
                }
            }
            catch (Exception ex)
            {
                mensaje = $"Error al obtener deducciones: {ex.Message}";
            }

            return lista;
        }

        public bool Salarios_PagarSalario(Salario salario, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
                using (SqlCommand cmd = new SqlCommand("SP_PagarSalario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdEmpleado", salario.IdEmpleado?.IdEmpleado ?? 0);
                    cmd.Parameters.AddWithValue("@Seguro", salario.Seguro);
                    cmd.Parameters.AddWithValue("@Adelanto", salario.Adelanto);
                    cmd.Parameters.AddWithValue("@RebajoDePrestamo", salario.RebajoDePrestamo);
                    cmd.Parameters.AddWithValue("@HorasTrabajadas", salario.HorasTrabajadas);
                    cmd.Parameters.AddWithValue("@HorasExtra", salario.HorasExtra);
                    cmd.Parameters.AddWithValue("@Bonificacion", salario.Bonificacion);
                    cmd.Parameters.AddWithValue("@SalarioReal", salario.SalarioReal);
                    cmd.Parameters.AddWithValue("@SalarioPagado", salario.SalarioPagado);
                    cmd.Parameters.AddWithValue("@SalarioReportado", salario.SalarioReportado);
                    cmd.Parameters.AddWithValue("@DiasAusentes", salario.DiasAusentes);
                    cmd.Parameters.AddWithValue("@DiasIncapacitados", salario.DiasIncapacitados);
                    cmd.Parameters.AddWithValue("@DiasDobles", salario.DiasDobles);

                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
                    mensaje = cmd.Parameters["@Mensaje"].Value?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                mensaje = $"Error al pagar el salario: {ex.Message}";
                resultado = false;
            }
            return resultado;
        }
    }
}
