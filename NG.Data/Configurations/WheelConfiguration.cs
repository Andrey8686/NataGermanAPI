using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NG.Data.Models;

namespace NG.Data.Configurations
{
    public class WheelConfiguration : BaseConfiguration<Wheel>
    {
        public override void Configure(EntityTypeBuilder<Wheel> builder)
        {
            base.Configure(builder);

            builder.Property(m => m.Title).IsRequired().HasMaxLength(255);
            builder.Property(m => m.Description).HasMaxLength(1000);

            builder.HasOne(x => x.User).WithMany(x => x.Wheels).HasForeignKey(x => x.CreatedUserId);
            builder.HasOne(x => x.User).WithMany(x => x.Wheels).HasForeignKey(x => x.UpdatedUserId);
            builder.HasOne(x => x.User).WithMany(x => x.Wheels).HasForeignKey(x => x.DeletedUserId);
        }
    }
}
