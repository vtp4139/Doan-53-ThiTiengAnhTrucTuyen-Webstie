using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishExamOnline.Backend.Data.Migrations
{
    public partial class SeedQuestions01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "AnswerA", "AnswerB", "AnswerC", "AnswerD", "CorrectAnswer", "QuestionInfo" },
                values: new object[,]
                {
                    { 1, "locations", "locate", "located", "location", "locations", "Sunwirth Sneakers has several ------- in the greater metropolitan area." },
                    { 2, "buying", "paying", "going", "eating", "paying", "Cimber CPAs offers clients the convenience of ------- their invoices online and by mail." },
                    { 3, "reliable", "to rely", "more reliable", "reliably", "reliably", "The new software at Patel Industries has been working ------- since it was installed last year." },
                    { 4, "along", "toward", "over", "throughout", "throughout", "Best practices in customer service are outlined ------- the training handbook." },
                    { 5, "simple", "simpler", "simply", "simplicity", "simply", "The Scratch software will help us migrate our client records -------." },
                    { 6, "herself", "her", "she", "hers", "her", "The comedian said that ------- sense of humor was inherited from a grandparent." },
                    { 7, "from", "beside", "along", "after", "from", "Starting this August, Gavelton Bike Tours will be leading group cycling trips ------- Paris to Berlin." },
                    { 8, "reach", "talk", "reason", "put", "reach", "We hope to ------- an agreement with Mason Cooper, Inc., within the next week." },
                    { 9, "if", "to", "of", "as", "of", "Factory-floor managers must submit an inspection report at the end ------- their shift." },
                    { 10, "Sometimes", "Later", "Formerly", "Frequently", "Formerly", "------- a retail store, Seedum International will now sell merchandise only through its Web site." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 10);
        }
    }
}
