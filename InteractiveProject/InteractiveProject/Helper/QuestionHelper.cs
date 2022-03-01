using Interactive_Saga;

namespace InteractiveProject.Helper
{
    public class QuestionHelper
    {
        public void GenerateQuestion(Character character)
        {
            Random rand = new Random();
            int index = rand.Next(1, 6);
            character.SelectedQuestion = character.riddle[index];
            Console.ReadKey();
            AskQuestion(character);

        }

        
        public void AskQuestion(Character character)
        {
            Console.WriteLine(character.HelloPhrase);// till meny 
            Console.WriteLine(character.SelectedQuestion.Question);//
            Console.WriteLine(character.SelectedQuestion.Alternative);//

            
            Console.WriteLine("Please answer from your options");
            AnswerQuestion(  user);
          
        }

        
        

        
        public void AnswerQuestion(Character character, User user)
        {
            var userAnswer = Console.ReadLine().ToUpper();

            if (userAnswer == character.SelectedQuestion.CorrectAnswer)
            {
                Console.WriteLine(character.CongratsPhrase);
                 CorrectAnswer(character, user);
            }
            else if (userAnswer == null || userAnswer != "A" || userAnswer != "B" || userAnswer != "C")
            {
                Console.WriteLine("You stupid! Enter one of the OPTIONS!");
                questionHelper.AnswerQuestion(character, user);
            }
           // else if (userAnswer != character.SelectedQuestion.CorrectAnswer)
            //{
             //   IncorrectAnswer(character, user);
           // }

            
        }

       
        //public void CheckAnswer()
        //{
        //    IncorrectAnswer(user);
         //   CorrectAnswer(user);
       // }

        
        public void CorrectAnswer(Character character, User user)
        {
            
            Console.WriteLine(character.CongratsPhrase);
            user.NumberOfCorrectAnswers++;
            user.Diamonds++;

            Console.WriteLine("Would you like to see the menu or continue your journey? 1) Menu 2) Continue");
            var userInput = Console.ReadLine();
            if (userInput == "1")
            {
                questionHelper.SeeMenu();
            }
            else if (userInput == "2")
            {
                questionHelper.GenerateQuestion(character);
            }
            else
            {
                Console.WriteLine("Input 1 or 2 please!");
                Console.ReadKey();
            }

            
        }

        
        public void IncorrectAnswer(Character character,User user)
        {
            
            Console.WriteLine(character.IncorrectPhrase);
            user.NumberOfWrongAnswers++;
            
            Console.WriteLine("Would you like to see the menu or continue your journey? a) Menu b) Continue");
            var userInput = Console.ReadLine();
            if (userInput == "a")
            {
                questionHelper.SeeMenu();
            }
            else if (userInput == "b")
            {
                questionHelper.GenerateQuestion(character);
            }
            else
            {
                Console.WriteLine("Input a or b please!");
                Console.ReadKey();
            }
        }

       // public void SeeMenu()
       // {
            
            
            //mainMenu.RunMenu();
            
        //}
    }
}