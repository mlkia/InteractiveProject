using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveProject
{
    //  Varannan fråga är “crossroad”, svarar man fel på denna åker man tillbaka till föregående “crossroad”    

    // Ett vägskäl. User blir tillfrågad antingen om t.ex. man vill går höger eller vänster eller en lättare fråga med två alternativ. 50/50 chans att svara rätt helt enkelt. Svarar man rätt går man vidare till karaktärs-frågan, svara man fel går man tillbaka till föregående crossroad på den level man befinner sig. Svarar man rätt får man 0-1 diamanter(random).

    /* MARCUS:
     var rnd = new Random(); // Slumpgenerator
var rightDir = rnd.Next(100) > 50; // 50% chans att det blir true
Console.WriteLine($"Right direction is {(rightDir ? "left" : "right")}"); // Gör något av de 50% 
     */

    internal class Crossroad
    {
        public bool CorrectAnswer { get; set; } = false;

        public void ChoosePath()
        {
            Console.WriteLine("Vill du gå höger eller vänster? Tryck h eller v!");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "v":
                    Console.WriteLine("Du valde att gå till vänster.");

                    // Randomisering över huruvida vänster eller höger är korrekt väg att gå:
                    Random rnd = new Random();
                    int randomised = rnd.Next(0, 2);
                    if (randomised == 0) CorrectPath();
                    if (randomised == 1) IncorrectPath();
                    break;

                case "h":
                    Console.WriteLine("Du valde att gå till höger.");

                    // Randomisering över huruvida vänster eller höger är korrekt väg att gå:
                    Random rnd1 = new Random();
                    int randomised1 = rnd1.Next(0, 2);
                    if (randomised1 == 0) IncorrectPath();
                    if (randomised1 == 1) CorrectPath();
                    break;

                default:
                    Console.WriteLine("Något gick fel.");
                    break;
            }
        }

        private void CorrectPath()
        {
            Console.WriteLine("Grattis! Du valde rätt väg!");
            Random random = new Random();
            int randomNumberOfDiamonds = random.Next(0, 2); // Randomisering, de får en eller två diamanter.
            Console.WriteLine(" Du får " + randomNumberOfDiamonds + " diamanter!");
            CorrectAnswer = true;
            GoToCharacterQuestion();
        }

        private void IncorrectPath()
        {
            Console.WriteLine("Attans! Du valde fel väg! Du får gå tillbaks till förra crossroaden!");
            CorrectAnswer = false;
            ReturnToPreviousCrossroadOnThisLevel();
        }

        private void GoToCharacterQuestion()
        {
            global::System.Console.WriteLine("Nu kommer du att få en character question (ej implenterat).");
        }

        private void ReturnToPreviousCrossroadOnThisLevel()
        {
            ChoosePath();
        }
    }
}