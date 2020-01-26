using System;

namespace _15._7.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFloors = int.Parse(Console.ReadLine());
            int numberRoomsOnFloor = int.Parse(Console.ReadLine());


            for (int i = numberFloors; i >= 1; i--)
            {
                
                for (int k = 0; k <numberRoomsOnFloor; k++)
                {
                    if (numberFloors==i)
                    {
                        Console.Write($"L{i}{k} ");
                    }
                    else if (i%2==0)
                    {
                        Console.Write($"O{i}{k} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{k} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
