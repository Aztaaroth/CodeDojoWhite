using System.Globalization;

string name = "hero";
int playerHealth = 100;
float playerAttack = 15.5f;
float experience = 250;
bool isParalyzed = true;
double playerCurrency = 24.75;

        
double healthPointsDouble = playerHealth; // Int to Double
Console.WriteLine($"Health as double (implicit conversion): {healthPointsDouble}");

        
int attackPowerInt = (int)playerAttack; // Float to Int
Console.WriteLine($"Attack Power as int (explicit conversion): {attackPowerInt}");

        
int experiencePointsInt = Convert.ToInt32(experience); // Float to Int
Console.WriteLine($"Experience as int (using Convert): {experiencePointsInt}");

        
string currencyString = "150.3333333"; // Parsing String to Double
if (double.TryParse(currencyString, NumberStyles.Float, CultureInfo.InvariantCulture, out double parsedCurrency)) // Had some trouble, according to chatGPT this was the way to solve it
{
    Console.WriteLine($"Gold Coins (parsed from string): {parsedCurrency}");
}
else
{
    Console.WriteLine($"Parsing failed: '{currencyString}' is not a valid double.");
}
       
if (int.TryParse(name, out int parsedInt))
{
    Console.WriteLine($"Parsed integer from name: {parsedInt}");
}
else
{
    Console.WriteLine($"Parsing failed: '{name}' is not a number.");
}

Console.WriteLine("\nCharacter Information:"); 
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Health Points: {playerHealth}");
Console.WriteLine($"Attack Power: {playerAttack}");
Console.WriteLine($"Experience Points: {experience}");
Console.WriteLine($"Is Paralyzed: {isParalyzed}"); 
Console.WriteLine($"Currency Amount: {playerCurrency}");