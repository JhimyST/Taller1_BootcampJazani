using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller1.Domain.Admins.Models;

namespace Taller1.Domain.Admins.Repositories
{
    public interface IMiningconcessionRepository
    {
        Task<IReadOnlyList<Miningconcession>> FindAllAsync();
        Task<Miningconcession?> FindByIdAsync(int id);
        Task<Miningconcession?> SaveAsync(Miningconcession miningconcessions);
    }
}
