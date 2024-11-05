int playerHealth = 100;
float playerAttack = 15.5f;
bool isParalyzed = true;
double playerCurrency = 24.75f;

Console.WriteLine("Please enter your name");
string name = Console.ReadLine();
Console.Clear();

Console.WriteLine($"{name}");
Console.WriteLine($"Health: {playerHealth}");
Console.WriteLine($"Attack Power: {playerAttack}");
Console.WriteLine($"Paralyzed: {isParalyzed}"); 
Console.WriteLine($"Gold Coins: {playerCurrency}");