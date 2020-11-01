
using System;

namespace exersie
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStudents = int.Parse(Console.ReadLine());
            int numLesson = int.Parse(Console.ReadLine());
            int firstBonus = int.Parse(Console.ReadLine());

            double currLesson = 0 ;
            double min = double.MinValue;

            for (int i = 0; i < numStudents; i++)
            {
                double presence = double.Parse(Console.ReadLine());

                double totalBonus = (presence / numLesson) * (5 + firstBonus);
                
                if(totalBonus > min)
                {
                    min = totalBonus;
                    currLesson = presence;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Round(min)}.");
            Console.WriteLine($"The student has attended {currLesson} lectures.");

        }
    }
}
