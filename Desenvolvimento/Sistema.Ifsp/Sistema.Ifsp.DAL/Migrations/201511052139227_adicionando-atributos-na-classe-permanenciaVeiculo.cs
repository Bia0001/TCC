namespace Sistema.Ifsp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionandoatributosnaclassepermanenciaVeiculo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PermanenciaVeiculo", "setor", c => c.String(unicode: false));
            AddColumn("dbo.PermanenciaVeiculo", "isDocente", c => c.String(unicode: false));
            AddColumn("dbo.PermanenciaVeiculo", "ano", c => c.Int(nullable: false));
            AlterColumn("dbo.PermanenciaVeiculo", "dataEntrada", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.PermanenciaVeiculo", "dataSaida", c => c.DateTime(nullable: false, precision: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PermanenciaVeiculo", "dataSaida", c => c.String(unicode: false));
            AlterColumn("dbo.PermanenciaVeiculo", "dataEntrada", c => c.String(unicode: false));
            DropColumn("dbo.PermanenciaVeiculo", "ano");
            DropColumn("dbo.PermanenciaVeiculo", "isDocente");
            DropColumn("dbo.PermanenciaVeiculo", "setor");
        }
    }
}
