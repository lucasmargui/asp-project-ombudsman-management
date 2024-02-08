namespace Gestao_Ouvidoria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoTabelaRespostaManifestacao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RespostaManifestacoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ManifestacaoResposta = c.String(nullable: false),
                        Arquivo = c.String(),
                        IdManifestacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manifestacoes", t => t.IdManifestacao, cascadeDelete: true)
                .Index(t => t.IdManifestacao);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RespostaManifestacoes", "IdManifestacao", "dbo.Manifestacoes");
            DropIndex("dbo.RespostaManifestacoes", new[] { "IdManifestacao" });
            DropTable("dbo.RespostaManifestacoes");
        }
    }
}
