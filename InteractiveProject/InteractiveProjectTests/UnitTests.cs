using Microsoft.VisualStudio.TestTools.UnitTesting;
using InteractiveProject.Helper;
using Interactive_Saga;
using InteractiveProject;


namespace InteractiveProject.Tests
{
    [TestClass()]
    public class Character1Tests
    {
        
        [TestMethod()] 
        public void GenerateQuestionHandleRightAnswer() 
        {
            // Arrange
            ConsoleHelper.IsTestMode=true;
            UserHelper.CreateUser("TestUser");
            CharacterHelper.SetupCharacters();
            var character = CharacterHelper.GetCharacter(UserHelper.CurrentUser.Level);

            TestHelper.GiveCorrectAnswer = true;

            // Act
            QuestionHelper.GenerateQuestion(character); // true
            
            // Assert
            Assert.AreEqual(UserHelper.CurrentUser.NumberOfCorrectAnswers, 1); // true, true = testet ska bli grönt
        }
        [TestMethod()]
        public void GenerateQuestionHandleWrongAnswer()
        {
            // Arrange
            ConsoleHelper.IsTestMode = true;
            UserHelper.CreateUser("TestUser");
            CharacterHelper.SetupCharacters();
            var character = CharacterHelper.GetCharacter(UserHelper.CurrentUser.Level);

            TestHelper.GiveCorrectAnswer = false;

            // Act
            QuestionHelper.GenerateQuestion(character); // true

            // Assert
            Assert.AreEqual(UserHelper.CurrentUser.NumberOfWrongAnswers, 1);
        }

        [TestMethod()]
        public void AskQuestion_Test()
        {
            // Arrange
            ConsoleHelper.IsTestMode = true;
            UserHelper.CreateUser("TestUser");
            CharacterHelper.SetupCharacters();
            var character = CharacterHelper.GetCharacter(UserHelper.CurrentUser.Level);

            // Act
            QuestionHelper.GenerateQuestion(character);
            QuestionHelper.AskQuestion(character);
            var question = character.SelectedQuestion;
            
            // Assert
            Assert.IsNotNull(question);
        }

        [TestMethod()]
        public void GiveClueOption_Test()
        {
            //Arrange
            var characterQuestion = new CharacterQuestion();
            UserHelper.CreateUser("TestUser");
            CharacterHelper.SetupCharacters();
            var character = CharacterHelper.GetCharacter(UserHelper.CurrentUser.Level);
            

            //Act
            QuestionHelper.GiveClueOption(character);// charq, char, user, cr, qh, lev123, messh, menu
            //Assert
            Assert.IsNotNull(character);
        }

        [TestMethod()]
        public void AnswerQuestion_Test()
        {
            ConsoleHelper.IsTestMode = true;
            Character character = new Character();


            bool result = QuestionHelper.AnswerQuestion(character);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void SeeMenu_Test()
        {
            ConsoleHelper.IsTestMode = true;
            TestHelper.ReturnToMenu = true;

            bool result = QuestionHelper.SeeMenu();

            Assert.IsTrue(result);
        }
    }
}