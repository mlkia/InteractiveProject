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
            //bool result0 = GenerateQuestion();
            //bool result1 = qHelp.GenerateQuestion();

            bool result = qHelp.GenerateQuestion(character,charQ,player,cross,qHelp,lev1,lev2,lev3,messH,menu); // true
            
            // Assert
            Assert.AreEqual(result, true); // true, true = testet ska bli grönt
        }

        [TestMethod()] public void AskQuestion_Test() 
        {
            // A
            var qHelp = new QuestionHelper();

            Character character = new Character();
            CharacterQuestion charQ = new();
            User player = new User();
            Crossroad cross = new Crossroad();
            Level_1 lev1 = new Level_1();
            Level_2 lev2 = new Level_2();
            Level_3 lev3 = new Level_3();
            MessageHelper messH = new MessageHelper();
            MainMenu menu = new MainMenu();

            // A
            bool result = qHelp.AskQuestion(character, charQ, player, cross, qHelp, lev1, lev2, lev3, messH, menu);

            // A
            Assert.AreEqual(result, true);
        }

        [TestMethod()] public void GiveClueOption_Test()
        {
            var qHelp = new QuestionHelper();

            Character character = new Character();
            CharacterQuestion charQ = new();
            User player = new User();
            Crossroad cross = new Crossroad();
            Level_1 lev1 = new Level_1();
            Level_2 lev2 = new Level_2();
            Level_3 lev3 = new Level_3();
            MessageHelper messH = new MessageHelper();
            MainMenu menu = new MainMenu();

            bool result = qHelp.GiveClueOption(charQ, character, player, cross, qHelp, lev1, lev2, lev3, messH, menu);// charq, char, user, cr, qh, lev123, messh, menu

            Assert.AreEqual(result, true);
        }

        [TestMethod()] public void AnswerQuestion_Test()
        {
            var qHelp = new QuestionHelper();

            Character character = new Character();
            CharacterQuestion charQ = new();
            User player = new User();
            Crossroad cross = new Crossroad();
            Level_1 lev1 = new Level_1();
            Level_2 lev2 = new Level_2();
            Level_3 lev3 = new Level_3();
            MessageHelper messH = new MessageHelper();
            MainMenu menu = new MainMenu();

            bool result = qHelp.AnswerQuestion(character, charQ, player, cross, qHelp, lev1, lev2, lev3, messH, menu);

            Assert.AreEqual(result, true);
        }

        [TestMethod()] public void CorrectAnswer_Test()
        {
            var qHelp = new QuestionHelper();

            Character character = new Character();
            CharacterQuestion charQ = new();
            User player = new User();
            Crossroad cross = new Crossroad();
            Level_1 lev1 = new Level_1();
            Level_2 lev2 = new Level_2();
            Level_3 lev3 = new Level_3();
            MessageHelper messH = new MessageHelper();
            MainMenu menu = new MainMenu();

            bool result = qHelp.CorrectAnswer(character, charQ, player, cross, qHelp, menu, lev1, lev2, lev3, messH);

            Assert.AreEqual(result, true);
        }

        [TestMethod()] public void InCorrectAnswer_Test()
        {
            var qHelp = new QuestionHelper();

            Character character = new Character();
            CharacterQuestion charQ = new();
            User player = new User();
            Crossroad cross = new Crossroad();
            Level_1 lev1 = new Level_1();
            Level_2 lev2 = new Level_2();
            Level_3 lev3 = new Level_3();
            MessageHelper messH = new MessageHelper();
            MainMenu menu = new MainMenu();

            bool result = qHelp.IncorrectAnswer(character, charQ, player, cross, qHelp,  lev1, lev2, lev3, messH, menu);

            Assert.AreEqual(result, true);
        }

        [TestMethod()] public void SeeMenu_Test()
        {
            var qHelp = new QuestionHelper();

            Character character = new Character();
            CharacterQuestion charQ = new();
            User player = new User();
            Crossroad cross = new Crossroad();
            Level_1 lev1 = new Level_1();
            Level_2 lev2 = new Level_2();
            Level_3 lev3 = new Level_3();
            MessageHelper messH = new MessageHelper();
            MainMenu menu = new MainMenu();

            bool result = qHelp.SeeMenu(charQ, player, menu, cross, lev1, lev2, lev3, character, messH, qHelp);

            Assert.AreEqual(result, true);
        }

        #region LevelTests (includes characters as return type)
        [TestMethod()] public void RunLevelOne_Test()
        {
            var lev1 = new Level_1();
            Character testRabbit = new Character();

            Character rabbit = lev1.RunLevelOne();  // TODO: lägga till parametrar

            Assert.AreEqual(rabbit, testRabbit);
        }

        [TestMethod()] public void RunLevelTwo_Test()
        {
            var lev2 = new Level_1();
            Character testReindeer = new Character();

            Character reindeer = lev2.RunLevelOne();  // TODO: lägga till parametrar

            Assert.AreEqual(reindeer, testReindeer);
        }

        [TestMethod()] public void RunLevelThree_Test()
        {
            var lev3 = new Level_1();
            Character testIcequeen = new Character();

            Character icequeen = lev3.RunLevelOne();  // TODO: lägga till parametrar

            Assert.AreEqual(icequeen, testIcequeen);
        }
        #endregion LevelTests
    }
}