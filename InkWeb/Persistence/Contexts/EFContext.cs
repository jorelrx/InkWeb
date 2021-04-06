using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Pessoa;
using Models;
using Persistence.Migrations;

namespace Persistence.Contexts
{
    class EFContext : DbContext
    {
        public EFContext() : base("Ink_Web")
        {
            Database.SetInitializer<EFContext>(new MigrateDatabaseToLatestVersion<EFContext, Configuration>());
        }
        public DbSet<MAdministrador> Administradores { get; set; }
        public DbSet<MCliente> Clientes { get; set; }
        public DbSet<MUsuario> Usuarios { get; set; }
        public DbSet<MServico> Servicos { get; set; }
        public DbSet<MAgenda> Agendas { get; set; }
        public DbSet<MHorario> Horarios { get; set; }
    }
}
