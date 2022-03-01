using Interactive_Saga;
using InteractiveProject.Helper;

namespace InteractiveProject
{
    public class Level_2
    {
        public Character RunLevelTwo(Character character, User user )
        {
            Character reindeer = new("Bambi", "Hello, my name is Bambi !", "So sorry! Your answer is wrong!", "Yees! That´s right, my friend!", "Bye! Bye! I wish you good luck with the Ice Queen!");
            reindeer.riddle = new CharacterQuestion[6];
            reindeer.riddle[1] = new("Which flower does produce opium?", "A. Poppy / B. Tulip / C. Carnation",  "A");
            reindeer.riddle[2] = new("Which flower do you use to get saffron?", "A. Sunflower/ B. Crocus / C. Lily",  "B");
            reindeer.riddle[3] = new("Which fruit is a stone fruit ? ", "A.Apple / B. Peach / C. Apelsin", "B");
            reindeer.riddle[4] = new("What kind of animal is the fastest animal on the land?", "A. Puma / B. Leopard / + C. Cheetah", "C");
            reindeer.riddle[5] = new("Which edible fungus does have another name as stone fungus?", "A.Mushroom/ B. Chantarelle / C. Penny bun", "C");

            if (user.NumberOfCorrectAnswers == 10)
            {
                user.Key++;
                user.Level++;
            }

           
           
        } 
    }
}
       