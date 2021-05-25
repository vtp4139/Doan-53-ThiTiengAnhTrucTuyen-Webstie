using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishExamOnline.Backend.Data.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4835914310");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7200984639");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2243634607");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4695426118");

            migrationBuilder.DeleteData(
                table: "ContestSchedules",
                keyColumn: "ContestScheduleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ContestSchedules",
                keyColumn: "ContestScheduleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 100, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 100, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 100, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 100, 4 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 100, 5 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 100, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 100, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 100, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 100, 9 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 100, 10 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 101, 11 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 101, 12 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 101, 13 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 101, 14 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 101, 15 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 101, 16 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 101, 17 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 101, 18 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 101, 19 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 101, 20 });

            migrationBuilder.DeleteData(
                table: "ContestSchedules",
                keyColumn: "ContestScheduleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ContestSchedules",
                keyColumn: "ContestScheduleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ContestSchedules",
                keyColumn: "ContestScheduleId",
                keyValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4835914310", "4025b78c-bc15-43e5-afd0-21eb1795bdbf", "User", "USER" },
                    { "7200984639", "2b774ac9-bd59-4afc-a038-938cced802ea", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4695426118", 0, null, "0e8cbbc7-25f5-4ed0-a151-0d4637d41102", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@vp.com", false, null, false, null, "USER@VP.COM", "user", "AQAAAAEAACcQAAAAEODPU+kz7+ETbpvCfGAxyRvkYvpc0xSDD0WNK+2B6Qt9AmZH+l5Pyv38lgFTo9hSiA==", null, false, "", false, "user" },
                    { "2243634607", 0, null, "36d8d8ad-6a03-4378-93b4-82bf94119a2f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@vp.com", false, null, false, null, "ADMIN@VP.COM", "admin", "AQAAAAEAACcQAAAAEBenOSxH+bcFvH6vCRyfkNim2W3/+kNrvTv1b8oXQkM1Pxyg3JQaDXw06c/AHBquBQ==", null, false, "", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "ContestSchedules",
                columns: new[] { "ContestScheduleId", "Length", "StartTime" },
                values: new object[,]
                {
                    { 1, 60, new DateTime(2021, 4, 12, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 60, new DateTime(2021, 5, 25, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 60, new DateTime(2021, 5, 25, 15, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 60, new DateTime(2021, 5, 25, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 60, new DateTime(2021, 5, 27, 20, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "AnswerA", "AnswerB", "AnswerC", "AnswerD", "CorrectAnswer", "QuestionInfo" },
                values: new object[,]
                {
                    { 1, "locations", "locate", "located", "location", "locations", "Sunwirth Sneakers has several ------- in the greater metropolitan area." },
                    { 20, "specify", "specified", "specifying", "specification", "specified", "The color of the new chairs was not ------- on the invoice" },
                    { 19, "grow", "growth", "grew", "grown", "growth", "The rising employment rate is one factor contributing to ------- in the housing construction trade." },
                    { 18, "safe", "close", "clean", "prompt", "prompt", "We were pleased by the ------- and courteous reply we received from Astella Airlines concerning the change in itinerary." },
                    { 17, "assortment", "excitement", "account", "industry", "assortment", "Each box of Lane Permanent Markers contains an ------- of surprising colors." },
                    { 16, "collaboration", "collaborative", "collaboratively", "collaborate", "collaboratively", "Justlox, Inc., is planning to ------- redesign Model 543Q with its partners in Britain to ensure a better product." },
                    { 15, "Despite", "Across", "Besides", "Inside", "Despite", "------- the addition of 300 spaces, the ferry terminal’s parking area is still full by 9:00 A.M. every day." },
                    { 14, "evaluate", "evaluation", "evaluator", "evaluative", "evaluation", "Konixer Printers is conducting a thorough ------- of current requests for equipment upgrades." },
                    { 12, "rigid", "most rigidly", "rigidly", "more rigid", "more rigid", "The new microwave soup containers are ------- than the previous ones." },
                    { 11, "or", "and", "with", "nor", "nor", "Remarkably, neither Ms. Chen ------- Mr. Gillespie had been notified that the board meeting was canceled." },
                    { 9, "if", "to", "of", "as", "of", "Factory-floor managers must submit an inspection report at the end ------- their shift." },
                    { 8, "reach", "talk", "reason", "put", "reach", "We hope to ------- an agreement with Mason Cooper, Inc., within the next week." },
                    { 7, "from", "beside", "along", "after", "from", "Starting this August, Gavelton Bike Tours will be leading group cycling trips ------- Paris to Berlin." },
                    { 6, "herself", "her", "she", "hers", "her", "The comedian said that ------- sense of humor was inherited from a grandparent." },
                    { 5, "simple", "simpler", "simply", "simplicity", "simply", "The Scratch software will help us migrate our client records -------." },
                    { 4, "along", "toward", "over", "throughout", "throughout", "Best practices in customer service are outlined ------- the training handbook." },
                    { 3, "reliable", "to rely", "more reliable", "reliably", "reliably", "The new software at Patel Industries has been working ------- since it was installed last year." },
                    { 2, "buying", "paying", "going", "eating", "paying", "Cimber CPAs offers clients the convenience of ------- their invoices online and by mail." },
                    { 13, "regular", "general", "proud", "favorite", "proud", "The Banly Tourism Society is ------- to present the first issue of its publication, The Banly Quarterly." },
                    { 10, "Sometimes", "Later", "Formerly", "Frequently", "Formerly", "------- a retail store, Seedum International will now sell merchandise only through its Web site." }
                });

            migrationBuilder.InsertData(
                table: "Contests",
                columns: new[] { "ContestId", "ContestName", "ContestScheduleId", "CreatedDate", "Description", "Status" },
                values: new object[,]
                {
                    { 100, "English Test (Morning) - ETS 21", 1, new DateTime(2021, 5, 12, 0, 34, 13, 858, DateTimeKind.Local).AddTicks(8361), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", true },
                    { 101, "English Test (Morning) - ETS 21", 1, new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2600), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", true },
                    { 106, "English Test (Morning) - ETS 21", 1, new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2687), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", false },
                    { 107, "English Test (Afternoon) - ETS 21", 1, new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2692), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", false },
                    { 108, "English Test (Night) - ETS 21", 1, new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2696), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", false },
                    { 109, "English Test (Night) - ETS 21", 1, new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2700), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", false },
                    { 110, "English Test (Afternoon) - ETS 21", 1, new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2705), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", false },
                    { 102, "English Test (Morning) - ETS 21", 2, new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2666), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", true },
                    { 103, "English Test (Afternoon) - ETS 21", 2, new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2673), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", true },
                    { 104, "English Test (Night) - ETS 21", 2, new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2678), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", true },
                    { 105, "English Test (Afternoon) - ETS 21", 3, new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2682), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", true }
                });

            migrationBuilder.InsertData(
                table: "QuestionDetails",
                columns: new[] { "ContestId", "QuestionId", "Index" },
                values: new object[,]
                {
                    { 100, 1, 1 },
                    { 101, 18, 18 },
                    { 101, 17, 17 },
                    { 101, 16, 16 },
                    { 101, 15, 15 },
                    { 101, 14, 14 },
                    { 101, 13, 13 },
                    { 101, 12, 12 },
                    { 101, 11, 11 },
                    { 100, 10, 10 },
                    { 100, 9, 9 },
                    { 100, 8, 8 },
                    { 100, 7, 7 },
                    { 100, 6, 6 },
                    { 100, 5, 5 },
                    { 100, 4, 4 },
                    { 100, 3, 3 },
                    { 100, 2, 2 },
                    { 101, 19, 19 },
                    { 101, 20, 20 }
                });
        }
    }
}
