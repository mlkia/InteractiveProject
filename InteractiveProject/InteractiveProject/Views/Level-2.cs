using Interactive_Saga;
using InteractiveProject.Helper;

namespace InteractiveProject
{
    public class Level_2
    {
        public void RunLevelTwo(Character character, User user, Level_3 level3,
            Crossroad crossroad, MessageHelper messageHelper, MainMenu mainMenu, QuestionHelper questionHelper)
        {
            Character reindeer = new("Bambi", "Hello, my name is Bambi !", "So sorry! Your answer is wrong!", "Yees! That´s right, my friend!", "Bye! Bye! I wish you good luck with the Ice Queen!");
            reindeer.riddle = new CharacterQuestion[6];
            reindeer.riddle[1] = new("Which flower does produce opium?", "A. Poppy / B. Tulip / C. Carnation", "These small black grains usually can be found in sweet buns", "A");
            reindeer.riddle[2] = new("Which flower do you use to get saffron?", "A. Sunflower/ B. Crocus / C. Lily", "You usually eat  buns this spice on Christmas", "B");
            reindeer.riddle[3] = new("Which fruit is a stone fruit ? ", "A.Apple / B. Peach / C. Apelsin", "It is something yellow/orange and juicy", "B");
            reindeer.riddle[4] = new("What kind of animal is the fastest animal on the land?", "A. Puma / B. Leopard / + C. Cheetah", "( It sounds similar to leopard", "C");
            reindeer.riddle[5] = new("Which edible fungus does have another name as stone fungus?", "A.Mushroom/ B. Chantarelle / C. Penny bun", "It has white body and brown hat", "C");

            if (user.NumberOfCorrectAnswers == 10)
            {
                user.Key++;
                user.Level++;
                level3.RunLevelThree(character, user, crossroad, messageHelper, mainMenu, questionHelper);
            }

            while (user.NumberOfCorrectAnswers < 10)

            {
                crossroad.ChoosePath(questionHelper, character);
            }
        }

        public void GenerateQuestion(Character character, User user, Level_2 level_2)
        {
            if (user.Level == 2)
            {
                Random rand = new Random();
                int index = rand.Next(1, 6);
                switch (index)
                {
                    case 1:
                        Console.WriteLine(character.riddle[1].Question);
                        break;

                    case 2:
                        Console.WriteLine(character.riddle[2].Question);
                        break;

                    case 3:
                        Console.WriteLine(character.riddle[3].Question);
                        break;

                    case 4:
                        Console.WriteLine(character.riddle[4].Question);
                        break;

                    case 5:
                        Console.WriteLine(character.riddle[5].Question);
                        break;
                }
            }
        }
    }
}