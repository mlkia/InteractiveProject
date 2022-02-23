﻿using System;
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
        public void GenerateQuestion(Character character, CharacterQuestion characterQuestion, User user)
        {
            if (user.Level == 1)
            {
                Random rand = new Random();
               int index = rand.Next(1, 5);
                switch (index)
                {
                    case 1:
                        Console.WriteLine();
                        break;
                   
                    case 2:
                        Console.WriteLine(Riddle2.);
                        break;
                  
                    case 3:
                        Console.WriteLine(Riddle3.);
                        break;
                   
                    case 4:
                        Console.WriteLine(Riddle4.);
                        break;
                   
                    case 5:
                        Console.WriteLine(Riddle5.);
                        break;
                }
            }
            
        }


        // Fråge metod
        public void AskQuestion(Character character, CharacterQuestion characterQuestion, 
            User user, Crossroad crossroad)
        {
            Console.WriteLine(character.HelloPhrase);
            Console.WriteLine(characterQuestion.Question);
            Console.WriteLine(characterQuestion.Alternative);
            GiveClueOption(characterQuestion, character, user, crossroad);
            Console.WriteLine("Please answer from your options");
            AnswerQuestion(character, characterQuestion, user, crossroad);
        }

        //Ledtråd Metod
        public void GiveClueOption(CharacterQuestion characterQuestion, Character character, 
            User user, Crossroad crossroad)
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
                Console.WriteLine(characterQuestion.Clue);
                AskQuestion(character, characterQuestion, user, crossroad);
            }
            if (inputInt == 2)
            {
                Console.Clear();
                AnswerQuestion(character, characterQuestion, user, crossroad);
            }
            
        }

        // Metod för att kunna svara på frågan
        public void AnswerQuestion(Character character, CharacterQuestion characterQuestion, 
            User user, Crossroad crossroad)
        {
            var userAnswer = Console.ReadLine();
            CheckAnswer(character, characterQuestion, user, crossroad);
        }

        //Metod för att se svaret
        public void CheckAnswer(Character character, CharacterQuestion characterQuestion,
            User user, Crossroad crossroad)
        {
            var userAnswer = Console.ReadLine();
            IncorrectAnswer(character, characterQuestion, user);
            CorrectAnswer(character, characterQuestion,user, crossroad);
        }

        // Rätt svar metod 
        public void CorrectAnswer(Character character, CharacterQuestion characterQuestion, 
            User user, Crossroad crossroad)
        {
            var userAnswer = Console.ReadLine();
            if (userAnswer == characterQuestion.CorrectAnswer)
            {
                Console.WriteLine(character.CongratsPhrase);
                user.NumberOfCorrectAnswers++;
                user.Diamonds++;
                crossroad.ChoosePath();
            }
            IncorrectAnswer(character, characterQuestion, user);
        }

        // Fel svar metod skickar anropar ChoosePath()
        private void IncorrectAnswer(Character character, CharacterQuestion characterQuestion, User user)
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
                GenerateQuestion(character, characterQuestion, user);
            }
        }

        public void SeeMenu(Mainmenu mainMenu, Crossroad crossroad)
        {
            Console.Clear();
            Console.WriteLine("Would you like to see menu press Y, or else press any key to continue");
            var answer = Console.ReadKey().KeyChar;
            if (answer == 'Y' || answer == 'y')
            {
                mainMenu.RunMenu();
            }
            else
            {
                crossroad.ChoosePath();
            }
        }
    }
}
