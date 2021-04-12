using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishExamOnline.Backend.Data.Migrations
{
    public partial class SeedQuestionDetail01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "QuestionDetails",
                keyColumns: new[] { "ContestId", "QuestionId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 30, 18, 765, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 30, 18, 767, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.InsertData(
                table: "QuestionDetails",
                columns: new[] { "ContestId", "QuestionId", "Index" },
                values: new object[,]
                {
                    { 100, 9, 9 },
                    { 100, 8, 8 },
                    { 100, 7, 7 },
                    { 100, 6, 6 },
                    { 100, 5, 5 },
                    { 100, 4, 4 },
                    { 100, 3, 3 },
                    { 100, 2, 2 },
                    { 100, 10, 10 },
                    { 100, 1, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 26, 24, 33, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 26, 24, 34, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 26, 24, 34, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 26, 24, 34, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 26, 24, 34, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 26, 24, 34, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 26, 24, 34, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 26, 24, 34, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 26, 24, 34, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 26, 24, 34, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 12, 8, 26, 24, 34, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.InsertData(
                table: "QuestionDetails",
                columns: new[] { "ContestId", "QuestionId", "Index" },
                values: new object[,]
                {
                    { 1, 9, 9 },
                    { 1, 8, 8 },
                    { 1, 7, 7 },
                    { 1, 6, 6 },
                    { 1, 5, 5 },
                    { 1, 4, 4 },
                    { 1, 3, 3 },
                    { 1, 2, 2 },
                    { 1, 10, 10 },
                    { 1, 1, 1 }
                });
        }
    }
}
