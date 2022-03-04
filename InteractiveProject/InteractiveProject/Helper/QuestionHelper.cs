using Interactive_Saga;

namespace InteractiveProject.Helper
{
    public static class QuestionHelper
    {
        public static bool GenerateQuestion(Character character, User user)
        {
            Random rand = new Random();
            int index = rand.Next(1, 6);
            character.SelectedQuestion = character.riddle[index];
            //Console.ReadKey();
            AskQuestion(character, user);
            return true;

        }

        // Fråge metod
        public static bool AskQuestion(Character character, User user)
        {
            Console.WriteLine(character.HelloPhrase);

            Console.WriteLine(character.SelectedQuestion.Question);
            Console.WriteLine(character.SelectedQuestion.Alternative);

            GiveClueOption(character, user);
            AnswerQuestion(character, user);
            return true;
        }

        //Ledtråd Metod
        public static bool GiveClueOption(Character character, User user) //bool
        {
            Console.WriteLine("Do you want a clue for the cost of one diamond," +
                " (Press 1) for clue or (press 2) to continue");
            var userInput = Console.ReadLine();
            int inputInt = 0;
            int.TryParse(userInput, out inputInt);
            if (inputInt == 1)
            {
                Console.Clear();
                Console.WriteLine("Here is your clue..." + character.SelectedQuestion.Clue);
                Console.WriteLine(character.SelectedQuestion.Question);
                Console.WriteLine(character.SelectedQuestion.Alternative);
                return false;
            }
            if (inputInt == 2)
            {
                Console.Clear();
                Console.WriteLine(character.SelectedQuestion.Question);
                Console.WriteLine(character.SelectedQuestion.Alternative);
                //AnswerQuestion(character, user);
                return false;
            }
            if (inputInt != 1 || inputInt != 2)
            {
                Console.Clear();
                Console.WriteLine("Please answere from your options");
                Console.ReadKey();
            }
            return true;
        }

        // Metod för att kunna svara på frågan
        public static bool AnswerQuestion(Character character, User user) //bool
        {
            var userAnswer = Console.ReadLine().ToUpper();

            if (userAnswer == character.SelectedQuestion.CorrectAnswer)
            {
                 CorrectAnswer(character, user);
            }
            else if (userAnswer != character.SelectedQuestion.CorrectAnswer)
            {
               return IncorrectAnswer(character, user);
            }
            return true;
        }

        // Rätt svar metod
        public static bool CorrectAnswer(Character character, User user)
        {
            Console.WriteLine(character.CongratsPhrase);
            user.NumberOfCorrectAnswers++;
            user.Diamonds++;

            return true;
        }

        // Fel svar metod skickar anropar ChoosePath()
        public static bool IncorrectAnswer(Character character, User user)
        {
            
            Console.WriteLine(character.IncorrectPhrase);
            user.NumberOfWrongAnswers++;
           
            return true;
        }

    }
}