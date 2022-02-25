using Interactive_Saga;

namespace InteractiveProject.Helper
{
    public class QuestionHelper
    {
        public CharacterQuestion GenerateQuestion(Character character)
        {
            Random rand = new Random();
            int index = rand.Next(1, 6);
            character.SelectedQuestion = character.riddle[index];

            return character.SelectedQuestion;
        }

        // Fråge metod
        public void AskQuestion(Character character, CharacterQuestion characterQuestion,
        User user, Crossroad crossroad, QuestionHelper questionHelper,
        Level_1 level_1, Level_2 level_2, Level_3 level_3, MessageHelper messageHelper, MainMenu mainMenu)
        {
            Console.WriteLine(character.HelloPhrase);

            Console.WriteLine(character.SelectedQuestion.Question);
            Console.WriteLine(character.SelectedQuestion.Alternative);

            GiveClueOption(characterQuestion, character,
            user, crossroad, questionHelper,
            level_1, level_2, level_3, messageHelper, mainMenu);
            //Console.WriteLine("Please answer from your options");
            // AnswerQuestion(character, characterQuestion, user, crossroad, questionHelper);
        }

        //Ledtråd Metod
        public void GiveClueOption(CharacterQuestion characterQuestion, Character character,
            User user, Crossroad crossroad, QuestionHelper questionHelper,
            Level_1 level_1, Level_2 level_2, Level_3 level_3, MessageHelper messageHelper, MainMenu mainMenu)
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
                AnswerQuestion(character, characterQuestion, user, crossroad, questionHelper,
             level_1, level_2, level_3, messageHelper, mainMenu);
            }
            if (inputInt == 2)
            {
                Console.Clear();
                //Console.WriteLine(characterQuestion.Question);
                AnswerQuestion(character, characterQuestion, user, crossroad, questionHelper,
             level_1, level_2, level_3, messageHelper, mainMenu);
            }
        }

        // Metod för att kunna svara på frågan
        public void AnswerQuestion(Character character, CharacterQuestion characterQuestion,
            User user, Crossroad crossroad, QuestionHelper questionHelper,
            Level_1 level_1, Level_2 level_2, Level_3 level_3, MessageHelper messageHelper, MainMenu mainMenu)
        {
            var userAnswer = Console.ReadLine();

            if (userAnswer == character.SelectedQuestion.CorrectAnswer)
            {
                //    CorrectAnswer(character, characterQuestion, user, crossroad, questionHelper, user, mainMenu, crossroad, level_1, level_2,
                //level_3, character, messageHelper);
            }
            else if (userAnswer == null || userAnswer != "a" || userAnswer != "b" || userAnswer != "c")
            {
                Console.WriteLine("You stupid! Enter one of the OPTIONS!");
                questionHelper.AnswerQuestion(character, characterQuestion, user, crossroad, questionHelper,
             level_1, level_2, level_3, messageHelper, mainMenu);
            }
            else if (userAnswer != character.SelectedQuestion.CorrectAnswer)
            {
                IncorrectAnswer(character, characterQuestion,
            user, crossroad, questionHelper, level_1, level_2, level_3, messageHelper, mainMenu);
            }

            //CheckAnswer(character, questionHelper, characterQuestion, user, crossroad);
        }

        //Metod för att se svaret
        //public void CheckAnswer(Character character, QuestionHelper questionHelper,
        //    CharacterQuestion characterQuestion,User user, Crossroad crossroad)
        //{
        //    IncorrectAnswer(character, characterQuestion, user, crossroad, questionHelper);
        //    CorrectAnswer(character, characterQuestion, user, crossroad, questionHelper);
        //}

        // Rätt svar metod
        public void CorrectAnswer(Character character, CharacterQuestion characterQuestion,
            User user, Crossroad crossroad, QuestionHelper questionHelper, MainMenu mainMenu, Level_1 level_1, Level_2 level_2, Level_3 level_3, MessageHelper messageHelper)
        {
            var userAnswer = Console.ReadLine();
            //if (userAnswer == characterQuestion.CorrectAnswer)
            //{
            Console.WriteLine(character.CongratsPhrase);
            user.NumberOfCorrectAnswers++;
            user.Diamonds++;

            Console.WriteLine("Would you like to see the menu or continue your journey? a) Menu b) Continue");
            var userInput = Console.ReadLine();
            if (userInput == "a")
            {
                questionHelper.SeeMenu(user, mainMenu, crossroad, level_1, level_2,
            level_3, character, messageHelper, questionHelper);
            }
            else if (userInput == "b")
            {
                crossroad.ChoosePath(questionHelper, character);
            }
            else
            {
                Console.WriteLine("Input a or b please!");
                Console.ReadKey();
            }

            //}
            //IncorrectAnswer(character, characterQuestion, user, crossroad, questionHelper);
        }

        // Fel svar metod skickar anropar ChoosePath()
        private void IncorrectAnswer(Character character, CharacterQuestion characterQuestion,
            User user, Crossroad crossroad, QuestionHelper questionHelper,
            Level_1 level_1, Level_2 level_2, Level_3 level_3, MessageHelper messageHelper, MainMenu mainMenu)
        {
            //var userAnswer = Console.ReadLine();
            //if (userAnswer != characterQuestion.CorrectAnswer)
            //{
            Console.WriteLine(character.IncorrectPhrase);
            user.NumberOfWrongAnswers++;
            //}
            //else if (userAnswer == null || userAnswer != characterQuestion.Alternative)
            //{
            //Console.WriteLine("You're very funny, please answer from your options!");
            //Console.WriteLine(characterQuestion.Question);
            //AnswerQuestion(character, characterQuestion, user, crossroad, questionHelper);

            //}
            Console.WriteLine("Would you like to see the menu or continue your journey? a) Menu b) Continue");
            var userInput = Console.ReadLine();
            if (userInput == "a")
            {
                questionHelper.SeeMenu(user, mainMenu, crossroad, level_1, level_2,
            level_3, character, messageHelper, questionHelper);
            }
            else if (userInput == "b")
            {
                questionHelper.GenerateQuestion(character);
            }
            else
            {
                Console.WriteLine("Input a or b please!");
                Console.ReadKey();
            }
        }

        public void SeeMenu(User user, MainMenu mainMenu, Crossroad crossroad, Level_1 level_1, Level_2 level_2,
            Level_3 level_3, Character character, MessageHelper messageHelper, QuestionHelper questionHelper)
        {
            Console.Clear();
            //Console.WriteLine("Would you like to see menu press Y, or else press any key to continue");
            //var answer = Console.ReadKey().KeyChar;
            //if (answer == 'Y' || answer == 'y')
            //{
            mainMenu.RunMenu(user, level_1, level_2, level_3, character, crossroad, mainMenu, messageHelper, questionHelper);
            //}
            //else
            //{
            //crossroad.ChoosePath();
            //}
        }
    }
}