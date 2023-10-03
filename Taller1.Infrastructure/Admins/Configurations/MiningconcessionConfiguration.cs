using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller1.Domain.Admins.Models;

namespace Taller1.Infrastructure.Admins.Configurations
{
    internal class MiningconcessionConfiguration: IEntityTypeConfiguration<Miningconcession>
    {
        

        public void Configure(EntityTypeBuilder<Miningconcession> builder)
        {
            builder.ToTable("miningconcession", "mc");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnName("name");
            builder.Property(x => x.Description).HasColumnName("description");
            builder.Property(t => t.RegistrationDate).HasColumnName("registrationdate");
            builder.Property(t => t.State).HasColumnName("state");
        }
    }
}
