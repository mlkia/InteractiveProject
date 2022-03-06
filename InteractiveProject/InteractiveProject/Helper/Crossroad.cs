using Interactive_Saga;
using InteractiveProject.Helper;

namespace InteractiveProject
{
    //  Varannan fr�ga �r �crossroad�, svarar man fel p� denna �ker man tillbaka till f�reg�ende �crossroad�

    // Ett v�gsk�l. User blir tillfr�gad antingen om t.ex. man vill g�r h�ger eller v�nster eller en l�ttare fr�ga med tv� alternativ. 50/50 chans att svara r�tt helt enkelt. Svarar man r�tt g�r man vidare till karakt�rs-fr�gan, svara man fel g�r man tillbaka till f�reg�ende crossroad p� den level man befinner sig. Svarar man r�tt f�r man 0-1 diamanter(random).

    /* MARCUS:
     var rnd = new Random(); // Slumpgenerator
var rightDir = rnd.Next(100) > 50; // 50% chans att det blir true
ConsoleHelper.Write($"Right direction is {(rightDir ? "left" : "right")}"); // G�r n�got av de 50%
     */

    public class Crossroad
    {
        public static bool CorrectAnswer { get; set; } = false;

        public static void ChoosePath()  // �ndra till public bool???
        {
            ConsoleHelper.Write("Do your want to turn right or left?!");
            ConsoleHelper.Write("Enter L for left or R for right");
            string userInput = ConsoleHelper.Read();

            switch (userInput)
            {
                case "l":
                case "L":
                    ConsoleHelper.Write("You chose to go left.");

                    // Randomisering �ver huruvida v�nster eller h�ger �r korrekt v�g att g�:
                    Random rnd = new Random();
                    int randomised = rnd.Next(0, 2);
                    if (randomised == 0) CorrectPath();
                    if (randomised == 1) IncorrectPath();

                    break;

                case "r":
                case "R":
                    ConsoleHelper.Write("You chose to go right.");

                    // Randomisering �ver huruvida v�nster eller h�ger �r korrekt v�g att g�:
                    Random rnd1 = new Random();
                    int randomised1 = rnd1.Next(0, 2);
                    if (randomised1 == 0) IncorrectPath();
                    if (randomised1 == 1) CorrectPath();

                    break;

                default:
                    ConsoleHelper.Write("Something went wrong.");
                    break;
            }
        }

        private static bool CorrectPath()
        {
            ConsoleHelper.Write("Yay! You chose the correct path!");

            //Random random = new Random();
            //int randomNumberOfDiamonds = random.Next(0, 2); // Randomisering, de f�r en eller tv� diamanter.
            //ConsoleHelper.Write(" You get " + randomNumberOfDiamonds + " diamonds!");

            int numberOfDiamonds = 0;
            numberOfDiamonds++;
            ConsoleHelper.Write("You get " + numberOfDiamonds + " diamonds!");
            return CorrectAnswer = true;

            //questionHelper.GenerateQuestion(character, characterQuestion, user, crossroad, questionHelper, 
            //    level_1, level_2, level_3, messageHelper, mainMenu);
        }

        private static bool IncorrectPath()
        {
            ConsoleHelper.Write("Oh no! You chose the wrong path! You will have to return to the previous crossroad!");
            ConsoleHelper.Read();
            ReturnToPreviousCrossroadOnThisLevel();
            return true;
        }

        private static void ReturnToPreviousCrossroadOnThisLevel()
        {
            ConsoleHelper.Clear();
            ChoosePath();
        }
    }
}