using MySql.Data.Entity;
using System.Data.Entity;
/*Classe responsável por relatar ao Entity Framework as alterações de configurações e provider*/
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