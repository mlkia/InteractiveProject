using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveProject.Helper
{
    public static class CharacterHelper
    {
        public static Dictionary<int,Character> Characters { get; set; } = new Dictionary<int, Character>();

        public static Character? GetCharacter (int lvl)
        {
            return Characters.TryGetValue(lvl, out var character) ? character : null;
        }

        public static void SetupCharacters()
        {
            Character rabbit = new Character("Rabby", "Hello buddy! My name is Rabby!", "Yes, that´s right, buddy!", "Oh no, I´m so sorry! That answer is wrong! ", "Good bye, Good luck to you!");
            rabbit.riddle = new CharacterQuestion[6];
            rabbit.riddle[1] = new ("What has hands and a face, but can’t hold anything or smile?", "A. Clock /  B.Mirror / C.Sun", "Every person has this thing at home or in their bag", "A");
            rabbit.riddle[2] = new ("It belongs to you, but your friends use it more. What is it?", "A. Trust / B. Your name  / C. Time", "It is something very important for yourself", "B");
            rabbit.riddle[3] = new ("If you don’t keep me, I’ll break. What Am I?", "A. Promise / B. Health / C. Love", "It is the thing that costs more than gold", "A");
            rabbit.riddle[4] = new ("I can fill a room, but I take up no space. What am I? ", "A. Sound  / B. Light / C. Thought", "Think about physics", "B");
            rabbit.riddle[5] = new ("5.	If I have it, I don’t share it. If I share it, I don’t have it. What is it?", "A. Silence / B. Money / C. My partner", "If you don´t say anything?", "A");
            Characters.Add(1, rabbit);

            Character reindeer = new Character("Bambi", "Hello, my name is Bambi !", "Yees! That´s right, my friend!", "So sorry! Your answer is wrong!", "Bye! Bye! I wish you good luck with the Ice Queen!");
            reindeer.riddle = new CharacterQuestion[6];
            reindeer.riddle[1] = new("Which flower does produce opium?", "A. Poppy / B. Tulip / C. Carnation", "These small black grains usually can be found in sweet buns", "A");
            reindeer.riddle[2] = new("Which flower do you use to get saffron?", "A. Sunflower/ B. Crocus / C. Lily", "You usually eat  buns this spice on Christmas", "B");
            reindeer.riddle[3] = new("Which fruit is a stone fruit ? ", "A.Apple / B. Peach / C. Apelsin", "It is something yellow/orange and juicy", "B");
            reindeer.riddle[4] = new("What kind of animal is the fastest animal on the land?", "A. Puma / B. Leopard / + C. Cheetah", "( It sounds similar to leopard", "C");
            reindeer.riddle[5] = new("Which edible fungus does have another name as stone fungus?", "A.Mushroom/ B. Chantarelle / C. Penny bun", "It has white body and brown hat", "C");
            Characters.Add(2, reindeer);

            Character iceQueen = new Character(" Queen", "Hello  My name is Rabby!", "Oh, that´s right!", " That answer is wrong! ", "Bye! You have answered all my questions, you fool, but we will meet again some day! Run for your Life!");
            iceQueen.riddle = new CharacterQuestion[6];
            iceQueen.riddle[1] = new("What result is of this equation:  0.3 * 0.5? ", "A. 0.15 / B. 1.5 / C. 15", " Mathematics from 4-5 classes", "A");
            iceQueen.riddle[2] = new("What result is of this equation: (-2) *(-6)*(-7)´2 (upphöjt till två)", "A. 588 / B. -588 / C.168 ", "Mathematics from 8-9 classes", "A");
            iceQueen.riddle[3] = new("What result will be if you simplify this equation rutten av 12 – rutten av 3", "A.0 / B. 9 / C.rutten av tre ", "Mathematics from class 9 - Mathematics 1C", "C");
            iceQueen.riddle[4] = new("What result is of this equation will be if you simplify this equation 5x-(3x-(x-1))", "A. x-1 / B. x+1 / C. 1 ", "Mathematics from 8-9 classes", "B");
            iceQueen.riddle[5] = new("What result is of this equation if you develop it  (2x +3y)´2(upphöjt till två)? ", "A. 2x´2 +6x + 6y´2 /  B. 4x´2 + 12 xy + 9y´2 / C. 4x +12xy + 9y ", "Mathematics from 8-9 classes", "B");
            Characters.Add(3, iceQueen);
        }
    }
}
