using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller1.Domain.Admins.Models;

namespace Taller1.Domain.Admins.Repositories
{
    public interface IPaypenalityvalidityformatedRepository
    {
        Task<IReadOnlyList<Paypenalityvalidityformated>> FindAllAsync();
        Task<Paypenalityvalidityformated?> FindByIdAsync(int id);
        Task<Paypenalityvalidityformated?> SaveAsync(Paypenalityvalidityformated paypenalityvalidityformated);
    }
}
