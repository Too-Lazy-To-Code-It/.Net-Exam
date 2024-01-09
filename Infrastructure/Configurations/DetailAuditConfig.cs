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
    public class DetailAuditConfig : IEntityTypeConfiguration<DetailsAudit>
    {
        public void Configure(EntityTypeBuilder<DetailsAudit> builder)
        {
            builder.HasKey(d => new { d.EquipementFK, d.AuditFK, d.DateAudit });
        }
    }
}
