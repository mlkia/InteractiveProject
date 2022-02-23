using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveProject
{
    internal class User
    {
        public string UserName { get; set; } = "";
        public int Diamonds { get; set; } = 0;
        public int NumberOfCorrectAnswers { get; set; } = 0;
        public int NumberOfWrongAnswers { get; set; } = 0;
        public int Level { get; set; } = 1;
        public int Key { get; set; } = 0;



        public void ShowStates()
        {
            var Values = new CharacterQuestion();



            int[] TheValues = Values.CheckAnswer();

            

            //NumberOfCorrectAnswers = numOfAnswers[0];
            //NumberOfWrongAnswers = TheValues[1];



            Console.WriteLine("Name:     " + UserName);
            Console.WriteLine("You have: " + NumberOfCorrectAnswers + " Right answers");
            Console.WriteLine("You have: " + TheValues[1]+ " Wrong answers");
            Console.WriteLine("You have:    " + Diamonds + " Diamonds");
            Console.WriteLine("You are in Level:      " + Level + "/3");
        }
    }
}
