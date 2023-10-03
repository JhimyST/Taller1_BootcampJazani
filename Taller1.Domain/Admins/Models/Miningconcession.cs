using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1.Domain.Admins.Models
{
    public class Miningconcession
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public DateTimeOffset RegistrationDate { get; set; }
        public bool State { get; set; }
    }
}
