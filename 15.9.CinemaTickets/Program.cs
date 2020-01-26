using System;

namespace _15._9.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            double freeSeats = 0;
            string command = "";


            int standard = 0;
            int kid = 0;
            double student = 0;
            double total = 0;
            double currentCount = 0;
            double totalCount = 0;

           
             while (filmName != "Finish")
            {
                freeSeats = int.Parse(Console.ReadLine());
                currentCount = 0;
                for (int i = 0; i <= freeSeats; i++)
                {
                    command = Console.ReadLine();
                    if (command == "End")
                    {
                        total = (100 / freeSeats) * currentCount;
                        Console.WriteLine($"{filmName} - {total:f2}% full.");
                        total = 0;
                        break;
                    }
                    else if (command=="Finish")
                    {
                        total = (100 / freeSeats) * currentCount;
                        Console.WriteLine($"{filmName} - {total:f2}% full.");
                        filmName = "Finish";
                        total = 0;
                        break;
                    }
                    else if (command == "student")
                    {
                        student++;
                    }
                    else if (command == "standard")
                    {
                        standard++;
                    }
                    else if (command == "kid")
                    {
                        kid++;
                    }
                    currentCount++;
                    totalCount++;
                }
                if (filmName == "Finish")
                {
                    Console.WriteLine($"Total tickets: {totalCount}");
                    Console.WriteLine($"{(100 / totalCount) * student:f2}% student tickets.");
                    Console.WriteLine($"{(100 / totalCount) * standard:f2}% standard tickets.");
                    Console.WriteLine($"{(100 / totalCount) * kid:f2}% kids tickets.");
                    break;
                }
                filmName = Console.ReadLine();
            }
        }
    }
}

