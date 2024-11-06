
// For Loop
Console.WriteLine("Spawning enemies using a for loop:");
int numEnemiesForLoop = 5;
        
for (int i = 1; i <= numEnemiesForLoop; i++)
{
    Console.WriteLine($"Enemy #{i} spawned!");
}

// While Loop
Console.WriteLine("\nSpawning enemies using a while loop:");
int enemiesSpawned = 0;
int maxEnemiesWhileLoop = 3;

while (enemiesSpawned < maxEnemiesWhileLoop)
{
    enemiesSpawned++;
    Console.WriteLine($"Enemy #{enemiesSpawned} spawned!");
}