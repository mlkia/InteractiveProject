// See https://aka.ms/new-console-template for more information
using Interactive_Saga;

MessageHelper messageHelper = new(); // instansiera menyn
messageHelper.WelcomeMessage(); //anropar metod för välkomstmeddelande

MainMenu menu = new(); // instansiera menyn
menu.RunMenu(); //anropa menyn