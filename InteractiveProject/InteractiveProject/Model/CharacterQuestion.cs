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

        public CharacterQuestion()
        {
        }
    }
}