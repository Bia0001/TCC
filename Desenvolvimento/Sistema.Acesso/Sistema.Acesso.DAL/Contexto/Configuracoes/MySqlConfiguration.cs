using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Sistema.Acesso.DAL.Contexto;

namespace Sistema.Acesso.DAL
{
    /* dizendo ao Entity Framework que ele deve usar o HistoryContext que foi modificado*/
    public class MySqlConfiguration : DbConfiguration
    {
        public MySqlConfiguration()
        {
            SetHistoryContext("MySql.Data.MySqlClient", (conn, schema) => new MySqlHistoryContext(conn, schema));
        }
    }
}
