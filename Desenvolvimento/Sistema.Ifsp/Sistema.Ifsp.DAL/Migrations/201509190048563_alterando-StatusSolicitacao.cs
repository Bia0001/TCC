namespace Sistema.Ifsp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterandoStatusSolicitacao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Solicitacao", "abertura", c => c.DateTime(nullable: false, precision: 0));
            DropColumn("dbo.Solicitacao", "aberura");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Solicitacao", "aberura", c => c.DateTime(nullable: false, precision: 0));
            DropColumn("dbo.Solicitacao", "abertura");
        }
    }
}
