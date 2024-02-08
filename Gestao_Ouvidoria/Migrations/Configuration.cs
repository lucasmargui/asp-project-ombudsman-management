namespace Gestao_Ouvidoria.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Gestao_Ouvidoria.Models.OuvidoriaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Gestao_Ouvidoria.Models.OuvidoriaContext";
        }

        protected override void Seed(Gestao_Ouvidoria.Models.OuvidoriaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
