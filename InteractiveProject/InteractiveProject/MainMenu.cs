using Interactive_Saga;

public class MainMenu
{
    MessageHelper messageHelper = new();

    public void RunMenu()
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
                    if(/*user.NumberOfCorrectAnswers < 5*/)
                    {
                        //levelOne.RunLevelOne();
                    }
                    else if (/*user.NumberOfCorrectAnswers =5 && user.NumberOfCorrectAnswers < 10*/)
                    {
                        //levelTwo.RunLevelTwo();
                    }
                    else
                    {
                        // levelThree.RunLevelThree();
                    }
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