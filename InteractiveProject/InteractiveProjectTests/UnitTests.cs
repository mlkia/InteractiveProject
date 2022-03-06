using Microsoft.VisualStudio.TestTools.UnitTesting;
using InteractiveProject.Helper;
using Interactive_Saga;
using InteractiveProject;


namespace InteractiveProject.Tests
{
    [TestClass()]
    public class Character1Tests
    {
        #region QuestionHelper tests.
        [TestMethod()] public void GenerateQuestionHandleRightAnswer() 
        {
            // Arrange
            UserHelper.CreateUser("TestUser");
            CharacterHelper.SetupCharacters();
            var character = CharacterHelper.GetCharacter(UserHelper.CurrentUser.Level);

            TestHelper.GiveCorrectAnswer = true;

            // Act
            QuestionHelper.GenerateQuestion(character); // true
            
            // Assert
            Assert.AreEqual(UserHelper.CurrentUser.NumberOfCorrectAnswers, 1); // true, true = testet ska bli grönt
        }

        //[TestMethod()] public void AskQuestion_Test() 
        //{
        //    // A

        //    Character character = new Character();
        //    User player = new User();
        //    // A
        //    bool result = QuestionHelper.AskQuestion(character, player);

        //    // A
        //    Assert.AreEqual(result, true);
        //}

        //[TestMethod()] public void GiveClueOption_Test()
        //{
        //    Character character = new Character();
        //    User player = new User();


        //    bool result = QuestionHelper.GiveClueOption(character, player);// charq, char, user, cr, qh, lev123, messh, menu

        //    Assert.AreEqual(result, true);
        //}

        //[TestMethod()] public void AnswerQuestion_Test()
        //{

        //    Character character = new Character();
        //    User player = new User();


        //    bool result = QuestionHelper.AnswerQuestion(character, player);

        //    Assert.AreEqual(result, true);
        //}

        //[TestMethod()] public void CorrectAnswer_Test()
        //{
        //    Character character = new Character();
        //    User player = new User();

        //    bool result = QuestionHelper.CorrectAnswer(character, player);

        //    Assert.AreEqual(result, true);
        //}

        //[TestMethod()] public void InCorrectAnswer_Test()
        //{

        //    Character character = new Character();
        //    User player = new User();
        

        //    bool result = QuestionHelper.IncorrectAnswer(character, player);

        //    Assert.AreEqual(result, true);
        //}

        //[TestMethod()] public void SeeMenu_Test()
        //{

        //    Character character = new Character();
        //    CharacterQuestion charQ = new();
        //    bool result = QuestionHelper.SeeMenu();

        //    Assert.AreEqual(result, true);
        //}
        //#endregion QuestionHelper tests.

        //#region LevelTests (includes characters as return type)
        //[TestMethod()] public void RunLevelOne_Test()
        //{
        //    Character testRabbit = new Character();
        //    Character rabbit = Level_1.RunLevel1();

        //    Assert.AreEqual(rabbit, testRabbit);
        //}
        #endregion LevelTests
    }
} 