using Sistema.Ifsp.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Sistema.Ifsp.Repositorio
{
    public class BancoContexto : DbContext
    {
        /*Construtor utiliza da String de Conexão chamada ConnDB encontrado no App.Config da camada View*/
        public BancoContexto() : base("ConnDB") { }

        /*Cada DbSet representa uma classe que será tabela no banco de dados*/
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<AssistenteAluno> AssistentesAluno { get; set; }
        public DbSet<PessoaFisica> PessoasFisica { get; set; }
        public DbSet<Prontuario> Prontuarios { get; set; }
        public DbSet<SolicitacaoSaida> SolicitacoesSaida { get; set; }
        public DbSet<Vigilante> Vigilantes { get; set; }

        /*Sobreescrevendo método principal de DBContext*/
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /*Removendo convenção de pluralização de nomes de tabelas no banco de dados*/
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
