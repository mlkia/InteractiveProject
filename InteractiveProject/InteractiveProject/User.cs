using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public void ShowStates()
        {
            Console.WriteLine("Name:     " + UserName); //kommer ifr�n MessageHelper
            Console.WriteLine("You have: " + NumberOfCorrectAnswers + " Right answers"); //kommer ifr�n Character
            Console.WriteLine("You have: " + NumberOfWrongAnswers + " Wrong answers"); //kommer ifr�n Character
            Console.WriteLine("You have:    " + Diamonds + " Diamonds"); //kommer ifr�n Character
            Console.WriteLine("You have:    " + Key + " Key"); //kommer ifr�n LevelOne, LevelTwo, LevelThree
            Console.WriteLine("You are in Level:      " + Level + "/3"); //kommer ifr�n LevelOne, LevelTwo, LevelThree
        }
    }
}
