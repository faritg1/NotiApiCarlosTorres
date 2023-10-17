using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class BlockchainRepository : GenericRepository<Blockchain>, IBlockchain
    {
        private readonly NotificacionContext _context;

        public BlockchainRepository(NotificacionContext context) : base(context)
        {
            _context = context;
        }
    }
}