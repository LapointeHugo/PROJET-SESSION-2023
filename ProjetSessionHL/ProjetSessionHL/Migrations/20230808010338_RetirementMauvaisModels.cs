using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetSessionHL.Migrations
{
    public partial class RetirementMauvaisModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entraineurs");

            migrationBuilder.DropTable(
                name: "Jeuxs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jeuxs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ImgFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jeuxs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entraineurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdJeux = table.Column<int>(type: "int", nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ImgFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entraineurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entraineurs_Jeuxs_IdJeux",
                        column: x => x.IdJeux,
                        principalTable: "Jeuxs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Jeuxs",
                columns: new[] { "Id", "Description", "ImgFile", "Nom" },
                values: new object[,]
                {
                    { 1, "Bienvenue dans le monde de Valorant, un jeu de tir tactique COMPÉTITIF où l'équilibre entre stratégie et précision est la clé de la victoire.Préparez - vous à plonger dans un UNIVERS FUTURISTE!", "ImageValorant.png", "Valorant" },
                    { 2, "League of Legends est un jeu en ligne multijoueur compétitif où deux équipes s'affrontent pour détruire la base adverse à travers des affrontements stratégiques et des mécaniques de jeu variées.", "ImageLol.png", "League of Legends" },
                    { 3, "Counter-Strike: Global Offensive (CS: GO) est un jeu de tir à la première personne en ligne où les joueurs s'affrontent dans des équipes en utilisant des armes tactiques.", "ImageCsgo.png", "CSGO" },
                    { 4, "Rocket League est un jeu vidéo mêlant football et course automobile où des joueurs contrôlent des voitures pour marquer des buts.", "ImageRL.png", "Rocket League" }
                });

            migrationBuilder.InsertData(
                table: "Entraineurs",
                columns: new[] { "Id", "Alias", "Email", "FirstName", "IdJeux", "ImgFile", "LastName" },
                values: new object[,]
                {
                    { 1, "Ethan", "ethaneg@gmail.com", "Ethan", 1, "Entraineur1(Valorant).jpg", "Arnold" },
                    { 2, "FNS", "fnsnrg@gmail.com", "Pujan", 1, "Entraineur2(Valorant).jpg", "Mehta" },
                    { 3, "Fudge", "fudgec9@gmail.com", "Ibrahim", 2, "Entraineur3(Lol).jpg", "Allami" },
                    { 4, "Caps", "capsg2@gmail.com", "Rasmus", 2, "Entraineur4(Lol).jpg", "Borregaard Wintherr" },
                    { 5, "Twistzz", "twistzzfaze@gmail.com", "Russel", 3, "Entraineur5(Csgo).jpg", "Dulken" },
                    { 6, "s1mple", "s1mplenavi@gmail.com", "Oleksandr", 3, "Entraineur6(Csgo).jpg", "Kostyljev" },
                    { 7, "zen", "zenvitality@gmail.com", "Alexis", 4, "Entraineur7(RL).jpg", "Bernier" },
                    { 8, "Vatira", "vatirakc@gmail.com", "Axel", 4, "Entraineur8(RL).jpg", "Touret" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entraineurs_IdJeux",
                table: "Entraineurs",
                column: "IdJeux");
        }
    }
}
