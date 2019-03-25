using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballMarkets.Models.Configurations
{

    public class WinnerConfig : IEntityTypeConfiguration<Winner>
    {
        public void Configure(EntityTypeBuilder<Winner> builder)
        {
            builder.HasKey(w => w.Id);
        }
    }
}
