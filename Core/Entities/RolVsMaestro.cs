using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class RolVsMaestro : BaseEntity
    {
        [Required]
        public int IdRolFk { get; set; }
        public Rol Roles { get; set; }

        [Required]
        public int IdModuloMaestroFk { get; set; }
        public ModuloMaestro ModulosMaestros { get; set; }
    }
}