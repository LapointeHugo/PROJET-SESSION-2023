﻿using ProjetSessionHL.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetSessionHL.Data
{
    public static class ModelBuilderDataGenerator
    {
        public static void GenerateData(this ModelBuilder builder)
        {
            #region Données pour Enfant
            builder.Entity<Enfant>().HasData(new Enfant() {
                Id = 1,
                IdParent = 1,
                ImgFile = "LogoFnatic.png",
                Nom = "Fnatic",
                Description = "Fnatic est une célèbre organisation esportive mondiale qui a remporté de nombreux" +
                " titres et compétitions dans différents jeux, notamment League of Legends et Counter-Strike: Global" +
                " Offensive, Valorant, et qui est reconnue pour son excellence et son engagement envers l'esport.",
                Location = "United Kingdom",
                PossedeSite = true,
                Site = "fnatic.com",
                AnneCreation = 2004,
                Region = "Europe",
                Abbreviation = "FNC",
                MontantGagnee = 914634
            });
            builder.Entity<Enfant>().HasData(new Enfant() {
                Id = 2,
                IdParent = 1,
                ImgFile = "LogoC9.png",
                Nom = "Cloud 9",
                Description = "Cloud9 est une organisation esportive américaine de renom, englobant divers jeux" +
                " compétitifs, qui a acquis une réputation mondiale grâce à ses performances exceptionnelles et à" +
                " ses victoires mémorables dans des titres tels que League of Legends, Counter-Strike: Global Offensive" +
                " et bien d'autres.",
                Location = "United States",
                PossedeSite = true,
                Site = "cloud9.gg",
                AnneCreation = 2013,
                Region = "North America",
                Abbreviation = "C9",
                MontantGagnee = 247800
            });
            builder.Entity<Enfant>().HasData(new Enfant() {
                Id = 3,
                IdParent = 1,
                ImgFile = "LogoTL.png",
                Nom = "Team Liquid",
                Description = "Team Liquid est une organisation esportive influente et prolifique qui excelle dans" +
                " plusieurs jeux compétitifs et qui est reconnue pour son professionnalisme sa détermination et ses" +
                " résultats impressionnants, notamment dans des titres tels que Dota 2, League of Legends et Counter -" +
                " Strike: Global Offensive.",
                Location = "United States / Netherlands",
                PossedeSite = true,
                Site = "teamliquid.com",
                AnneCreation = 2000,
                Region = "Europe",
                Abbreviation = "TL",
                MontantGagnee = 534029
            });
            builder.Entity<Enfant>().HasData(new Enfant() {
                Id = 4,
                IdParent = 1,
                ImgFile = "LogoFPX.png",
                Nom = "FunPlus Phoenix",
                Description = "FPX (FunPlus Phoenix) est une équipe chinoise d'esport remarquable, connue pour sa" +
                " domination dans le jeu League of Legends, ayant remporté le championnat du monde en 2019 et impressionnant" +
                " les spectateurs par leur jeu agressif et coordonné.",
                Location = "China / Europe",
                PossedeSite = false,
                Site = "None",
                AnneCreation = 2017,
                Region = "Europe",
                Abbreviation = "FPX",
                MontantGagnee = 482291
            });
            builder.Entity<Enfant>().HasData(new Enfant() {
                Id = 5,
                IdParent = 2,
                ImgFile = "LogoNrg.png",
                Nom = "Nrg Esports",
                Description = "NRG Esports est une organisation esportive dynamique et diversifiée, qui excelle dans une" +
                " variété de jeux compétitifs, en investissant dans des talents prometteurs et en démontrant une passion" +
                " inébranlable pour la compétition et l'innovation.",
                Location = "United States",
                PossedeSite = true,
                Site = "nrg.gg",
                AnneCreation = 2015,
                Region = "North America",
                Abbreviation = "NRG",
                MontantGagnee = 0
            });
            builder.Entity<Enfant>().HasData(new Enfant() {
                Id = 6,
                IdParent = 2,
                ImgFile = "LogoT1.png",
                Nom = "T1",
                Description = "T1 (anciennement SK Telecom T1) est une équipe sud-coréenne de renom dans l'esport, célèbre" +
                " pour son héritage légendaire dans le jeu League of Legends, ayant remporté plusieurs championnats du" +
                " monde et incarnant l'excellence, la stratégie et la domination dans l'esport.",
                Location = "South Korea",
                PossedeSite = true,
                Site = "t1.gg",
                AnneCreation = 2002,
                Region = "Korea",
                Abbreviation = "T1",
                MontantGagnee = 6863823
            });
            builder.Entity<Enfant>().HasData(new Enfant() {
                Id = 7,
                IdParent = 2,
                ImgFile = "LogoFlyQuest.png",
                Nom = "Fly Quest",
                Description = "FlyQuest est une équipe esport américaine engagée dans la durabilité environnementale," +
                " qui se distingue non seulement par ses performances compétitives dans les jeux tels que League of Legends," +
                " mais aussi par son engagement en faveur de l'action sociale et de l'impact positif sur la planète.",
                Location = "United States",
                PossedeSite = false,
                Site = "None",
                AnneCreation = 2017,
                Region = "North America",
                Abbreviation = "FQ",
                MontantGagnee = 236725
            });
            builder.Entity<Enfant>().HasData(new Enfant() {
                Id = 8,
                IdParent = 2,
                ImgFile = "LogoJdg.png",
                Nom = "JD Gaming",
                Description = "L'équipe JDG (JD Gaming) est une équipe esport chinoise de premier plan, réputée pour ses" +
                " performances exceptionnelles dans des jeux tels que League of Legends, avec un roster talentueux et une " +
                "approche stratégique qui les a propulsés vers de nombreux succès et titres.",
                Location = "China",
                PossedeSite = false,
                Site = "None",
                AnneCreation = 2017,
                Region = "China",
                Abbreviation = "JDG",
                MontantGagnee = 1776065
            });
            builder.Entity<Enfant>().HasData(new Enfant() {
                Id = 9,
                IdParent = 3,
                ImgFile = "LogoNavi.png",
                Nom = "Natus Vincere",
                Description = "L'équipe Na'Vi, emblème indomptable de l'eSport, fusionne la précision millimétrée de leurs" +
                " stratégies avec la fougue intense de leurs joueurs pour défier les limites du possible et incarner la grandeur" +
                " du jeu vidéo compétitif.",
                Location = "Ukraine",
                PossedeSite = true,
                Site = "navi.gg",
                AnneCreation = 2009,
                Region = "Europe",
                Abbreviation = "NaVi",
                MontantGagnee = 9522791
            });
            builder.Entity<Enfant>().HasData(new Enfant() {
                Id = 10,
                IdParent = 3,
                ImgFile = "LogoMibr.png",
                Nom = "MIBR",
                Description = "L'équipe MIBR, portant fièrement les couleurs du Brésil, allie habilement le talent brut de ses " +
                "joueurs à une coordination implacable, propulsant ainsi leur gameplay vers des sommets vertigineux et faisant vibrer" +
                " les fans du monde entier.",
                Location = "United States / Brésil",
                PossedeSite = false,
                Site = "None",
                AnneCreation = 2018,
                Region = "North America",
                Abbreviation = "mibr",
                MontantGagnee = 2071519
            });
            builder.Entity<Enfant>().HasData(new Enfant() {
                Id = 11,
                IdParent = 3,
                ImgFile = "LogoVitality.png",
                Nom = "Team Vitality",
                Description = "La Team Vitality est une équipe emblématique de l'e-sport qui brille par son talent, sa passion" +
                " et sa détermination, repoussant constamment les limites pour atteindre l'excellence.",
                Location = "France",
                PossedeSite = true,
                Site = "vitality.gg",
                AnneCreation = 2012,
                Region = "Europe",
                Abbreviation = "VIT",
                MontantGagnee = 3477705
            });
            builder.Entity<Enfant>().HasData(new Enfant() {
                Id = 12,
                IdParent = 3,
                ImgFile = "LogoFuria.png",
                Nom = "FURIA Esports",
                Description = "La Team FURIA Esports incarne la fureur compétitive, alliant agressivité, stratégie et dynamisme pour faire" +
                " trembler ses adversaires sur la scène de l'e-sport.",
                Location = "Brazil / United States",
                PossedeSite = false,
                Site = "None",
                AnneCreation = 2017,
                Region = "North America",
                Abbreviation = "FURIA",
                MontantGagnee = 1618275
            });
            #endregion

            #region Données pour Parent
            builder.Entity<Parent>().HasData(new Parent() {
                Id = 1,
                Nom = "Valorant",
                Description = "Bienvenue dans le monde de Valorant, un jeu de tir tactique" +
                " COMPÉTITIF où l'équilibre entre stratégie et précision est la clé de la victoire.Préparez - vous à plonger dans un UNIVERS" +
                " FUTURISTE!",
                ImgFile = "ImageValorant.png",
                ImgFileEquipe = "ImageValorantEquipe.png",
                Courses = 6,
                Lessons = 54,
                Coaches = 15
            });
            builder.Entity<Parent>().HasData(new Parent() {
                Id = 2,
                Nom = "League of Legends",
                Description = "League of Legends est un jeu en ligne multijoueur" +
                " compétitif où deux équipes s'affrontent pour détruire la base adverse à travers des affrontements stratégiques et des" +
                " mécaniques de jeu variées.",
                ImgFile = "ImageLol.png",
                ImgFileEquipe = "ImageLolEquipe.png",
                Courses = 29,
                Lessons = 519,
                Coaches = 30
            });
            builder.Entity<Parent>().HasData(new Parent() {
                Id = 3,
                Nom = "CSGO",
                Description = "Counter-Strike: Global Offensive" +
                " (CS: GO) est un jeu de tir à la première personne en ligne où les joueurs s'affrontent dans des équipes en utilisant" +
                " des armes tactiques.",
                ImgFile = "ImageCsgo.png",
                ImgFileEquipe = "ImageCsgoEquipe.png",
                Courses = 5,
                Lessons = 102,
                Coaches = 6
            });
            #endregion

            #region Données pour Joueur
            builder.Entity<Joueur>().HasData(new Joueur() {
                Id = 1,
                Name = "rapId",
                Game = "Valorant",
                Age = 21
            });

            builder.Entity<Joueur>().HasData(new Joueur()
            {
                Id = 2,
                Name = "s0m",
                Game = "Valorant",
                Age = 22
            });

            builder.Entity<Joueur>().HasData(new Joueur()
            {
                Id = 3,
                Name = "faker",
                Game = "League of Legends",
                Age = 27
            });

            builder.Entity<Joueur>().HasData(new Joueur()
            {
                Id = 4,
                Name = "s1mple",
                Game = "Counter-Strike: Global Offensive",
                Age = 30
            });

            builder.Entity<Joueur>().HasData(new Joueur()
            {
                Id = 5,
                Name = "zen",
                Game = "Rocket League",
                Age = 16
            });

            #endregion

            #region Données pour Tournoi
            builder.Entity<Tournoi>().HasData(new Tournoi() {
                Id = 1,
                Name = "Paris Games Week 2023",
                Location = "Paris, France",
                PrizePool = 700000
            });

            builder.Entity<Tournoi>().HasData(new Tournoi()
            {
                Id = 2,
                Name = "Twitch Con",
                Location = "New York¸ USA",
                PrizePool = 1500000
            });

            builder.Entity<Tournoi>().HasData(new Tournoi()
            {
                Id = 3,
                Name = "Game Convention",
                Location = "Montréal, Canada",
                PrizePool = 1000000
            });

            #endregion

            #region Données pour Statistiques

            builder.Entity<StatistiquesDonnees>().HasData(new StatistiquesDonnees()
            {
                ID = 1,
                Mois = "Sep",
                VisitsToWebsite = 10,
                AccountsCreated = 750,
                Wins = 20,
                Loses = 5,
                GoalsScoredTeam = 51,
                SavesMadeTeam = 122,
                ScoreZenTotal = 10244,
                GoalsZenTotal = 17,
                ShotsZenTotal = 89,
                RatingZenTotal = 28,
            });

            builder.Entity<StatistiquesDonnees>().HasData(new StatistiquesDonnees()
            {
                ID = 2,
                Mois = "Oct",
                VisitsToWebsite = 30,
                AccountsCreated = 750,
                Wins = 20,
                Loses = 5,
                GoalsScoredTeam = 51,
                SavesMadeTeam = 122,
                ScoreZenTotal = 10244,
                GoalsZenTotal = 17,
                ShotsZenTotal = 89,
                RatingZenTotal = 28,
            });

            builder.Entity<StatistiquesDonnees>().HasData(new StatistiquesDonnees()
            {
                ID = 3,
                Mois = "Nov",
                VisitsToWebsite = 40,
                AccountsCreated = 750,
                Wins = 20,
                Loses = 5,
                GoalsScoredTeam = 51,
                SavesMadeTeam = 122,
                ScoreZenTotal = 10244,
                GoalsZenTotal = 17,
                ShotsZenTotal = 89,
                RatingZenTotal = 28,
            });

            builder.Entity<StatistiquesDonnees>().HasData(new StatistiquesDonnees()
            {
                ID = 4,
                Mois = "Dec",
                VisitsToWebsite = 60,
                AccountsCreated = 750,
                Wins = 20,
                Loses = 5,
                GoalsScoredTeam = 51,
                SavesMadeTeam = 122,
                ScoreZenTotal = 10244,
                GoalsZenTotal = 17,
                ShotsZenTotal = 89,
                RatingZenTotal = 28,
            });

            builder.Entity<StatistiquesDonnees>().HasData(new StatistiquesDonnees()
            {
                ID = 5,
                Mois = "Jan",
                VisitsToWebsite = 50,
                AccountsCreated = 750,
                Wins = 20,
                Loses = 5,
                GoalsScoredTeam = 51,
                SavesMadeTeam = 122,
                ScoreZenTotal = 10244,
                GoalsZenTotal = 17,
                ShotsZenTotal = 89,
                RatingZenTotal = 28,
            });

            builder.Entity<StatistiquesDonnees>().HasData(new StatistiquesDonnees()
            {
                ID = 6,
                Mois = "Feb",
                VisitsToWebsite = 30,
                AccountsCreated = 750,
                Wins = 20,
                Loses = 5,
                GoalsScoredTeam = 51,
                SavesMadeTeam = 122,
                ScoreZenTotal = 10244,
                GoalsZenTotal = 17,
                ShotsZenTotal = 89,
                RatingZenTotal = 28,
            });

            builder.Entity<StatistiquesDonnees>().HasData(new StatistiquesDonnees()
            {
                ID = 7,
                Mois = "Mar",
                VisitsToWebsite = 70,
                AccountsCreated = 750,
                Wins = 20,
                Loses = 5,
                GoalsScoredTeam = 51,
                SavesMadeTeam = 122,
                ScoreZenTotal = 10244,
                GoalsZenTotal = 17,
                ShotsZenTotal = 89,
                RatingZenTotal = 28,
            });

            builder.Entity<StatistiquesDonnees>().HasData(new StatistiquesDonnees()
            {
                ID = 8,
                Mois = "Apr",
                VisitsToWebsite = 10,
                AccountsCreated = 750,
                Wins = 20,
                Loses = 5,
                GoalsScoredTeam = 51,
                SavesMadeTeam = 122,
                ScoreZenTotal = 10244,
                GoalsZenTotal = 17,
                ShotsZenTotal = 89,
                RatingZenTotal = 28,
            });

            builder.Entity<StatistiquesDonnees>().HasData(new StatistiquesDonnees()
            {
                ID = 9,
                Mois = "May",
                VisitsToWebsite = 40,
                AccountsCreated = 750,
                Wins = 20,
                Loses = 5,
                GoalsScoredTeam = 51,
                SavesMadeTeam = 122,
                ScoreZenTotal = 10244,
                GoalsZenTotal = 17,
                ShotsZenTotal = 89,
                RatingZenTotal = 28,
            });

            builder.Entity<StatistiquesDonnees>().HasData(new StatistiquesDonnees()
            {
                ID = 10,
                Mois = "Jun",
                VisitsToWebsite = 20,
                AccountsCreated = 750,
                Wins = 20,
                Loses = 5,
                GoalsScoredTeam = 51,
                SavesMadeTeam = 122,
                ScoreZenTotal = 10244,
                GoalsZenTotal = 17,
                ShotsZenTotal = 89,
                RatingZenTotal = 28,
            });

            builder.Entity<StatistiquesDonnees>().HasData(new StatistiquesDonnees()
            {
                ID = 11,
                Mois = "Jul",
                VisitsToWebsite = 10,
                AccountsCreated = 750,
                Wins = 20,
                Loses = 5,
                GoalsScoredTeam = 51,
                SavesMadeTeam = 122,
                ScoreZenTotal = 10244,
                GoalsZenTotal = 17,
                ShotsZenTotal = 89,
                RatingZenTotal = 28,
            });

            builder.Entity<StatistiquesDonnees>().HasData(new StatistiquesDonnees()
            {
                ID = 12,
                Mois = "Aug",
                VisitsToWebsite = 40,
                AccountsCreated = 750,
                Wins = 20,
                Loses = 5,
                GoalsScoredTeam = 51,
                SavesMadeTeam = 122,
                ScoreZenTotal = 10244,
                GoalsZenTotal = 17,
                ShotsZenTotal = 89,
                RatingZenTotal = 28,
            });

            #endregion
        }
    }
}
