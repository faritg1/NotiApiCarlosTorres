using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Formato : BaseEntity
    {
        [Required]
        public string NombreFormato { get; set; }

        public ICollection<ModuloNotificacion> ModulosNotificaciones { get; set; }
    }
}