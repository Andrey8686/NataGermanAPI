using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NG.Data.Models;

namespace NG.Data.Configurations
{
    public class WheelAnswerConfiguration : BaseConfiguration<WheelAnswer>
    {
        public override void Configure(EntityTypeBuilder<WheelAnswer> builder)
        {
            base.Configure(builder);

            builder.Property(m => m.Mark).IsRequired().HasMaxLength(10);

            builder.HasOne(x => x.User).WithMany(x => x.WheelAnswers).HasForeignKey(x => x.CreatedUserId);
            builder.HasOne(x => x.WheelQuestion).WithMany(x => x.WheelAnswers).HasForeignKey(x => x.WheelQuestionId);
        }
    }
}
