using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetSessionHL.Migrations
{
    public partial class MigrationMisAJour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Parents",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Jeuxs",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Enfants",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

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
                table: "Parents",
                columns: new[] { "Id", "Coaches", "Courses", "Description", "ImgFile", "ImgFileEquipe", "Lessons", "Nom" },
                values: new object[,]
                {
                    { 1, 15, 6, "Bienvenue dans le monde de Valorant, un jeu de tir tactique COMPÉTITIF où l'équilibre entre stratégie et précision est la clé de la victoire.Préparez - vous à plonger dans un UNIVERS FUTURISTE!", "ImageValorant.png", "ImageValorantEquipe.png", 54, "Valorant" },
                    { 2, 30, 29, "League of Legends est un jeu en ligne multijoueur compétitif où deux équipes s'affrontent pour détruire la base adverse à travers des affrontements stratégiques et des mécaniques de jeu variées.", "ImageLol.png", "ImageLolEquipe.png", 519, "League of Legends" },
                    { 3, 6, 5, "Counter-Strike: Global Offensive (CS: GO) est un jeu de tir à la première personne en ligne où les joueurs s'affrontent dans des équipes en utilisant des armes tactiques.", "ImageCsgo.png", "ImageCsgoEquipe.png", 102, "CSGO" }
                });

            migrationBuilder.InsertData(
                table: "Enfants",
                columns: new[] { "Id", "Abbreviation", "AnneCreation", "Description", "IdParent", "ImgFile", "Location", "MontantGagnee", "Nom", "PossedeSite", "Region", "Site" },
                values: new object[,]
                {
                    { 1, "FNC", 2004, "Fnatic est une célèbre organisation esportive mondiale qui a remporté de nombreux titres et compétitions dans différents jeux, notamment League of Legends et Counter-Strike: Global Offensive, Valorant, et qui est reconnue pour son excellence et son engagement envers l'esport.", 1, "LogoFnatic.png", "United Kingdom", 914634m, "Fnatic", true, "Europe", "fnatic.com" },
                    { 2, "C9", 2013, "Cloud9 est une organisation esportive américaine de renom, englobant divers jeux compétitifs, qui a acquis une réputation mondiale grâce à ses performances exceptionnelles et à ses victoires mémorables dans des titres tels que League of Legends, Counter-Strike: Global Offensive et bien d'autres.", 1, "LogoC9.png", "United States", 247800m, "Cloud 9", true, "North America", "cloud9.gg" },
                    { 3, "TL", 2000, "Team Liquid est une organisation esportive influente et prolifique qui excelle dans plusieurs jeux compétitifs et qui est reconnue pour son professionnalisme sa détermination et ses résultats impressionnants, notamment dans des titres tels que Dota 2, League of Legends et Counter - Strike: Global Offensive.", 1, "LogoTL.png", "United States / Netherlands", 534029m, "Team Liquid", true, "Europe", "teamliquid.com" },
                    { 4, "FPX", 2017, "FPX (FunPlus Phoenix) est une équipe chinoise d'esport remarquable, connue pour sa domination dans le jeu League of Legends, ayant remporté le championnat du monde en 2019 et impressionnant les spectateurs par leur jeu agressif et coordonné.", 1, "LogoFPX.png", "China / Europe", 482291m, "FunPlus Phoenix", false, "Europe", "None" },
                    { 5, "NRG", 2015, "NRG Esports est une organisation esportive dynamique et diversifiée, qui excelle dans une variété de jeux compétitifs, en investissant dans des talents prometteurs et en démontrant une passion inébranlable pour la compétition et l'innovation.", 2, "LogoNrg.png", "United States", 0m, "Nrg Esports", true, "North America", "nrg.gg" },
                    { 6, "T1", 2002, "T1 (anciennement SK Telecom T1) est une équipe sud-coréenne de renom dans l'esport, célèbre pour son héritage légendaire dans le jeu League of Legends, ayant remporté plusieurs championnats du monde et incarnant l'excellence, la stratégie et la domination dans l'esport.", 2, "LogoT1.png", "South Korea", 6863823m, "T1", true, "Korea", "t1.gg" },
                    { 7, "FQ", 2017, "FlyQuest est une équipe esport américaine engagée dans la durabilité environnementale, qui se distingue non seulement par ses performances compétitives dans les jeux tels que League of Legends, mais aussi par son engagement en faveur de l'action sociale et de l'impact positif sur la planète.", 2, "LogoFlyQuest.png", "United States", 236725m, "Fly Quest", false, "North America", "None" },
                    { 8, "JDG", 2017, "L'équipe JDG (JD Gaming) est une équipe esport chinoise de premier plan, réputée pour ses performances exceptionnelles dans des jeux tels que League of Legends, avec un roster talentueux et une approche stratégique qui les a propulsés vers de nombreux succès et titres.", 2, "LogoJdg.png", "China", 1776065m, "JD Gaming", false, "China", "None" },
                    { 9, "NaVi", 2009, "L'équipe Na'Vi, emblème indomptable de l'eSport, fusionne la précision millimétrée de leurs stratégies avec la fougue intense de leurs joueurs pour défier les limites du possible et incarner la grandeur du jeu vidéo compétitif.", 3, "LogoNavi.png", "Ukraine", 9522791m, "Natus Vincere", true, "Europe", "navi.gg" },
                    { 10, "mibr", 2018, "L'équipe MIBR, portant fièrement les couleurs du Brésil, allie habilement le talent brut de ses joueurs à une coordination implacable, propulsant ainsi leur gameplay vers des sommets vertigineux et faisant vibrer les fans du monde entier.", 3, "LogoMibr.png", "United States / Brésil", 2071519m, "MIBR", false, "North America", "None" },
                    { 11, "VIT", 2012, "La Team Vitality est une équipe emblématique de l'e-sport qui brille par son talent, sa passion et sa détermination, repoussant constamment les limites pour atteindre l'excellence.", 3, "LogoVitality.png", "France", 3477705m, "Team Vitality", true, "Europe", "vitality.gg" },
                    { 12, "FURIA", 2017, "La Team FURIA Esports incarne la fureur compétitive, alliant agressivité, stratégie et dynamisme pour faire trembler ses adversaires sur la scène de l'e-sport.", 3, "LogoFuria.png", "Brazil / United States", 1618275m, "FURIA Esports", false, "North America", "None" }
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Enfants",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Entraineurs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Entraineurs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Entraineurs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Entraineurs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Entraineurs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Entraineurs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Entraineurs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Entraineurs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Jeuxs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jeuxs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jeuxs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jeuxs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Parents",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Jeuxs",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Enfants",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);
        }
    }
}
