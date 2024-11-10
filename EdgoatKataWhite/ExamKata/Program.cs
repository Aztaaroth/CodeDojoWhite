       
 // player and enemy stats
 int playerHealth = 100;
 int playerAttackPower = 15;
 int playerHealAmount = 10;
 int enemyHealth = 60; 
 int enemyAttackPower = 15;

 Random random = new Random();

 Console.WriteLine("A wild Goblin appears! The battle begins!\n");

 // Main battle loop
 while (playerHealth > 0 && enemyHealth > 0)
 { 
     // Display current health status
     Console.WriteLine($"Hero's Health: {playerHealth}");
     Console.WriteLine($"Goblin's Health: {enemyHealth}\n");

     // Player's turn
     Console.WriteLine("Choose an action:");
     Console.WriteLine("1. Attack");
     Console.WriteLine("2. Heal");
     Console.Write("> ");
     string choice = Console.ReadLine();

     if (choice == "1") // Player attacks
     { 
         Console.WriteLine("Hero attacks the Goblin!");
         enemyHealth -= playerAttackPower;
         Console.WriteLine($"Goblin takes {playerAttackPower} damage.\n");
     }
     else if (choice == "2") // Player heals
     {
         Console.WriteLine("Hero uses a healing spell!");
         playerHealth += playerHealAmount;
         Console.WriteLine($"Hero heals for {playerHealAmount} health.\n");
     }
     else
     { 
         Console.WriteLine("Invalid choice. Please choose 1 or 2.");
         continue; // Skip enemy's turn if the player made an invalid choice
     }
     
     if (enemyHealth <= 0) // Check if the enemy has been defeated
     {
         Console.WriteLine("Congratulations! Hero has defeated the Goblin!");
         break;
     }

     // Enemy's turn
     Console.WriteLine("Goblin attacks the Hero!");
     playerHealth -= enemyAttackPower;
     Console.WriteLine($"Hero takes {enemyAttackPower} damage.\n");
     
     if (playerHealth <= 0) // Check if the player has been defeated
     { 
         Console.WriteLine("The Hero has been defeated by the Goblin. Game over."); 
         break;
     } 
 }