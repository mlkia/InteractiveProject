using Interactive_Saga;
using InteractiveProject;
using InteractiveProject.Helper;

User user = new();
Level_1 level_1 = new();
Level_2 level_2 = new();
Level_3 level_3 = new();
Character character = new();
Crossroad crossroad = new();
MainMenu mainMenu = new();
MessageHelper messageHelper = new();
QuestionHelper questionHelper = new();
CharacterQuestion characterQuestion = new();
//MessageHelper messageHelper = new(); // instansiera menyn
messageHelper.WelcomeMessage(user); //anropar metod för välkomstmeddelande

//MainMenu mainMenu = new MainMenu(); // instansiera menyn

mainMenu.RunMenu(characterQuestion, user, level_1, level_2, level_3,
        character, crossroad, mainMenu, messageHelper, questionHelper); //anropa menyn