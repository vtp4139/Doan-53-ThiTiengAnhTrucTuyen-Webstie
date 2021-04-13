using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishExamOnline.Backend.Data.Migrations
{
    public partial class FixidUSer_ContestRegist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContestRegists_AspNetUsers_UsersId",
                table: "ContestRegists");

            migrationBuilder.DropIndex(
                name: "IX_ContestRegists_UsersId",
                table: "ContestRegists");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "ContestRegists");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ContestRegists",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.CreateIndex(
                name: "IX_ContestRegists_UserId",
                table: "ContestRegists",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContestRegists_AspNetUsers_UserId",
                table: "ContestRegists",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContestRegists_AspNetUsers_UserId",
                table: "ContestRegists");

            migrationBuilder.DropIndex(
                name: "IX_ContestRegists_UserId",
                table: "ContestRegists");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ContestRegists",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "ContestRegists",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_ContestRegists_UsersId",
                table: "ContestRegists",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContestRegists_AspNetUsers_UsersId",
                table: "ContestRegists",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
