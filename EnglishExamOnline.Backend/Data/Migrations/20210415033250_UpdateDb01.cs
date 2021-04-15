using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishExamOnline.Backend.Data.Migrations
{
    public partial class UpdateDb01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 13, 10, 53, 31, 676, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 13, 10, 53, 31, 678, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 13, 10, 53, 31, 678, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 13, 10, 53, 31, 678, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 13, 10, 53, 31, 678, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 13, 10, 53, 31, 678, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 13, 10, 53, 31, 678, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 13, 10, 53, 31, 678, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 13, 10, 53, 31, 678, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 13, 10, 53, 31, 678, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 13, 10, 53, 31, 678, DateTimeKind.Local).AddTicks(485));
        }
    }
}
