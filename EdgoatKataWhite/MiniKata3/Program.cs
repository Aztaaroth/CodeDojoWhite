
Random rand = new Random();
int playerLuck = rand.Next(1, 11); // Generates a number between 1 and 10

string choice = "";

while (true) // Loop in case the answer isn't "Yes" or "No"
{
    Console.WriteLine("You encounter an enemy! Do you want to attempt an attack? (yes/no)");
    choice = Console.ReadLine().ToLower(); // Makes the input Lowercase for visual clarity

    // Checks if the input is valid
    if (choice == "yes" || choice == "no")
    {
        break; // Exit loop if input is valid
    }
    else
    {
        Console.WriteLine("Invalid choice! Please type 'yes' or 'no'.");
    }
}

if (choice == "yes")
{
    Console.WriteLine("Attempting to attack...");
    
    if (playerLuck > 7)
    {
        Console.WriteLine("Success! Your attack hits the enemy.");
    }
    else if (playerLuck == 6 || playerLuck == 7)
    {
        Console.WriteLine("Close call! Your attack barely succeeded.");
    }
    else
    {
        Console.WriteLine("Oh no! Your attack missed.");
    }
}
else // choice = "no"
{
    Console.WriteLine("You chose to retreat and avoid the fight.");
}

// Displays player's luck for debugging/testing purposes
Console.WriteLine($"(Debug: Player Luck = {playerLuck})");