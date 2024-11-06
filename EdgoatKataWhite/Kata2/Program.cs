
string characterName = "Lory";
int level = 7;
float healthPoints = 83.7f;
double experiencePoints = 1125.80;
bool hasMagicAbility = true;
char rank = 'A';

// Exp needed to level up
double nextLevelThreshold = 1200.0;
double pointsToNextLevel = nextLevelThreshold - experiencePoints;


Console.WriteLine($"Character Name: {characterName}");
Console.WriteLine($"Level: {level}");
Console.WriteLine($"Health Points: {healthPoints}");
Console.WriteLine($"Experience Points: {experiencePoints}");
Console.WriteLine($"Has Magic Ability: {hasMagicAbility}");
Console.WriteLine($"Rank: {rank}");

// Exp needed until next level up
Console.WriteLine($"Points needed to reach next level: {pointsToNextLevel}");