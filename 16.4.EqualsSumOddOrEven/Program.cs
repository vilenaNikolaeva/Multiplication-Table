using System;

namespace _16._4.EqualsSumOddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

          
            for (int i = num1; i <=num2; i++)
            {
                int current = i;
                int odd = 0;
                int even = 0;
                while (current>0)
                {
                    odd += current % 10;
                    current /= 10;
                    even += current % 10;
                    current /= 10;
                }
                if (odd==even)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
