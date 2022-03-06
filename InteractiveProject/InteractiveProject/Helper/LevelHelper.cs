using Interactive_Saga;
using InteractiveProject.Helper;

namespace InteractiveProject
{
    public static class LevelHelper
    {
        public static void RunLevel()
        {
            var user = UserHelper.CurrentUser;
            if (user == null) return;

            while (true)
            {
                var character = CharacterHelper.GetCharacter(user.Level);
                if (character == null)
                {
                    MessageHelper.YouWinMessage(user);
                    return;
                }

                Crossroad.ChoosePath();
                if (Crossroad.CorrectAnswer == true)
                {
                    ConsoleHelper.ReadKey();
                    ConsoleHelper.Clear();
                    var seeMenu = QuestionHelper.GenerateQuestion(character);
                    if (seeMenu)
                        break;
                }
            }
        }
    }
}