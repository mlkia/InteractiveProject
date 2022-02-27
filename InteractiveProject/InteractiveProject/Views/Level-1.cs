﻿using Interactive_Saga;
using InteractiveProject.Helper;

namespace InteractiveProject
{
    public class Level_1

    {
        public Character RunLevelOne(Character character,CharacterQuestion characterQuestion, User user,Level_1 level_1, Level_2 level_2,
            Crossroad crossRoad, Level_3 level_3, MessageHelper messageHelper, MainMenu mainMenu, QuestionHelper questionHelper)
        {
            Character rabbit = new Character("Rabby", "Hello buddy! My name is Rabby!", "Yes, that´s right, buddy!", "Oh no, I´m so sorry! That answer is wrong! ", "Good bye, Good luck to you!");
            rabbit.riddle = new CharacterQuestion[6];
            rabbit.riddle[1] = new CharacterQuestion("What has hands and a face, but can’t hold anything or smile?", "A. Clock /  B.Mirror / C.Sun", "Every person has this thing at home or in their bag", "A");
            rabbit.riddle[2] = new CharacterQuestion("It belongs to you, but your friends use it more. What is it?", "A. Trust / B. Your name  / C. Time", "It is something very important for yourself", "B");
            rabbit.riddle[3] = new CharacterQuestion("If you don’t keep me, I’ll break. What Am I?", "A. Promise / B. Health / C. Love", "It is the thing that costs more than gold", "A");
            rabbit.riddle[4] = new CharacterQuestion("I can fill a room, but I take up no space. What am I? ", "A. Sound  / B. Light / C. Thought", "Think about physics", "B");
            rabbit.riddle[5] = new CharacterQuestion("5.	If I have it, I don’t share it. If I share it, I don’t have it. What is it?", "A. Silence / B. Money / C. My partner", "If you don´t say anything?", "A");

            if (user.NumberOfCorrectAnswers == 5)
            {
                user.Key++;
                user.Level++;
                level_2.RunLevelTwo(character, user,level_1, level_2, level_3, characterQuestion, crossRoad, messageHelper, mainMenu, questionHelper);
            }

            while (user.NumberOfCorrectAnswers < 5)
            {
                crossRoad.ChoosePath(questionHelper, character, user, characterQuestion, crossRoad,
                level_1, level_2, level_3, messageHelper, mainMenu);
                if (crossRoad.CorrectAnswer == true)
                {
                    questionHelper.GenerateQuestion(rabbit, characterQuestion, user, crossRoad, questionHelper,
             level_1, level_2, level_3, messageHelper, mainMenu);
                    return character;
                }
                else if(crossRoad.CorrectAnswer == false)
                {
                    crossRoad.ChoosePath(questionHelper, character, user, characterQuestion, crossRoad,
                level_1, level_2, level_3, messageHelper, mainMenu);
                    return character;
                }
            }
            
            return rabbit;
        }
        
    }
}