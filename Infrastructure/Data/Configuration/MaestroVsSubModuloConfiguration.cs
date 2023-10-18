using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class MaestroVsSubModuloConfiguration : IEntityTypeConfiguration<MaestroVsSubModulo>
    {
        public void Configure(EntityTypeBuilder<MaestroVsSubModulo> builder)
        {
            builder.ToTable("maestrovssubmodulo");

            builder.HasKey(k => k.Id);
            builder.Property(k => k.Id);

            builder.Property(e => e.FechaCreacion)
            .HasColumnType("datetime");
            
            builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime");

            builder.HasOne(p => p.ModulosMaestros)
            .WithMany(p => p.MaestrosVsSubModulos)
            .HasForeignKey(p => p.IdModuloMaestroFk);

            builder.HasOne(p => p.SubModulos)
            .WithMany(p => p.MaestrosVsSubModulos)
            .HasForeignKey(p => p.IdSubmoduloFk);
        }
    }
}