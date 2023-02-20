using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Config
{
    public class PlakBilgileriConfiguration : IEntityTypeConfiguration<PlakBilgileri>
    {
        public void Configure(EntityTypeBuilder<PlakBilgileri> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
