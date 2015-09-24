namespace Sistema.Ifsp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionandoatributoemsolicitacaoSaida : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SolicitacaoSaida", "saidaSupervisionada", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SolicitacaoSaida", "saidaSupervisionada");
        }
    }
}
