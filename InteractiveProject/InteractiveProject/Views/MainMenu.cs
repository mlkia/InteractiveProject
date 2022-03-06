using Interactive_Saga;
using InteractiveProject;
using InteractiveProject.Helper;

public static class MainMenu
{
    public static void RunMenu()
    {
        while (true)
        {
            MessageHelper.MainMenuMessage();

            string userMenuInput = ConsoleHelper.Read();

            int menuInputInt = 0;
            int.TryParse(userMenuInput, out menuInputInt);

            switch (menuInputInt)
            {
                case 1:
                    ConsoleHelper.Clear();
                    if (UserHelper.CurrentUser.Level == 4)
                    {
                       if(!MessageHelper.PlayAgain())
                        {
                            continue;
                        }
                        UserHelper.Reset();
                    }
                    LevelHelper.RunLevel();
                    continue;

                case 2:
                    ConsoleHelper.Clear();
                    UserHelper.CurrentUser?.ShowStats();
                    continue;

                case 3:
                    ConsoleHelper.Clear();
                    MessageHelper.RulesOfGame();
                    continue;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    MessageHelper.MenuErrorMessage();
                    ConsoleHelper.ReadKey();
                    break;
            }
        }
    }
}