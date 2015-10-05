namespace Sistema.Ifsp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class excluindoatributonomedaclassevaga : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vaga", "codigoPlaca", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Dia", "periodo", c => c.String(unicode: false));
            DropColumn("dbo.Vaga", "tipoVaga");
            DropColumn("dbo.Dia", "nome");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dia", "nome", c => c.String(unicode: false));
            AddColumn("dbo.Vaga", "tipoVaga", c => c.Int(nullable: false));
            AlterColumn("dbo.Dia", "periodo", c => c.Int(nullable: false));
            AlterColumn("dbo.Vaga", "codigoPlaca", c => c.String(unicode: false));
        }
    }
}
