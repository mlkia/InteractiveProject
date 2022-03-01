using Microsoft.VisualStudio.TestTools.UnitTesting;
using InteractiveProject.Helper;
using Interactive_Saga;
using InteractiveProject;

namespace InteractiveProject.Tests
{
    [TestClass()]
    public class Character1Tests
    {            
        [TestMethod()] public void GenerateQuestion_Test() 
        {
            // Arrange
            Character character = new Character();
            CharacterQuestion charQ = new();
            User player = new User();
            Crossroad cross = new Crossroad();
            Level_1 lev1 = new Level_1();
            Level_2 lev2 = new Level_2();
            Level_3 lev3 = new Level_3();
            MessageHelper messH = new MessageHelper();
            MainMenu menu = new MainMenu();

            QuestionHelper qHelp = new QuestionHelper();
            qHelp.GenerateQuestion(character, charQ, player, cross, qHelp, lev1, lev2, lev3, messH, menu);

            // Act
            bool result = GenerateQuestion(); // true
            
            // Assert
            Assert.AreEqual(result, true); // true, true = testet ska bli grönt
        }

        [TestMethod()] public void AskQuestion_Test() { }

        [TestMethod()] public void GiveClueOption_Test() { }

        [TestMethod()] public void AnswerQuestion_Test() { }

        [TestMethod()] public void CorrectAnswer_Test() { }

        [TestMethod()] public void InCorrectAnswer_Test() { }

        [TestMethod()] public void SeeMenu_Test() { }

        [TestMethod()] public void RunLevelOne_Test() { }

        [TestMethod()] public void RunLevelTwo_Test() { }

        [TestMethod()] public void RunLevelThree_Test() { }
    }
}