using Interactive_Saga;
using InteractiveProject;
using InteractiveProject.Helper;

public class MainMenu
{
    public void RunMenu(CharacterQuestion characterQuestion, User user, Level_1 level_1, Level_2 level_2, Level_3 level_3,
        Character character, MessageHelper messageHelper, QuestionHelper questionHelper)
    {
        bool runMenu = true;
        while (runMenu)
        {
            messageHelper.MainMenuMessage();

            

            int menuInputInt = 0;
            int.TryParse(userMenuInput, out menuInputInt);

            switch (menuInputInt)
            {
                case 1:
                   
                    if (user.NumberOfCorrectAnswers < 5)
                    {
                        level_1.RunLevelOne(character, user);
                    }
                    else if (user.NumberOfCorrectAnswers == 5 && user.NumberOfCorrectAnswers < 10)
                    {
                        level_2.RunLevelTwo(character, user);
                    }
                    else
                    {
                        level_3.RunLevelThree(character, user);
                    }
                    break;

                case 2:
                    
                    user.ShowStats();
                    break;

                case 3:
                   
                    messageHelper.RulesOfGame();
                    mainMenu.RunMenu(characterQuestion, user, level_1, level_2, level_3, character, messageHelper, questionHelper);
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