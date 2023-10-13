using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class HiloRespuestaNotConfiguration : IEntityTypeConfiguration<HiloRespuestaNotificacion>
    {
        public void Configure(EntityTypeBuilder<HiloRespuestaNotificacion> builder)
        {
            builder.ToTable("hilorespuestanotificacion");

            builder.HasKey(k => k.Id);
            builder.Property(k => k.Id);

            builder.Property(e => e.NombreTipo)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(e => e.FechaCreacion)
            .HasColumnType("datetime");

            builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime");
        }
    }
}