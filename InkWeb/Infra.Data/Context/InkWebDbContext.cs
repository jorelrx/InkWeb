using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context
{
    public class InkWebDbContext : DbContext
    {
        public InkWebDbContext(DbContextOptions<InkWebDbContext> options) : base(options) {}

        public DbSet<Tattoo> Tattoos { get; set; }
        public DbSet<Scheduling> Schedulings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(InkWebDbContext).Assembly);
        }
    }
}
