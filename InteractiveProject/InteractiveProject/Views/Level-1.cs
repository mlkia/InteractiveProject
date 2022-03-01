using Interactive_Saga;
using InteractiveProject.Helper;

namespace InteractiveProject
{
    public class Level_1

    {
        public Character RunLevelOne(Character character, User user)
        {
            Character rabbit = new("Rabby", "Hello buddy! My name is Rabby!", "Oh no, I´m so sorry! That answer is wrong! ", "Yes, that´s right, buddy!", "Good bye, Good luck to you!");
            rabbit.riddle = new CharacterQuestion[6];
            rabbit.riddle[1] = new CharacterQuestion("What has hands and a face, but can’t hold anything or smile?", "A. Clock /  B.Mirror / C.Sun", "A");
            rabbit.riddle[2] = new CharacterQuestion("It belongs to you, but your friends use it more. What is it?", "A. Trust / B. Your name  / C. Time", "B");
            rabbit.riddle[3] = new CharacterQuestion("If you don’t keep me, I’ll break. What Am I?", "A. Promise / B. Health / C. Love",  "A");
            rabbit.riddle[4] = new CharacterQuestion("I can fill a room, but I take up no space. What am I? ", "A. Sound  / B. Light / C. Thought", "B");
            rabbit.riddle[5] = new CharacterQuestion("If I have it, I don’t share it. If I share it, I don’t have it. What is it?", "A. Silence / B. Money / C. My partner", "A");

            if (user.NumberOfCorrectAnswers == 5)
            {
                user.Key++;
                user.Level++;
                
            }

            
            
            
        }
        
    }
}