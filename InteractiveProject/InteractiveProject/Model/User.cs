using InteractiveProject.Helper;

namespace InteractiveProject
{
    public class User
    {
        public string UserName { get; set; } = "";
        public int Diamonds { get; set; }
        public int NumberOfCorrectAnswers { get; set; }
        public int NumberOfWrongAnswers { get; set; }
        public int Level { get; set; } = 1;
        public int Key { get; set; }

        public void ShowStats()
        {
            ConsoleHelper.Write("Name:     " + UserName); //kommer ifrån MessageHelper
            ConsoleHelper.Write("You have: " + NumberOfCorrectAnswers + " Right answers"); //kommer ifrån Character
            ConsoleHelper.Write("You have: " + NumberOfWrongAnswers + " Wrong answers"); //kommer ifrån Character
            ConsoleHelper.Write("You have:    " + Diamonds + " Diamonds"); //kommer ifrån Character
            ConsoleHelper.Write("You have:    " + Key + " Key"); //kommer ifrån LevelOne, LevelTwo, LevelThree
            ConsoleHelper.Write(Level == 4 ? "You have finished the game" : "You are in Level:      " + Level + "/3"); //kommer ifrån LevelOne, LevelTwo, LevelThree
            ConsoleHelper.ReadKey();
        }
    }
}