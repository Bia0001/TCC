using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Sistema.Acesso.Entidades;

namespace Sistema.Acesso.DAL.Contexto
{
    public class BancoContexto : DbContext
    {
        /*referenciando a string de conexão*/
        public BancoContexto() : base("ConnDB") { }
    }
}
