namespace Sistema.Acesso.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removendo_pk_de_classe_herdadas_de_pessoaFisica : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Alunos", "idAluno");
            DropColumn("dbo.AssistentesAluno", "idAssistenteAluno");
            DropColumn("dbo.Vigilantes", "idVigilante");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vigilantes", "idVigilante", c => c.Int(nullable: false));
            AddColumn("dbo.AssistentesAluno", "idAssistenteAluno", c => c.Int(nullable: false));
            AddColumn("dbo.Alunos", "idAluno", c => c.Int(nullable: false));
        }
    }
}
