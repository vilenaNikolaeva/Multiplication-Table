using System;

namespace _16._6.SumPrimeOrNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine(); ;
            int primeNum = 0;
            int nonPrimeNu=0;
            bool prime = true;
            

            while (command!="stop")
            {
                int input = int.Parse(command);
                prime = true;

                if (input < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    int num = input / 2;
                    for (int i = 2; i <= num; i++)
                    {
                        if (input % i == 0)
                        {
                            nonPrimeNu += input;
                            prime = false;
                            break;
                        }
                    }
                    if (prime)
                    {
                        primeNum += input;
                    }
                }
                command = Console.ReadLine();
            }
            if (command=="stop")
            {
                Console.WriteLine($"Sum of all prime numbers is: {primeNum}");
                Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNu}");
            }
        }
    }
}
