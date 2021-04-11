using EnglishExamOnline.Backend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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

            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    QuestionId = 1,
                    QuestionInfo = "Sunwirth Sneakers has several ------- in the greater metropolitan area.",
                    AnswerA = "locations",
                    AnswerB = "locate",
                    AnswerC = "located",
                    AnswerD = "location",
                    CorrectAnswer = "locations"
                },
                new Question
                {
                    QuestionId = 2,
                    QuestionInfo = "Cimber CPAs offers clients the convenience of ------- their invoices online and by mail.",
                    AnswerA = "buying",
                    AnswerB = "paying",
                    AnswerC = "going",
                    AnswerD = "eating",
                    CorrectAnswer = "paying"
                },
                new Question
                {
                    QuestionId = 3,
                    QuestionInfo = "The new software at Patel Industries has been working ------- since it was installed last year.",
                    AnswerA = "reliable",
                    AnswerB = "to rely",
                    AnswerC = "more reliable",
                    AnswerD = "reliably",
                    CorrectAnswer = "reliably"
                },
                new Question
                {
                    QuestionId = 4,
                    QuestionInfo = "Best practices in customer service are outlined ------- the training handbook.",
                    AnswerA = "along",
                    AnswerB = "toward",
                    AnswerC = "over",
                    AnswerD = "throughout",
                    CorrectAnswer = "throughout"
                },
                new Question
                {
                    QuestionId = 5,
                    QuestionInfo = "The Scratch software will help us migrate our client records -------.",
                    AnswerA = "simple",
                    AnswerB = "simpler",
                    AnswerC = "simply",
                    AnswerD = "simplicity",
                    CorrectAnswer = "simply"
                },
                new Question
                {
                    QuestionId = 6,
                    QuestionInfo = "The comedian said that ------- sense of humor was inherited from a grandparent.",
                    AnswerA = "herself",
                    AnswerB = "her",
                    AnswerC = "she",
                    AnswerD = "hers",
                    CorrectAnswer = "her"
                },
                new Question
                {
                    QuestionId = 7,
                    QuestionInfo = "Starting this August, Gavelton Bike Tours will be leading group cycling trips ------- Paris to Berlin.",
                    AnswerA = "from",
                    AnswerB = "beside",
                    AnswerC = "along",
                    AnswerD = "after",
                    CorrectAnswer = "from"
                },
                new Question
                {
                    QuestionId = 8,
                    QuestionInfo = "We hope to ------- an agreement with Mason Cooper, Inc., within the next week.",
                    AnswerA = "reach",
                    AnswerB = "talk",
                    AnswerC = "reason",
                    AnswerD = "put",
                    CorrectAnswer = "reach"
                },
                new Question
                {
                    QuestionId = 9,
                    QuestionInfo = "Factory-floor managers must submit an inspection report at the end ------- their shift.",
                    AnswerA = "if",
                    AnswerB = "to",
                    AnswerC = "of",
                    AnswerD = "as",
                    CorrectAnswer = "of"
                },
                new Question
                {
                    QuestionId = 10,
                    QuestionInfo = "------- a retail store, Seedum International will now sell merchandise only through its Web site.",
                    AnswerA = "Sometimes",
                    AnswerB = "Later",
                    AnswerC = "Formerly",
                    AnswerD = "Frequently",
                    CorrectAnswer = "Formerly"
                }
                );
            
        }
    }
}
