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

        [TestMethod()] public void AskQuestion_Test() 
        {
            // A
            var qh = new QuestionHelper();

            // A
            bool result = AskQuestion();

            // A
            Assert.AreEqual(result, true);
        }

        [TestMethod()] public void GiveClueOption_Test()
        {
            var qh = new QuestionHelper();

            bool result = GiveClueOption();

            Assert.AreEqual(result, true);
        }

        [TestMethod()] public void AnswerQuestion_Test()
        {
            var qh = new QuestionHelper();

            bool result = AnswerQuestion();

            Assert.AreEqual(result, true);
        }

        [TestMethod()] public void CorrectAnswer_Test()
        {
            var qh = new QuestionHelper();

            bool result = CorrectAnswer();

            Assert.AreEqual(result, true);
        }

        [TestMethod()] public void InCorrectAnswer_Test()
        {
            var qh = new QuestionHelper();

            bool result = InCorrectAnswer();

            Assert.AreEqual(result, true);
        }

        [TestMethod()] public void SeeMenu_Test()
        {
            var qh = new QuestionHelper();

            bool result = SeeMenu();

            Assert.AreEqual(result, true);
        }

        #region LevelTests (includes characters as return type)
        [TestMethod()] public void RunLevelOne_Test()
        {
            var lev1 = new Level_1();
            Character testRabbit = new Character();

            Character rabbit = RunLevelOne();

            Assert.AreEqual(rabbit, testRabbit);
        }

        [TestMethod()] public void RunLevelTwo_Test()
        {
            var lev1 = new Level_1();
            Character testReindeer = new Character();

            Character reindeer = RunLevelOne();

            Assert.AreEqual(reindeer, testReindeer);
        }

        [TestMethod()] public void RunLevelThree_Test()
        {
            var lev1 = new Level_1();
            Character testIcequeen = new Character();

            Character icequeen = RunLevelOne();

            Assert.AreEqual(icequeen, testIcequeen);
        }
        #endregion LevelTests
    }
}