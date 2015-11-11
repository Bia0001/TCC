using Sistema.Ifsp.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Sistema.Ifsp.DAL
{
    /*classe reponsável por realizar o mapeamento objeto relacional
    cada atributo DbSet representará uma tabela no banco de dados*/
    public class Contexto : DbContext
    {
        /*passando o nome da connectionString como argumento para superclasse */
        public Contexto() : base("ConnDB") { }

        public DbSet<Aluno> aluno { get; set; }
        public DbSet<Funcionario> funcionario { get; set; }
        public DbSet<AdministradorSistema> administradoresSistemas { get; set; }
        public DbSet<AssistenteAluno> assistenteAluno { get; set; }
        public DbSet<AssistenteAdministracao> assistenteAdministracao { get; set; }
        public DbSet<AssistenteCoordenadoria> assistenteCoordenadoria { get; set; }
        public DbSet<PessoaFisica> pessoaFisica { get; set; }
        public DbSet<Porteiro> porteiro { get; set; }
        public DbSet<Terceirizado> terceirizado { get; set; }
        public DbSet<Solicitacao> solicitacao { get; set; }
        public DbSet<SolicitacaoEntrada> solicitacaoEntrada { get; set; }
        public DbSet<SolicitacaoSaida> solicitacaoSaida { get; set; }
        public DbSet<Visitante> visitante { get; set; }
        public DbSet<Fornecedor> fornecedor { get; set; }
        public DbSet<Prontuario> prontuario { get; set; }
        public DbSet<Vaga> vaga { get; set; }
        public DbSet<PermanenciaVeiculo> permanenciaVeiculo { get; set; }
        public DbSet<Autenticacao> atenticacoes { get; set; }
        /*removendo convenção de pluralização do Entity Fremework*/
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
