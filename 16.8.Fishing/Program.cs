using System;

namespace _16._8.Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int quota = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double fishPrice = 0;
            double total = 0;
            int counter = 0;
            double tirdFish = 0;
            double kg = 0;

            while (command!="Stop" || counter!=quota)
            {
                if (counter==quota)
                {
                    break;
                }
                else if (command=="Stop")
                {
                    break;
                }
                for (int i = 0; i < quota; i++)
                {
                    kg = double.Parse(Console.ReadLine());
                    counter++;
                    for (int k = command.Length-1; k >= 0; k--)
                    {
                        char symbol = command[k];
                        double inNumber = Convert.ToInt32(symbol);
                        total +=Math.Abs(inNumber);
                    }
                    if (counter % 3 == 0)
                    {
                        tirdFish += total / kg;
                    }
                    else
                    {
                        fishPrice += Math.Abs(total / kg);
                    }

                    if (counter == quota)
                    {
                        break;
                    }
                    command = Console.ReadLine();
                    if (command == "Stop")
                    {
                        break;
                    }
                    total = 0;
                }
            }
            if (command=="Stop"|| counter==quota)
            {
                if (counter == quota)
                {
                    Console.WriteLine("Lyubo fulfilled the quota!");
                    if (tirdFish >= fishPrice)
                    {
                        Console.WriteLine($"Lyubo's profit from {counter} fishes is {Math.Abs(tirdFish - fishPrice):f2} leva.");
                    }
                    else
                    {
                        Console.WriteLine($"Lyubo lost {Math.Abs(fishPrice - tirdFish):f2} leva today.");
                    }
                }
                else if (command == "Stop")
                {
                    if (tirdFish >= fishPrice)
                    {
                        Console.WriteLine($"Lyubo's profit from {counter} fishes is {Math.Abs(tirdFish - fishPrice):f2} leva.");
                    }
                    else if (fishPrice >= tirdFish)
                    {
                        Console.WriteLine($"Lyubo lost {Math.Abs(fishPrice - tirdFish):f2} leva today.");
                    }
                }
            }
        }
    }
}
