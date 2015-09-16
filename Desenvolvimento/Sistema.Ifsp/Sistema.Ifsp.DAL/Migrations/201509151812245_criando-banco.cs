namespace Sistema.Ifsp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criandobanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PessoaFisica",
                c => new
                    {
                        idPessoaFisica = c.Int(nullable: false, identity: true),
                        nome = c.String(unicode: false),
                        celular = c.String(unicode: false),
                        telefone = c.String(unicode: false),
                        nascimento = c.DateTime(nullable: false, precision: 0),
                        rg = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idPessoaFisica);
            
            CreateTable(
                "dbo.Prontuario",
                c => new
                    {
                        idProntuario = c.Int(nullable: false, identity: true),
                        prontuario = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idProntuario);
            
            CreateTable(
                "dbo.Terceirizado",
                c => new
                    {
                        area = c.Int(nullable: false),
                        empresa = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.area);
            
            CreateTable(
                "dbo.Solicitacao",
                c => new
                    {
                        idSolicitacao = c.Int(nullable: false, identity: true),
                        aberura = c.DateTime(nullable: false, precision: 0),
                        motivo = c.String(unicode: false),
                        status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idSolicitacao);
            
            CreateTable(
                "dbo.UsoEstacionamento",
                c => new
                    {
                        idUsoEstacionamento = c.Int(nullable: false, identity: true),
                        diaDaSemana = c.Int(nullable: false),
                        entrada = c.DateTime(nullable: false, precision: 0),
                        saida = c.DateTime(nullable: false, precision: 0),
                        tipoVaga = c.Int(nullable: false),
                        codAcessoEstacionamento = c.String(unicode: false),
                        pessoaFisica_idPessoaFisica = c.Int(),
                    })
                .PrimaryKey(t => t.idUsoEstacionamento)
                .ForeignKey("dbo.PessoaFisica", t => t.pessoaFisica_idPessoaFisica)
                .Index(t => t.pessoaFisica_idPessoaFisica);
            
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        idPessoaFisica = c.Int(nullable: false),
                        area = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idPessoaFisica)
                .ForeignKey("dbo.PessoaFisica", t => t.idPessoaFisica)
                .Index(t => t.idPessoaFisica);
            
            CreateTable(
                "dbo.AdministradorSitema",
                c => new
                    {
                        idPessoaFisica = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idPessoaFisica)
                .ForeignKey("dbo.Funcionario", t => t.idPessoaFisica)
                .Index(t => t.idPessoaFisica);
            
            CreateTable(
                "dbo.Aluno",
                c => new
                    {
                        idPessoaFisica = c.Int(nullable: false),
                        prontuario_idProntuario = c.Int(),
                        Solicitacao_idSolicitacao = c.Int(),
                        responsavel1 = c.String(unicode: false),
                        responsavel2 = c.String(unicode: false),
                        contato1 = c.String(unicode: false),
                        contato2 = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idPessoaFisica)
                .ForeignKey("dbo.PessoaFisica", t => t.idPessoaFisica)
                .ForeignKey("dbo.Prontuario", t => t.prontuario_idProntuario)
                .ForeignKey("dbo.Solicitacao", t => t.Solicitacao_idSolicitacao)
                .Index(t => t.idPessoaFisica)
                .Index(t => t.prontuario_idProntuario)
                .Index(t => t.Solicitacao_idSolicitacao);
            
            CreateTable(
                "dbo.AssistenteAdministracao",
                c => new
                    {
                        idPessoaFisica = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idPessoaFisica)
                .ForeignKey("dbo.Funcionario", t => t.idPessoaFisica)
                .Index(t => t.idPessoaFisica);
            
            CreateTable(
                "dbo.AssistenteAluno",
                c => new
                    {
                        idPessoaFisica = c.Int(nullable: false),
                        Solicitacao_idSolicitacao = c.Int(),
                    })
                .PrimaryKey(t => t.idPessoaFisica)
                .ForeignKey("dbo.Funcionario", t => t.idPessoaFisica)
                .ForeignKey("dbo.Solicitacao", t => t.Solicitacao_idSolicitacao)
                .Index(t => t.idPessoaFisica)
                .Index(t => t.Solicitacao_idSolicitacao);
            
            CreateTable(
                "dbo.AssistenteCoordenadoria",
                c => new
                    {
                        idPessoaFisica = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idPessoaFisica)
                .ForeignKey("dbo.Funcionario", t => t.idPessoaFisica)
                .Index(t => t.idPessoaFisica);
            
            CreateTable(
                "dbo.Porteiro",
                c => new
                    {
                        area = c.Int(nullable: false),
                        SolicitacaoSaida_idSolicitacao = c.Int(),
                    })
                .PrimaryKey(t => t.area)
                .ForeignKey("dbo.Terceirizado", t => t.area)
                .ForeignKey("dbo.SolicitacaoSaida", t => t.SolicitacaoSaida_idSolicitacao)
                .Index(t => t.area)
                .Index(t => t.SolicitacaoSaida_idSolicitacao);
            
            CreateTable(
                "dbo.SolicitacaoEntrada",
                c => new
                    {
                        idSolicitacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idSolicitacao)
                .ForeignKey("dbo.Solicitacao", t => t.idSolicitacao)
                .Index(t => t.idSolicitacao);
            
            CreateTable(
                "dbo.SolicitacaoSaida",
                c => new
                    {
                        idSolicitacao = c.Int(nullable: false),
                        encerramento = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.idSolicitacao)
                .ForeignKey("dbo.Solicitacao", t => t.idSolicitacao)
                .Index(t => t.idSolicitacao);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SolicitacaoSaida", "idSolicitacao", "dbo.Solicitacao");
            DropForeignKey("dbo.SolicitacaoEntrada", "idSolicitacao", "dbo.Solicitacao");
            DropForeignKey("dbo.Porteiro", "SolicitacaoSaida_idSolicitacao", "dbo.SolicitacaoSaida");
            DropForeignKey("dbo.Porteiro", "area", "dbo.Terceirizado");
            DropForeignKey("dbo.AssistenteCoordenadoria", "idPessoaFisica", "dbo.Funcionario");
            DropForeignKey("dbo.AssistenteAluno", "Solicitacao_idSolicitacao", "dbo.Solicitacao");
            DropForeignKey("dbo.AssistenteAluno", "idPessoaFisica", "dbo.Funcionario");
            DropForeignKey("dbo.AssistenteAdministracao", "idPessoaFisica", "dbo.Funcionario");
            DropForeignKey("dbo.Aluno", "Solicitacao_idSolicitacao", "dbo.Solicitacao");
            DropForeignKey("dbo.Aluno", "prontuario_idProntuario", "dbo.Prontuario");
            DropForeignKey("dbo.Aluno", "idPessoaFisica", "dbo.PessoaFisica");
            DropForeignKey("dbo.AdministradorSitema", "idPessoaFisica", "dbo.Funcionario");
            DropForeignKey("dbo.Funcionario", "idPessoaFisica", "dbo.PessoaFisica");
            DropForeignKey("dbo.UsoEstacionamento", "pessoaFisica_idPessoaFisica", "dbo.PessoaFisica");
            DropIndex("dbo.SolicitacaoSaida", new[] { "idSolicitacao" });
            DropIndex("dbo.SolicitacaoEntrada", new[] { "idSolicitacao" });
            DropIndex("dbo.Porteiro", new[] { "SolicitacaoSaida_idSolicitacao" });
            DropIndex("dbo.Porteiro", new[] { "area" });
            DropIndex("dbo.AssistenteCoordenadoria", new[] { "idPessoaFisica" });
            DropIndex("dbo.AssistenteAluno", new[] { "Solicitacao_idSolicitacao" });
            DropIndex("dbo.AssistenteAluno", new[] { "idPessoaFisica" });
            DropIndex("dbo.AssistenteAdministracao", new[] { "idPessoaFisica" });
            DropIndex("dbo.Aluno", new[] { "Solicitacao_idSolicitacao" });
            DropIndex("dbo.Aluno", new[] { "prontuario_idProntuario" });
            DropIndex("dbo.Aluno", new[] { "idPessoaFisica" });
            DropIndex("dbo.AdministradorSitema", new[] { "idPessoaFisica" });
            DropIndex("dbo.Funcionario", new[] { "idPessoaFisica" });
            DropIndex("dbo.UsoEstacionamento", new[] { "pessoaFisica_idPessoaFisica" });
            DropTable("dbo.SolicitacaoSaida");
            DropTable("dbo.SolicitacaoEntrada");
            DropTable("dbo.Porteiro");
            DropTable("dbo.AssistenteCoordenadoria");
            DropTable("dbo.AssistenteAluno");
            DropTable("dbo.AssistenteAdministracao");
            DropTable("dbo.Aluno");
            DropTable("dbo.AdministradorSitema");
            DropTable("dbo.Funcionario");
            DropTable("dbo.UsoEstacionamento");
            DropTable("dbo.Solicitacao");
            DropTable("dbo.Terceirizado");
            DropTable("dbo.Prontuario");
            DropTable("dbo.PessoaFisica");
        }
    }
}
