using System;

namespace _15._4.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combination = 0;
            for (int i = startNumber; i <= endNumber; i++)
            {
                for (int j = startNumber; j <= endNumber; j++)
                {
                    combination++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combination} {i} + {j} = {i + j}");
                        break;
                    }
                }
            }
            Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
        }
    }//40t.
}
