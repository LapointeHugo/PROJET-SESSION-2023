using Castle.Core.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Moq;
using ProjetSessionHL.Controllers;
using ProjetSessionHL.Models;
using ProjetSessionHL.Services;
using ProjetSessionHL.ViewModels;
using System;
using System.Formats.Asn1;

namespace ProjetSession_Tests
{
    public class GestionEnfantController_Tests
    { 
        private Mock<ILogger> _gestionEnfantLogger_Mock;
        private Mock<IParentService> _parentService_Mock;
        private Mock<IStringLocalizer<GestionEnfantController>> _stringLoccalizer_Mock;
        private GestionEnfantController _gestionEnfantController;

        public GestionEnfantController_Tests()
        { 
            _gestionEnfantLogger_Mock = new Mock<ILogger>();
            _parentService_Mock = new Mock<IParentService>();
            _stringLoccalizer_Mock = new Mock<IStringLocalizer<GestionEnfantController>>();
            //_gestionEnfantController = new GestionEnfantController(_gestionEnfantLogger_Mock.Object, _stringLoccalizer_Mock.Object, _parentService_Mock.Object);
        }

        [Fact]
        public async Task Create_ModelValid()
        {
            // Arrange
            var enfant = new Enfant()
            {
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
            };

            var vm = new EnfantVM<Enfant>()
            {
                IsCreate = true,
                Id = 1,
                Entity = enfant,
                SelectLists = null
            };

            //// Act
            //var result = await _gestionEnfantController.Create(vm);

            ////// Assert
            //Assert.IsType<RedirectToActionResult>(result);
            //Assert.IsType("Index", result.ViewName);
        }
    }
}