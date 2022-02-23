using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveProject
{
    public class CharacterQuestion
    {
        // properties för en fråga/ vad en fråga ska innehålla
        public string Question { get; set; }
        public string Alternative { get; set; }
        public string Clue { get; set; }
        public string CorrectAnswer { get; set; }

        public CharacterQuestion(string question, string alternatives,
            string clue, string correctAnswer)
        {
            Question = question;
            Alternative = alternatives; 
            Clue = clue;
            CorrectAnswer = correctAnswer; 
        }

        


        //// Josefins kod

        //// properties för en fråga/ vad en fråga ska innehålla
        //public List<CharacterQuestion> question { get; set; }
        //public string Alternatives { get; set; }
        //public string Clue { get; set; }
        //public string CorrectAnswer { get; set; }

        ////constructor
        //public QuestionHelper(string question, string alternatives, string clue, string correctAnswer)
        //{
        //    this.Question = question;
        //    this.Alternatives = alternatives;
        //    this.Clue = clue;
        //    this.CorrectAnswer = correctAnswer;
        //}

        //public QuestionHelper() // tom constructor                                                 // skapad av VS, borde inte behövas....?
        //{
        //}


        //public void CheckAnswer(UserJosefinTest user, QuestionHelper questionHelper)          // funkar inte för mig :(
        //{
        //    Console.Clear();
        //    Console.WriteLine(questionHelper.Question);
        //    Console.WriteLine(questionHelper.Alternatives);
        //    Console.WriteLine("Answer by pressing a, b or c!");
        //    string userAnswer = Console.ReadLine();

        //    if (userAnswer == questionHelper.CorrectAnswer)
        //    {
        //        Console.WriteLine("Correct!");
        //        RandomDiamond(user);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Wrong answer! You now go back to the last question...");
        //    }
        //}

        //public void GiveClue(QuestionHelper questionHelper, UserJosefinTest user) // metod för att ge en ledtråd, anropas den specifika frågans clue-property
        //{
        //    Console.Clear();
        //    Console.WriteLine("Here is your clue...");
        //    Console.WriteLine(questionHelper.Clue);
        //    //questionHelper.CheckAnswer(user);                                      // checkanswer funkar inte :(
        //}

        //public void RandomDiamond(UserJosefinTest user)  // exprimenterade med en metod för att randomisera 0-1 diamanter, ska anropas när userAnswer == CorrectAnswer
        //{
        //    Random rnd = new Random();
        //    int random = rnd.Next(0, 1);
        //    if (random == 0)
        //    {
        //        Console.WriteLine("No diamonds for you! Better luck next time...");
        //    }
        //    if (random == 1)
        //    {
        //        user.Diamonds++;
        //        Console.WriteLine("You got i diamond! You now have " + user.Diamonds + " diamonds!");
        //    }
        //}

        //public void AskQuestion(QuestionHelper questionHelper, Character character, UserJosefinTest user) //exprimenterade även med en metoden som skall ställa alla frågor. 
        //{
        //    Console.WriteLine(character.HelloPhrase);  // introducera karaktären, ställ karaktärens specifika fråga och presentera alternativen
        //    Console.WriteLine(questionHelper.Question);
        //    Console.WriteLine(questionHelper.Alternatives);
        //    Console.WriteLine("Are you ready to answer(press 1) or do you want to buy a clue for 1 diamonds(press 2)?");  // ge alternativet att svara eller köpa en ledtråd
        //    string userInput = Console.ReadLine();
        //    int inputInt = 0;
        //    int.TryParse(userInput, out inputInt);

        //    if (inputInt == 1)
        //    {
        //        //questionHelper.CheckAnswer(user);                                           // checkanswer funkar inte
        //        Console.WriteLine("ska kolla om du svarat rätt");  // min tanke var att CheckAnswer() ska ta emot en input(a, b eller c) och kolla om det stämmer med karaktärens specifika CorrectAnswer
        //    }
        //    else if (inputInt == 2)
        //    {
        //        // questionHelper.GiveClue(user);  // fungerar inte eftersom checkanswer inte funkar ännu :(
        //        Console.WriteLine("ska ge ledtråd");  // anropa metod en GiveClue() som skriver ut karakäterns specifika ledtråd
        //    }
        //    else
        //    {
        //        Console.WriteLine("Enter 1 or 2 please!"); //felmeddelande till user
        //    }

        //}
        //public class QuestionAlina
        //{
        //    public QuestionAlina(string text, List<string> answers, int correctAnswerIndex) // konstruktör för fråga
        //    {
        //        Text = text;
        //        Answers = answers;
        //        CorrectAnswerIndex = correctAnswerIndex;
        //    }

        //    public string Text { get; }
        //    public List<string> Answers { get; }

        //    private int CorrectAnswerIndex { get; }

        //    public bool IsCorrectAnswer(int answerIndex)
        //           => answerIndex == CorrectAnswerIndex;

        //}

        //Josefin 
        //public void GiveClue(QuestionHelper questionHelper, UserJosefinTest user) // metod för att ge en ledtråd, anropas den specifika frågans clue-property
        //{
        //    Console.Clear();
        //    Console.WriteLine("Here is your clue...");
        //    Console.WriteLine(questionHelper.Clue);
        //    //questionHelper.CheckAnswer(user);                                      // checkanswer funkar inte :(
        //}

        //public void RandomDiamond(UserJosefinTest user)  // exprimenterade med en metod för att randomisera 0-1 diamanter, ska anropas när userAnswer == CorrectAnswer
        //{
        //    Random rnd = new Random();
        //    int random = rnd.Next(0, 1);
        //    if (random == 0)
        //    {
        //        Console.WriteLine("No diamonds for you! Better luck next time...");
        //    }
        //    if (random == 1)
        //    {
        //        user.Diamonds++;
        //        Console.WriteLine("You got i diamond! You now have " + user.Diamonds + " diamonds!");
        //    }
        //}

        //public void AskQuestion(QuestionHelper questionHelper, Character character, UserJosefinTest user) //exprimenterade även med en metoden som skall ställa alla frågor. 
        //{
        //    Console.WriteLine(character.HelloPhrase);  // introducera karaktären, ställ karaktärens specifika fråga och presentera alternativen
        //    Console.WriteLine(questionHelper.Question);
        //    Console.WriteLine(questionHelper.Alternatives);
        //    Console.WriteLine("Are you ready to answer(press 1) or do you want to buy a clue for 1 diamonds(press 2)?");  // ge alternativet att svara eller köpa en ledtråd
        //    string userInput = Console.ReadLine();
        //    int inputInt = 0;
        //    int.TryParse(userInput, out inputInt);

        //    if (inputInt == 1)
        //    {
        //        //questionHelper.CheckAnswer(user);                                           // checkanswer funkar inte
        //        Console.WriteLine("ska kolla om du svarat rätt");  // min tanke var att CheckAnswer() ska ta emot en input(a, b eller c) och kolla om det stämmer med karaktärens specifika CorrectAnswer
        //    }
        //    else if (inputInt == 2)
        //    {
        //        // questionHelper.GiveClue(user);  // fungerar inte eftersom checkanswer inte funkar ännu :(
        //        Console.WriteLine("ska ge ledtråd");  // anropa metod en GiveClue() som skriver ut karakäterns specifika ledtråd
        //    }
        //    else
        //    {
        //        Console.WriteLine("Enter 1 or 2 please!"); //felmeddelande till user
        //    }

        //}
    }
}
