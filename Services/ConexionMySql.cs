using MySql.Data.MySqlClient;

namespace SaludTotalEscritorio.Datos
{
    public class ConexionMySQL
    {
        private const string cadenaConexion = "server=localhost;port=3306;database=saludtotal;uid=root;pwd=43108540;";

        public static MySqlConnection ObtenerConexion()
        {
            var conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }
    }
}
