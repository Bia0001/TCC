using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Sistema.Acesso.Entidades;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Acesso.DAL.Contexto
{
    public class BancoContexto : DbContext
    {
        /* método construtor referenciando a string de conexão*/
        public BancoContexto() : base("ConnDB") { }

        /* cada DbSet representa uma tabela do banco de dados*/
        
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<AssistenteAluno> AssistentesAluno { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<PessoaFisica> PessoasFisica { get; set; }
        public DbSet<Prontuario> Prontuarios { get; set; }
        public DbSet<SolicitacaoSaida> SolicitacoesSaida { get; set; }
        public DbSet<Vigilante> Vigilantes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /* Removendo convenção de pluralização de nomenclaturas de tabelas no banco de dados*/
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Aluno>().ToTable("Alunos");
            modelBuilder.Entity<AssistenteAluno>().ToTable("AssistentesAluno");
            modelBuilder.Entity<Endereco>().ToTable("Enderecos");
            modelBuilder.Entity<PessoaFisica>().ToTable("PessoasFisica");
            modelBuilder.Entity<Prontuario>().ToTable("Prontuarios");
            modelBuilder.Entity<SolicitacaoSaida>().ToTable("SolicitacoesSaida");
            modelBuilder.Entity<Vigilante>().ToTable("Vigilantes");
        }
    }
}
