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
            Console.WriteLine("Name:     " + UserName); 
            Console.WriteLine("You have: " + NumberOfCorrectAnswers + " Right answers"); 
            Console.WriteLine("You have: " + NumberOfWrongAnswers + " Wrong answers");
            Console.WriteLine("You have:    " + Diamonds + " Diamonds"); 
            Console.WriteLine("You have:    " + Key + " Key"); 
            Console.WriteLine("You are in Level:      " + Level + "/3"); 
            Console.ReadKey();
        }
    }
}