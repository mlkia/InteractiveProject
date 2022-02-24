using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveProject
{
    public  class Level_2 
    {
        public void RunLevelTwo()
        {
            //User user = new(UserName, Diamonds, NumberOfCorrectAnswers, NumberOfWrongAnswers, Level, Key);
            Character reindeer = new("Bambi", "Hello, my name is Bambi !", "So sorry! Your answer is wrong!", "Yees! That´s right, my friend!", "Bye! Bye! I wish you good luck with the Ice Queen!");
            CharacterQuestion florafauna1 = ("Which flower does produce opium?", "A. Poppy / B. Tulip / C. Carnation", "These small black grains usually can be found in sweet buns", "A");
            CharacterQuestion florafauna2 = ("Which flower do you use to get saffron?", "A. Sunflower/ B. Crocus / C. Lily", "You usually eat  buns this spice on Christmas", "B");
            CharacterQuestion florafauna3 = ("Which fruit is a stone fruit ? ", "A.Apple / B. Peach / C. Apelsin", "It is something yellow/orange and juicy", "B");
            CharacterQuestion florafauna4 = ("What kind of animal is the fastest animal on the land?", "A. Puma / B. Leopard / + C. Cheetah", "( It sounds similar to leopard", "C");
            CharacterQuestion florafauna5 = ("Which edible fungus does have another name as stone fungus?", "A.Mushroom/ B. Chantarelle / C. Penny bun", "It has white body and brown hat", "C");

            if (user.NumberOfCorrectAnswers = 10)
            {
                user.Key++;
                user.Level++;
                levelThree.RunLevelThree();
            }

            while (user.NumberOfCorrectAnswers < 10)

            {
                crossRoad.ChoosePath();

            }

        }
    }
}
