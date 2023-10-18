using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        IAuditoria Auditorias { get; }
        IBlockchain Blockchains { get; }
        IEstadoNotificacion EstadosNotificaciones { get; }
        IFormato Formatos { get; }
        IHiloRespuestaNoti HilosRespuestasNotis {get; }
        IModuloNotificacion ModulosNotificaciones { get; }
        IRadicado Radicados { get; }
        ITipoNotificacion TiposNotificaciones { get; }
        ITipoRequerimiento TiposRequerimientos { get; }
        IGenericoVsSubModulo GenericosVsSubModulos { get; }
        IMaestroVsSubModulo MaestrosVsSubModulos { get; }
        IModuloMaestro ModulosMaestros { get; }
        IPermisoGenerico PermisosGenericos { get; }
        IRol Roles { get; }
        IRolVsMaestro RolesVsMaestros { get; }
        ISubModulo SubModulos { get; }
        Task<int> SaveAsync();
    }
}