namespace Sistema.Ifsp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class permitindosalvardataDeEntradaclassepermanenciaVeiculo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PermanenciaVeiculo", "dataSaida", c => c.DateTime(precision: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PermanenciaVeiculo", "dataSaida", c => c.DateTime(nullable: false, precision: 0));
        }
    }
}
