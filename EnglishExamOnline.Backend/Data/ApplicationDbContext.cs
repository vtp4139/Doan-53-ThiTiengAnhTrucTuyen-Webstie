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

            //seed data cau hoi
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
                },
                new Question
                {
                    QuestionId = 11,
                    QuestionInfo = "Remarkably, neither Ms. Chen ------- Mr. Gillespie had been notified that the board meeting was canceled.",
                    AnswerA = "or",
                    AnswerB = "and",
                    AnswerC = "with",
                    AnswerD = "nor",
                    CorrectAnswer = "nor"
                },
                new Question
                {
                    QuestionId = 12,
                    QuestionInfo = "The new microwave soup containers are ------- than the previous ones.",
                    AnswerA = "rigid",
                    AnswerB = "most rigidly",
                    AnswerC = "rigidly",
                    AnswerD = "more rigid",
                    CorrectAnswer = "more rigid"
                },
                new Question
                {
                    QuestionId = 13,
                    QuestionInfo = "The Banly Tourism Society is ------- to present the first issue of its publication, The Banly Quarterly.",
                    AnswerA = "regular",
                    AnswerB = "general",
                    AnswerC = "proud",
                    AnswerD = "favorite",
                    CorrectAnswer = "proud"
                },
                new Question
                {
                    QuestionId = 14,
                    QuestionInfo = "Konixer Printers is conducting a thorough ------- of current requests for equipment upgrades.",
                    AnswerA = "evaluate",
                    AnswerB = "evaluation",
                    AnswerC = "evaluator",
                    AnswerD = "evaluative",
                    CorrectAnswer = "evaluation"
                },
                new Question
                {
                    QuestionId = 15,
                    QuestionInfo = "------- the addition of 300 spaces, the ferry terminal’s parking area is still full by 9:00 A.M. every day.",
                    AnswerA = "Despite",
                    AnswerB = "Across",
                    AnswerC = "Besides",
                    AnswerD = "Inside",
                    CorrectAnswer = "Despite"
                },
                new Question
                {
                    QuestionId = 16,
                    QuestionInfo = "Justlox, Inc., is planning to ------- redesign Model 543Q with its partners in Britain to ensure a better product.",
                    AnswerA = "collaboration",
                    AnswerB = "collaborative",
                    AnswerC = "collaboratively",
                    AnswerD = "collaborate",
                    CorrectAnswer = "collaboratively"
                },
                new Question
                {
                    QuestionId = 17,
                    QuestionInfo = "Each box of Lane Permanent Markers contains an ------- of surprising colors.",
                    AnswerA = "assortment",
                    AnswerB = "excitement",
                    AnswerC = "account",
                    AnswerD = "industry",
                    CorrectAnswer = "assortment"
                },
                new Question
                {
                    QuestionId = 18,
                    QuestionInfo = "We were pleased by the ------- and courteous reply we received from Astella Airlines concerning the change in itinerary.",
                    AnswerA = "safe",
                    AnswerB = "close",
                    AnswerC = "clean",
                    AnswerD = "prompt",
                    CorrectAnswer = "prompt"
                },
                new Question
                {
                    QuestionId = 19,
                    QuestionInfo = "The rising employment rate is one factor contributing to ------- in the housing construction trade.",
                    AnswerA = "grow",
                    AnswerB = "growth",
                    AnswerC = "grew",
                    AnswerD = "grown",
                    CorrectAnswer = "growth"
                },
                new Question
                {
                    QuestionId = 20,
                    QuestionInfo = "The color of the new chairs was not ------- on the invoice",
                    AnswerA = "specify",
                    AnswerB = "specified",
                    AnswerC = "specifying",
                    AnswerD = "specification",
                    CorrectAnswer = "specified"
                }

                );
            //seed data lich thi
            modelBuilder.Entity<ContestSchedule>().HasData(
                new ContestSchedule
                {
                    ContestScheduleId = 1,
                    StartTime = new DateTime(2021, 4, 12, 10, 30, 0),
                    Length = 60
                },
                new ContestSchedule
                {
                    ContestScheduleId = 2,
                    StartTime = new DateTime(2021, 5, 25, 10, 30, 0),
                    Length = 60
                },
                new ContestSchedule
                {
                    ContestScheduleId = 3,
                    StartTime = new DateTime(2021, 5, 25, 15, 30, 0),
                    Length = 60
                },
                new ContestSchedule
                {
                    ContestScheduleId = 4,
                    StartTime = new DateTime(2021, 5, 25, 20, 0, 0),
                    Length = 60
                },
                new ContestSchedule
                {
                    ContestScheduleId = 5,
                    StartTime = new DateTime(2021, 5, 27, 20, 0, 0),
                    Length = 60
                }
                );
            //seed data cuoc thi
            modelBuilder.Entity<Contest>().HasData(
                new Contest
                {
                    ContestId = 100,
                    ContestName = "English Test (Morning) - ETS 21",
                    Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                    CreatedDate = DateTime.Now,
                    Status = true,
                    ContestScheduleId = 1,
                },
                new Contest
                {
                    ContestId = 101,
                    ContestName = "English Test (Morning) - ETS 21",
                    Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                    CreatedDate = DateTime.Now,
                    Status = true,
                    ContestScheduleId = 1,
                },
                new Contest
                {
                    ContestId = 102,
                    ContestName = "English Test (Morning) - ETS 21",
                    Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                    CreatedDate = DateTime.Now,
                    Status = true,
                    ContestScheduleId = 2,
                },
                new Contest
                {
                    ContestId = 103,
                    ContestName = "English Test (Afternoon) - ETS 21",
                    Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                    CreatedDate = DateTime.Now,
                    Status = true,
                    ContestScheduleId = 2,
                },
                new Contest
                {
                    ContestId = 104,
                    ContestName = "English Test (Night) - ETS 21",
                    Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                    CreatedDate = DateTime.Now,
                    Status = true,
                    ContestScheduleId = 2,
                },
                new Contest
                {
                    ContestId = 105,
                    ContestName = "English Test (Afternoon) - ETS 21",
                    Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                    CreatedDate = DateTime.Now,
                    Status = true,
                    ContestScheduleId = 3,
                },
                new Contest
                {
                    ContestId = 106,
                    ContestName = "English Test (Morning) - ETS 21",
                    Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                    CreatedDate = DateTime.Now,
                    Status = false,
                    ContestScheduleId = 1,
                },
                new Contest
                {
                    ContestId = 107,
                    ContestName = "English Test (Afternoon) - ETS 21",
                    Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                    CreatedDate = DateTime.Now,
                    Status = false,
                    ContestScheduleId = 1,
                },
                new Contest
                {
                    ContestId = 108,
                    ContestName = "English Test (Night) - ETS 21",
                    Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                    CreatedDate = DateTime.Now,
                    Status = false,
                    ContestScheduleId = 1,
                },
                new Contest
                {
                    ContestId = 109,
                    ContestName = "English Test (Night) - ETS 21",
                    Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                    CreatedDate = DateTime.Now,
                    Status = false,
                    ContestScheduleId = 1,
                },
                new Contest
                {
                    ContestId = 110,
                    ContestName = "English Test (Afternoon) - ETS 21",
                    Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                    CreatedDate = DateTime.Now,
                    Status = false,
                    ContestScheduleId = 1,
                }
                );
            modelBuilder.Entity<QuestionDetail>().HasData(
                new QuestionDetail
                {
                    QuestionId = 1,
                    ContestId = 100,
                    Index = 1
                },
                new QuestionDetail
                {
                    QuestionId = 2,
                    ContestId = 100,
                    Index = 2
                },
                new QuestionDetail
                {
                    QuestionId = 3,
                    ContestId = 100,
                    Index = 3
                },
                new QuestionDetail
                {
                    QuestionId = 4,
                    ContestId = 100,
                    Index = 4
                },
                new QuestionDetail
                {
                    QuestionId = 5,
                    ContestId = 100,
                    Index = 5
                },
                new QuestionDetail
                {
                    QuestionId = 6,
                    ContestId = 100,
                    Index = 6
                },
                new QuestionDetail
                {
                    QuestionId = 7,
                    ContestId = 100,
                    Index = 7
                },
                new QuestionDetail
                {
                    QuestionId = 8,
                    ContestId = 100,
                    Index = 8
                },
                new QuestionDetail
                {
                    QuestionId = 9,
                    ContestId = 100,
                    Index = 9
                },
                new QuestionDetail
                {
                    QuestionId = 10,
                    ContestId = 100,
                    Index = 10
                },
                new QuestionDetail
                {
                    QuestionId = 11,
                    ContestId = 100,
                    Index = 11
                },
                new QuestionDetail
                {
                    QuestionId = 12,
                    ContestId = 100,
                    Index = 12
                },
                new QuestionDetail
                {
                    QuestionId = 13,
                    ContestId = 100,
                    Index = 13
                },
                new QuestionDetail
                {
                    QuestionId = 14,
                    ContestId = 100,
                    Index = 14
                },
                new QuestionDetail
                {
                    QuestionId = 15,
                    ContestId = 100,
                    Index = 15
                },
                new QuestionDetail
                {
                    QuestionId = 16,
                    ContestId = 100,
                    Index = 16
                },
                new QuestionDetail
                {
                    QuestionId = 17,
                    ContestId = 100,
                    Index = 17
                },
                new QuestionDetail
                {
                    QuestionId = 18,
                    ContestId = 100,
                    Index = 18
                },
                new QuestionDetail
                {
                    QuestionId = 19,
                    ContestId = 100,
                    Index = 19
                },
                new QuestionDetail
                {
                    QuestionId = 20,
                    ContestId = 100,
                    Index = 20
                }
                );
        }
    }
}
