using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NG.Data.Models;

namespace NG.Data.Configurations
{
    public class WheelQuestionConfiguration : BaseConfiguration<WheelQuestion>
    {
        public override void Configure(EntityTypeBuilder<WheelQuestion> builder)
        {
            base.Configure(builder);

            builder.Property(m => m.Title).IsRequired().HasMaxLength(255);

            builder.HasOne(x => x.User).WithMany(x => x.WheelQuestions).HasForeignKey(x => x.CreatedUserId);
            builder.HasOne(x => x.User).WithMany(x => x.WheelQuestions).HasForeignKey(x => x.UpdatedUserId);
            builder.HasOne(x => x.User).WithMany(x => x.WheelQuestions).HasForeignKey(x => x.DeletedUserId);
            builder.HasOne(x => x.WheelQuestionType).WithMany(x => x.WheelQuestions).HasForeignKey(x => x.WheelQuestionTypeId);
        }
    }
}
