using Interactive_Saga;
using InteractiveProject;
using InteractiveProject.Helper;

public class MainMenu
{
    public void RunMenu(User user, Level_1 level_1, Level_2 level_2, Level_3 level_3,
        Character character, Crossroad crossroad, MainMenu mainMenu, MessageHelper messageHelper, QuestionHelper questionHelper)
    {
        bool runMenu = true;
        while (runMenu)
        {
            messageHelper.MainMenuMessage();

            string userMenuInput = Console.ReadLine();

            int menuInputInt = 0;
            int.TryParse(userMenuInput, out menuInputInt);

            switch (menuInputInt)
            {
                case 1:
                    Console.Clear();
                    if (user.NumberOfCorrectAnswers < 5)
                    {
                        level_1.RunLevelOne(character, user, level_2, crossroad, level_3, messageHelper, mainMenu, questionHelper);
                    }
                    else if (user.NumberOfCorrectAnswers == 5 && user.NumberOfCorrectAnswers < 10)
                    {
                        level_2.RunLevelTwo(character, user, level_3, crossroad, messageHelper, mainMenu, questionHelper);
                    }
                    else
                    {
                        level_3.RunLevelThree(character, user, crossroad, messageHelper, mainMenu, questionHelper);
                    }
                    break;

                case 2:
                    Console.Clear();
                    user.ShowStats();
                    break;

                case 3:
                    Console.Clear();
                    messageHelper.RulesOfGame();
                    mainMenu.RunMenu(user, level_1, level_2, level_3, character, crossroad, mainMenu, messageHelper, questionHelper);
                    break;

                case 4:
                    runMenu = false;
                    break;

                default:
                    messageHelper.MenuErrorMessage();
                    Console.ReadKey();
                    break;
            }
        }
    }
}