using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NG.Data.Configurations;
using NG.Data.Models;

namespace NG.Data
{
    public class NataGermanContext : IdentityDbContext<NataGermanUser, NataGermanRole, Guid>
    {
        public DbSet<Wheel> Wheels { get; set; }
        public DbSet<WheelQuestionType> WheelQuestionTypes { get; set; }
        public DbSet<WheelQuestion> WheelQuestions { get; set; }
        public DbSet<WheelAnswer> WheelAnswers { get; set; }

        public NataGermanContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new NataGermanUserConfiguration());
            modelBuilder.ApplyConfiguration(new WheelConfiguration());
            modelBuilder.ApplyConfiguration(new WheelQuestionTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WheelQuestionConfiguration());
            modelBuilder.ApplyConfiguration(new WheelAnswerConfiguration());
        }
    }
}