using Interactive_Saga;
using InteractiveProject.Helper;

namespace InteractiveProject
{
    public static class Level_2
    {
        public static Character RunLevelTwo()
        {
            User user = new User();

            Character reindeer = new Character("Bambi", "Hello, my name is Bambi !", "Yees! That´s right, my friend!", "So sorry! Your answer is wrong!" ,"Bye! Bye! I wish you good luck with the Ice Queen!");
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
                //level_2.RunLevelTwo(character, user,level_1, level_2, level_3, characterQuestion, crossRoad, messageHelper, mainMenu, questionHelper);
            }

            while (user.NumberOfCorrectAnswers < 10)
            {
                Crossroad.ChoosePath();
                if (Crossroad.CorrectAnswer == true)
                {
                    Console.ReadKey();
                    Console.Clear();
                    QuestionHelper.GenerateQuestion(reindeer, user);
                }
            }
            return reindeer;
        } 
    }
}
        //public void GenerateQuestion(Character character, User user, Level_2 level_2)
        //{
        //    if (user.Level == 2)
        //    {
        //        Random rand = new Random();
        //        int index = rand.Next(1, 6);
        //        switch (index)
        //        {
        //            case 1:
        //                Console.WriteLine(character.riddle[1].Question);
        //                break;

        //            case 2:
        //                Console.WriteLine(character.riddle[2].Question);
        //                break;

        //            case 3:
        //                Console.WriteLine(character.riddle[3].Question);
        //                break;

        //            case 4:
        //                Console.WriteLine(character.riddle[4].Question);
        //                break;

        //            case 5:
        //                Console.WriteLine(character.riddle[5].Question);
        //                break;
        //        }