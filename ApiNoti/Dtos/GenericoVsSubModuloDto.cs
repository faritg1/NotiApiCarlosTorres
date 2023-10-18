using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNoti.Dtos
{
    public class GenericoVsSubModuloDto
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int IdPermisoGenericoFk { get; set; }
        public int IdMaestroSubModulosFk { get; set; }
        public int IdRolFk { get; set; }
    }
}