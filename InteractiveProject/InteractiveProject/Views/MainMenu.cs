using Interactive_Saga;
using InteractiveProject;
using InteractiveProject.Helper;

public static class MainMenu
{
    public static void RunMenu(User user)
    {
        while (true)
        {
            MessageHelper.MainMenuMessage();

            string userMenuInput = Console.ReadLine();

            int menuInputInt = 0;
            int.TryParse(userMenuInput, out menuInputInt);

            switch (menuInputInt)
            {
                case 1:
                    Console.Clear();
                    Setup.Adventure();
                    continue;

                case 2:
                    Console.Clear();
                    user.ShowStats();
                    continue;

                case 3:
                    Console.Clear();
                    MessageHelper.RulesOfGame();
                    continue;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    MessageHelper.MenuErrorMessage();
                    Console.ReadKey();
                    break;
            }
        }
    }
}