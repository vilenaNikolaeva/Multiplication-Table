using System;

namespace _16._5.EqualLefSumAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;
            int current = 0;

            for (int i = num1; i <=num2 ; i++)
            {
                current = i;
                int fifthDig = current % 10;
                current =(current-fifthDig)/ 10;
                int fourthDig = current % 10;
                current = (current - fourthDig) / 10;
                int tirdDig = current % 10;
                current= (current - tirdDig) / 10;
                int secondDig = current % 10;
                current = (current - secondDig) / 10;
                int firstDig = current % 10;
                current = (current - firstDig) / 10;

                rightSum = fifthDig + fourthDig;
                leftSum = firstDig + secondDig;

                if (leftSum == rightSum)
                {
                    Console.Write(i + " ");
                    continue;
                }
                else if (leftSum>rightSum)
                {
                    rightSum += tirdDig;
                }
                else if (rightSum>leftSum)
                {
                    leftSum += tirdDig;
                }
                if (leftSum==rightSum)
                {
                    Console.Write(i+" ");
                }
                rightSum = 0;
                leftSum = 0;
                
            }
           
           
        }
    }
}
