using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishExamOnline.Backend.Data.Migrations
{
    public partial class SeedContestSchedule01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContestSchedules",
                keyColumn: "ContestScheduleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ContestSchedules",
                keyColumn: "ContestScheduleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ContestSchedules",
                keyColumn: "ContestScheduleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ContestSchedules",
                keyColumn: "ContestScheduleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ContestSchedules",
                keyColumn: "ContestScheduleId",
                keyValue: 5);
        }
    }
}
