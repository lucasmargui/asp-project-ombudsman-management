namespace Gestao_Ouvidoria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Created_Modified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Manifestacoes", "Created", c => c.DateTime(nullable: false));
            AddColumn("dbo.Manifestacoes", "Modified", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Manifestacoes", "Modified");
            DropColumn("dbo.Manifestacoes", "Created");
        }
    }
}
