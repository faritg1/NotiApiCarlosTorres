using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Rol : BaseEntity
    {
        [Required]
        public string NombreRol { get; set; }
        public ICollection<GenericoVsSubModulo> GenericosVsSubModulos { get; set; }
        public ICollection<RolVsMaestro> RolesVsMaestros { get; set; }
    }
}