namespace Sistema.Ifsp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criandodatabase : DbMigration
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
                "dbo.Autenticacao",
                c => new
                    {
                        idAutenticacao = c.Int(nullable: false, identity: true),
                        usuario = c.String(nullable: false, unicode: false),
                        senha = c.String(nullable: false, unicode: false),
                        nivelAcesso = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.idAutenticacao);
            
            CreateTable(
                "dbo.Prontuario",
                c => new
                    {
                        idProntuario = c.Int(nullable: false, identity: true),
                        prontuario = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.idProntuario);
            
            CreateTable(
                "dbo.PermanenciaVeiculo",
                c => new
                    {
                        idPermanenciaVeiculo = c.Int(nullable: false, identity: true),
                        nome = c.String(unicode: false),
                        rg = c.String(unicode: false),
                        prontuario = c.String(unicode: false),
                        telefone = c.String(unicode: false),
                        tipoSolicitante = c.String(unicode: false),
                        setor = c.String(unicode: false),
                        isDocente = c.String(unicode: false),
                        curso = c.String(unicode: false),
                        modulo = c.String(unicode: false),
                        turno = c.String(unicode: false),
                        anoLetivo = c.String(unicode: false),
                        marca = c.String(unicode: false),
                        modelo = c.String(unicode: false),
                        placa = c.String(unicode: false),
                        cor = c.String(unicode: false),
                        ano = c.Int(nullable: false),
                        servidorPublico1 = c.String(unicode: false),
                        servidorPublico2 = c.String(unicode: false),
                        servidorPublico3 = c.String(unicode: false),
                        servidorPublico4 = c.String(unicode: false),
                        prontuario1 = c.String(unicode: false),
                        prontuario2 = c.String(unicode: false),
                        prontuario3 = c.String(unicode: false),
                        prontuario4 = c.String(unicode: false),
                        dataEntrada = c.DateTime(nullable: false, precision: 0),
                        dataSaida = c.DateTime(precision: 0),
                        assistenteAdministracao_idPessoaFisica = c.Int(),
                    })
                .PrimaryKey(t => t.idPermanenciaVeiculo)
                .ForeignKey("dbo.AssistenteAdministracao", t => t.assistenteAdministracao_idPessoaFisica)
                .Index(t => t.assistenteAdministracao_idPessoaFisica);
            
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
                "dbo.Vaga",
                c => new
                    {
                        idVaga = c.Int(nullable: false, identity: true),
                        codigoPlaca = c.String(nullable: false, unicode: false),
                        isDocente = c.Boolean(nullable: false),
                        domingo_idDia = c.Int(),
                        pessoaFisica_idPessoaFisica = c.Int(),
                        quarta_feira_idDia = c.Int(),
                        quinta_feira_idDia = c.Int(),
                        sabado_idDia = c.Int(),
                        segunda_feira_idDia = c.Int(),
                        sexta_feira_idDia = c.Int(),
                        terca_feira_idDia = c.Int(),
                    })
                .PrimaryKey(t => t.idVaga)
                .ForeignKey("dbo.Dia", t => t.domingo_idDia)
                .ForeignKey("dbo.PessoaFisica", t => t.pessoaFisica_idPessoaFisica)
                .ForeignKey("dbo.Dia", t => t.quarta_feira_idDia)
                .ForeignKey("dbo.Dia", t => t.quinta_feira_idDia)
                .ForeignKey("dbo.Dia", t => t.sabado_idDia)
                .ForeignKey("dbo.Dia", t => t.segunda_feira_idDia)
                .ForeignKey("dbo.Dia", t => t.sexta_feira_idDia)
                .ForeignKey("dbo.Dia", t => t.terca_feira_idDia)
                .Index(t => t.domingo_idDia)
                .Index(t => t.pessoaFisica_idPessoaFisica)
                .Index(t => t.quarta_feira_idDia)
                .Index(t => t.quinta_feira_idDia)
                .Index(t => t.sabado_idDia)
                .Index(t => t.segunda_feira_idDia)
                .Index(t => t.sexta_feira_idDia)
                .Index(t => t.terca_feira_idDia);
            
            CreateTable(
                "dbo.Dia",
                c => new
                    {
                        idDia = c.Int(nullable: false, identity: true),
                        periodo = c.String(unicode: false),
                        pessoaFisica_idPessoaFisica = c.Int(),
                    })
                .PrimaryKey(t => t.idDia)
                .ForeignKey("dbo.PessoaFisica", t => t.pessoaFisica_idPessoaFisica)
                .Index(t => t.pessoaFisica_idPessoaFisica);
            
            CreateTable(
                "dbo.Visitante",
                c => new
                    {
                        idVisitante = c.Int(nullable: false, identity: true),
                        nome = c.String(unicode: false),
                        rg = c.String(unicode: false),
                        entrada = c.DateTime(nullable: false, precision: 0),
                        saida = c.DateTime(precision: 0),
                        empresa = c.String(unicode: false),
                        motivo = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idVisitante);
            
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        idPessoaFisica = c.Int(nullable: false),
                        autenticacao_idAutenticacao = c.Int(),
                        prontuario_idProntuario = c.Int(),
                        area = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idPessoaFisica)
                .ForeignKey("dbo.PessoaFisica", t => t.idPessoaFisica)
                .ForeignKey("dbo.Autenticacao", t => t.autenticacao_idAutenticacao)
                .ForeignKey("dbo.Prontuario", t => t.prontuario_idProntuario)
                .Index(t => t.idPessoaFisica)
                .Index(t => t.autenticacao_idAutenticacao)
                .Index(t => t.prontuario_idProntuario);
            
            CreateTable(
                "dbo.AdministradorSistema",
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
                        autenticacao_idAutenticacao = c.Int(),
                        area = c.String(unicode: false),
                        empresa = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idPessoaFisica)
                .ForeignKey("dbo.PessoaFisica", t => t.idPessoaFisica)
                .ForeignKey("dbo.Autenticacao", t => t.autenticacao_idAutenticacao)
                .Index(t => t.idPessoaFisica)
                .Index(t => t.autenticacao_idAutenticacao);
            
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
                        saidaSupervisionada = c.Boolean(nullable: false),
                        status = c.Int(nullable: false),
                        encerramento = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.idSolicitacao)
                .ForeignKey("dbo.Solicitacao", t => t.idSolicitacao)
                .ForeignKey("dbo.Porteiro", t => t.porteiro_idPessoaFisica)
                .Index(t => t.idSolicitacao)
                .Index(t => t.porteiro_idPessoaFisica);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SolicitacaoSaida", "porteiro_idPessoaFisica", "dbo.Porteiro");
            DropForeignKey("dbo.SolicitacaoSaida", "idSolicitacao", "dbo.Solicitacao");
            DropForeignKey("dbo.SolicitacaoEntrada", "idSolicitacao", "dbo.Solicitacao");
            DropForeignKey("dbo.Porteiro", "idPessoaFisica", "dbo.Terceirizado");
            DropForeignKey("dbo.Terceirizado", "autenticacao_idAutenticacao", "dbo.Autenticacao");
            DropForeignKey("dbo.Terceirizado", "idPessoaFisica", "dbo.PessoaFisica");
            DropForeignKey("dbo.AssistenteCoordenadoria", "idPessoaFisica", "dbo.Funcionario");
            DropForeignKey("dbo.AssistenteAluno", "idPessoaFisica", "dbo.Funcionario");
            DropForeignKey("dbo.AssistenteAdministracao", "idPessoaFisica", "dbo.Funcionario");
            DropForeignKey("dbo.Aluno", "prontuario_idProntuario", "dbo.Prontuario");
            DropForeignKey("dbo.Aluno", "idPessoaFisica", "dbo.PessoaFisica");
            DropForeignKey("dbo.AdministradorSistema", "idPessoaFisica", "dbo.Funcionario");
            DropForeignKey("dbo.Funcionario", "prontuario_idProntuario", "dbo.Prontuario");
            DropForeignKey("dbo.Funcionario", "autenticacao_idAutenticacao", "dbo.Autenticacao");
            DropForeignKey("dbo.Funcionario", "idPessoaFisica", "dbo.PessoaFisica");
            DropForeignKey("dbo.Vaga", "terca_feira_idDia", "dbo.Dia");
            DropForeignKey("dbo.Vaga", "sexta_feira_idDia", "dbo.Dia");
            DropForeignKey("dbo.Vaga", "segunda_feira_idDia", "dbo.Dia");
            DropForeignKey("dbo.Vaga", "sabado_idDia", "dbo.Dia");
            DropForeignKey("dbo.Vaga", "quinta_feira_idDia", "dbo.Dia");
            DropForeignKey("dbo.Vaga", "quarta_feira_idDia", "dbo.Dia");
            DropForeignKey("dbo.Vaga", "pessoaFisica_idPessoaFisica", "dbo.PessoaFisica");
            DropForeignKey("dbo.Vaga", "domingo_idDia", "dbo.Dia");
            DropForeignKey("dbo.Dia", "pessoaFisica_idPessoaFisica", "dbo.PessoaFisica");
            DropForeignKey("dbo.Solicitacao", "assistenteAluno_idPessoaFisica", "dbo.AssistenteAluno");
            DropForeignKey("dbo.Solicitacao", "aluno_idPessoaFisica", "dbo.Aluno");
            DropForeignKey("dbo.PermanenciaVeiculo", "assistenteAdministracao_idPessoaFisica", "dbo.AssistenteAdministracao");
            DropIndex("dbo.SolicitacaoSaida", new[] { "porteiro_idPessoaFisica" });
            DropIndex("dbo.SolicitacaoSaida", new[] { "idSolicitacao" });
            DropIndex("dbo.SolicitacaoEntrada", new[] { "idSolicitacao" });
            DropIndex("dbo.Porteiro", new[] { "idPessoaFisica" });
            DropIndex("dbo.Terceirizado", new[] { "autenticacao_idAutenticacao" });
            DropIndex("dbo.Terceirizado", new[] { "idPessoaFisica" });
            DropIndex("dbo.AssistenteCoordenadoria", new[] { "idPessoaFisica" });
            DropIndex("dbo.AssistenteAluno", new[] { "idPessoaFisica" });
            DropIndex("dbo.AssistenteAdministracao", new[] { "idPessoaFisica" });
            DropIndex("dbo.Aluno", new[] { "prontuario_idProntuario" });
            DropIndex("dbo.Aluno", new[] { "idPessoaFisica" });
            DropIndex("dbo.AdministradorSistema", new[] { "idPessoaFisica" });
            DropIndex("dbo.Funcionario", new[] { "prontuario_idProntuario" });
            DropIndex("dbo.Funcionario", new[] { "autenticacao_idAutenticacao" });
            DropIndex("dbo.Funcionario", new[] { "idPessoaFisica" });
            DropIndex("dbo.Vaga", new[] { "terca_feira_idDia" });
            DropIndex("dbo.Vaga", new[] { "sexta_feira_idDia" });
            DropIndex("dbo.Vaga", new[] { "segunda_feira_idDia" });
            DropIndex("dbo.Vaga", new[] { "sabado_idDia" });
            DropIndex("dbo.Vaga", new[] { "quinta_feira_idDia" });
            DropIndex("dbo.Vaga", new[] { "quarta_feira_idDia" });
            DropIndex("dbo.Vaga", new[] { "pessoaFisica_idPessoaFisica" });
            DropIndex("dbo.Vaga", new[] { "domingo_idDia" });
            DropIndex("dbo.Dia", new[] { "pessoaFisica_idPessoaFisica" });
            DropIndex("dbo.Solicitacao", new[] { "assistenteAluno_idPessoaFisica" });
            DropIndex("dbo.Solicitacao", new[] { "aluno_idPessoaFisica" });
            DropIndex("dbo.PermanenciaVeiculo", new[] { "assistenteAdministracao_idPessoaFisica" });
            DropTable("dbo.SolicitacaoSaida");
            DropTable("dbo.SolicitacaoEntrada");
            DropTable("dbo.Porteiro");
            DropTable("dbo.Terceirizado");
            DropTable("dbo.AssistenteCoordenadoria");
            DropTable("dbo.AssistenteAluno");
            DropTable("dbo.AssistenteAdministracao");
            DropTable("dbo.Aluno");
            DropTable("dbo.AdministradorSistema");
            DropTable("dbo.Funcionario");
            DropTable("dbo.Visitante");
            DropTable("dbo.Dia");
            DropTable("dbo.Vaga");
            DropTable("dbo.Solicitacao");
            DropTable("dbo.Fornecedor");
            DropTable("dbo.PermanenciaVeiculo");
            DropTable("dbo.Prontuario");
            DropTable("dbo.Autenticacao");
            DropTable("dbo.PessoaFisica");
        }
    }
}
