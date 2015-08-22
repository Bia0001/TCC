namespace Sistema.Ifsp.Repositorio.Migrations
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
                        nome = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                        cpf = c.String(nullable: false, maxLength: 11, unicode: false, storeType: "nvarchar"),
                        rg = c.String(nullable: false, maxLength: 9, unicode: false, storeType: "nvarchar"),
                        email = c.String(maxLength: 100, unicode: false, storeType: "nvarchar"),
                        celular = c.String(maxLength: 11, unicode: false, storeType: "nvarchar"),
                        telefone = c.String(maxLength: 10, unicode: false, storeType: "nvarchar"),
                        nascimento = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.idPessoaFisica);
            
            CreateTable(
                "dbo.Prontuario",
                c => new
                    {
                        idProntuario = c.Int(nullable: false, identity: true),
                        prontuario = c.String(nullable: false, maxLength: 7, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idProntuario);
            
            CreateTable(
                "dbo.SolicitacaoSaida",
                c => new
                    {
                        idSolicitacaoSaida = c.Int(nullable: false, identity: true),
                        abertura = c.DateTime(nullable: false, precision: 0),
                        previsaoEncerramento = c.DateTime(nullable: false, precision: 0),
                        encerramento = c.DateTime(precision: 0),
                        motivo = c.String(nullable: false, maxLength: 300, unicode: false, storeType: "nvarchar"),
                        status = c.String(nullable: false, maxLength: 10, unicode: false, storeType: "nvarchar"),
                        Aluno_idPessoaFisica = c.Int(),
                        AssistenteAluno_idPessoaFisica = c.Int(),
                        Vigilante_idPessoaFisica = c.Int(),
                    })
                .PrimaryKey(t => t.idSolicitacaoSaida)
                .ForeignKey("dbo.Aluno", t => t.Aluno_idPessoaFisica)
                .ForeignKey("dbo.AssistenteAluno", t => t.AssistenteAluno_idPessoaFisica)
                .ForeignKey("dbo.Vigilante", t => t.Vigilante_idPessoaFisica)
                .Index(t => t.Aluno_idPessoaFisica)
                .Index(t => t.AssistenteAluno_idPessoaFisica)
                .Index(t => t.Vigilante_idPessoaFisica);
            
            CreateTable(
                "dbo.Aluno",
                c => new
                    {
                        idPessoaFisica = c.Int(nullable: false),
                        Prontuario_idProntuario = c.Int(),
                        contato1 = c.String(nullable: false, maxLength: 11, unicode: false, storeType: "nvarchar"),
                        contato2 = c.String(maxLength: 11, unicode: false, storeType: "nvarchar"),
                        responsavel1 = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                        responsavel2 = c.String(maxLength: 100, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idPessoaFisica)
                .ForeignKey("dbo.PessoaFisica", t => t.idPessoaFisica)
                .ForeignKey("dbo.Prontuario", t => t.Prontuario_idProntuario)
                .Index(t => t.idPessoaFisica)
                .Index(t => t.Prontuario_idProntuario);
            
            CreateTable(
                "dbo.AssistenteAluno",
                c => new
                    {
                        idPessoaFisica = c.Int(nullable: false),
                        Prontuario_idProntuario = c.Int(),
                    })
                .PrimaryKey(t => t.idPessoaFisica)
                .ForeignKey("dbo.PessoaFisica", t => t.idPessoaFisica)
                .ForeignKey("dbo.Prontuario", t => t.Prontuario_idProntuario)
                .Index(t => t.idPessoaFisica)
                .Index(t => t.Prontuario_idProntuario);
            
            CreateTable(
                "dbo.Vigilante",
                c => new
                    {
                        idPessoaFisica = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idPessoaFisica)
                .ForeignKey("dbo.PessoaFisica", t => t.idPessoaFisica)
                .Index(t => t.idPessoaFisica);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vigilante", "idPessoaFisica", "dbo.PessoaFisica");
            DropForeignKey("dbo.AssistenteAluno", "Prontuario_idProntuario", "dbo.Prontuario");
            DropForeignKey("dbo.AssistenteAluno", "idPessoaFisica", "dbo.PessoaFisica");
            DropForeignKey("dbo.Aluno", "Prontuario_idProntuario", "dbo.Prontuario");
            DropForeignKey("dbo.Aluno", "idPessoaFisica", "dbo.PessoaFisica");
            DropForeignKey("dbo.SolicitacaoSaida", "Vigilante_idPessoaFisica", "dbo.Vigilante");
            DropForeignKey("dbo.SolicitacaoSaida", "AssistenteAluno_idPessoaFisica", "dbo.AssistenteAluno");
            DropForeignKey("dbo.SolicitacaoSaida", "Aluno_idPessoaFisica", "dbo.Aluno");
            DropIndex("dbo.Vigilante", new[] { "idPessoaFisica" });
            DropIndex("dbo.AssistenteAluno", new[] { "Prontuario_idProntuario" });
            DropIndex("dbo.AssistenteAluno", new[] { "idPessoaFisica" });
            DropIndex("dbo.Aluno", new[] { "Prontuario_idProntuario" });
            DropIndex("dbo.Aluno", new[] { "idPessoaFisica" });
            DropIndex("dbo.SolicitacaoSaida", new[] { "Vigilante_idPessoaFisica" });
            DropIndex("dbo.SolicitacaoSaida", new[] { "AssistenteAluno_idPessoaFisica" });
            DropIndex("dbo.SolicitacaoSaida", new[] { "Aluno_idPessoaFisica" });
            DropTable("dbo.Vigilante");
            DropTable("dbo.AssistenteAluno");
            DropTable("dbo.Aluno");
            DropTable("dbo.SolicitacaoSaida");
            DropTable("dbo.Prontuario");
            DropTable("dbo.PessoaFisica");
        }
    }
}
