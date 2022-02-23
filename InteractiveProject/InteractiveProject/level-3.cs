using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveProject
{
    public  class level_3 
    {
        Character iceQueen= new(" Queen", "Hello  My name is Rabby!", " That answer is wrong! ", "Oh, that´s right!", "Bye! You have answered all my questions, you fool, but we will meet again some day! Run for your Life!");
        CharacterQuestion mathematics1 = new("What result is of this equation:  0.3 * 0.5? ", "A. 0.15 / B. 1.5 / C. 15", " Mathematics from 4-5 classes",  "A");
        CharacterQuestion mathematics2 = new("What result is of this equation: (-2) *(-6)*(-7)´2 (upphöjt till två)", "A. 588 / B. -588 / C.168 ", "Mathematics from 8-9 classes", "A");
        CharacterQuestion mathematics3 = new("What result will be if you simplify this equation rutten av 12 – rutten av 3", "A.0 / B. 9 / C.rutten av tre ", "Mathematics from class 9 - Mathematics 1C", "C");
        CharacterQuestion mathematics4 = new("What result is of this equation will be if you simplify this equation 5x-(3x-(x-1))", "A. x-1 / B. x+1 / C. 1 ", "Mathematics from 8-9 classes", "B");
        CharacterQuestion mathematics5 = new("What result is of this equation if you develop it  (2x +3y)´2(upphöjt till två)? ", "A. 2x´2 +6x + 6y´2 /  B. 4x´2 + 12 xy + 9y´2 / C. 4x +12xy + 9y ", "Mathematics from 8-9 classes", "B");

         if (user.NumberOfCorrectAnswers = 15)
            {
                user.Key++;
                //Gratis-meddelande ();
            }
            
            while(user.NumberOfCorrectAnswers< 15)
            {
                crossRoad.ChoosePath();

            }
    }
}
 