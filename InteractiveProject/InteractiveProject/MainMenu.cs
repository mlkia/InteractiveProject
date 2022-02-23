using Interactive_Saga;

public class MainMenu
{
    MessageHelper messageHelper = new();

    public void RunMenu()
    {
        while (/* user.Level < 4 */ true) // så länge man inte hunnit vinna över alla 3 bossar
        {
            messageHelper.MainMenuMessage();

            string userMenuInput = Console.ReadLine();

            int menuInputInt = 0;
            int.TryParse(userMenuInput, out menuInputInt);

            switch (menuInputInt)
            {
                case 1:
                    Console.Clear();
                    // anropa RunGame();
                    break;

                case 2:
                    Console.Clear();
                    // user.ShowStats();
                    break;

                case 3:
                    Console.Clear();
                    messageHelper.RulesOfGame();
                    break;

                case 4:
                    // user.Level = 4;
                    break;

                default:
                    messageHelper.MenuErrorMessage();
                    Console.ReadKey();
                    break;
            }
        }
    }
}