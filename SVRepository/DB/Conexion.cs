using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SVRepository.DB
{
    public class Conexion
    {
        private readonly IConfiguration _configuration;
        private readonly string _cadenaSql;

        public Conexion(IConfiguration configuration)
        {
            _configuration = configuration;
            _cadenaSql = _configuration.GetConnectionString("CadenaSql")!;
        }

        public SqlConnection ObtenerSqlConexion()
        {
            return new SqlConnection(_cadenaSql);
        }
    }
}
