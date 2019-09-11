using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NG.Data.Models;

namespace NG.Data.Configurations
{
    public class WheelQuestionTypeConfiguration : BaseConfiguration<WheelQuestionType>
    {
        public override void Configure(EntityTypeBuilder<WheelQuestionType> builder)
        {
            base.Configure(builder);

            builder.Property(m => m.Title).IsRequired().HasMaxLength(255);
            builder.Property(m => m.Description).HasMaxLength(1000);
            
            builder.HasOne(x => x.User).WithMany(x => x.WheelQuestionTypes).HasForeignKey(x => x.CreatedUserId);
            builder.HasOne(x => x.User).WithMany(x => x.WheelQuestionTypes).HasForeignKey(x => x.UpdatedUserId);
            builder.HasOne(x => x.User).WithMany(x => x.WheelQuestionTypes).HasForeignKey(x => x.DeletedUserId);
            builder.HasOne(x => x.Wheel).WithMany(x => x.WheelQuestionTypes).HasForeignKey(x => x.WheelId);
        }
    }
}
