using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveProject.Helper
{
    public static class UserHelper
    {
        public static User? CurrentUser { get; set; }

        public static void CreateUser (string name)
        {
            CurrentUser = new User { UserName = name };
        }

        public static void RewardUser(Character character)
        {
            if (CurrentUser == null)
                return;

            CurrentUser.NumberOfCorrectAnswers++;
            CurrentUser.Diamonds++;
            ConsoleHelper.Write(character.CongratsPhrase);

            if ((CurrentUser.NumberOfCorrectAnswers % 5) == 0)
            {
                CurrentUser.Level++;
                CurrentUser.Key++;
                ConsoleHelper.Write("Congrats! You have now answered all my questions");
                ConsoleHelper.Write(character.GoodbyePhrase);
            }
        }

        public static void Reset()
        {
            CurrentUser = new User { UserName = CurrentUser.UserName };

        }

        public static void PunishUser(Character character)
        {
            ConsoleHelper.Write(character.IncorrectPhrase);

            if (CurrentUser == null)
                return;

            CurrentUser.NumberOfWrongAnswers++;
        }
    }
}
