using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Blockchain : BaseEntity
    {
        [Required]
        public int IdTipoNotificacion { get; set; }
        public TipoNotificacion TiposNotificaciones { get; set; }

        [Required]
        public int IdHiloRespuestaNotificacion { get; set; }
        public HiloRespuestaNotificacion HilosRespuestasNotificaciones { get; set; }
        
        [Required]
        public int IdAuditoria { get; set; }
        public Auditoria Auditorias { get; set; }

        [Required]
        public string HashGenerado { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        [Required]
        public DateTime FechaModificacion { get; set; }
    }
}