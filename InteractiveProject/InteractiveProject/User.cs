using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveProject
{
    internal class User
    {
        public string UserName { get; set; }
        public int Diamonds { get; set; }
        public int NumberOfCorrectAnswers { get; set; }
        public int NumberOfWrongAnswers { get; set; }
        public int Level { get; set; } = 1;
        public int Key{ get; set; }



        public void ShowStates()
        {
            var TheAnswers = new CharacterQuestion();

            //int[] numOfAnswers = new int[2];

            //numOfAnswers = TheAnswers.numOfAnswer();

            //NumberOfCorrectAnswers = numOfAnswers[0];
            //NumberOfWrongAnswers = numOfAnswers[1];


            Console.WriteLine("Name:     " + UserName);
            Console.WriteLine("You have: " + NumberOfCorrectAnswers + " Right answers");
            Console.WriteLine("You have: " + NumberOfWrongAnswers + " Wrong answers");
            Console.WriteLine("You have:    " + Diamonds + "Diamonds");
            Console.WriteLine("You are in Level:      " + Level + "/3");
        }
    }

}
}
