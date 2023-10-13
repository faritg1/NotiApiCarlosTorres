using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class AuditoriaConfiguration : IEntityTypeConfiguration<Auditoria>
    {
        public void Configure(EntityTypeBuilder<Auditoria> builder){
            builder.ToTable("auditoria");

            builder.HasKey(k => k.Id);
            builder.Property(k => k.Id);

            builder.Property(n => n.NombreUsuario)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(f => f.FechaCreacion)
            .HasColumnType("datetime");

            builder.Property(f => f.FechaModificacion)
            .HasColumnType("datetime");
        }
    }
}