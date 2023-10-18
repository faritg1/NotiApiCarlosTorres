using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ModuloMaestro : BaseEntity
    {
        [Required]
        public string NombreModulo { get; set; }
        public ICollection<RolVsMaestro> RolesVsMaestros { get; set; }
        public ICollection<MaestroVsSubModulo> MaestrosVsSubModulos { get; set; }
    }
}