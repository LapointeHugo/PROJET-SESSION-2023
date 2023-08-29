﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetSessionHL.Data;

#nullable disable

namespace ProjetSessionHL.Migrations
{
    [DbContext(typeof(ProjetSessionDbContext))]
    [Migration("20230829223727_AjoutStatsDonnees")]
    partial class AjoutStatsDonnees
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JoueurTournoi", b =>
                {
                    b.Property<int>("JoueursId")
                        .HasColumnType("int");

                    b.Property<int>("TournoisId")
                        .HasColumnType("int");

                    b.HasKey("JoueursId", "TournoisId");

                    b.HasIndex("TournoisId");

                    b.ToTable("JoueurTournoi");
                });

            modelBuilder.Entity("ProjetSessionHL.Models.Enfant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("AnneCreation")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("IdParent")
                        .HasColumnType("int");

                    b.Property<string>("ImgFile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MontantGagnee")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("PossedeSite")
                        .HasColumnType("bit");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Site")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdParent");

                    b.ToTable("Enfants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Abbreviation = "FNC",
                            AnneCreation = 2004,
                            Description = "Fnatic est une célèbre organisation esportive mondiale qui a remporté de nombreux titres et compétitions dans différents jeux, notamment League of Legends et Counter-Strike: Global Offensive, Valorant, et qui est reconnue pour son excellence et son engagement envers l'esport.",
                            IdParent = 1,
                            ImgFile = "LogoFnatic.png",
                            Location = "United Kingdom",
                            MontantGagnee = 914634m,
                            Nom = "Fnatic",
                            PossedeSite = true,
                            Region = "Europe",
                            Site = "fnatic.com"
                        },
                        new
                        {
                            Id = 2,
                            Abbreviation = "C9",
                            AnneCreation = 2013,
                            Description = "Cloud9 est une organisation esportive américaine de renom, englobant divers jeux compétitifs, qui a acquis une réputation mondiale grâce à ses performances exceptionnelles et à ses victoires mémorables dans des titres tels que League of Legends, Counter-Strike: Global Offensive et bien d'autres.",
                            IdParent = 1,
                            ImgFile = "LogoC9.png",
                            Location = "United States",
                            MontantGagnee = 247800m,
                            Nom = "Cloud 9",
                            PossedeSite = true,
                            Region = "North America",
                            Site = "cloud9.gg"
                        },
                        new
                        {
                            Id = 3,
                            Abbreviation = "TL",
                            AnneCreation = 2000,
                            Description = "Team Liquid est une organisation esportive influente et prolifique qui excelle dans plusieurs jeux compétitifs et qui est reconnue pour son professionnalisme sa détermination et ses résultats impressionnants, notamment dans des titres tels que Dota 2, League of Legends et Counter - Strike: Global Offensive.",
                            IdParent = 1,
                            ImgFile = "LogoTL.png",
                            Location = "United States / Netherlands",
                            MontantGagnee = 534029m,
                            Nom = "Team Liquid",
                            PossedeSite = true,
                            Region = "Europe",
                            Site = "teamliquid.com"
                        },
                        new
                        {
                            Id = 4,
                            Abbreviation = "FPX",
                            AnneCreation = 2017,
                            Description = "FPX (FunPlus Phoenix) est une équipe chinoise d'esport remarquable, connue pour sa domination dans le jeu League of Legends, ayant remporté le championnat du monde en 2019 et impressionnant les spectateurs par leur jeu agressif et coordonné.",
                            IdParent = 1,
                            ImgFile = "LogoFPX.png",
                            Location = "China / Europe",
                            MontantGagnee = 482291m,
                            Nom = "FunPlus Phoenix",
                            PossedeSite = false,
                            Region = "Europe",
                            Site = "None"
                        },
                        new
                        {
                            Id = 5,
                            Abbreviation = "NRG",
                            AnneCreation = 2015,
                            Description = "NRG Esports est une organisation esportive dynamique et diversifiée, qui excelle dans une variété de jeux compétitifs, en investissant dans des talents prometteurs et en démontrant une passion inébranlable pour la compétition et l'innovation.",
                            IdParent = 2,
                            ImgFile = "LogoNrg.png",
                            Location = "United States",
                            MontantGagnee = 0m,
                            Nom = "Nrg Esports",
                            PossedeSite = true,
                            Region = "North America",
                            Site = "nrg.gg"
                        },
                        new
                        {
                            Id = 6,
                            Abbreviation = "T1",
                            AnneCreation = 2002,
                            Description = "T1 (anciennement SK Telecom T1) est une équipe sud-coréenne de renom dans l'esport, célèbre pour son héritage légendaire dans le jeu League of Legends, ayant remporté plusieurs championnats du monde et incarnant l'excellence, la stratégie et la domination dans l'esport.",
                            IdParent = 2,
                            ImgFile = "LogoT1.png",
                            Location = "South Korea",
                            MontantGagnee = 6863823m,
                            Nom = "T1",
                            PossedeSite = true,
                            Region = "Korea",
                            Site = "t1.gg"
                        },
                        new
                        {
                            Id = 7,
                            Abbreviation = "FQ",
                            AnneCreation = 2017,
                            Description = "FlyQuest est une équipe esport américaine engagée dans la durabilité environnementale, qui se distingue non seulement par ses performances compétitives dans les jeux tels que League of Legends, mais aussi par son engagement en faveur de l'action sociale et de l'impact positif sur la planète.",
                            IdParent = 2,
                            ImgFile = "LogoFlyQuest.png",
                            Location = "United States",
                            MontantGagnee = 236725m,
                            Nom = "Fly Quest",
                            PossedeSite = false,
                            Region = "North America",
                            Site = "None"
                        },
                        new
                        {
                            Id = 8,
                            Abbreviation = "JDG",
                            AnneCreation = 2017,
                            Description = "L'équipe JDG (JD Gaming) est une équipe esport chinoise de premier plan, réputée pour ses performances exceptionnelles dans des jeux tels que League of Legends, avec un roster talentueux et une approche stratégique qui les a propulsés vers de nombreux succès et titres.",
                            IdParent = 2,
                            ImgFile = "LogoJdg.png",
                            Location = "China",
                            MontantGagnee = 1776065m,
                            Nom = "JD Gaming",
                            PossedeSite = false,
                            Region = "China",
                            Site = "None"
                        },
                        new
                        {
                            Id = 9,
                            Abbreviation = "NaVi",
                            AnneCreation = 2009,
                            Description = "L'équipe Na'Vi, emblème indomptable de l'eSport, fusionne la précision millimétrée de leurs stratégies avec la fougue intense de leurs joueurs pour défier les limites du possible et incarner la grandeur du jeu vidéo compétitif.",
                            IdParent = 3,
                            ImgFile = "LogoNavi.png",
                            Location = "Ukraine",
                            MontantGagnee = 9522791m,
                            Nom = "Natus Vincere",
                            PossedeSite = true,
                            Region = "Europe",
                            Site = "navi.gg"
                        },
                        new
                        {
                            Id = 10,
                            Abbreviation = "mibr",
                            AnneCreation = 2018,
                            Description = "L'équipe MIBR, portant fièrement les couleurs du Brésil, allie habilement le talent brut de ses joueurs à une coordination implacable, propulsant ainsi leur gameplay vers des sommets vertigineux et faisant vibrer les fans du monde entier.",
                            IdParent = 3,
                            ImgFile = "LogoMibr.png",
                            Location = "United States / Brésil",
                            MontantGagnee = 2071519m,
                            Nom = "MIBR",
                            PossedeSite = false,
                            Region = "North America",
                            Site = "None"
                        },
                        new
                        {
                            Id = 11,
                            Abbreviation = "VIT",
                            AnneCreation = 2012,
                            Description = "La Team Vitality est une équipe emblématique de l'e-sport qui brille par son talent, sa passion et sa détermination, repoussant constamment les limites pour atteindre l'excellence.",
                            IdParent = 3,
                            ImgFile = "LogoVitality.png",
                            Location = "France",
                            MontantGagnee = 3477705m,
                            Nom = "Team Vitality",
                            PossedeSite = true,
                            Region = "Europe",
                            Site = "vitality.gg"
                        },
                        new
                        {
                            Id = 12,
                            Abbreviation = "FURIA",
                            AnneCreation = 2017,
                            Description = "La Team FURIA Esports incarne la fureur compétitive, alliant agressivité, stratégie et dynamisme pour faire trembler ses adversaires sur la scène de l'e-sport.",
                            IdParent = 3,
                            ImgFile = "LogoFuria.png",
                            Location = "Brazil / United States",
                            MontantGagnee = 1618275m,
                            Nom = "FURIA Esports",
                            PossedeSite = false,
                            Region = "North America",
                            Site = "None"
                        });
                });

            modelBuilder.Entity("ProjetSessionHL.Models.Joueur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Game")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Joueurs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 21,
                            Game = "Valorant",
                            Name = "rapId"
                        },
                        new
                        {
                            Id = 2,
                            Age = 22,
                            Game = "Valorant",
                            Name = "s0m"
                        },
                        new
                        {
                            Id = 3,
                            Age = 27,
                            Game = "League of Legends",
                            Name = "faker"
                        },
                        new
                        {
                            Id = 4,
                            Age = 30,
                            Game = "Counter-Strike: Global Offensive",
                            Name = "s1mple"
                        },
                        new
                        {
                            Id = 5,
                            Age = 16,
                            Game = "Rocket League",
                            Name = "zen"
                        });
                });

            modelBuilder.Entity("ProjetSessionHL.Models.Parent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Coaches")
                        .HasColumnType("int");

                    b.Property<int>("Courses")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ImgFile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgFileEquipe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Lessons")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Parents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Coaches = 15,
                            Courses = 6,
                            Description = "Bienvenue dans le monde de Valorant, un jeu de tir tactique COMPÉTITIF où l'équilibre entre stratégie et précision est la clé de la victoire.Préparez - vous à plonger dans un UNIVERS FUTURISTE!",
                            ImgFile = "ImageValorant.png",
                            ImgFileEquipe = "ImageValorantEquipe.png",
                            Lessons = 54,
                            Nom = "Valorant"
                        },
                        new
                        {
                            Id = 2,
                            Coaches = 30,
                            Courses = 29,
                            Description = "League of Legends est un jeu en ligne multijoueur compétitif où deux équipes s'affrontent pour détruire la base adverse à travers des affrontements stratégiques et des mécaniques de jeu variées.",
                            ImgFile = "ImageLol.png",
                            ImgFileEquipe = "ImageLolEquipe.png",
                            Lessons = 519,
                            Nom = "League of Legends"
                        },
                        new
                        {
                            Id = 3,
                            Coaches = 6,
                            Courses = 5,
                            Description = "Counter-Strike: Global Offensive (CS: GO) est un jeu de tir à la première personne en ligne où les joueurs s'affrontent dans des équipes en utilisant des armes tactiques.",
                            ImgFile = "ImageCsgo.png",
                            ImgFileEquipe = "ImageCsgoEquipe.png",
                            Lessons = 102,
                            Nom = "CSGO"
                        });
                });

            modelBuilder.Entity("ProjetSessionHL.Models.StatistiquesDonnees", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("AccountsCreated")
                        .HasColumnType("int");

                    b.Property<int>("GoalsScoredTeam")
                        .HasColumnType("int");

                    b.Property<int>("GoalsZenTotal")
                        .HasColumnType("int");

                    b.Property<int>("Loses")
                        .HasColumnType("int");

                    b.Property<string>("Mois")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RatingZenTotal")
                        .HasColumnType("int");

                    b.Property<int>("SavesMadeTeam")
                        .HasColumnType("int");

                    b.Property<int>("ScoreZenTotal")
                        .HasColumnType("int");

                    b.Property<int>("ShotsZenTotal")
                        .HasColumnType("int");

                    b.Property<int>("VisitsToWebsite")
                        .HasColumnType("int");

                    b.Property<int>("Wins")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("StatistiquesDonnees");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AccountsCreated = 750,
                            GoalsScoredTeam = 51,
                            GoalsZenTotal = 17,
                            Loses = 5,
                            Mois = "Sep",
                            RatingZenTotal = 28,
                            SavesMadeTeam = 122,
                            ScoreZenTotal = 10244,
                            ShotsZenTotal = 89,
                            VisitsToWebsite = 10,
                            Wins = 20
                        },
                        new
                        {
                            ID = 2,
                            AccountsCreated = 750,
                            GoalsScoredTeam = 51,
                            GoalsZenTotal = 17,
                            Loses = 5,
                            Mois = "Oct",
                            RatingZenTotal = 28,
                            SavesMadeTeam = 122,
                            ScoreZenTotal = 10244,
                            ShotsZenTotal = 89,
                            VisitsToWebsite = 30,
                            Wins = 20
                        },
                        new
                        {
                            ID = 3,
                            AccountsCreated = 750,
                            GoalsScoredTeam = 51,
                            GoalsZenTotal = 17,
                            Loses = 5,
                            Mois = "Nov",
                            RatingZenTotal = 28,
                            SavesMadeTeam = 122,
                            ScoreZenTotal = 10244,
                            ShotsZenTotal = 89,
                            VisitsToWebsite = 40,
                            Wins = 20
                        },
                        new
                        {
                            ID = 4,
                            AccountsCreated = 750,
                            GoalsScoredTeam = 51,
                            GoalsZenTotal = 17,
                            Loses = 5,
                            Mois = "Dec",
                            RatingZenTotal = 28,
                            SavesMadeTeam = 122,
                            ScoreZenTotal = 10244,
                            ShotsZenTotal = 89,
                            VisitsToWebsite = 60,
                            Wins = 20
                        },
                        new
                        {
                            ID = 5,
                            AccountsCreated = 750,
                            GoalsScoredTeam = 51,
                            GoalsZenTotal = 17,
                            Loses = 5,
                            Mois = "Jan",
                            RatingZenTotal = 28,
                            SavesMadeTeam = 122,
                            ScoreZenTotal = 10244,
                            ShotsZenTotal = 89,
                            VisitsToWebsite = 50,
                            Wins = 20
                        },
                        new
                        {
                            ID = 6,
                            AccountsCreated = 750,
                            GoalsScoredTeam = 51,
                            GoalsZenTotal = 17,
                            Loses = 5,
                            Mois = "Feb",
                            RatingZenTotal = 28,
                            SavesMadeTeam = 122,
                            ScoreZenTotal = 10244,
                            ShotsZenTotal = 89,
                            VisitsToWebsite = 30,
                            Wins = 20
                        },
                        new
                        {
                            ID = 7,
                            AccountsCreated = 750,
                            GoalsScoredTeam = 51,
                            GoalsZenTotal = 17,
                            Loses = 5,
                            Mois = "Mar",
                            RatingZenTotal = 28,
                            SavesMadeTeam = 122,
                            ScoreZenTotal = 10244,
                            ShotsZenTotal = 89,
                            VisitsToWebsite = 70,
                            Wins = 20
                        },
                        new
                        {
                            ID = 8,
                            AccountsCreated = 750,
                            GoalsScoredTeam = 51,
                            GoalsZenTotal = 17,
                            Loses = 5,
                            Mois = "Apr",
                            RatingZenTotal = 28,
                            SavesMadeTeam = 122,
                            ScoreZenTotal = 10244,
                            ShotsZenTotal = 89,
                            VisitsToWebsite = 10,
                            Wins = 20
                        },
                        new
                        {
                            ID = 9,
                            AccountsCreated = 750,
                            GoalsScoredTeam = 51,
                            GoalsZenTotal = 17,
                            Loses = 5,
                            Mois = "May",
                            RatingZenTotal = 28,
                            SavesMadeTeam = 122,
                            ScoreZenTotal = 10244,
                            ShotsZenTotal = 89,
                            VisitsToWebsite = 40,
                            Wins = 20
                        },
                        new
                        {
                            ID = 10,
                            AccountsCreated = 750,
                            GoalsScoredTeam = 51,
                            GoalsZenTotal = 17,
                            Loses = 5,
                            Mois = "Jun",
                            RatingZenTotal = 28,
                            SavesMadeTeam = 122,
                            ScoreZenTotal = 10244,
                            ShotsZenTotal = 89,
                            VisitsToWebsite = 20,
                            Wins = 20
                        },
                        new
                        {
                            ID = 11,
                            AccountsCreated = 750,
                            GoalsScoredTeam = 51,
                            GoalsZenTotal = 17,
                            Loses = 5,
                            Mois = "Jul",
                            RatingZenTotal = 28,
                            SavesMadeTeam = 122,
                            ScoreZenTotal = 10244,
                            ShotsZenTotal = 89,
                            VisitsToWebsite = 10,
                            Wins = 20
                        },
                        new
                        {
                            ID = 12,
                            AccountsCreated = 750,
                            GoalsScoredTeam = 51,
                            GoalsZenTotal = 17,
                            Loses = 5,
                            Mois = "Aug",
                            RatingZenTotal = 28,
                            SavesMadeTeam = 122,
                            ScoreZenTotal = 10244,
                            ShotsZenTotal = 89,
                            VisitsToWebsite = 40,
                            Wins = 20
                        });
                });

            modelBuilder.Entity("ProjetSessionHL.Models.Tournoi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<float>("PrizePool")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Tournois");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = "Paris, France",
                            Name = "Paris Games Week 2023",
                            PrizePool = 700000f
                        },
                        new
                        {
                            Id = 2,
                            Location = "New York¸ USA",
                            Name = "Twitch Con",
                            PrizePool = 1500000f
                        },
                        new
                        {
                            Id = 3,
                            Location = "Montréal, Canada",
                            Name = "Game Convention",
                            PrizePool = 1000000f
                        });
                });

            modelBuilder.Entity("JoueurTournoi", b =>
                {
                    b.HasOne("ProjetSessionHL.Models.Joueur", null)
                        .WithMany()
                        .HasForeignKey("JoueursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetSessionHL.Models.Tournoi", null)
                        .WithMany()
                        .HasForeignKey("TournoisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjetSessionHL.Models.Enfant", b =>
                {
                    b.HasOne("ProjetSessionHL.Models.Parent", "Parent")
                        .WithMany("Enfants")
                        .HasForeignKey("IdParent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("ProjetSessionHL.Models.Parent", b =>
                {
                    b.Navigation("Enfants");
                });
#pragma warning restore 612, 618
        }
    }
}
