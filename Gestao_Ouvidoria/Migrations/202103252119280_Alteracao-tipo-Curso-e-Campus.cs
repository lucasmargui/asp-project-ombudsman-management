namespace Gestao_Ouvidoria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaotipoCursoeCampus : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Manifestacoes", "Campus", c => c.Int(nullable: false));
            AlterColumn("dbo.Manifestacoes", "Curso", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Manifestacoes", "Curso", c => c.String(nullable: false));
            AlterColumn("dbo.Manifestacoes", "Campus", c => c.String(nullable: false));
        }
    }
}
