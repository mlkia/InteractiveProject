﻿using Interactive_Saga;

namespace InteractiveProject.Helper
{
    public class QuestionHelper
    {
        public bool GenerateQuestion(Character character, CharacterQuestion characterQuestion,
        User user, Crossroad crossroad, QuestionHelper questionHelper,
        Level_1 level_1, Level_2 level_2, Level_3 level_3, MessageHelper messageHelper, MainMenu mainMenu)
        {
            Random rand = new Random();
            int index = rand.Next(1, 6);
            character.SelectedQuestion = character.riddle[index];
            Console.ReadKey();
            AskQuestion(character, characterQuestion, user, crossroad, questionHelper,
             level_1, level_2, level_3, messageHelper, mainMenu);
            return true;

        }

        // Fråge metod
        public bool AskQuestion(Character character, CharacterQuestion characterQuestion,
        User user, Crossroad crossroad, QuestionHelper questionHelper,
        Level_1 level_1, Level_2 level_2, Level_3 level_3, MessageHelper messageHelper, MainMenu mainMenu)
        {
            Console.WriteLine(character.HelloPhrase);

            Console.WriteLine(character.SelectedQuestion.Question);
            Console.WriteLine(character.SelectedQuestion.Alternative);

           GiveClueOption(characterQuestion, character,
            user, crossroad, questionHelper,
            level_1, level_2, level_3, messageHelper, mainMenu);
            return true;
        }

        //Ledtråd Metod
        public bool GiveClueOption(CharacterQuestion characterQuestion, Character character,
            User user, Crossroad crossroad, QuestionHelper questionHelper,
            Level_1 level_1, Level_2 level_2, Level_3 level_3, MessageHelper messageHelper, MainMenu mainMenu) //bool
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
            if (inputInt != 1 || inputInt != 2)
            {
                Console.Clear();
                Console.WriteLine("Please answere from your options");
                Console.ReadKey();
            }
            if (inputInt == 2)
            {
                Console.Clear();
                Console.WriteLine(character.SelectedQuestion.Question);
                Console.WriteLine(character.SelectedQuestion.Alternative);
                AnswerQuestion(character, characterQuestion, user, crossroad, questionHelper,
             level_1, level_2, level_3, messageHelper, mainMenu);
            }
            return true;
        }

        // Metod för att kunna svara på frågan
        public bool AnswerQuestion(Character character, CharacterQuestion characterQuestion,
            User user, Crossroad crossroad, QuestionHelper questionHelper,
            Level_1 level_1, Level_2 level_2, Level_3 level_3, MessageHelper messageHelper, MainMenu mainMenu) //bool
        {
            var userAnswer = Console.ReadLine().ToUpper();

            if (userAnswer == character.SelectedQuestion.CorrectAnswer)
            {
                 CorrectAnswer(character, characterQuestion, user, crossroad, questionHelper, mainMenu, level_1, level_2,
                level_3, messageHelper);
            }
            //else if (userAnswer == null || userAnswer != "A" || userAnswer != "B" || userAnswer != "C")
            //{
            //    Console.WriteLine("You stupid! Enter one of the OPTIONS!");
            //    Console.ReadLine();
            //    return false;
            //}
            else if (userAnswer != character.SelectedQuestion.CorrectAnswer)
            {
               return IncorrectAnswer(character, characterQuestion,
            user, crossroad, questionHelper, level_1, level_2, level_3, messageHelper, mainMenu);
            }
            return true;
        }

        // Rätt svar metod
        public bool CorrectAnswer(Character character, CharacterQuestion characterQuestion,
            User user, Crossroad crossroad, QuestionHelper questionHelper, MainMenu mainMenu, Level_1 level_1, Level_2 level_2, Level_3 level_3, MessageHelper messageHelper)
        {
            //var userInput = Console.ReadLine();
            //if (userAnswer == characterQuestion.CorrectAnswer)
            //{
            Console.WriteLine(character.CongratsPhrase);
            user.NumberOfCorrectAnswers++;
            user.Diamonds++;

            //Console.WriteLine("Would you like to see the menu or continue your journey? 1) Menu 2) Continue");
            //var userInput = Console.ReadLine();
            //if (userInput == "1")
            //{
            //    questionHelper.SeeMenu(characterQuestion, user, mainMenu, crossroad, level_1, level_2,
            //level_3, character, messageHelper, questionHelper);
            //}
            //else if (userInput == "2")
            //{
            //    crossroad.ChoosePath(questionHelper, character, user, characterQuestion, crossroad,
            //    level_1, level_2, level_3, messageHelper, mainMenu);
            //}
            //else
            //{
            //    Console.WriteLine("Input 1 or 2 please!");
            //    Console.ReadKey();
            //}
            return true;
        }

        // Fel svar metod skickar anropar ChoosePath()
        private bool IncorrectAnswer(Character character, CharacterQuestion characterQuestion,
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
            //Console.WriteLine("Would you like to see the menu or continue your journey? a) Menu b) Continue");
            //var userInput = Console.ReadLine();
            //if (userInput == "a")
            //{
            //    questionHelper.SeeMenu(characterQuestion, user, mainMenu, crossroad, level_1, level_2,
            //level_3, character, messageHelper, questionHelper);
            //}
            //else if (userInput == "b")
            //{
            //   questionHelper.GenerateQuestion(character, characterQuestion, user, crossroad, questionHelper,
            // level_1, level_2, level_3, messageHelper, mainMenu);
            //}
            //else
            //{
            //    Console.WriteLine("Input a or b please!");
            //    Console.ReadKey();
            //}
            return true;
        }

        //public bool SeeMenu(CharacterQuestion characterQuestion, User user, MainMenu mainMenu, Crossroad crossroad, Level_1 level_1, Level_2 level_2,
        //    Level_3 level_3, Character character, MessageHelper messageHelper, QuestionHelper questionHelper)
        //{
        //    Console.Clear();
        //    //Console.WriteLine("Would you like to see menu press Y, or else press any key to continue");
        //    //var answer = Console.ReadKey().KeyChar;
        //    //if (answer == 'Y' || answer == 'y')
        //    //{
        //    mainMenu.RunMenu(characterQuestion, user, level_1, level_2, level_3, character, crossroad, mainMenu, messageHelper, questionHelper);
        //    //}
        //    //else
        //    //{
        //    //crossroad.ChoosePath();
        //    //}
        //    return false;
        //}
    }
}