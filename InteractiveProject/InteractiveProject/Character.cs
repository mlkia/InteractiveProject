using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveProject
{
    public class Character
    {   
            public string Name { get; set; }
            public string HelloPhrase { get; set; }
            public string IncorrectPhrase { get; set; }
            public string CongratsPhrase { get; set; }
            public string GoodbyePhrase { get; set; }

            internal void Print()
            {
                Console.WriteLine("You have met the tricky " + Name);
            }

            public Character(string name, string helloPhrase, string congratsPhrase,
                string incorrectPhrase, string goodbyePhrase)
            {
                Name = name;
                HelloPhrase = helloPhrase;
                CongratsPhrase = congratsPhrase;
                IncorrectPhrase = incorrectPhrase;
                GoodbyePhrase = goodbyePhrase;
            }

        // Generate Character metod



        // Fråge metod
        public void AskQuestion(Character character, CharacterQuestion characterQuestion)
        {
            Console.WriteLine(character.HelloPhrase);
            GiveClueOption();
            Console.WriteLine(characterQuestion.Question);
            Console.WriteLine(characterQuestion.Alternative);
            Console.WriteLine("Please answer from your options");
            CheckAnswer(character, characterQuestion);

        }

        private void GiveClueOption()
        {
       
            Console.WriteLine("Do you want a clue for the cost of one diamond," +
                " (Press 1) for clue or press 2 to continue");
            var userInput = Console.ReadLine();
            int inputInt = 0;
            int.TryParse(userInput, out inputInt);
            if (inputInt == 1)
            {
                Console.Clear();
                Console.WriteLine("Here is your clue...");
                Console.WriteLine(CharacterQuestion.Clue);
                AskQuestion();
            }
        }

        private void AskQuestion()
        {
            throw new NotImplementedException();
        }

        public static void CheckAnswer(Character character, CharacterQuestion characterQuestion)
        {
            var userAnswer = Console.ReadLine();
            IncorrectAnswer(character, characterQuestion, userAnswer);
        }

        private static void IncorrectAnswer(Character character, CharacterQuestion characterQuestion, string? userAnswer)
        {
            if (userAnswer != characterQuestion.CorrectAnswer)
            {
                Console.WriteLine(character.IncorrectPhrase);
            }
            else if (userAnswer == null || userAnswer != characterQuestion.Alternative)
            {
                Console.WriteLine("You're very funny, please answer from your options!");
            }
        }

        // Rätt svar metod 

        // Fel svar metod skickar anropar ChoosePath()

        // Random Diamant metod

        //Ledtråd Metod

        //AskToSeeMenu Metod




        //public static Character GenerateCharacter()
        //{
        //    Character randomCharacter = null;
        //    Random rand = new Random();
        //    int index = rand.Next(1, 5);
        //    switch (index)
        //    {
        //        case 1:
        //            randomCharacter = new Lurifax();
        //            break;

        //        default: return null;
        //    }
        //    return randomCharacter;
        //}

        //public class Lurifax : Character
        //{
        //    public Lurifax()
        //    {
        //        Name = "Lurifax";
        //        HelloPhrase = "dsadas";
        //        CorrectPhrase = "sadsa";
        //        GoodbyePhrase = "sadsad";
        //        IncorrectPhrase = "sadsad";

        //    }
        //   }


        //Josefin kod


        // public string Name { get; set; } // karaktärens namn
        // public string HelloPhrase { get; set; }  // hälsningsfras, inte nödvändigt men roligt

        //public string CongratulationsPhrase { get; set; }                  // extra properties vi kan lägga till
        //public string IncorrectAnswerPhrase { get; set; }
        //public string GoodbyePhrase { get; set; }

        // public Character(string name, string helloPhrase)  // constructor
        // {
        //     this.Name = name;
        //    this.HelloPhrase = helloPhrase;
        // }

        //public class CharacterAlina // basklass för karaktär 
        //{
        //    public string Name { get; }
        //    private List<QuestionAlina> Questions;

        //    private static Random random = new Random(); // random-funktion skapas i början, så att den inte anropas på nytt varje gång

        //    public CharacterAlina(string name, List<QuestionAlina> questions) // karaktär har med sig lista med frågor 
        //    {
        //        Name = name;
        //        Questions = questions;
        //    }

        //    public bool AskQuestion() // frågefunktion har bool, så att anroparen kan bedömma vad som ska ske vid rätt/fel svar 
        //    {
        //        var randomQuestion = Questions[random.Next(Questions.Count)];
        //        Console.WriteLine(randomQuestion.Text);

        //        for (int i = 0; i < randomQuestion.Answers.Count; i++)
        //        {
        //            var answer = randomQuestion.Answers[i];

        //            Console.WriteLine($"{i + 1}: {answer}"); // frågor och svar börjar från 1 till 3
        //        }

        //        int userAnswer = int.Parse(Console.ReadLine()) - 1;

        //        return randomQuestion.IsCorrectAnswer(userAnswer);
        //    }
    }
}
