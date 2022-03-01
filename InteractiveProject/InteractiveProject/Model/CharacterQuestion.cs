namespace InteractiveProject
{
    public class CharacterQuestion
    {
        
        public string Question { get; set; }
        public string Alternative { get; set; }
        public string CorrectAnswer { get; set; }

        public CharacterQuestion(string question, string alternatives,
            string correctAnswer)
        {
            Question = question;
            Alternative = alternatives;
            CorrectAnswer = correctAnswer;
        }

        
    }
}