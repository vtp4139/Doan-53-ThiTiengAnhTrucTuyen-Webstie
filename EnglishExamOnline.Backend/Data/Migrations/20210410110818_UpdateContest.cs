using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishExamOnline.Backend.Data.Migrations
{
    public partial class UpdateContest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contests_ContestSchedules_ContestScheduleId",
                table: "Contests");

            migrationBuilder.AlterColumn<int>(
                name: "ContestScheduleId",
                table: "Contests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contests_ContestSchedules_ContestScheduleId",
                table: "Contests",
                column: "ContestScheduleId",
                principalTable: "ContestSchedules",
                principalColumn: "ContestScheduleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contests_ContestSchedules_ContestScheduleId",
                table: "Contests");

            migrationBuilder.AlterColumn<int>(
                name: "ContestScheduleId",
                table: "Contests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Contests_ContestSchedules_ContestScheduleId",
                table: "Contests",
                column: "ContestScheduleId",
                principalTable: "ContestSchedules",
                principalColumn: "ContestScheduleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
