using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Gestao_Ouvidoria.Models
{
    public class OuvidoriaContext : DbContext
    {
       
        public OuvidoriaContext() : base("Name=DefaultConnection")
        {
            Database.SetInitializer<OuvidoriaContext>(
                new CreateDatabaseIfNotExists<OuvidoriaContext>());
            Database.Initialize(false);

            Database.Log = d => System.Diagnostics.Debug.WriteLine(d);
        }

        public DbSet<Manifestacao> Manifestacao { get; set; }

        public System.Data.Entity.DbSet<Gestao_Ouvidoria.Models.Perfil> Perfil { get; set; }

        public System.Data.Entity.DbSet<Gestao_Ouvidoria.Models.RespostaManifestacao> RespostaManifestacao { get; set; }
    }
}