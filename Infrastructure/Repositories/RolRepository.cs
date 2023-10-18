using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class RolRepository : GenericRepository<Rol>, IRol
    {
        private readonly NotificacionContext _context;

        public RolRepository(NotificacionContext context) : base(context)
        {
            _context = context;
        }
    }
}