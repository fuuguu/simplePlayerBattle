internal class Program
{
    private static void Main(string[] args)
    {
        int playerHealth=100;
        int playerDamage=25;
        int enemyHealth=300;
        int enemyDamage=10;

        while(playerHealth>0&&enemyHealth>0)
        {
            playerHealth -= enemyDamage;
            enemyHealth -= playerDamage;

            Console.WriteLine(playerHealth + "Игрок");
            Console.WriteLine(enemyHealth + "Враг");
        }

        if(playerHealth<=0 && enemyHealth <= 0)
        {
            Console.WriteLine("Ничья");
        }
        else if (enemyHealth <= 0)
        {
            Console.WriteLine("Победа игрока");
        }
        else if (playerHealth <= 0)
        {
            Console.WriteLine("Победа врага");
        }
    }
}