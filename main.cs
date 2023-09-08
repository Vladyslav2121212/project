using System; 
namespace project
{
    class Program
    {
        static void Main()
        {
             Random random = new Random();
             int[] healthLevels = new int[2];
             int[] attackLevels = new int[2];
             
           for (int i = 0; i < 2; i++)
           {
            healthLevels[i] = random.Next(50, 100); 
            attackLevels[i] = random.Next(10, 20); 
           }

        
           while (healthLevels[0] > 0 && healthLevels[1] > 0)
          {
            healthLevels[1] -= attackLevels[0];
            Console.WriteLine($"Маг 1 атакував Мага 2. У Мага 2 залишилось {healthLevels[1]} здоров'я.");

            
            if (healthLevels[1] <= 0)
            {
                Console.WriteLine("Маг 1 переміг");
                break;
            }
            healthLevels[0] -= attackLevels[1];
            Console.WriteLine($"Маг 2 атакував Мага 1. У Мага 1 залишилось {healthLevels[0]} здоров'я");
            
            if (healthLevels[0] <= 0)
            {
                Console.WriteLine("Маг 2 переміг");
                break;
            }
            
          }

        }
    }
}
