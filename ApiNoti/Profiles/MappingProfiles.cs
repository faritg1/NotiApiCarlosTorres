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
            CreateMap<TipoRequerimiento, TipoRequerimientoDto>().ReverseMap();
            CreateMap<ModuloNotificacion, ModuloNotificacionDto>().ReverseMap();
            CreateMap<Blockchain, BlockchainDto>().ReverseMap();
            CreateMap<GenericoVsSubModulo, GenericoVsSubModuloDto>().ReverseMap();
            CreateMap<MaestroVsSubModulo, MestroVsSubModuloDto>().ReverseMap();
            CreateMap<ModuloMaestro, ModuloMaestroDto>().ReverseMap();
            CreateMap<PermisoGenerico, PermisoGenericoDto>().ReverseMap();
            CreateMap<Rol, RolDto>().ReverseMap();
            CreateMap<RolVsMaestro, RolVsMaestroDto>().ReverseMap();
            CreateMap<SubModulo, SubModuloDto>().ReverseMap();
        }
    }
}