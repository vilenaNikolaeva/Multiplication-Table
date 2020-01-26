using System;

namespace _16._1.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                for (int k = a; k <=b; k++)
                {
                    for (int l = c; l <=d; l++)
                    {
                        for (int m = c; m <=d; m++)
                        {
                            if (i+m==k+l && i!=k && l!=m)
                            {
                                Console.WriteLine($"{i}{k}");
                                Console.WriteLine($"{l}{m}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        } 
    }
}
