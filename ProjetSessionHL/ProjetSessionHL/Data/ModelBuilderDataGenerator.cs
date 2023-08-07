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

            #region Données pour Entraineur
            builder.Entity<Entraineur>().HasData(new Entraineur() {
                Id = 1,
                ImgFile = "Entraineur1(Valorant).jpg",
                Alias = "Ethan",
                FirstName = "Ethan",
                LastName = "Arnold",
                Email = "ethaneg@gmail.com",
                IdJeux = 1
            });
            builder.Entity<Entraineur>().HasData(new Entraineur() {
                Id = 2,
                ImgFile = "Entraineur2(Valorant).jpg",
                Alias = "FNS",
                FirstName = "Pujan",
                LastName = "Mehta",
                Email = "fnsnrg@gmail.com",
                IdJeux = 1
            });
            builder.Entity<Entraineur>().HasData(new Entraineur() {
                Id = 3,
                ImgFile = "Entraineur3(Lol).jpg",
                Alias = "Fudge",
                FirstName = "Ibrahim",
                LastName = "Allami",
                Email = "fudgec9@gmail.com",
                IdJeux = 2
            });
            builder.Entity<Entraineur>().HasData(new Entraineur() {
                Id = 4,
                ImgFile = "Entraineur4(Lol).jpg",
                Alias = "Caps",
                FirstName = "Rasmus",
                LastName = "Borregaard Wintherr",
                Email = "capsg2@gmail.com",
                IdJeux = 2
            });
            builder.Entity<Entraineur>().HasData(new Entraineur() {
                Id = 5,
                ImgFile = "Entraineur5(Csgo).jpg",
                Alias = "Twistzz",
                FirstName = "Russel",
                LastName = "Dulken",
                Email = "twistzzfaze@gmail.com",
                IdJeux = 3
            });
            builder.Entity<Entraineur>().HasData(new Entraineur() {
                Id = 6,
                ImgFile = "Entraineur6(Csgo).jpg",
                Alias = "s1mple",
                FirstName = "Oleksandr",
                LastName = "Kostyljev",
                Email = "s1mplenavi@gmail.com",
                IdJeux = 3
            });
            builder.Entity<Entraineur>().HasData(new Entraineur() {
                Id = 7,
                ImgFile = "Entraineur7(RL).jpg",
                Alias = "zen",
                FirstName = "Alexis",
                LastName = "Bernier",
                Email = "zenvitality@gmail.com",
                IdJeux = 4
            });
            builder.Entity<Entraineur>().HasData(new Entraineur() {
                Id = 8,
                ImgFile = "Entraineur8(RL).jpg",
                Alias = "Vatira",
                FirstName = "Axel",
                LastName = "Touret",
                Email = "vatirakc@gmail.com",
                IdJeux = 4
            });
            #endregion

            #region Données pour Jeux
            builder.Entity<Jeux>().HasData(new Jeux() {
                Id = 1,
                Nom = "Valorant",
                Description = "Bienvenue dans le monde de Valorant, un jeu de tir tactique" +
                " COMPÉTITIF où l'équilibre entre stratégie et précision est la clé de la victoire.Préparez - vous à plonger dans un UNIVERS" +
                " FUTURISTE!",
                ImgFile = "ImageValorant.png"
            });
            builder.Entity<Jeux>().HasData(new Jeux() {
                Id = 2,
                Nom = "League of Legends",
                Description = "League of Legends est un jeu en ligne multijoueur" +
                " compétitif où deux équipes s'affrontent pour détruire la base adverse à travers des affrontements stratégiques et des" +
                " mécaniques de jeu variées.",
                ImgFile = "ImageLol.png"
            });
            builder.Entity<Jeux>().HasData(new Jeux() {
                Id = 3,
                Nom = "CSGO",
                Description = "Counter-Strike: Global Offensive" +
                " (CS: GO) est un jeu de tir à la première personne en ligne où les joueurs s'affrontent dans des équipes en utilisant" +
                " des armes tactiques.",
                ImgFile = "ImageCsgo.png"
            });
            builder.Entity<Jeux>().HasData(new Jeux() {
                Id = 4,
                Nom = "Rocket League",
                Description = "Rocket League est un jeu vidéo mêlant football et course automobile où des joueurs contrôlent des voitures" +
                " pour marquer des buts.",
                ImgFile = "ImageRL.png"
            });
            #endregion
        }
    }
}
