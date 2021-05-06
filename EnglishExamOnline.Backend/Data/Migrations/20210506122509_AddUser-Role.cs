using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishExamOnline.Backend.Data.Migrations
{
    public partial class AddUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29fce81d-c585-4648-8400-5db4723775aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31c98769-2994-4d12-ae49-45510afedb3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3ddef7e-c4ee-447e-a40d-1670e4f2ffe4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da389f65-c563-4928-a109-4133bc67b7de");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7200984639", "5cf8e42f-0806-4fee-a685-7215fc46802c", "Admin", "ADMIN" },
                    { "4835914310", "3bf63b38-3d9b-47ec-8cb5-eefea7759b98", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2243634607", 0, "487be84b-f0bf-4a69-8318-e5e1672d83a9", "admin@vp.com", false, null, false, null, "ADMIN@VP.COM", "admin", "AQAAAAEAACcQAAAAEPYQl//PFcgB7+wdLOyGbTKDde0AGVkbGQFsKoPn5Gqyrf3GJUXYPnFCuXR4EvFMtQ==", null, false, "", false, "admin" },
                    { "4695426118", 0, "e086727a-e9b5-4a32-bb2e-9bf3c796b785", "user@vp.com", false, null, false, null, "USER@VP.COM", "user", "AQAAAAEAACcQAAAAEGxnnuBnOU1/zOlmtsM8VXmFgRqrQi4rcdDA7Iw1EOMKv7v639gkWZ+JF6uQdmqzig==", null, false, "", false, "user" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7200984639", "2243634607" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4835914310", "4695426118" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7200984639", "2243634607" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4835914310", "4695426118" });

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29fce81d-c585-4648-8400-5db4723775aa", "d104a45d-96b8-40c4-813e-f1bb775da0c1", "Admin", "ADMIN" },
                    { "31c98769-2994-4d12-ae49-45510afedb3e", "e6d70226-f1bd-4c0c-9ece-4a3d5e4c093f", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b3ddef7e-c4ee-447e-a40d-1670e4f2ffe4", 0, "717cde8e-e3bd-41ac-99e6-bb72efe69960", "admin@vp.com", false, null, false, null, "ADMIN@VP.COM", "admin", "AQAAAAEAACcQAAAAEKs+RD/oeGQZVtn7oi6yM8QYRiYK8Ebg2gaqxWrr8w+WFVOFsYPRbkPTSLNLcu8f7g==", null, false, "", false, "admin" },
                    { "da389f65-c563-4928-a109-4133bc67b7de", 0, "36ccb319-e8ff-484a-82fb-aaddfc33b2da", "user@vp.com", false, null, false, null, "USER@VP.COM", "user", "AQAAAAEAACcQAAAAEL+Q4mbJ/60fC9kyNlF6SNvzWrZJAcwSfBtd4Jv4sn/36rY617Jbpj0OF5nMQ/QoNA==", null, false, "", false, "user" }
                });

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 13, 45, 556, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 13, 45, 558, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 13, 45, 558, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 13, 45, 558, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 13, 45, 558, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 13, 45, 558, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 13, 45, 558, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 13, 45, 558, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 13, 45, 558, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 13, 45, 558, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Contests",
                keyColumn: "ContestId",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2021, 5, 6, 19, 13, 45, 558, DateTimeKind.Local).AddTicks(6158));
        }
    }
}
