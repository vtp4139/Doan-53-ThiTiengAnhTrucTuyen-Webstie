using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishExamOnline.Backend.Data.Migrations
{
    public partial class updateuserresult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Results");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4835914310",
                column: "ConcurrencyStamp",
                value: "4025b78c-bc15-43e5-afd0-21eb1795bdbf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7200984639",
                column: "ConcurrencyStamp",
                value: "2b774ac9-bd59-4afc-a038-938cced802ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2243634607",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "36d8d8ad-6a03-4378-93b4-82bf94119a2f", "AQAAAAEAACcQAAAAEBenOSxH+bcFvH6vCRyfkNim2W3/+kNrvTv1b8oXQkM1Pxyg3JQaDXw06c/AHBquBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4695426118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0e8cbbc7-25f5-4ed0-a151-0d4637d41102", "AQAAAAEAACcQAAAAEODPU+kz7+ETbpvCfGAxyRvkYvpc0xSDD0WNK+2B6Qt9AmZH+l5Pyv38lgFTo9hSiA==" });

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 0, 34, 13, 858, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 12, 0, 34, 13, 861, DateTimeKind.Local).AddTicks(2705));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "Results",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4835914310",
                column: "ConcurrencyStamp",
                value: "3bf63b38-3d9b-47ec-8cb5-eefea7759b98");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7200984639",
                column: "ConcurrencyStamp",
                value: "5cf8e42f-0806-4fee-a685-7215fc46802c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2243634607",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "487be84b-f0bf-4a69-8318-e5e1672d83a9", "AQAAAAEAACcQAAAAEPYQl//PFcgB7+wdLOyGbTKDde0AGVkbGQFsKoPn5Gqyrf3GJUXYPnFCuXR4EvFMtQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4695426118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e086727a-e9b5-4a32-bb2e-9bf3c796b785", "AQAAAAEAACcQAAAAEGxnnuBnOU1/zOlmtsM8VXmFgRqrQi4rcdDA7Iw1EOMKv7v639gkWZ+JF6uQdmqzig==" });

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 25, 8, 133, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 25, 8, 135, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 25, 8, 135, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 25, 8, 135, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 25, 8, 135, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 25, 8, 135, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 25, 8, 135, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 25, 8, 135, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 25, 8, 135, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 25, 8, 135, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 25, 8, 135, DateTimeKind.Local).AddTicks(6931));
        }
    }
}
