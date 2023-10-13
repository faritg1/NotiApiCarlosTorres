using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class FormatoConfiguration : IEntityTypeConfiguration<Formato>
    {
        public void Configure(EntityTypeBuilder<Formato> builder)
        {
            builder.ToTable("formato");

            builder.HasKey(k => k.Id);
            builder.Property(k => k.Id);

            builder.Property(e => e.NombreFormato)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(e => e.FechaCreacion)
            .HasColumnType("datetime");

            builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime");
        }
    }
}