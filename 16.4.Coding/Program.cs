using System;

namespace _16._4.Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int total = 0;

            for (int i =number.Length-1; i>=0; i--)
            {
                char symbol = number[i];
                string toParse = symbol.ToString();
                int inNumber = int.Parse(toParse);
                if (inNumber==0)
                {
                    Console.WriteLine("ZERO");
                }
                for (int j = 0; j <inNumber && inNumber!=0; j++)
                {
                    total = inNumber + 33;
                    char ascii = (char)total;
                    Console.Write(ascii);
                }
                if (inNumber!=0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
