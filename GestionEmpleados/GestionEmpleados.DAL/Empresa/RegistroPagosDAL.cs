using GestionEmpleados.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace GestionEmpleados.DAL.Empresa
{
    public class RegistroPagosDAL
    {

        public List<RegistroPago> ObtenerRegistrosPagos(out string mensaje,RegistroPago idSeleccionado = null, DateTime? fecha = null)
        {
            List<RegistroPago> registros = new List<RegistroPago>();
            mensaje = string.Empty; 
            try
            {
                using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_VerRegistroPagos", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        if (idSeleccionado != null)
                        {
                            cmd.Parameters.AddWithValue("@IdEmpleado", idSeleccionado.IdEmpleado?.IdEmpleado);
                        }
                        if (fecha != null)
                        {
                            cmd.Parameters.AddWithValue("@Fecha", fecha);
                        }
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                RegistroPago registro = new RegistroPago
                                {
                                    NombreEmpleado = reader.GetString(reader.GetOrdinal("NombreEmpleado")),
                                    HorasTrabajadas = reader.GetDecimal(reader.GetOrdinal("HorasTrabajadas")),
                                    HorasExtra = reader.GetDecimal(reader.GetOrdinal("HorasExtra")),
                                    DiasAusentes = reader.GetInt32(reader.GetOrdinal("DiasAusentes")),
                                    DiasIncapacitados = reader.GetInt32(reader.GetOrdinal("DiasIncapacitados")),
                                    DiasDobles = reader.GetInt32(reader.GetOrdinal("DiasDobles")),
                                    SalarioReal = reader.GetDecimal(reader.GetOrdinal("SalarioReal")),
                                    SalarioPagado = reader.GetDecimal(reader.GetOrdinal("SalarioPagado")),
                                    SalarioReportado = reader.GetDecimal(reader.GetOrdinal("SalarioReportado")),
                                    Seguro = reader.GetDecimal(reader.GetOrdinal("Seguro")),
                                    Adelanto = reader.GetDecimal(reader.GetOrdinal("Adelanto")),
                                    Prestamo = reader.GetDecimal(reader.GetOrdinal("Prestamo")),
                                    Bonificacion = reader.GetDecimal(reader.GetOrdinal("Bonificacion")),
                                    Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha"))
                                };
                                registros.Add(registro);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al registrar el pago en el historial: " + ex.Message;
            }


            return registros;
        }
    }
}
