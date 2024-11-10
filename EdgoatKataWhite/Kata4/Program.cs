
int totalWaves = 3;          // Total number of waves
int enemiesPerWave = 4;       // Number of enemies per wave
int delayBetweenWaves = 2000; // Delay between waves in milliseconds (2 seconds)

for (int wave = 1; wave <= totalWaves; wave++)
{
    Console.WriteLine($"\nWave {wave} is starting!");
    
    for (int enemy = 1; enemy <= enemiesPerWave; enemy++)
    {
        Console.WriteLine($"  Enemy #{enemy} has spawned.");
    }

    Console.WriteLine($"Wave {wave} completed. Preparing for the next wave...");

    
    if (wave < totalWaves)  // No delay after the last wave
    {
        Thread.Sleep(delayBetweenWaves); // Delay between waves (Change time on line 4)
    }
}


Console.WriteLine("\nAll waves completed! Victory is yours!"); // Victory message after all waves are completed