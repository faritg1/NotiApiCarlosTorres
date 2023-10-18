using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class SubModuloRepository : GenericRepository<SubModulo>, ISubModulo
    {
        private readonly NotificacionContext _context;

        public SubModuloRepository(NotificacionContext context) : base(context)
        {
            _context = context;
        }
    }
}