namespace Sistema.Acesso.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PessoasFisica",
                c => new
                    {
                        idPessoaFisica = c.Int(nullable: false, identity: true),
                        nome = c.String(unicode: false),
                        cpf = c.String(unicode: false),
                        rg = c.String(unicode: false),
                        email = c.String(unicode: false),
                        celular = c.String(unicode: false),
                        telefone = c.String(unicode: false),
                        nascimento = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.idPessoaFisica);
            
            CreateTable(
                "dbo.Prontuarios",
                c => new
                    {
                        idProntuario = c.Int(nullable: false, identity: true),
                        prontuario = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idProntuario);
            
            CreateTable(
                "dbo.Enderecos",
                c => new
                    {
                        idEndereco = c.Int(nullable: false, identity: true),
                        logradouro = c.String(unicode: false),
                        numero = c.String(unicode: false),
                        bairro = c.String(unicode: false),
                        cep = c.String(unicode: false),
                        cidade = c.String(unicode: false),
                        uf = c.String(unicode: false),
                        complemento = c.String(unicode: false),
                        pessoaFisica_idPessoaFisica = c.Int(),
                    })
                .PrimaryKey(t => t.idEndereco)
                .ForeignKey("dbo.PessoasFisica", t => t.pessoaFisica_idPessoaFisica)
                .Index(t => t.pessoaFisica_idPessoaFisica);
            
            CreateTable(
                "dbo.SolicitacoesSaida",
                c => new
                    {
                        idSolicitacaoSaida = c.Int(nullable: false, identity: true),
                        abertura = c.DateTime(nullable: false, precision: 0),
                        previsaoEncerramento = c.DateTime(nullable: false, precision: 0),
                        encerramento = c.DateTime(nullable: false, precision: 0),
                        motivo = c.String(unicode: false),
                        status = c.String(unicode: false),
                        aluno_idPessoaFisica = c.Int(),
                        assistenteAluno_idPessoaFisica = c.Int(),
                        vigilante_idPessoaFisica = c.Int(),
                    })
                .PrimaryKey(t => t.idSolicitacaoSaida)
                .ForeignKey("dbo.Alunos", t => t.aluno_idPessoaFisica)
                .ForeignKey("dbo.AssistentesAluno", t => t.assistenteAluno_idPessoaFisica)
                .ForeignKey("dbo.Vigilantes", t => t.vigilante_idPessoaFisica)
                .Index(t => t.aluno_idPessoaFisica)
                .Index(t => t.assistenteAluno_idPessoaFisica)
                .Index(t => t.vigilante_idPessoaFisica);
            
            CreateTable(
                "dbo.Alunos",
                c => new
                    {
                        idPessoaFisica = c.Int(nullable: false),
                        prontuario_idProntuario = c.Int(),
                        idAluno = c.Int(nullable: false),
                        contato1 = c.String(unicode: false),
                        contato2 = c.String(unicode: false),
                        responsavel1 = c.String(unicode: false),
                        responsavel2 = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.idPessoaFisica)
                .ForeignKey("dbo.PessoasFisica", t => t.idPessoaFisica)
                .ForeignKey("dbo.Prontuarios", t => t.prontuario_idProntuario)
                .Index(t => t.idPessoaFisica)
                .Index(t => t.prontuario_idProntuario);
            
            CreateTable(
                "dbo.AssistentesAluno",
                c => new
                    {
                        idPessoaFisica = c.Int(nullable: false),
                        prontuario_idProntuario = c.Int(),
                        idAssistenteAluno = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idPessoaFisica)
                .ForeignKey("dbo.PessoasFisica", t => t.idPessoaFisica)
                .ForeignKey("dbo.Prontuarios", t => t.prontuario_idProntuario)
                .Index(t => t.idPessoaFisica)
                .Index(t => t.prontuario_idProntuario);
            
            CreateTable(
                "dbo.Vigilantes",
                c => new
                    {
                        idPessoaFisica = c.Int(nullable: false),
                        idVigilante = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idPessoaFisica)
                .ForeignKey("dbo.PessoasFisica", t => t.idPessoaFisica)
                .Index(t => t.idPessoaFisica);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vigilantes", "idPessoaFisica", "dbo.PessoasFisica");
            DropForeignKey("dbo.AssistentesAluno", "prontuario_idProntuario", "dbo.Prontuarios");
            DropForeignKey("dbo.AssistentesAluno", "idPessoaFisica", "dbo.PessoasFisica");
            DropForeignKey("dbo.Alunos", "prontuario_idProntuario", "dbo.Prontuarios");
            DropForeignKey("dbo.Alunos", "idPessoaFisica", "dbo.PessoasFisica");
            DropForeignKey("dbo.SolicitacoesSaida", "vigilante_idPessoaFisica", "dbo.Vigilantes");
            DropForeignKey("dbo.SolicitacoesSaida", "assistenteAluno_idPessoaFisica", "dbo.AssistentesAluno");
            DropForeignKey("dbo.SolicitacoesSaida", "aluno_idPessoaFisica", "dbo.Alunos");
            DropForeignKey("dbo.Enderecos", "pessoaFisica_idPessoaFisica", "dbo.PessoasFisica");
            DropIndex("dbo.Vigilantes", new[] { "idPessoaFisica" });
            DropIndex("dbo.AssistentesAluno", new[] { "prontuario_idProntuario" });
            DropIndex("dbo.AssistentesAluno", new[] { "idPessoaFisica" });
            DropIndex("dbo.Alunos", new[] { "prontuario_idProntuario" });
            DropIndex("dbo.Alunos", new[] { "idPessoaFisica" });
            DropIndex("dbo.SolicitacoesSaida", new[] { "vigilante_idPessoaFisica" });
            DropIndex("dbo.SolicitacoesSaida", new[] { "assistenteAluno_idPessoaFisica" });
            DropIndex("dbo.SolicitacoesSaida", new[] { "aluno_idPessoaFisica" });
            DropIndex("dbo.Enderecos", new[] { "pessoaFisica_idPessoaFisica" });
            DropTable("dbo.Vigilantes");
            DropTable("dbo.AssistentesAluno");
            DropTable("dbo.Alunos");
            DropTable("dbo.SolicitacoesSaida");
            DropTable("dbo.Enderecos");
            DropTable("dbo.Prontuarios");
            DropTable("dbo.PessoasFisica");
        }
    }
}
