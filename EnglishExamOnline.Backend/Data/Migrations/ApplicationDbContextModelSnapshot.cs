﻿// <auto-generated />
using System;
using EnglishExamOnline.Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EnglishExamOnline.Backend.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EnglishExamOnline.Backend.Models.Contest", b =>
                {
                    b.Property<int>("ContestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContestName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ContestScheduleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ContestId");

                    b.HasIndex("ContestScheduleId");

                    b.ToTable("Contests");

                    b.HasData(
                        new
                        {
                            ContestId = 100,
                            ContestName = "English Test (Morning) - ETS 21",
                            ContestScheduleId = 1,
                            CreatedDate = new DateTime(2021, 4, 12, 8, 30, 18, 765, DateTimeKind.Local).AddTicks(7964),
                            Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                            Status = true
                        },
                        new
                        {
                            ContestId = 101,
                            ContestName = "English Test (Morning) - ETS 21",
                            ContestScheduleId = 1,
                            CreatedDate = new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1272),
                            Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                            Status = true
                        },
                        new
                        {
                            ContestId = 102,
                            ContestName = "English Test (Morning) - ETS 21",
                            ContestScheduleId = 2,
                            CreatedDate = new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1307),
                            Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                            Status = true
                        },
                        new
                        {
                            ContestId = 103,
                            ContestName = "English Test (Afternoon) - ETS 21",
                            ContestScheduleId = 2,
                            CreatedDate = new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1311),
                            Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                            Status = true
                        },
                        new
                        {
                            ContestId = 104,
                            ContestName = "English Test (Night) - ETS 21",
                            ContestScheduleId = 2,
                            CreatedDate = new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1313),
                            Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                            Status = true
                        },
                        new
                        {
                            ContestId = 105,
                            ContestName = "English Test (Afternoon) - ETS 21",
                            ContestScheduleId = 3,
                            CreatedDate = new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1315),
                            Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                            Status = true
                        },
                        new
                        {
                            ContestId = 106,
                            ContestName = "English Test (Morning) - ETS 21",
                            ContestScheduleId = 1,
                            CreatedDate = new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1319),
                            Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                            Status = false
                        },
                        new
                        {
                            ContestId = 107,
                            ContestName = "English Test (Afternoon) - ETS 21",
                            ContestScheduleId = 1,
                            CreatedDate = new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1321),
                            Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                            Status = false
                        },
                        new
                        {
                            ContestId = 108,
                            ContestName = "English Test (Night) - ETS 21",
                            ContestScheduleId = 1,
                            CreatedDate = new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1323),
                            Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                            Status = false
                        },
                        new
                        {
                            ContestId = 109,
                            ContestName = "English Test (Night) - ETS 21",
                            ContestScheduleId = 1,
                            CreatedDate = new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1326),
                            Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                            Status = false
                        },
                        new
                        {
                            ContestId = 110,
                            ContestName = "English Test (Afternoon) - ETS 21",
                            ContestScheduleId = 1,
                            CreatedDate = new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1328),
                            Description = "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.",
                            Status = false
                        });
                });

            modelBuilder.Entity("EnglishExamOnline.Backend.Models.ContestRegist", b =>
                {
                    b.Property<int>("ContestRegistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContestId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ContestRegistId");

                    b.HasIndex("ContestId");

                    b.HasIndex("UsersId");

                    b.ToTable("ContestRegists");
                });

            modelBuilder.Entity("EnglishExamOnline.Backend.Models.ContestSchedule", b =>
                {
                    b.Property<int>("ContestScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ContestScheduleId");

                    b.ToTable("ContestSchedules");

                    b.HasData(
                        new
                        {
                            ContestScheduleId = 1,
                            Length = 60,
                            StartTime = new DateTime(2021, 4, 12, 10, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ContestScheduleId = 2,
                            Length = 60,
                            StartTime = new DateTime(2021, 5, 25, 10, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ContestScheduleId = 3,
                            Length = 60,
                            StartTime = new DateTime(2021, 5, 25, 15, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ContestScheduleId = 4,
                            Length = 60,
                            StartTime = new DateTime(2021, 5, 25, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ContestScheduleId = 5,
                            Length = 60,
                            StartTime = new DateTime(2021, 5, 27, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("EnglishExamOnline.Backend.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnswerA")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AnswerB")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AnswerC")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AnswerD")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CorrectAnswer")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("QuestionInfo")
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("QuestionId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QuestionId = 1,
                            AnswerA = "locations",
                            AnswerB = "locate",
                            AnswerC = "located",
                            AnswerD = "location",
                            CorrectAnswer = "locations",
                            QuestionInfo = "Sunwirth Sneakers has several ------- in the greater metropolitan area."
                        },
                        new
                        {
                            QuestionId = 2,
                            AnswerA = "buying",
                            AnswerB = "paying",
                            AnswerC = "going",
                            AnswerD = "eating",
                            CorrectAnswer = "paying",
                            QuestionInfo = "Cimber CPAs offers clients the convenience of ------- their invoices online and by mail."
                        },
                        new
                        {
                            QuestionId = 3,
                            AnswerA = "reliable",
                            AnswerB = "to rely",
                            AnswerC = "more reliable",
                            AnswerD = "reliably",
                            CorrectAnswer = "reliably",
                            QuestionInfo = "The new software at Patel Industries has been working ------- since it was installed last year."
                        },
                        new
                        {
                            QuestionId = 4,
                            AnswerA = "along",
                            AnswerB = "toward",
                            AnswerC = "over",
                            AnswerD = "throughout",
                            CorrectAnswer = "throughout",
                            QuestionInfo = "Best practices in customer service are outlined ------- the training handbook."
                        },
                        new
                        {
                            QuestionId = 5,
                            AnswerA = "simple",
                            AnswerB = "simpler",
                            AnswerC = "simply",
                            AnswerD = "simplicity",
                            CorrectAnswer = "simply",
                            QuestionInfo = "The Scratch software will help us migrate our client records -------."
                        },
                        new
                        {
                            QuestionId = 6,
                            AnswerA = "herself",
                            AnswerB = "her",
                            AnswerC = "she",
                            AnswerD = "hers",
                            CorrectAnswer = "her",
                            QuestionInfo = "The comedian said that ------- sense of humor was inherited from a grandparent."
                        },
                        new
                        {
                            QuestionId = 7,
                            AnswerA = "from",
                            AnswerB = "beside",
                            AnswerC = "along",
                            AnswerD = "after",
                            CorrectAnswer = "from",
                            QuestionInfo = "Starting this August, Gavelton Bike Tours will be leading group cycling trips ------- Paris to Berlin."
                        },
                        new
                        {
                            QuestionId = 8,
                            AnswerA = "reach",
                            AnswerB = "talk",
                            AnswerC = "reason",
                            AnswerD = "put",
                            CorrectAnswer = "reach",
                            QuestionInfo = "We hope to ------- an agreement with Mason Cooper, Inc., within the next week."
                        },
                        new
                        {
                            QuestionId = 9,
                            AnswerA = "if",
                            AnswerB = "to",
                            AnswerC = "of",
                            AnswerD = "as",
                            CorrectAnswer = "of",
                            QuestionInfo = "Factory-floor managers must submit an inspection report at the end ------- their shift."
                        },
                        new
                        {
                            QuestionId = 10,
                            AnswerA = "Sometimes",
                            AnswerB = "Later",
                            AnswerC = "Formerly",
                            AnswerD = "Frequently",
                            CorrectAnswer = "Formerly",
                            QuestionInfo = "------- a retail store, Seedum International will now sell merchandise only through its Web site."
                        });
                });

            modelBuilder.Entity("EnglishExamOnline.Backend.Models.QuestionDetail", b =>
                {
                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("ContestId")
                        .HasColumnType("int");

                    b.Property<int>("Index")
                        .HasColumnType("int");

                    b.HasKey("QuestionId", "ContestId");

                    b.HasIndex("ContestId");

                    b.ToTable("QuestionDetails");

                    b.HasData(
                        new
                        {
                            QuestionId = 1,
                            ContestId = 100,
                            Index = 1
                        },
                        new
                        {
                            QuestionId = 2,
                            ContestId = 100,
                            Index = 2
                        },
                        new
                        {
                            QuestionId = 3,
                            ContestId = 100,
                            Index = 3
                        },
                        new
                        {
                            QuestionId = 4,
                            ContestId = 100,
                            Index = 4
                        },
                        new
                        {
                            QuestionId = 5,
                            ContestId = 100,
                            Index = 5
                        },
                        new
                        {
                            QuestionId = 6,
                            ContestId = 100,
                            Index = 6
                        },
                        new
                        {
                            QuestionId = 7,
                            ContestId = 100,
                            Index = 7
                        },
                        new
                        {
                            QuestionId = 8,
                            ContestId = 100,
                            Index = 8
                        },
                        new
                        {
                            QuestionId = 9,
                            ContestId = 100,
                            Index = 9
                        },
                        new
                        {
                            QuestionId = 10,
                            ContestId = 100,
                            Index = 10
                        });
                });

            modelBuilder.Entity("EnglishExamOnline.Backend.Models.Result", b =>
                {
                    b.Property<int>("ResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContestRegistId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumOfCorrect")
                        .HasColumnType("int");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ResultId");

                    b.HasIndex("ContestRegistId")
                        .IsUnique();

                    b.ToTable("Results");
                });

            modelBuilder.Entity("EnglishExamOnline.Backend.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EnglishExamOnline.Backend.Models.Contest", b =>
                {
                    b.HasOne("EnglishExamOnline.Backend.Models.ContestSchedule", "ContestSchedule")
                        .WithMany("Contests")
                        .HasForeignKey("ContestScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContestSchedule");
                });

            modelBuilder.Entity("EnglishExamOnline.Backend.Models.ContestRegist", b =>
                {
                    b.HasOne("EnglishExamOnline.Backend.Models.Contest", "Contest")
                        .WithMany("ContestRegists")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnglishExamOnline.Backend.Models.User", "Users")
                        .WithMany("ContestRegists")
                        .HasForeignKey("UsersId");

                    b.Navigation("Contest");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("EnglishExamOnline.Backend.Models.QuestionDetail", b =>
                {
                    b.HasOne("EnglishExamOnline.Backend.Models.Contest", "Contest")
                        .WithMany("QuestionDetails")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnglishExamOnline.Backend.Models.Question", "Question")
                        .WithMany("QuestionDetails")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contest");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("EnglishExamOnline.Backend.Models.Result", b =>
                {
                    b.HasOne("EnglishExamOnline.Backend.Models.ContestRegist", "ContestRegist")
                        .WithOne("Result")
                        .HasForeignKey("EnglishExamOnline.Backend.Models.Result", "ContestRegistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContestRegist");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EnglishExamOnline.Backend.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EnglishExamOnline.Backend.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnglishExamOnline.Backend.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EnglishExamOnline.Backend.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnglishExamOnline.Backend.Models.Contest", b =>
                {
                    b.Navigation("ContestRegists");

                    b.Navigation("QuestionDetails");
                });

            modelBuilder.Entity("EnglishExamOnline.Backend.Models.ContestRegist", b =>
                {
                    b.Navigation("Result");
                });

            modelBuilder.Entity("EnglishExamOnline.Backend.Models.ContestSchedule", b =>
                {
                    b.Navigation("Contests");
                });

            modelBuilder.Entity("EnglishExamOnline.Backend.Models.Question", b =>
                {
                    b.Navigation("QuestionDetails");
                });

            modelBuilder.Entity("EnglishExamOnline.Backend.Models.User", b =>
                {
                    b.Navigation("ContestRegists");
                });
#pragma warning restore 612, 618
        }
    }
}
