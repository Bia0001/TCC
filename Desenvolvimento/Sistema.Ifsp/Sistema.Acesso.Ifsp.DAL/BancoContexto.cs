using Sistema.Acesso.Ifsp.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
/*Classe dedicada a ser o Conxtexto do banco de dados em memória ram
todas as consultas e persistêncis são feitas por meio dela. Cada propriedade do tipo DbSet
representa um tabela no banco de dados.*/
namespace Sistema.Acesso.Ifsp.DAL
{
    public class BancoContexto : DbContext
    {
        /*Construtor utiliza da String de Conexão chamada ConnDB encontrado no App.Config da camada View*/
        public BancoContexto() : base("ConnDB") { }

        /*Cada DbSet representa uma classe entidade e tambén tabela no banco de dados*/
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<AssistenteAluno> AssistenteAluno { get; set; }
        public DbSet<Porteiro> Porteiro { get; set; }
        public DbSet<Prontuario> Prontuario { get; set; }
        public DbSet<SolicitacaoSaida> SolicitacoesSaida { get; set; }

        /*Sobreescrevendo método responsável pela modelagem do sistema operacional no banco de dados*/
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /*Removendo convenção de pluralização de nomes de tabelas no banco de dados*/
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
