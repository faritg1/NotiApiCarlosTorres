using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class GenericoVsSubModuloConfiguration : IEntityTypeConfiguration<GenericoVsSubModulo>
    {
        public void Configure(EntityTypeBuilder<GenericoVsSubModulo> builder)
        {
            builder.ToTable("genericovssubmodulo");

            builder.HasKey(k => k.Id);
            builder.Property(k => k.Id);

            builder.Property(e => e.FechaCreacion)
            .HasColumnType("datetime");
            
            builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime");

            builder.HasOne(p => p.Roles)
            .WithMany(p => p.GenericosVsSubModulos)
            .HasForeignKey(p => p.IdRolFk);

            builder.HasOne(p => p.PermisosGenericos)
            .WithMany(p => p.GenericosVsSubModulos)
            .HasForeignKey(p => p.IdPermisoGenericoFk);

            builder.HasOne(p => p.MaestrosVsSubModulos)
            .WithMany(p => p.GenericosVsSubModulos)
            .HasForeignKey(p => p.IdMaestroSubModulosFk);
        }
    }
}