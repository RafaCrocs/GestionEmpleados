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
                        SalarioBase = reader.GetDecimal(reader.GetOrdinal("SalarioBase")),
                        Adelantos = reader.GetDecimal(reader.GetOrdinal("TotalAdelantos")),
                        RebajoDePrestamo = reader.GetDecimal(reader.GetOrdinal("Rebajo_de_Prestamo")),
                        Seguro = reader.GetDecimal(reader.GetOrdinal("Seguro")),
                        HorasTrabajadas = reader.GetDecimal(reader.GetOrdinal("HorasTrabajadas")),
                        HorasExtras = reader.GetDecimal(reader.GetOrdinal("HorasExtra")),
                        Monto = reader.GetDecimal(reader.GetOrdinal("SalarioFinal")),
                    });
                }
            }
            catch (Exception ex)
            {
                mensaje = $"Error al obtener deducciones: {ex.Message}";
            }

            return lista;
        }

        public bool Salarios_PagarSalario(int idEmpleado, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
                using (SqlCommand cmd = new SqlCommand("SP_PagarSalario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

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
