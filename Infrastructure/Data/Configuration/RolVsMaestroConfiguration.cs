using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class RolVsMaestroConfiguration : IEntityTypeConfiguration<RolVsMaestro>
    {
        public void Configure(EntityTypeBuilder<RolVsMaestro> builder)
        {
            builder.ToTable("rolvsmaestro");

            builder.HasKey(k => k.Id);
            builder.Property(k => k.Id);

            builder.Property(e => e.FechaCreacion)
            .HasColumnType("datetime");
            
            builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime");

            builder.HasOne(p => p.Roles)
            .WithMany(p => p.RolesVsMaestros)
            .HasForeignKey(p => p.IdRolFk);

            builder.HasOne(p => p.ModulosMaestros)
            .WithMany(p => p.RolesVsMaestros)
            .HasForeignKey(p => p.IdModuloMaestroFk);
        }
    }
}