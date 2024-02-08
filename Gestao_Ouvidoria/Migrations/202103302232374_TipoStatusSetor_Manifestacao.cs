namespace Gestao_Ouvidoria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoStatusSetor_Manifestacao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Manifestacoes", "StatusSetor", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Manifestacoes", "StatusSetor");
        }
    }
}
