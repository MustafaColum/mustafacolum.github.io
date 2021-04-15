using System;
using System.Collections.Generic;
using System.Text;

namespace TransitionGameRevision
{
    class Player
    {
        public string Name;

        public List<Item> inv = new List<Item>();
        public List<Character> friends = new List<Character>();
        public void NameCharacter()
        {
            Console.WriteLine("What will you be called?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nEnter your name here: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Name = Console.ReadLine();

            Console.ResetColor();
            Console.Write("\n\nYou're on your way, ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{Name}");
            Console.ResetColor();
            Console.Write($".\n\n\n");
        }
    }
}
