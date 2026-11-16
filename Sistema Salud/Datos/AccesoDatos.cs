
using Microsoft.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class AccesoDatosBD
    {
        public bool EjecutarComando(
            string consulta,
            params SqlParameter[] parametros)
        {
            using (SqlConnection conexion =
                ConexionDB.Instancia.ObtenerConexion())
            using (SqlCommand comando =
                new SqlCommand(consulta, conexion))
            {
                comando.Parameters.AddRange(parametros);

                conexion.Open();

                return comando.ExecuteNonQuery() > 0;
            }
        }

        public DataTable EjecutarConsulta(
            string consulta,
            params SqlParameter[] parametros)
        {
            DataTable resultado = new DataTable();

            using (SqlConnection conexion =
                ConexionDB.Instancia.ObtenerConexion())
            using (SqlCommand comando =
                new SqlCommand(consulta, conexion))
            {
                comando.Parameters.AddRange(parametros);

                using (SqlDataAdapter adaptador =
                    new SqlDataAdapter(comando))
                {
                    adaptador.Fill(resultado);
                }
            }

            return resultado;
        }
    }
}
