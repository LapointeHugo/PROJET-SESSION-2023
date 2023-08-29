using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetSessionHL.Migrations
{
    public partial class AjoutStatsDonnees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StatistiquesDonnees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mois = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitsToWebsite = table.Column<int>(type: "int", nullable: false),
                    AccountsCreated = table.Column<int>(type: "int", nullable: false),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Loses = table.Column<int>(type: "int", nullable: false),
                    GoalsScoredTeam = table.Column<int>(type: "int", nullable: false),
                    SavesMadeTeam = table.Column<int>(type: "int", nullable: false),
                    ScoreZenTotal = table.Column<int>(type: "int", nullable: false),
                    GoalsZenTotal = table.Column<int>(type: "int", nullable: false),
                    ShotsZenTotal = table.Column<int>(type: "int", nullable: false),
                    RatingZenTotal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatistiquesDonnees", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "StatistiquesDonnees",
                columns: new[] { "ID", "AccountsCreated", "GoalsScoredTeam", "GoalsZenTotal", "Loses", "Mois", "RatingZenTotal", "SavesMadeTeam", "ScoreZenTotal", "ShotsZenTotal", "VisitsToWebsite", "Wins" },
                values: new object[,]
                {
                    { 1, 750, 51, 17, 5, "Sep", 28, 122, 10244, 89, 10, 20 },
                    { 2, 750, 51, 17, 5, "Oct", 28, 122, 10244, 89, 30, 20 },
                    { 3, 750, 51, 17, 5, "Nov", 28, 122, 10244, 89, 40, 20 },
                    { 4, 750, 51, 17, 5, "Dec", 28, 122, 10244, 89, 60, 20 },
                    { 5, 750, 51, 17, 5, "Jan", 28, 122, 10244, 89, 50, 20 },
                    { 6, 750, 51, 17, 5, "Feb", 28, 122, 10244, 89, 30, 20 },
                    { 7, 750, 51, 17, 5, "Mar", 28, 122, 10244, 89, 70, 20 },
                    { 8, 750, 51, 17, 5, "Apr", 28, 122, 10244, 89, 10, 20 },
                    { 9, 750, 51, 17, 5, "May", 28, 122, 10244, 89, 40, 20 },
                    { 10, 750, 51, 17, 5, "Jun", 28, 122, 10244, 89, 20, 20 },
                    { 11, 750, 51, 17, 5, "Jul", 28, 122, 10244, 89, 10, 20 },
                    { 12, 750, 51, 17, 5, "Aug", 28, 122, 10244, 89, 40, 20 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StatistiquesDonnees");
        }
    }
}
