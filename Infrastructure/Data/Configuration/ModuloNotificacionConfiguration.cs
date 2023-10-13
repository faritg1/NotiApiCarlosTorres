using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ModuloNotificacionConfiguration : IEntityTypeConfiguration<ModuloNotificacion>
    {
        public void Configure(EntityTypeBuilder<ModuloNotificacion> builder)
        {
            builder.ToTable("modulonotificacion");

            builder.HasKey(k => k.Id);
            builder.Property(k => k.Id);

            builder.Property(e => e.AsuntoNotificacion)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(e => e.TextoNotificacion)
            .IsRequired()
            .HasMaxLength(100);

            builder.Property(e => e.FechaCreacion)
            .HasColumnType("datetime");
            
            builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime");

            builder.HasOne(p => p.TiposRequerimientos)
            .WithMany(p => p.ModulosNotificaciones)
            .HasForeignKey(p => p.IdtpRequerimientoFk);

            builder.HasOne(p => p.Radicados)
            .WithMany(p => p.ModulosNotificaciones)
            .HasForeignKey(p => p.IdRadicadoFk);

            builder.HasOne(p => p.EstadosNotificaciones)
            .WithMany(p => p.ModulosNotificaciones)
            .HasForeignKey(p => p.IdEstadoNotificacionFk);

            builder.HasOne(p => p.HilosRespuestasNotificaciones)
            .WithMany(p => p.ModulosNotificaciones)
            .HasForeignKey(p => p.IdHiloNotificacionFk);

            builder.HasOne(p => p.Formatos)
            .WithMany(p => p.ModulosNotificaciones)
            .HasForeignKey(p => p.IdFormatoFk);

            builder.HasOne(p => p.TiposNotificaciones)
            .WithMany(p => p.ModulosNotificaciones)
            .HasForeignKey(p => p.IdTipoNotificacionFk);
        }
    }
}