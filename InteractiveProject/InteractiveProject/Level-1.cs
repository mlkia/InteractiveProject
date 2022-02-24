using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveProject
{
    public class Level_1

    {
        public void RunLevelOne()
        {
            //instansiera user + level2 + crossroad + character + characterquestion ... 
            //User user = new(UserName, Diamonds, NumberOfCorrectAnswers, NumberOfWrongAnswers, Level, Key); // i process..

            Character rabbit = new("Rabby", "Hello buddy! My name is Rabby!", "Oh no, I´m so sorry! That answer is wrong! ", "Yes, that´s right, buddy!", "Good bye, Good luck to you!");
            CharacterQuestion riddle1 = new("What has hands and a face, but can’t hold anything or smile?", "A. Clock /  B.Mirror / C.Sun", "Every person has this thing at home or in their bag", "A");
            CharacterQuestion riddle2 = new("It belongs to you, but your friends use it more. What is it?", "A. Trust / B. Your name  / C. Time", "It is something very important for yourself", "B");
            CharacterQuestion riddle3 = new("If you don’t keep me, I’ll break. What Am I?", "A. Promise / B. Health / C. Love", "It is the thing that costs more than gold", "A");
            CharacterQuestion riddle4 = new("I can fill a room, but I take up no space. What am I? ", "A. Sound  / B. Light / C. Thought", "Think about physics", "B");
            CharacterQuestion riddle5 = new("5.	If I have it, I don’t share it. If I share it, I don’t have it. What is it?", "A. Silence / B. Money / C. My partner", "If you don´t say anything?", "A");

            if (user.NumberOfCorrectAnswers = 5)
            {
                user.Key++;
                user.Level++;
                levelTwo.RunLevelTwo();
            }

            while (user.NumberOfCorrectAnswers < 5)
            {
                crossRoad.ChoosePath();

            }

        }


    }


}
       //karaktär 
       //frågor
        
        //anropa choosepath()
        // (om man väljer rätt väg skickas man vidare till en kanin, AskQuestion() anropas i Character.cs)
        //(om man väljer fel väg anropas ChoosePath() i Crossroad.cs)
        //(kaninen instansieras och en fråga randomiseras i AskQuestion()???
        //om rätt svar anropa choosepath()
        //om fel svar instansiera en ny kanin och randomisera en ny fråga
        
        
        
        //frågor 
        // skapar 5 kaniner 
        //crossroad 
    

