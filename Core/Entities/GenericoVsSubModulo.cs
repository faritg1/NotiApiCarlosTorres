using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class GenericoVsSubModulo : BaseEntity
    {
        [Required]
        public int IdPermisoGenericoFk { get; set; }
        public PermisoGenerico PermisosGenericos { get; set; }

        [Required]
        public int IdMaestroSubModulosFk { get; set; }
        public MaestroVsSubModulo MaestrosVsSubModulos { get; set; }

        [Required]
        public int IdRolFk { get; set; }
        public Rol Roles { get; set; }
    }
}