using MySql.Data.Entity;
using System.Data.Entity;

namespace Sistema.IFSP.Repositorio.Configuracoes
{
    public class MySqlConfiguration : DbConfiguration
    {
        public MySqlConfiguration()
        {
            SetHistoryContext(
            "MySql.Data.MySqlClient", (conn, schema) => new MySqlHistoryContext(conn, schema));
        }
    }
}