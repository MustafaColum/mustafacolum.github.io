# Assignments 

### Adventure Game
![Image](https://puu.sh/HysCp/537295e14b.png)

A non-violent and non-linear game.
Based on a dating simulator. Each time the player progresses through the story, they pick up a random item to give to their desired character.

### Study Application
![Image](https://puu.sh/HysMf/ee756c66de.png)

A study application that tests the player's ability to match a term to the correct definition.

### Trivia Game 1.0
![Image](https://puu.sh/HysPx/51d05762f2.png)

A trivia application that allows a player to type in their guess.

# Group Projects

### Underwater Creatures
A project that demonstrates inheritance, polymorphism, and encapsulation. 

### Substitution Cipher
An application that encodes and decodes using a simple substitution cipher.

### Explorable Areas
A command-line game application with areas to explore, with items for the player to find in each area.

### Store Application

Allows players to order items from a menu.

```markdown
class Player
    {
        public string Name;
        public double Money;

        public Player(string name, double money)
        {
            Name = name;
            Money = money;
        }
        public void Greeting()
        {
            Console.WriteLine($"What is your name? ");
            string name = Console.ReadLine();
            string result = "Nice to meet you, " + name;
            Console.WriteLine(result);
        }
        public void ShowBudget()
        {
            double money = 15;
            Console.WriteLine($"You have {money:c}");
        }
```        
