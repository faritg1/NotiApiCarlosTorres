using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.Data;

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

        public UnitOfWork(NotificacionContext context)
        {
            _context = context;
        }

        /* public IAuditoria Auditorias{
            get{
                if(_auditorias == null){
                    _auditorias = new PaisRepository(_context);
                }
                return _auditorias;
            }
        } */

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