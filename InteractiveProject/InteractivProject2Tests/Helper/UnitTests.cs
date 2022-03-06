using Microsoft.VisualStudio.TestTools.UnitTesting;
using InteractiveProject.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveProject.Helper.Tests
{
    [TestClass()]
    public class UnitTests
    {
        [TestMethod()]
        public void GetCharacterQuestionTest()
        {
            UserHelper.CreateUser("TestUser");
            CharacterHelper.SetupCharacters();
            var character = CharacterHelper.GetCharacter(UserHelper.CurrentUser.Level);

            TestHelper.GiveCorrectAnswer = true;

            // Act
            QuestionHelper.GenerateQuestion(character); // true

            // Assert
            Assert.AreEqual(UserHelper.CurrentUser.NumberOfCorrectAnswers, 1);
        }
    }
}