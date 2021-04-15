using System;
using System.Collections.Generic;
using System.Text;

namespace TransitionGameRevision
{
    class Game
    {
        int Scenarios = 3;
        List<Character> npcs = new List<Character>();
        Gacha gacha = new Gacha();
        Player player = new Player();
        public void StartGame()
        {
            gacha.itemsFill();
            player.NameCharacter();
            Choice();
        }

        public void Choice()
        {
            npcs.Add(new Character("Noelle", new Item("Origami Rose", "Seems like a folded piece of red paper the shape of a rose.")));
            npcs.Add(new Character("Benny", new Item("Sketch Pad", "Seems like a rusty sketch pad, was it lost?")));
            for (int section = 1; section <= Scenarios; section++)
            {
                string input = "";

                switch (section)
                {
                    case 1:
                        Console.WriteLine(Story.PartOne[0]);


                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\nEnter your choice here: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        input = Console.ReadLine();
                        input = input.ToLower();

                        if (input == "a")
                        {
                            Console.ResetColor();
                            Console.WriteLine(Story.PartOne[1]);
                            next();
                        }
                        else
                        {
                            Console.ResetColor();
                            Console.WriteLine(Story.PartOne[2]);
                            next();
                        }

                        Console.WriteLine(Story.PartOne[3]);
                        next();
                        if (input == "a")
                        {
                            Console.ResetColor();
                            Console.WriteLine(Story.PartOne[4]);
                            next();
                        }
                        else
                        {
                            Console.ResetColor();
                            Console.WriteLine(Story.PartOne[5]);
                            next();
                        }

                        Item one = gacha.randomizeItem();
                        player.inv.Add(one);
                        

                        Console.Write("\nAs you approach the class, you found something on the floor. It's a ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(one.Name);
                        Console.ResetColor();
                        Console.WriteLine("!");
                        next();

                        Console.WriteLine(Story.PartOne[6]);
                        entertoContinue();
                        Console.Clear();

                        break;

                    case 2:
                        Console.WriteLine(Story.PartTwo[0]);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\nEnter your choice here: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        input = Console.ReadLine();
                        input = input.ToLower();

                        if (input == "a")
                        {
                            Console.ResetColor();
                            Console.WriteLine(Story.PartTwo[1]);
                            next();
                        }
                        else
                        {
                            Console.ResetColor();
                            Console.WriteLine(Story.PartTwo[2]);
                            next();
                        }

                        Console.WriteLine(Story.PartTwo[3]);
                        next();
                        if (input == "a")
                        {
                            Console.ResetColor();
                            Console.WriteLine(Story.PartTwo[4]);
                            next();
                        }
                        else
                        {
                            Console.ResetColor();
                            Console.WriteLine(Story.PartTwo[5]);
                            next();
                        }
                        Item two = gacha.randomizeItem();
                        player.inv.Add(two);


                        Console.Write("\nAs you head out of the class, you found something on the floor. It's a ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(two.Name);
                        Console.ResetColor();
                        Console.WriteLine("!");
                        next();

                        Console.WriteLine(Story.PartTwo[6]);
                        entertoContinue();
                        Console.Clear();

                        break;
                    case 3:

                        Item three = gacha.randomizeItem();
                        player.inv.Add(three);
                        Console.Write("\nAs you approach the Cafeteria, you found something on the floor. It's a ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(three.Name);
                        Console.ResetColor();
                        Console.WriteLine("!");
                        next();

                        Console.WriteLine(Story.PartThree[0]);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\nEnter your choice here: ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        input = Console.ReadLine();
                        input = input.ToLower();

                        if (input == "a")
                        {
                            Console.ResetColor();
                            Console.WriteLine(Story.PartThree[1]);
                            next();

                            Console.WriteLine("\nAre you interested in giving her an item? a) Yes b) No");
                            input = Console.ReadLine();
                            input = input.ToLower();
                            if (input == "a")
                            {
                                Console.WriteLine("\nWhat do you wanna give her?");
                                int index = 0;
                                foreach (var item in player.inv)
                                {
                                    index++;
                                    Console.WriteLine($"{index}) {item.Name}");
                                }

                                 // add chosen item to the npc's inv / item varaibale
                                 // remove item from players
                                int choice = int.Parse(Console.ReadLine());
                                npcs[0].givenItem = player.inv[choice - 1];
                                player.inv.RemoveAt(choice - 1);
                                // Npc item likeablility logic helped by IAM tutor Austin derrickson
                                // seeing if the item you gave is their desired item
                                if (npcs[0].Decision())
                                {
                                    // if they liked the item you gave them then make them a friend and
                                    // remove them from your npcs list
                                    player.friends.Add(npcs[0]);
                                    npcs.RemoveAt(0);
                                    Console.WriteLine("\nYou have given Noelle an Origami Rose");
                                    next();
                                    Console.WriteLine("\"Oh my.. this is wonderful..! I have always made little origami roses when I was a kid, it's still one of my favourite past times\" Noelle says.");
                                    next();
                                    Console.WriteLine("\"Hey, I have an idea! Let's go back to class and make some more before the break is over, shall we?\"");
                                    next();
                                    Console.WriteLine("You both head back to the building...");
                                    next();
                                }
                                else
                                {
                                    Console.WriteLine("\"Oh, I appreciate the thought..!\" Noelle says, \"But I'm not sure what I can do with this.. Sorry\"");
                                    next();
                                    Console.WriteLine("\"It was nice meeting you! I should get going now, see you another time!\"");
                                    next();
                                    Console.WriteLine("Noelle takes off, and you also head back to the building...");
                                    next();
                                }

                            }
                            else
                            {
                                Console.WriteLine("\"It was nice meeting you! I should get going now, see you another time!\"");
                                next();
                                Console.WriteLine("Noelle takes off, and you also head back to the building...");
                                next();
                            }
                        }
                        else
                        {
                            Console.ResetColor();
                            Console.WriteLine(Story.PartThree[2]);
                            next();

                            Console.WriteLine("\nAre you interested in giving him an item? a) Yes b) No");
                            input = Console.ReadLine();
                            input = input.ToLower();
                            if (input == "a")
                            {
                                Console.WriteLine("\nWhat do you wanna give him?");
                                int index = 0;
                                foreach (var item in player.inv)
                                {
                                    index++;
                                    Console.WriteLine($"{index}) {item.Name}");
                                }

                                int choice = int.Parse(Console.ReadLine());
                                npcs[1].givenItem = player.inv[choice - 1];
                                player.inv.RemoveAt(choice - 1);

                                if (npcs[1].Decision())
                                {
                                    player.friends.Add(npcs[1]);
                                    npcs.RemoveAt(1);
                                    Console.WriteLine("\nYou have given Benny a Sketch Pad");
                                    next();
                                    Console.WriteLine("\"Oh hey..! is this my old sketch pad? I've been looking for it everywhere!\" Benny says");
                                    next();
                                    Console.WriteLine("\"Hey! Let's head back with your food and chill over there, you can take a look at my old drawings!\" Benny proposes");
                                    next();
                                    Console.WriteLine("You both head to the table...");
                                    next();
                                }
                                else
                                {
                                    Console.WriteLine("\n\"Oh..! What do you have there?\" Benny says, \"I'm not sure what I can do with this.. Sorry!\"");
                                    next();
                                    Console.WriteLine("\"Anyway, here's your food! We'll catch up another time, yeah?\"");
                                    next();
                                    Console.WriteLine("You take off with your food...");
                                    next();
                                }

                            }
                            else
                            {
                                Console.WriteLine("\"Anyway, here's your food! We'll catch up another time, yeah?\"");
                                next();
                                Console.WriteLine("You take off with your food...");
                                next();
                            }
                        }

                        //Console.WriteLine(Story.PartThree[3]);
                        //next();
                        //if (input == "a")
                        //{
                        //    Console.ResetColor();
                        //    Console.WriteLine(Story.PartThree[4]);
                        //    next();
                        //}
                        //else
                        //{
                        //    Console.ResetColor();
                        //    Console.WriteLine(Story.PartThree[5]);
                        //    next();
                        //}
                        Console.WriteLine(Story.PartThree[6]);
                        entertoContinue();
                        Console.Clear();
                        break;
                    default:
                        entertoContinue();
                        Console.Clear();
                        break;

                }
            }
        }
        public void EndGame()
        {
            Console.WriteLine($"Thanks for playing, {player.Name}!");
            Console.WriteLine($"\nYour ending:\n");

            if (npcs.Count == 2)
            {
                Console.WriteLine("You have reached the ending where you do not give further interest to your friend.");
            }
            else if (player.friends.Count > 0)
            {
                if (player.friends.Count > 1)
                {
                    int index = 1;
                    Console.WriteLine("Choose a friend to date");
                    foreach (var friend in player.friends)
                    {
                        Console.WriteLine($"{index}) {friend.name}");
                        index++;
                    }

                    int choice = int.Parse(Console.ReadLine());

                    //player.friends[choice - 1].happyDialogue;
                }
                else
                {
                    if (player.friends[0].name == "Noelle")
                    {
                        Console.WriteLine("You have reached the ending where you have given Noelle a rose.");
                        next();
                        Console.WriteLine(Story.PartThree[6]);
                    }
                    else
                    {
                        Console.WriteLine("You have reached the ending where you found Benny's old sketch pad.");
                        next();
                        Console.WriteLine(Story.PartThree[6]);
                    }
                }
               

            }
        }

        private void entertoContinue()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPress enter to continue...");
            Console.ResetColor();
            Console.ReadKey();
        }
        private void next()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPress enter to read next...\n");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}