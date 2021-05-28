using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishExamOnline.Backend.Data.Migrations
{
    public partial class UpdateContest_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Contests");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Contests",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
