using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;

namespace GestionEmpleados.DAL.Empresa
{
    public class Puestos_SegurosDAL
    {
        public List<Puesto> Puestos_Seguros_ObtenerTodos()
        {
            string query = "SELECT * FROM VW_Puestos_Seguros";
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
                            IdPuesto = reader.GetInt32(reader.GetOrdinal("IdPuesto")),
                            Nombre = reader.GetString(reader.GetOrdinal("NombrePuesto")),
                            SalarioReportado = reader.GetDecimal(reader.GetOrdinal("SalarioReportado")),
                            PorcentajeSeguro = reader.GetDecimal(reader.GetOrdinal("PorcentajeSeguro")),
                            Seguro = reader.GetDecimal(reader.GetOrdinal("Seguro"))
                        };
                        lista.Add(nuevo);
                    }
                }
                conn.Close();
            }
            return lista;
        }

        public bool Puestos_Seguros_Insertar(Puesto nuevoPuesto, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_InsertarPuesto_Seguro", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nombre", nuevoPuesto.Nombre);
                        cmd.Parameters.AddWithValue("@SalarioReportado", nuevoPuesto.SalarioReportado);
                        cmd.Parameters.AddWithValue("@PorcentajeSeguro", nuevoPuesto.PorcentajeSeguro);

                        cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                        mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                        conn.Close();
                    }
                }
            }
            catch (Exception e)
            {
                mensaje = $"Error al insertar Puesto: {e.Message}";
                resultado = false;

            }
            return resultado;

        }

        public bool Puestos_Seguros_Editar(Puesto puestoSeguro, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Editar_Puesto_Seguro", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdPuesto", puestoSeguro.IdPuesto);
                        cmd.Parameters.AddWithValue("@Nombre", puestoSeguro.Nombre);
                        cmd.Parameters.AddWithValue("@SalarioReportado", puestoSeguro.SalarioReportado);
                        cmd.Parameters.AddWithValue("@PorcentajeSeguro", puestoSeguro.PorcentajeSeguro);


                        cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;


                        conn.Open();
                        cmd.ExecuteNonQuery();
                        resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                        mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                        conn.Close();
                    }
                }
            }
            catch (Exception e)
            {
                mensaje = $"Error al editar Puesto: {e.Message}";
                resultado = false;
            }
            return resultado;
        }

        public bool Puestos_Seguros_Eliminar(int idPuesto, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_Eliminar_Puesto", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdPuesto", idPuesto);
                        cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                        mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                        conn.Close();
                    }
                }
            }
            catch (Exception e)
            {
                mensaje = $"Error al eliminar Puesto: {e.Message}";
                resultado = false;
            }
            return resultado;
        }
    }
}
