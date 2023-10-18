using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class MaestroVsSubModulo : BaseEntity
    {
        [Required]
        public int IdModuloMaestroFk { get; set; }
        public ModuloMaestro ModulosMaestros { get; set; }

        [Required]
        public int IdSubmoduloFk { get; set; }
        public SubModulo SubModulos { get; set; }
        public ICollection<GenericoVsSubModulo> GenericosVsSubModulos { get; set; }
    }
}