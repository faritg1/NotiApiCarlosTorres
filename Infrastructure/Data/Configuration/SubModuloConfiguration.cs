using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class SubModuloConfiguration : IEntityTypeConfiguration<SubModulo>
    {
        public void Configure(EntityTypeBuilder<SubModulo> builder)
        {
            builder.ToTable("submodulos");

            builder.HasKey(k => k.Id);
            builder.Property(k => k.Id);

            builder.Property(e => e.NombreSubModulo)
            .IsRequired()
            .HasMaxLength(80);

            builder.Property(e => e.FechaCreacion)
            .HasColumnType("datetime");
            
            builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime");
        }
    }
}