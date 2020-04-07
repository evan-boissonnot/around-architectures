using Around.Architectures.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Around.Architectures.Core.Data.EntityConfigurations
{
    public class RowEntityTypeConfiguration : IEntityTypeConfiguration<Row>
    {
        public void Configure(EntityTypeBuilder<Row> builder)
        {
            builder.ToTable("Row");

            builder.HasKey(item => item.Id);


        }
    }
}
