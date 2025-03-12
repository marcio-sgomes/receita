using Microsoft.EntityFrameworkCore;
using ReceitaFederal.Domain.Entities;

namespace ReceitaFederal.Infrastructure.Persistence.Contexts
{
    public class ReceitaFederalContext : DbContext
    {
        public ReceitaFederalContext(DbContextOptions<ReceitaFederalContext> options) : base(options) { }

        public DbSet<Empresa> Empresas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ReceitaFederalContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
