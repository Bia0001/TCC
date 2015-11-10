namespace Sistema.Ifsp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteracaodatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Autenticacao", "nivelAcesso", c => c.String(nullable: false, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Autenticacao", "nivelAcesso", c => c.Int(nullable: false));
        }
    }
}
