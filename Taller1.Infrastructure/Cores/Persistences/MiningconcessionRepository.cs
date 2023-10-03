using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller1.Domain.Admins.Models;
using Taller1.Domain.Admins.Repositories;
using Taller1.Infrastructure.Cores.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Taller1.Infrastructure.Cores.Persistences
{
    internal class MiningconcessionRepository : IMiningconcessionRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public MiningconcessionRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IReadOnlyList<Miningconcession>> FindAllAsync()
        {
            return await _dbContext.Miningconcessions.ToListAsync();
        }

        public async Task<Miningconcession?> FindByIdAsync(int id)
        {
            return await _dbContext.Miningconcessions.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Miningconcession?> SaveAsync(Miningconcession miningconcession)
        {
            EntityState state = _dbContext.Entry(miningconcession).State;
            _ = state switch
            {
                EntityState.Detached => _dbContext.Miningconcessions.Add(miningconcession),
                EntityState.Modified => _dbContext.Miningconcessions.Update(miningconcession),
            };

            await _dbContext.SaveChangesAsync();

            return miningconcession;
        }
    }
}
