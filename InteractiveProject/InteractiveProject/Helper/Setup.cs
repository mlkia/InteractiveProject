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
            // instansiera menyn
            MessageHelper.WelcomeMessage(); //anropar metod för välkomstmeddelande

            CharacterHelper.SetupCharacters();

            // instansiera menyn

            MainMenu.RunMenu(); //anropa menyn
        }
    }
}
