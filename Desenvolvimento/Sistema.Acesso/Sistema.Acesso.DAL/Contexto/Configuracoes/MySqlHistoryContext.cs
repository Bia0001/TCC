using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations.History;

namespace Sistema.Acesso.DAL.Contexto
{
    /* Pelo fato da solução utilizar o banco de dados Mysql 5.6, existe um conflito com o tamanho da chave primaria descrita na History-Migrations
     com o padrão Mysql, por essa razão estamos sobrescrevendo o método que define o tamanho da chave primaria */
    public class MySqlHistoryContext : HistoryContext
    {
        public MySqlHistoryContext(DbConnection existingConnection, string defaultSchema) : base (existingConnection, defaultSchema) {}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<HistoryRow>().Property(h => h.MigrationId).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<HistoryRow>().Property(h => h.ContextKey).HasMaxLength(200).IsRequired();
        }
    }
}
