using System;

namespace _16._8.PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (char k = (char)097; k <(char)097+L ; k++)
                    {
                        for (char l = (char)097; l <(char)097+L; l++)
                        {
                            for (int m = 1; m <=n; m++)
                            {
                                if (m>i&&m<j)
                                {
                                    Console.Write($"{i}{j}{k}{l}{m}  ");
                                }
                            }
                        }
                    }
                }//not done!
            }
        }
    }
}
