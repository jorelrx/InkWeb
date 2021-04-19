using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Gerenciamento;
using Models.Tattoo;
using Persistence.Migrations;

namespace Persistence.Contexts
{
    class EFContext : DbContext
    {
        public EFContext() : base("InkWeb")
        {
            Database.SetInitializer<EFContext>(new MigrateDatabaseToLatestVersion<EFContext, Configuration>());
        }
        public DbSet<MUsuario> Usuarios { get; set; }
        public DbSet<MRole> Roles { get; set; }
        public DbSet<MServico> Servicos { get; set; }
    }
}
