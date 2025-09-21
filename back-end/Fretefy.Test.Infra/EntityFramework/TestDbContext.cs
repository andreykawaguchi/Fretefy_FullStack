using Fretefy.Test.Infra.EntityFramework.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Fretefy.Test.Infra.EntityFramework
{
    public class TestDbContext : DbContext
    {
        public TestDbContext()
        {

        }

        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CidadeMap());
            modelBuilder.ApplyConfiguration(new RegiaoMap());
            modelBuilder.ApplyConfiguration(new RegiaoCidadeMap());
        }

        // DbSets
        public DbSet<Domain.Entities.Cidade> Cidades { get; set; }
        public DbSet<Domain.Entities.Regiao> Regioes { get; set; }
        public DbSet<Domain.Entities.RegiaoCidade> RegiaoCidades { get; set; }
    }
}
