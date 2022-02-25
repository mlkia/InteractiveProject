namespace InteractiveProject
{
    public class User
    {
        public string UserName { get; set; } = "";
        public int Diamonds { get; set; } = 0;
        public int NumberOfCorrectAnswers { get; set; } = 0;
        public int NumberOfWrongAnswers { get; set; } = 0;
        public int Level { get; set; } = 1;
        public int Key { get; set; } = 0;

        public void ShowStats()
        {
            Console.WriteLine("Name:     " + UserName); //kommer ifrån MessageHelper
            Console.WriteLine("You have: " + NumberOfCorrectAnswers + " Right answers"); //kommer ifrån Character
            Console.WriteLine("You have: " + NumberOfWrongAnswers + " Wrong answers"); //kommer ifrån Character
            Console.WriteLine("You have:    " + Diamonds + " Diamonds"); //kommer ifrån Character
            Console.WriteLine("You have:    " + Key + " Key"); //kommer ifrån LevelOne, LevelTwo, LevelThree
            Console.WriteLine("You are in Level:      " + Level + "/3"); //kommer ifrån LevelOne, LevelTwo, LevelThree
            Console.ReadKey();
        }
    }
}