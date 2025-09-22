using Fretefy.Test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fretefy.Test.Infra.EntityFramework.Mappings
{
    public class RegiaoCidadeMap : IEntityTypeConfiguration<RegiaoCidade>
    {
        public void Configure(EntityTypeBuilder<RegiaoCidade> builder)
        {
            builder.HasKey(rc => rc.Id);

            builder.HasOne(rc => rc.Regiao)
                   .WithMany(r => r.RegiaoCidades)
                   .HasForeignKey(rc => rc.RegiaoId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(rc => rc.Cidade)
                   .WithMany(c => c.RegiaoCidades)
                   .HasForeignKey(rc => rc.CidadeId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(rc => new { rc.RegiaoId, rc.CidadeId }).IsUnique();
        }
    }
}