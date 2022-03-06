using Interactive_Saga;

namespace InteractiveProject.Helper
{
    public static class QuestionHelper
    {
        public static bool GenerateQuestion(Character character)
        {
            Random rand = new Random();
            int index = rand.Next(1, 6);
            character.SelectedQuestion = character.riddle[index];
            AskQuestion(character);
            return SeeMenu();
        }

        // Fråge metod
        public static void AskQuestion(Character character)
        {
            ConsoleHelper.Write(character.HelloPhrase);

            ConsoleHelper.Write(character.SelectedQuestion.Question);
            ConsoleHelper.Write(character.SelectedQuestion.Alternative);

            GiveClueOption(character);
            AnswerQuestion(character);
        }

        //Ledtråd Metod
        public static void GiveClueOption(Character character) //bool
        {
            if (ConsoleHelper.IsTestMode)
                return;
            ConsoleHelper.Write("Do you want a clue for the cost of one diamond," +
                " (Press 1) for clue or (press 2) to continue");
            var userInput = ConsoleHelper.Read();
            int.TryParse(userInput, out int inputInt);
            if (inputInt == 1)
            {
                ConsoleHelper.Clear();
                ConsoleHelper.Write("Here is your clue..." + character.SelectedQuestion.Clue);
                ConsoleHelper.Write(character.SelectedQuestion.Question);
                ConsoleHelper.Write(character.SelectedQuestion.Alternative);
                return;
            }
            if (inputInt == 2)
            {
                ConsoleHelper.Clear();
                ConsoleHelper.Write(character.SelectedQuestion.Question);
                ConsoleHelper.Write(character.SelectedQuestion.Alternative);
                //AnswerQuestion(character, user);
                return;
            }
            if (inputInt != 1 || inputInt != 2)
            {
                ConsoleHelper.Clear();
                ConsoleHelper.Write("Please answere from your options");
                ConsoleHelper.ReadKey();
            }
        }

        // Metod för att kunna svara på frågan
        public static bool AnswerQuestion(Character character) //bool
        {
            if (ConsoleHelper.IsTestMode)
            {
                if (TestHelper.GiveCorrectAnswer)
                {
                    CorrectAnswer(character);
                }
                else
                {
                    IncorrectAnswer(character);
                    return false;
                }
                return true;
            }

            var answer = Answer();

            if (answer == character.SelectedQuestion.CorrectAnswer)
            {
                 CorrectAnswer(character);
                return true;
            }
            else if (answer != character.SelectedQuestion.CorrectAnswer)
            {
                IncorrectAnswer(character);
                return false;
            }
            return true;
        }

        // Rätt svar metod
        public static void CorrectAnswer(Character character)
        {
            UserHelper.RewardUser(character);
        }

        // Fel svar metod skickar anropar ChoosePath()
        public static void IncorrectAnswer(Character character)
        {
            UserHelper.PunishUser(character);
        }

        public static bool SeeMenu()
        {
            if (TestHelper.ReturnToMenu == true)
                ConsoleHelper.Write("Do you wanna see menu!, press y for yes, press anything else for no");
                var answer = ConsoleHelper.ReadKey();

               return answer == 'y' || answer == 'Y';
        }
        public static string? Answer()
        {
            return ConsoleHelper.Read();
        }
    }
}