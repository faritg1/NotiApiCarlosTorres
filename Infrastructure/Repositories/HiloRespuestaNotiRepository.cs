using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class HiloRespuestaNotiRepository : GenericRepository<HiloRespuestaNotificacion>, IHiloRespuestaNoti
    {
        private readonly NotificacionContext _context;

        public HiloRespuestaNotiRepository(NotificacionContext context) : base(context)
        {
            _context = context;
        }
    }
}