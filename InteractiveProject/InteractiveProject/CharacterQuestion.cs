using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveProject
{
    internal class CharacterQuestion
    {
        public string Question { get; set; }
        public string Alternative { get; set; }
        public string Clue { get; set; }
        public string CorrectAnswer { get; set; }


        public static void CheckAnswer(Character character, CharacterQuestion characterQuestion, User user)
        {
            var userAnswer = Console.ReadLine();
            if (userAnswer != characterQuestion.CorrectAnswer)
            {
                Console.WriteLine(character.IncorrectPhrase);
                user.NumberOfWrongAnswers++;
            }
            else if (userAnswer == null || userAnswer != characterQuestion.Alternative)
            {
                Console.WriteLine("You're very funny, please answer from your options!");
                user.NumberOfCorrectAnswers++;
                user.Diamonds++;
            }
        }



        //public void CheckAnswer(User user, QuestionHelper questionHelper)          // funkar inte för mig :(
        //{
        //    Console.Clear();
        //    Console.WriteLine(questionHelper.Question);
        //    Console.WriteLine(questionHelper.Alternatives);
        //    Console.WriteLine("Answer by pressing a, b or c!");
        //    string userAnswer = Console.ReadLine();

        //    if (userAnswer == questionHelper.CorrectAnswer)
        //    {
        //        Console.WriteLine("Correct!");
        //        RandomDiamond(user.Diamonds);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Wrong answer! You now go back to the last question...");
        //    }
    }
}

