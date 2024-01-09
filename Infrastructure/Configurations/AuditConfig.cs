using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class AuditConfig : IEntityTypeConfiguration<Audit>
    {
        public void Configure(EntityTypeBuilder<Audit> builder)
        {
            builder.HasOne(a => a.Cabinet_Audit)
                .WithMany(c => c.Audits)
                .HasForeignKey(a=>a.CabinetAuditFK )
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
