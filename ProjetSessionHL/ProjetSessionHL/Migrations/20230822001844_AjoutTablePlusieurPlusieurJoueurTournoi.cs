using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetSessionHL.Migrations
{
    public partial class AjoutTablePlusieurPlusieurJoueurTournoi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Joueurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Game = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joueurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tournois",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PrizePool = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournois", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JoueurTournoi",
                columns: table => new
                {
                    JoueursId = table.Column<int>(type: "int", nullable: false),
                    TournoisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoueurTournoi", x => new { x.JoueursId, x.TournoisId });
                    table.ForeignKey(
                        name: "FK_JoueurTournoi_Joueurs_JoueursId",
                        column: x => x.JoueursId,
                        principalTable: "Joueurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JoueurTournoi_Tournois_TournoisId",
                        column: x => x.TournoisId,
                        principalTable: "Tournois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Joueurs",
                columns: new[] { "Id", "Age", "Game", "Name" },
                values: new object[,]
                {
                    { 1, 21, "Valorant", "rapId" },
                    { 2, 22, "Valorant", "s0m" },
                    { 3, 27, "League of Legends", "faker" },
                    { 4, 30, "Counter-Strike: Global Offensive", "s1mple" },
                    { 5, 16, "Rocket League", "zen" }
                });

            migrationBuilder.InsertData(
                table: "Tournois",
                columns: new[] { "Id", "Location", "Name", "PrizePool" },
                values: new object[,]
                {
                    { 1, "Paris, France", "Paris Games Week 2023", 700000f },
                    { 2, "New York¸ USA", "Twitch Con", 1500000f },
                    { 3, "Montréal, Canada", "Game Convention", 1000000f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_JoueurTournoi_TournoisId",
                table: "JoueurTournoi",
                column: "TournoisId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JoueurTournoi");

            migrationBuilder.DropTable(
                name: "Joueurs");

            migrationBuilder.DropTable(
                name: "Tournois");
        }
    }
}
