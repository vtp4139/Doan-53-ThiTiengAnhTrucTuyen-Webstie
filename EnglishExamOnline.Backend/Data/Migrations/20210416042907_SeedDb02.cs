using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishExamOnline.Backend.Data.Migrations
{
    public partial class SeedDb02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 16, 11, 29, 6, 344, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 16, 11, 29, 6, 346, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 16, 11, 29, 6, 346, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 16, 11, 29, 6, 346, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 16, 11, 29, 6, 346, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 16, 11, 29, 6, 346, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 16, 11, 29, 6, 346, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 16, 11, 29, 6, 346, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 16, 11, 29, 6, 346, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 16, 11, 29, 6, 346, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 16, 11, 29, 6, 346, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "AnswerA", "AnswerB", "AnswerC", "AnswerD", "CorrectAnswer", "QuestionInfo" },
                values: new object[,]
                {
                    { 19, "grow", "growth", "grew", "grown", "growth", "The rising employment rate is one factor contributing to ------- in the housing construction trade." },
                    { 18, "safe", "close", "clean", "prompt", "prompt", "We were pleased by the ------- and courteous reply we received from Astella Airlines concerning the change in itinerary." },
                    { 17, "assortment", "excitement", "account", "industry", "assortment", "Each box of Lane Permanent Markers contains an ------- of surprising colors." },
                    { 16, "collaboration", "collaborative", "collaboratively", "collaborate", "collaboratively", "Justlox, Inc., is planning to ------- redesign Model 543Q with its partners in Britain to ensure a better product." },
                    { 15, "Despite", "Across", "Besides", "Inside", "Despite", "------- the addition of 300 spaces, the ferry terminal’s parking area is still full by 9:00 A.M. every day." },
                    { 14, "evaluate", "evaluation", "evaluator", "evaluative", "evaluation", "Konixer Printers is conducting a thorough ------- of current requests for equipment upgrades." },
                    { 13, "regular", "general", "proud", "favorite", "proud", "The Banly Tourism Society is ------- to present the first issue of its publication, The Banly Quarterly." },
                    { 12, "rigid", "most rigidly", "rigidly", "more rigid", "more rigid", "The new microwave soup containers are ------- than the previous ones." },
                    { 20, "specify", "specified", "specifying", "specification", "specified", "The color of the new chairs was not ------- on the invoice" },
                    { 11, "or", "and", "with", "nor", "nor", "Remarkably, neither Ms. Chen ------- Mr. Gillespie had been notified that the board meeting was canceled." }
                });

            migrationBuilder.InsertData(
                table: "QuestionDetails",
                columns: new[] { "ContestId", "QuestionId", "Index" },
                values: new object[,]
                {
                    { 101, 11, 11 },
                    { 101, 12, 12 },
                    { 101, 13, 13 },
                    { 101, 14, 14 },
                    { 101, 15, 15 },
                    { 101, 16, 16 },
                    { 101, 17, 17 },
                    { 101, 18, 18 },
                    { 101, 19, 19 },
                    { 101, 20, 20 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 15, 10, 32, 49, 90, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 15, 10, 32, 49, 92, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 15, 10, 32, 49, 92, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 15, 10, 32, 49, 92, DateTimeKind.Local).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 15, 10, 32, 49, 92, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 15, 10, 32, 49, 92, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 15, 10, 32, 49, 92, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 15, 10, 32, 49, 92, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 15, 10, 32, 49, 92, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 15, 10, 32, 49, 92, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 15, 10, 32, 49, 92, DateTimeKind.Local).AddTicks(3948));
        }
    }
}
