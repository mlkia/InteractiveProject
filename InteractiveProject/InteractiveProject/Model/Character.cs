namespace InteractiveProject
{
    public class Character
    {
        public string Name { get; set; }
        public string HelloPhrase { get; set; }
        public string IncorrectPhrase { get; set; }
        public string CongratsPhrase { get; set; }
        public string GoodbyePhrase { get; set; }
        public CharacterQuestion[] riddle { get; set; }
        public CharacterQuestion SelectedQuestion { get; set; }

        public Character(
            string name, 
            string helloPhrase, 
            string congratsPhrase,
            string incorrectPhrase, 
            string goodbyePhrase)
        {
            Name = name;
            HelloPhrase = helloPhrase;
            CongratsPhrase = congratsPhrase;
            IncorrectPhrase = incorrectPhrase;
            GoodbyePhrase = goodbyePhrase;
        }

       
    }
}