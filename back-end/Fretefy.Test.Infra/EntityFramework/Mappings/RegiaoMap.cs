using Fretefy.Test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fretefy.Test.Infra.EntityFramework.Mappings
{
    public class RegiaoMap : IEntityTypeConfiguration<Regiao>
    {
        public void Configure(EntityTypeBuilder<Regiao> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();
            
            builder.HasIndex(p => p.Nome).IsUnique();

            builder.HasData(
                new Regiao("Norte"),
                new Regiao("Nordeste"),
                new Regiao("Centro-Oeste"),
                new Regiao("Sudeste"),
                new Regiao("Sul")
            );
        }
    }
}
