using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.ToTable("rol");

            builder.HasKey(k => k.Id);
            builder.Property(k => k.Id);

            builder.Property(e => e.NombreRol)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(e => e.FechaCreacion)
            .HasColumnType("datetime");
            
            builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime");
        }
    }
}