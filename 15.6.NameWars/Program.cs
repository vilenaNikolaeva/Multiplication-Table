using System;

namespace _15._6.NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name =Console.ReadLine();
            int sum = 0;
            int maxResult = int.MinValue;
            string currentName = string.Empty;

            while (name!="STOP")
            {
                for (int i = 0; i <name.Length; i++)
                {
                    char symbol = name[i];
                    int inNumber =(char)symbol;
                    sum += inNumber;
                }
                if (sum > maxResult)
                {
                    maxResult = sum;
                    currentName = name;
                }
                sum = 0;
                name = Console.ReadLine();
                if (name == "STOP")
                {
                    Console.WriteLine($"Winner is {currentName} - {maxResult}!");
                }
            }
           
        }
    }
}
