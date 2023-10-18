using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly NotificacionContext _context;
        private IAuditoria _auditorias;
        private IBlockchain _blockchains;
        private IEstadoNotificacion _estadosnotificaciones;
        private IFormato _formatos;
        private IHiloRespuestaNoti _hilosrespuestasnotis;
        private IModuloNotificacion _modulosnotificaciones;
        private IRadicado _radicados;
        private ITipoNotificacion _tiposnotificaciones;
        private ITipoRequerimiento _tiposrequerimientos;
        private IGenericoVsSubModulo _genericosvssubmodulos;
        private IMaestroVsSubModulo _maestrosvssubmodulos;
        private IModuloMaestro _modulosmaestros;
        private IPermisoGenerico _permisosgenericos;
        private IRol _roles;
        private IRolVsMaestro _rolesvsmaestros;
        private ISubModulo _submodulos;

        public UnitOfWork(NotificacionContext context)
        {
            _context = context;
        }

        public IAuditoria Auditorias{
            get{
                if(_auditorias == null){
                    _auditorias = new AuditoriaRepository(_context);
                }
                return _auditorias;
            }
        }
        public IBlockchain Blockchains{
            get{
                if(_blockchains == null){
                    _blockchains = new BlockchainRepository(_context);
                }
                return _blockchains;
            }
        }
        public IEstadoNotificacion EstadosNotificaciones{
            get{
                if(_estadosnotificaciones == null){
                    _estadosnotificaciones = new EstadoNotificacionRepository(_context);
                }
                return _estadosnotificaciones;
            }
        }
        public IFormato Formatos{
            get{
                if(_formatos == null){
                    _formatos = new FormatoRepository(_context);
                }
                return _formatos;
            }
        }
        public IHiloRespuestaNoti HilosRespuestasNotis{
            get{
                if(_hilosrespuestasnotis == null){
                    _hilosrespuestasnotis = new HiloRespuestaNotiRepository(_context);
                }
                return _hilosrespuestasnotis;
            }
        }
        public IModuloNotificacion ModulosNotificaciones{
            get{
                if(_modulosnotificaciones == null){
                    _modulosnotificaciones = new ModuloNotificacionRepository(_context);
                }
                return _modulosnotificaciones;
            }
        }
        public IRadicado Radicados{
            get{
                if(_radicados == null){
                    _radicados = new RadicadoRepository(_context);
                }
                return _radicados;
            }
        }
        public ITipoNotificacion TiposNotificaciones{
            get{
                if(_tiposnotificaciones == null){
                    _tiposnotificaciones = new TipoNotificacionRepository(_context);
                }
                return _tiposnotificaciones;
            }
        }
        public ITipoRequerimiento TiposRequerimientos{
            get{
                if(_tiposrequerimientos == null){
                    _tiposrequerimientos = new TipoRequerimientoRepository(_context);
                }
                return _tiposrequerimientos;
            }
        }
        public IGenericoVsSubModulo GenericosVsSubModulos{
            get{
                if(_genericosvssubmodulos == null){
                    _genericosvssubmodulos = new GenericoVsSubModuloRepository(_context);
                }
                return _genericosvssubmodulos;
            }
        }
        public IMaestroVsSubModulo MaestrosVsSubModulos{
            get{
                if(_maestrosvssubmodulos == null){
                    _maestrosvssubmodulos = new MaestroVsSubModuloRepository(_context);
                }
                return _maestrosvssubmodulos;
            }
        }
        public IModuloMaestro ModulosMaestros{
            get{
                if(_modulosmaestros == null){
                    _modulosmaestros = new ModuloMaestroRepository(_context);
                }
                return _modulosmaestros;
            }
        }
        public IPermisoGenerico PermisosGenericos{
            get{
                if(_permisosgenericos == null){
                    _permisosgenericos = new PermisoGenericoRepository(_context);
                }
                return _permisosgenericos;
            }
        }
        public IRol Roles{
            get{
                if(_roles == null){
                    _roles = new RolRepository(_context);
                }
                return _roles;
            }
        }
        public IRolVsMaestro RolesVsMaestros{
            get{
                if(_rolesvsmaestros == null){
                    _rolesvsmaestros = new RolVsMaestroRepository(_context);
                }
                return _rolesvsmaestros;
            }
        }
        public ISubModulo SubModulos{
            get{
                if(_submodulos == null){
                    _submodulos = new SubModuloRepository(_context);
                }
                return _submodulos;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}