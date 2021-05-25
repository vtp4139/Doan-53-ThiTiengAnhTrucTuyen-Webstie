using EnglishExamOnline.Backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace EnglishExamOnline.Backend.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionDetail> QuestionDetails { get; set; }
        public DbSet<Contest> Contests { get; set; }
        public DbSet<ContestSchedule> ContestSchedules { get; set; }
        public DbSet<ContestRegist> ContestRegists { get; set; }
        public DbSet<Result> Results { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<QuestionDetail>()
            .HasKey(qd => new { qd.QuestionId, qd.ContestId });

            modelBuilder.Entity<QuestionDetail>()
                .HasOne(qd => qd.Question)
                .WithMany(p => p.QuestionDetails)
                .HasForeignKey(qd => qd.QuestionId);

            modelBuilder.Entity<QuestionDetail>()
                .HasOne(qd => qd.Contest)
                .WithMany(c => c.QuestionDetails)
                .HasForeignKey(qd => qd.ContestId);

            modelBuilder.Entity<User>()
                .ToTable("AspNetUsers");    

            //Add role to user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "7200984639",
                UserId = "2243634607"
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "4835914310",
                UserId = "4695426118"
            });           
        }
    }
}
