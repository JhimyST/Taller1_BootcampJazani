using Taller1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller1.Domain.Admins.Models;
using Taller1.Domain.Admins.Repositories;
using Taller1.Infrastructure.Cores.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Taller1.Infrastructure.Cores.Persistences
{
    public class PaypenalityvalidityformatedRepository : IPaypenalityvalidityformatedRepository
    {

        private readonly ApplicationDbContext _dbContext;

        public PaypenalityvalidityformatedRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IReadOnlyList<Paypenalityvalidityformated>> FindAllAsync()
        {
            return await _dbContext.Paypenalityvalidityformateds.ToListAsync();
        }

        public async Task<Paypenalityvalidityformated?> FindByIdAsync(int id)
        {
            return await _dbContext.Paypenalityvalidityformateds.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Paypenalityvalidityformated?> SaveAsync(Paypenalityvalidityformated paypenalityvalidityformated)
        {
            EntityState state = _dbContext.Entry(paypenalityvalidityformated).State;
            _ = state switch
            {
                EntityState.Detached => _dbContext.Paypenalityvalidityformateds.Add(paypenalityvalidityformated),
                EntityState.Modified => _dbContext.Paypenalityvalidityformateds.Update(paypenalityvalidityformated),
            };

            await _dbContext.SaveChangesAsync();

            return paypenalityvalidityformated;
        }
    }
}
