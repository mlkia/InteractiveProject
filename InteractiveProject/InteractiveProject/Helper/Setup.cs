using Interactive_Saga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveProject.Helper
{
    public static class Setup
    {
        public static void Run()
        {
            User user = new User();
           
            // instansiera menyn
            MessageHelper.WelcomeMessage(user); //anropar metod för välkomstmeddelande

            // instansiera menyn

            MainMenu.RunMenu(user); //anropa menyn
        }

        public static void Adventure()
        {
            Character character = new Character();
            User user = new User();
            while (true)
            {
                Level_1.RunLevel1();
                Level_2.RunLevelTwo();
                Level_3.RunLevelThree();
            }
        }
    }
}
