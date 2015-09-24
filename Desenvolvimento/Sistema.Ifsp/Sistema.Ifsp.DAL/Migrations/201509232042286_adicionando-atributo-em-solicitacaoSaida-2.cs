namespace Sistema.Ifsp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionandoatributoemsolicitacaoSaida2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Visitante", "saida", c => c.DateTime(precision: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Visitante", "saida", c => c.DateTime(nullable: false, precision: 0));
        }
    }
}
