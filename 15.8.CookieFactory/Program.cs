using System;

namespace _15._8.CookieFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int batchNumber =int.Parse(Console.ReadLine());

            string product = string.Empty;
            int eggsCount = 0;
            int sugarCount = 0;
            int flourCount = 0;
            int count = 0;


            for (int i = 0; i <batchNumber; i++)
            {
                product = Console.ReadLine();
                eggsCount = 0;
                flourCount = 0;
                sugarCount = 0;
                while (product!="Bake!")
                {
                    if (product=="eggs")
                    {
                        eggsCount++;
                    }
                    else if (product=="flour")
                    {
                        flourCount++;
                    }
                    else if (product=="sugar")
                    {
                        sugarCount++;
                    }
                    product = Console.ReadLine();
                }
                count++;
                if (eggsCount >= 1 && flourCount >= 1 && sugarCount >= 1)
                {
                    Console.WriteLine( $"Baking batch number {count}...");
                }
                else
                {
                    count -=1;
                    i -= 1;
                    Console.WriteLine("The batter should contain flour, eggs and sugar!");
                }
            }//90t+.80t.
        }
    }
}
