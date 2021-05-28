using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishExamOnline.Backend.Data.Migrations
{
    public partial class UpdateContest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Contests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Contests");
        }
    }
}
