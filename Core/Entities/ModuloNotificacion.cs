using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ModuloNotificacion : BaseEntity
    {
        [Required]
        public string AsuntoNotificacion { get; set; }

        [Required]
        public int IdtpRequerimientoFk { get; set; }
        public TipoRequerimiento TiposRequerimientos { get; set; }

        [Required]
        public int IdRadicadoFk { get; set; }
        public Radicado Radicados { get; set; }
        
        [Required]
        public int IdEstadoNotificacionFk { get; set; }
        public EstadoNotificacion EstadosNotificaciones { get; set; }
        
        [Required]
        public int IdHiloNotificacionFk { get; set; }
        public HiloRespuestaNotificacion HilosRespuestasNotificaciones { get; set; }
        
        [Required]
        public int IdFormatoFk { get; set; }
        public Formato Formatos { get; set; }
        
        [Required]
        public int IdTipoNotificacionFk { get; set; }
        public TipoNotificacion TiposNotificaciones { get; set; }

        [Required]
        public string TextoNotificacion { get; set; }
    }
}