namespace Sistema.Ifsp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adiconandopessoaFisicaindia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dia", "pessoaFisica_idPessoaFisica", c => c.Int());
            CreateIndex("dbo.Dia", "pessoaFisica_idPessoaFisica");
            AddForeignKey("dbo.Dia", "pessoaFisica_idPessoaFisica", "dbo.PessoaFisica", "idPessoaFisica");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dia", "pessoaFisica_idPessoaFisica", "dbo.PessoaFisica");
            DropIndex("dbo.Dia", new[] { "pessoaFisica_idPessoaFisica" });
            DropColumn("dbo.Dia", "pessoaFisica_idPessoaFisica");
        }
    }
}
