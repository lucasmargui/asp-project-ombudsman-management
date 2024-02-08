namespace Gestao_Ouvidoria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Tipo_Status : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Manifestacoes", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Manifestacoes", "Status");
        }
    }
}
