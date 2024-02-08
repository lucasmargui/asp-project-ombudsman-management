namespace Gestao_Ouvidoria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Manifestacoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Campus = c.String(nullable: false),
                        Curso = c.String(nullable: false),
                        TipoSolicitacao = c.Int(nullable: false),
                        Setor = c.Int(nullable: false),
                        Assunto = c.String(nullable: false),
                        ManifestacaoConteudo = c.String(nullable: false),
                        IdPerfil = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Perfil", t => t.IdPerfil, cascadeDelete: true)
                .Index(t => t.IdPerfil);
            
            CreateTable(
                "dbo.Perfil",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Telefone = c.String(nullable: false),
                        Celular = c.String(nullable: false),
                        TipoPerfil = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Manifestacoes", "IdPerfil", "dbo.Perfil");
            DropIndex("dbo.Manifestacoes", new[] { "IdPerfil" });
            DropTable("dbo.Perfil");
            DropTable("dbo.Manifestacoes");
        }
    }
}
