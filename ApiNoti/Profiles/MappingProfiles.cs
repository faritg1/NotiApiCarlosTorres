using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNoti.Dtos;
using AutoMapper;
using Core.Entities;

namespace ApiNoti.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() {
            CreateMap<Auditoria, AuditoriaDto>().ReverseMap();
            CreateMap<EstadoNotificacion, EstadoNotificacionDto>().ReverseMap();
            CreateMap<Formato, FormatoDto>().ReverseMap();
            CreateMap<HiloRespuestaNotificacion, HiloRespuestaNotDto>().ReverseMap();
            CreateMap<Radicado, RadicadoDto>().ReverseMap();
            CreateMap<TipoNotificacion, TipoNotificacionDto>().ReverseMap();
        }
    }
}