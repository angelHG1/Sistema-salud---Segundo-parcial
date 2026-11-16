using Microsoft.Data.SqlClient;

namespace Datos
{

    public class ConexionDB
    {
        //Singleton, Lazy para solo crear la instancia cuando se necesite
        private static readonly Lazy<ConexionDB> _instancia = new Lazy<ConexionDB>(() => new ConexionDB ());
        private readonly string _cadenaConexion =
            "Server=ANGELH;" +
            "Database=SistemaSalud;" +
            "User ID=angel;" +
            "Password=Diciembre2006;" +
            "TrustServerCertificate=True;" +
            "Encrypt=True;";

        private ConexionDB()
        { }

        public static ConexionDB Instancia => _instancia.Value;

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(_cadenaConexion);
        }

    }
}