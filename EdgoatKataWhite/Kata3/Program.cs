
Random random = new Random();
int playerLuck = random.Next(1, 11); // Generate a playerLuck value between 1 and 10

string choice = "";
bool validChoice = false;

while (!validChoice) // Display initial choices and keep asking until the player enters a valid choice
{
    Console.WriteLine("You find a mysterious treasure chest! What will you do?");
    Console.WriteLine("1. Open the chest");
    Console.WriteLine("2. Ignore the chest");
    Console.WriteLine("3. Leave the area");
    Console.Write("> ");
    
    choice = Console.ReadLine();

    
    if (choice == "1" || choice == "2" || choice == "3") // Check if the choice is valid
    {
        validChoice = true; // Exit the loop on a valid choice
    }
    else
    {
        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
    }
}


if (choice == "1")
{
    Console.WriteLine("You try to open the chest...");
    
    if (playerLuck > 7)
    {
        Console.WriteLine("Success! The chest contains a rare gem.");
    }
    else if (playerLuck >= 5)
    {
        Console.WriteLine("You find some gold in the chest.");
    }
    else
    {
        Console.WriteLine("Oh no! The chest was trapped, you got teleported away. Better luck next time!");
    }
}
else if (choice == "2")
{
    Console.WriteLine("You decided to ignore the chest and continued on your journey.");
}
else if (choice == "3")
{
    Console.WriteLine("You left the area, leaving the mystery unsolved.");
}