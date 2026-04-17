using System.Data;
using System.Data.SqlClient;

namespace GestionEmpleados.DAL.Empresa
{
    public class RegistroHorasDAL
    {
        public bool RegistroHoras_RegistrarEntradaSalida(int idEmpleado, string tipoRegistro, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(CadenaConexion.Cadena))
                using (SqlCommand cmd = new SqlCommand("SP_RegistrarEntradaSalida", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@TipoRegistro", tipoRegistro);

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
                mensaje = $"Error al registrar entrada/salida: {ex.Message}";
                resultado = false;
            }
            return resultado;
        }
    }
}
