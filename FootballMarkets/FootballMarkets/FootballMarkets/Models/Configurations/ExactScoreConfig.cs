using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballMarkets.Models.Configurations
{
    public class ExactScoreConfig : IEntityTypeConfiguration<ExactScore>
    {
        public void Configure(EntityTypeBuilder<ExactScore> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
