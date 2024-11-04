

Console.WriteLine("Welcome to Edgoat's coding dojo, what's your name?");
string? name = Console.ReadLine();
Console.WriteLine($"Welcome {name}! I hope you will enjoy learning as much as I enjoy teaching");
Console.WriteLine("Say, how excited are you on a scale of 1 to 10? Where 1 is bored and 10 is super excited.");
string? excitedString = Console.ReadLine();
int excited = int.Parse(excitedString);

    if (excited <= 3)
    {
        Console.WriteLine("Oh... Im sorry to hear that, I'll make some changes so you hopefully next session you will enjoy it more!");
    }
    else if (excited <= 5)
    {
        Console.WriteLine("Oh, and here I thought I was doing a great job...");
    }
    else if (excited <= 7)
    {
        Console.WriteLine("How fun, I hope to see you in future lectures");
    }
    else if (excited <= 10)
    {
        Console.WriteLine("Perfect! That means Im doing my work correctly, see you next lecture!");
    }
    