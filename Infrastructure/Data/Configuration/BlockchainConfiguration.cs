using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class BlockchainConfiguration : IEntityTypeConfiguration<Blockchain>
    {
        public void Configure(EntityTypeBuilder<Blockchain> builder){
            builder.ToTable("blockchain");

            builder.HasKey(k => k.Id);
            builder.Property(k => k.Id);

            builder.Property(h => h.HashGenerado)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(e => e.FechaCreacion)
            .HasColumnType("datetime");

            builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime");

            builder.HasOne(p => p.TiposNotificaciones)
            .WithMany(p => p.Blockchains)
            .HasForeignKey(p => p.IdTipoNotificacion);

            builder.HasOne(p => p.HilosRespuestasNotificaciones)
            .WithMany(p => p.Blockchains)
            .HasForeignKey(p => p.IdHiloRespuestaNotificacion);

            builder.HasOne(p => p.Auditorias)
            .WithMany(p => p.Blockchains)
            .HasForeignKey(p => p.IdAuditoria);

        }
    }
}