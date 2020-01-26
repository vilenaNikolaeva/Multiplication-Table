using System;

namespace _15._5.Trip
{
    class Program
    {
        static void Main(string[] args)
        {

            string destination =Console.ReadLine();
            int totalSavedMoney = 0;

            while (destination!="Ënd")
            {
                int tripMoney = int.Parse(Console.ReadLine());
                for (int i = 0; i <=tripMoney; i++)
                {
                    int currentSaveSum = int.Parse(Console.ReadLine());
                    totalSavedMoney += currentSaveSum;

                    if (totalSavedMoney>=tripMoney)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }
                totalSavedMoney = 0;
                destination = Console.ReadLine();
                if (destination=="End")
                {
                    break;
                }
            }//60t.
        }
    }
}
