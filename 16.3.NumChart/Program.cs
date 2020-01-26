using System;

namespace _16._3.NumChart
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int current = 1;

            for (int row = 0; row <number; row++)
            {
                for (int col = 0; col < number; col++)
                {
                    current = row + col + 1;
                    if (current>number)
                    {
                        current = 2 * number - current;
                    }
                    Console.Write(current + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
