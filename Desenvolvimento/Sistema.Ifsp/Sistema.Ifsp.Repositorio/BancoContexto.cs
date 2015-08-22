using Sistema.Ifsp.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
/*Classe dedicada a ser o Conxtexto do banco de dados em memória ram
todas as consultas e persistêncis são feitas por meio dela. Cada propriedade do tipo DbSet
representa um tabela no banco de dados.*/
namespace Sistema.Ifsp.Repositorio
{
    public class BancoContexto : DbContext
    {
        /*Construtor utiliza da String de Conexão chamada ConnDB encontrado no App.Config da camada View*/
        public BancoContexto() : base("ConnDB") { }

        /*Cada DbSet representa uma classe entidade e tambén tabela no banco de dados*/
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<AssistenteAluno> AssistentesAluno { get; set; }
        public DbSet<PessoaFisica> PessoasFisica { get; set; }
        public DbSet<Prontuario> Prontuarios { get; set; }
        public DbSet<SolicitacaoSaida> SolicitacoesSaida { get; set; }
        public DbSet<Vigilante> Vigilantes { get; set; }

        /*Sobreescrevendo método responsável pela modelagem do sistema operacional no banco de dados*/
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /*Removendo convenção de pluralização de nomes de tabelas no banco de dados*/
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
