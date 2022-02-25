using InteractiveProject.Helper;

namespace InteractiveProject
{
    //  Varannan fr�ga �r �crossroad�, svarar man fel p� denna �ker man tillbaka till f�reg�ende �crossroad�

    // Ett v�gsk�l. User blir tillfr�gad antingen om t.ex. man vill g�r h�ger eller v�nster eller en l�ttare fr�ga med tv� alternativ. 50/50 chans att svara r�tt helt enkelt. Svarar man r�tt g�r man vidare till karakt�rs-fr�gan, svara man fel g�r man tillbaka till f�reg�ende crossroad p� den level man befinner sig. Svarar man r�tt f�r man 0-1 diamanter(random).

    /* MARCUS:
     var rnd = new Random(); // Slumpgenerator
var rightDir = rnd.Next(100) > 50; // 50% chans att det blir true
Console.WriteLine($"Right direction is {(rightDir ? "left" : "right")}"); // G�r n�got av de 50%
     */

    public class Crossroad
    {
        public bool CorrectAnswer { get; set; } = false;

        public void ChoosePath(QuestionHelper questionHelper, Character character)  // �ndra till public bool???
        {
            Console.WriteLine("Do your want to turn right or left?!");
            Console.WriteLine("Enter l for left or r for right");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "l":
                    Console.WriteLine("You chose left.");

                    // Randomisering �ver huruvida v�nster eller h�ger �r korrekt v�g att g�:
                    Random rnd = new Random();
                    int randomised = rnd.Next(0, 2);
                    if (randomised == 0) CorrectPath(questionHelper, character);
                    if (randomised == 1) IncorrectPath(questionHelper, character);

                    break;

                case "r":
                    Console.WriteLine("You chose right.");

                    // Randomisering �ver huruvida v�nster eller h�ger �r korrekt v�g att g�:
                    Random rnd1 = new Random();
                    int randomised1 = rnd1.Next(0, 2);
                    if (randomised1 == 0) IncorrectPath(questionHelper, character);
                    if (randomised1 == 1) CorrectPath(questionHelper, character);

                    break;

                default:
                    Console.WriteLine("Something went wrong.");
                    break;
            }
        }

        private bool CorrectPath(QuestionHelper questionHelper, Character character)
        {
            Console.WriteLine("Yay! You chose the correct path!");

            //Random random = new Random();
            //int randomNumberOfDiamonds = random.Next(0, 2); // Randomisering, de f�r en eller tv� diamanter.
            //Console.WriteLine(" You get " + randomNumberOfDiamonds + " diamonds!");

            int numberOfDiamonds = 0;
            numberOfDiamonds++;
            Console.WriteLine("You get " + numberOfDiamonds + "diamonds!");
            return CorrectAnswer = true;

            // questionHelper.GenerateQuestion(character);
        }

        private bool IncorrectPath(QuestionHelper questionHelper, Character character)
        {
            Console.WriteLine("Oh no! You chose the wrong path! You will have to return to the previous crossroad!");
            return CorrectAnswer = false;
            // ReturnToPreviousCrossroadOnThisLevel(questionHelper, character);
        }

        //private void ReturnToPreviousCrossroadOnThisLevel(QuestionHelper questionHelper, Character character)
        //{
        //    ChoosePath(questionHelper, character);
        //}
    }
}