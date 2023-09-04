using Moq;
using System;
using System.Formats.Asn1;

namespace ProjetSession_Tests
{
    public class GestionEnfantController_Tests
    {
        //private GestionEnfantController _gestionEnfantController;

        //public GestionEnfantController_Tests()
        //{
        //    _moviesEnfantController = new GestionEnfantController();
        //}

        [Fact]
        public async Task Create_ModelValid()
        {
            // Arrange
            //var vm = new Enfant()
            //{
            //    Id = 1,
            //    IdParent = 1,
            //    ImgFile = "LogoFnatic.png",
            //    Nom = "Fnatic",
            //    Description = "Fnatic est une célèbre organisation esportive mondiale qui a remporté de nombreux" +
            //    " titres et compétitions dans différents jeux, notamment League of Legends et Counter-Strike: Global" +
            //    " Offensive, Valorant, et qui est reconnue pour son excellence et son engagement envers l'esport.",
            //    Location = "United Kingdom",
            //    PossedeSite = true,
            //    Site = "fnatic.com",
            //    AnneCreation = 2004,
            //    Region = "Europe",
            //    Abbreviation = "FNC",
            //    MontantGagnee = 914634
            //};

            //// Act
            //var result = await _moviesEnfantController.Create(vm);

            //// Assert
            //Assert.IsType<RedirectToActionResult>(result);
            //Assert.AreEqual("Index", result.ViewName);
        }
    }
}