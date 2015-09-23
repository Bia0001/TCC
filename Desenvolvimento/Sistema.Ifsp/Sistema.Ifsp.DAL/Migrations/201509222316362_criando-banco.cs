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
                        nome = c.String(nullable: false, unicode: false),
                        celular = c.String(unicode: false),
                        telefone = c.String(unicode: false),
                        nascimento = c.DateTime(nullable: false, precision: 0),
                        rg = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.idPessoaFisica);
            
            CreateTable(
                "dbo.Prontuario",
                c => new
                    {
                        idProntuario = c.Int(nullable: false, identity: true),
                        prontuario = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.idProntuario);
            
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        idFornecedor = c.Int(nullable: false, identity: true),
                        nome = c.String(unicode: false),
                        rg = c.String(unicode: false),
                        entrada = c.DateTime(nullable: false, precision: 0),
                        saida = c.DateTime(nullable: false, precision: 0),
                        empresa = c.String(unicode: false),
                        motivo = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idFornecedor);
            
            CreateTable(
                "dbo.Solicitacao",
                c => new
                    {
                        idSolicitacao = c.Int(nullable: false, identity: true),
                        abertura = c.DateTime(nullable: false, precision: 0),
                        motivo = c.String(nullable: false, unicode: false),
                        aluno_idPessoaFisica = c.Int(nullable: false),
                        assistenteAluno_idPessoaFisica = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idSolicitacao)
                .ForeignKey("dbo.Aluno", t => t.aluno_idPessoaFisica)
                .ForeignKey("dbo.AssistenteAluno", t => t.assistenteAluno_idPessoaFisica)
                .Index(t => t.aluno_idPessoaFisica)
                .Index(t => t.assistenteAluno_idPessoaFisica);
            
            CreateTable(
                "dbo.UsoEstacionamentoVeiculo",
                c => new
                    {
                        idUsoEstacionamento = c.Int(nullable: false, identity: true),
                        diaDaSemana = c.String(nullable: false, unicode: false),
                        turno = c.String(nullable: false, unicode: false),
                        tipoVaga = c.Int(nullable: false),
                        codAcessoEstacionamento = c.String(unicode: false),
                        pessoaFisica_idPessoaFisica = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idUsoEstacionamento)
                .ForeignKey("dbo.PessoaFisica", t => t.pessoaFisica_idPessoaFisica, cascadeDelete: true)
                .Index(t => t.pessoaFisica_idPessoaFisica);
            
            CreateTable(
                "dbo.Visitante",
                c => new
                    {
                        idVisitante = c.Int(nullable: false, identity: true),
                        nome = c.String(unicode: false),
                        rg = c.String(unicode: false),
                        entrada = c.DateTime(nullable: false, precision: 0),
                        saida = c.DateTime(nullable: false, precision: 0),
                        empresa = c.String(unicode: false),
                        motivo = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idVisitante);
            
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        idPessoaFisica = c.Int(nullable: false),
                        prontuario_idProntuario = c.Int(),
                        area = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idPessoaFisica)
                .ForeignKey("dbo.PessoaFisica", t => t.idPessoaFisica)
                .ForeignKey("dbo.Prontuario", t => t.prontuario_idProntuario)
                .Index(t => t.idPessoaFisica)
                .Index(t => t.prontuario_idProntuario);
            
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
                        prontuario_idProntuario = c.Int(nullable: false),
                        responsavel1 = c.String(nullable: false, unicode: false),
                        responsavel2 = c.String(unicode: false),
                        contato1 = c.String(nullable: false, unicode: false),
                        contato2 = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idPessoaFisica)
                .ForeignKey("dbo.PessoaFisica", t => t.idPessoaFisica)
                .ForeignKey("dbo.Prontuario", t => t.prontuario_idProntuario, cascadeDelete: true)
                .Index(t => t.idPessoaFisica)
                .Index(t => t.prontuario_idProntuario);
            
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
                    })
                .PrimaryKey(t => t.idPessoaFisica)
                .ForeignKey("dbo.Funcionario", t => t.idPessoaFisica)
                .Index(t => t.idPessoaFisica);
            
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
                "dbo.Terceirizado",
                c => new
                    {
                        idPessoaFisica = c.Int(nullable: false),
                        area = c.String(unicode: false),
                        empresa = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idPessoaFisica)
                .ForeignKey("dbo.PessoaFisica", t => t.idPessoaFisica)
                .Index(t => t.idPessoaFisica);
            
            CreateTable(
                "dbo.Porteiro",
                c => new
                    {
                        idPessoaFisica = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idPessoaFisica)
                .ForeignKey("dbo.Terceirizado", t => t.idPessoaFisica)
                .Index(t => t.idPessoaFisica);
            
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
                        porteiro_idPessoaFisica = c.Int(),
                        status = c.Int(nullable: false),
                        encerramento = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.idSolicitacao)
                .ForeignKey("dbo.Solicitacao", t => t.idSolicitacao)
                .ForeignKey("dbo.Porteiro", t => t.porteiro_idPessoaFisica)
                .Index(t => t.idSolicitacao)
                .Index(t => t.porteiro_idPessoaFisica);
            
            CreateTable(
                "dbo.UsoEstacionamentoCarro",
                c => new
                    {
                        idUsoEstacionamento = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idUsoEstacionamento)
                .ForeignKey("dbo.UsoEstacionamentoVeiculo", t => t.idUsoEstacionamento)
                .Index(t => t.idUsoEstacionamento);
            
            CreateTable(
                "dbo.UsoEstacionamentoMoto",
                c => new
                    {
                        idUsoEstacionamento = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idUsoEstacionamento)
                .ForeignKey("dbo.UsoEstacionamentoVeiculo", t => t.idUsoEstacionamento)
                .Index(t => t.idUsoEstacionamento);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsoEstacionamentoMoto", "idUsoEstacionamento", "dbo.UsoEstacionamentoVeiculo");
            DropForeignKey("dbo.UsoEstacionamentoCarro", "idUsoEstacionamento", "dbo.UsoEstacionamentoVeiculo");
            DropForeignKey("dbo.SolicitacaoSaida", "porteiro_idPessoaFisica", "dbo.Porteiro");
            DropForeignKey("dbo.SolicitacaoSaida", "idSolicitacao", "dbo.Solicitacao");
            DropForeignKey("dbo.SolicitacaoEntrada", "idSolicitacao", "dbo.Solicitacao");
            DropForeignKey("dbo.Porteiro", "idPessoaFisica", "dbo.Terceirizado");
            DropForeignKey("dbo.Terceirizado", "idPessoaFisica", "dbo.PessoaFisica");
            DropForeignKey("dbo.AssistenteCoordenadoria", "idPessoaFisica", "dbo.Funcionario");
            DropForeignKey("dbo.AssistenteAluno", "idPessoaFisica", "dbo.Funcionario");
            DropForeignKey("dbo.AssistenteAdministracao", "idPessoaFisica", "dbo.Funcionario");
            DropForeignKey("dbo.Aluno", "prontuario_idProntuario", "dbo.Prontuario");
            DropForeignKey("dbo.Aluno", "idPessoaFisica", "dbo.PessoaFisica");
            DropForeignKey("dbo.AdministradorSitema", "idPessoaFisica", "dbo.Funcionario");
            DropForeignKey("dbo.Funcionario", "prontuario_idProntuario", "dbo.Prontuario");
            DropForeignKey("dbo.Funcionario", "idPessoaFisica", "dbo.PessoaFisica");
            DropForeignKey("dbo.UsoEstacionamentoVeiculo", "pessoaFisica_idPessoaFisica", "dbo.PessoaFisica");
            DropForeignKey("dbo.Solicitacao", "assistenteAluno_idPessoaFisica", "dbo.AssistenteAluno");
            DropForeignKey("dbo.Solicitacao", "aluno_idPessoaFisica", "dbo.Aluno");
            DropIndex("dbo.UsoEstacionamentoMoto", new[] { "idUsoEstacionamento" });
            DropIndex("dbo.UsoEstacionamentoCarro", new[] { "idUsoEstacionamento" });
            DropIndex("dbo.SolicitacaoSaida", new[] { "porteiro_idPessoaFisica" });
            DropIndex("dbo.SolicitacaoSaida", new[] { "idSolicitacao" });
            DropIndex("dbo.SolicitacaoEntrada", new[] { "idSolicitacao" });
            DropIndex("dbo.Porteiro", new[] { "idPessoaFisica" });
            DropIndex("dbo.Terceirizado", new[] { "idPessoaFisica" });
            DropIndex("dbo.AssistenteCoordenadoria", new[] { "idPessoaFisica" });
            DropIndex("dbo.AssistenteAluno", new[] { "idPessoaFisica" });
            DropIndex("dbo.AssistenteAdministracao", new[] { "idPessoaFisica" });
            DropIndex("dbo.Aluno", new[] { "prontuario_idProntuario" });
            DropIndex("dbo.Aluno", new[] { "idPessoaFisica" });
            DropIndex("dbo.AdministradorSitema", new[] { "idPessoaFisica" });
            DropIndex("dbo.Funcionario", new[] { "prontuario_idProntuario" });
            DropIndex("dbo.Funcionario", new[] { "idPessoaFisica" });
            DropIndex("dbo.UsoEstacionamentoVeiculo", new[] { "pessoaFisica_idPessoaFisica" });
            DropIndex("dbo.Solicitacao", new[] { "assistenteAluno_idPessoaFisica" });
            DropIndex("dbo.Solicitacao", new[] { "aluno_idPessoaFisica" });
            DropTable("dbo.UsoEstacionamentoMoto");
            DropTable("dbo.UsoEstacionamentoCarro");
            DropTable("dbo.SolicitacaoSaida");
            DropTable("dbo.SolicitacaoEntrada");
            DropTable("dbo.Porteiro");
            DropTable("dbo.Terceirizado");
            DropTable("dbo.AssistenteCoordenadoria");
            DropTable("dbo.AssistenteAluno");
            DropTable("dbo.AssistenteAdministracao");
            DropTable("dbo.Aluno");
            DropTable("dbo.AdministradorSitema");
            DropTable("dbo.Funcionario");
            DropTable("dbo.Visitante");
            DropTable("dbo.UsoEstacionamentoVeiculo");
            DropTable("dbo.Solicitacao");
            DropTable("dbo.Fornecedor");
            DropTable("dbo.Prontuario");
            DropTable("dbo.PessoaFisica");
        }
    }
}
