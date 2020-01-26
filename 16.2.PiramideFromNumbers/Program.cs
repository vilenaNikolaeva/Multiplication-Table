using System;

namespace _16._2.PiramideFromNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int counter = 1;
            bool biggerNumber = false;

            for (int i = 1; i <=number; i++)
            {
                for (int k = 1; k <=i; k++)
                {
                    if (counter>=number)
                    {
                        biggerNumber = true;
                        break;
                    }
                    Console.Write(counter + " ");
                    counter++;
                }
                if (biggerNumber)
                {
                    Console.WriteLine(counter);
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
