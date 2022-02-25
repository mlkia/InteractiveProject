using InteractiveProject.Helper;

namespace InteractiveProject
{
    //  Varannan fråga är “crossroad”, svarar man fel på denna åker man tillbaka till föregående “crossroad”

    // Ett vägskäl. User blir tillfrågad antingen om t.ex. man vill går höger eller vänster eller en lättare fråga med två alternativ. 50/50 chans att svara rätt helt enkelt. Svarar man rätt går man vidare till karaktärs-frågan, svara man fel går man tillbaka till föregående crossroad på den level man befinner sig. Svarar man rätt får man 0-1 diamanter(random).

    /* MARCUS:
     var rnd = new Random(); // Slumpgenerator
var rightDir = rnd.Next(100) > 50; // 50% chans att det blir true
Console.WriteLine($"Right direction is {(rightDir ? "left" : "right")}"); // Gör något av de 50%
     */

    public class Crossroad
    {
        public bool CorrectAnswer { get; set; } = false;

        public void ChoosePath(QuestionHelper questionHelper, Character character)  // ändra till public bool???
        {
            Console.WriteLine("Do your want to turn right or left?!");
            Console.WriteLine("Enter l for left or r for right");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "l":
                    Console.WriteLine("You chose left.");

                    // Randomisering över huruvida vänster eller höger är korrekt väg att gå:
                    Random rnd = new Random();
                    int randomised = rnd.Next(0, 2);
                    if (randomised == 0) CorrectPath(questionHelper, character);
                    if (randomised == 1) IncorrectPath(questionHelper, character);

                    break;

                case "r":
                    Console.WriteLine("You chose right.");

                    // Randomisering över huruvida vänster eller höger är korrekt väg att gå:
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
            //int randomNumberOfDiamonds = random.Next(0, 2); // Randomisering, de får en eller två diamanter.
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