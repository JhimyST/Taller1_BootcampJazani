using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller1.Domain.Admins.Models;

namespace Taller1.Infrastructure.Admins.Configurations
{
    internal class PaypenalityvalidityformatedConfiguration : IEntityTypeConfiguration<Paypenalityvalidityformated>
    {
        public void Configure(EntityTypeBuilder<Paypenalityvalidityformated> builder)
        {
            builder.ToTable("paypenalityvalidityformated", "mc");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).HasColumnName("description");
            builder.Property(t => t.RegistrationDate).HasColumnName("registrationdate");
            builder.Property(t => t.State).HasColumnName("state");
        }
    }
}
