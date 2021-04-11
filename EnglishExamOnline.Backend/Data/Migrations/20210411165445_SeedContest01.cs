using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishExamOnline.Backend.Data.Migrations
{
    public partial class SeedContest01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contests",
                columns: new[] { "ContestId", "ContestName", "ContestScheduleId", "CreatedDate", "Description", "Status" },
                values: new object[,]
                {
                    { 100, "English Test (Morning) - ETS 21", 1, new DateTime(2021, 4, 11, 23, 54, 44, 576, DateTimeKind.Local).AddTicks(9146), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", true },
                    { 101, "English Test (Morning) - ETS 21", 1, new DateTime(2021, 4, 11, 23, 54, 44, 579, DateTimeKind.Local).AddTicks(3216), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", true },
                    { 102, "English Test (Morning) - ETS 21", 2, new DateTime(2021, 4, 11, 23, 54, 44, 579, DateTimeKind.Local).AddTicks(3272), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", true },
                    { 103, "English Test (Afternoon) - ETS 21", 2, new DateTime(2021, 4, 11, 23, 54, 44, 579, DateTimeKind.Local).AddTicks(3278), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", true },
                    { 104, "English Test (Night) - ETS 21", 2, new DateTime(2021, 4, 11, 23, 54, 44, 579, DateTimeKind.Local).AddTicks(3281), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", true },
                    { 105, "English Test (Afternoon) - ETS 21", 3, new DateTime(2021, 4, 11, 23, 54, 44, 579, DateTimeKind.Local).AddTicks(3285), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", true },
                    { 106, "English Test (Morning) - ETS 21", 1, new DateTime(2021, 4, 11, 23, 54, 44, 579, DateTimeKind.Local).AddTicks(3288), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", false },
                    { 107, "English Test (Afternoon) - ETS 21", 1, new DateTime(2021, 4, 11, 23, 54, 44, 579, DateTimeKind.Local).AddTicks(3291), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", false },
                    { 108, "English Test (Night) - ETS 21", 1, new DateTime(2021, 4, 11, 23, 54, 44, 579, DateTimeKind.Local).AddTicks(3295), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", false },
                    { 109, "English Test (Night) - ETS 21", 1, new DateTime(2021, 4, 11, 23, 54, 44, 579, DateTimeKind.Local).AddTicks(3298), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", false },
                    { 110, "English Test (Afternoon) - ETS 21", 1, new DateTime(2021, 4, 11, 23, 54, 44, 579, DateTimeKind.Local).AddTicks(3302), "The ETS is an international standardized test of English language proficiency for non-native speakers. It is intentionally designed to measure the everyday English skills of people working in an international environment.", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 101);

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
        }
    }
}
