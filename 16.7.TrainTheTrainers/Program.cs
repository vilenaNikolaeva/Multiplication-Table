using System;

namespace _16._7.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();

            double grade = 0;
            double finalGrade = 0;
            double counter = 0;
            int gradesCounter = 0;

            while (presentation != "Finish")
            {
               
                for (int i = 0; i < jury; i++)
                {
                    grade = double.Parse(Console.ReadLine());
                    counter += grade;
                    finalGrade += grade;
                    gradesCounter++;
                }
                Console.WriteLine($"{presentation} - {counter/jury:f2}.");
                grade = 0;
                counter = 0;
                presentation = Console.ReadLine();
            }
            if (presentation=="Finish")
            {
                Console.WriteLine($"Student's final assessment is {finalGrade/gradesCounter:f2}.");
            }
        }
    }
}
