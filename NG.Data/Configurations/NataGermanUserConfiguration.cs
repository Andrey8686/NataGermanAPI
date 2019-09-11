using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NG.Data.Models;

namespace NG.Data.Configurations
{
    public class NataGermanUserConfiguration : IEntityTypeConfiguration<NataGermanUser>
    {
        public void Configure(EntityTypeBuilder<NataGermanUser> builder)
        {
            builder.Property(m => m.LastName).IsRequired().HasMaxLength(20);
            builder.Property(m => m.FirstName).HasMaxLength(20);
            builder.Property(m => m.Patronymic).HasMaxLength(20);
        }
    }
}
