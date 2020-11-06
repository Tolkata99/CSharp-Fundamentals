using System;

namespace DisnyLand
{
    class Program
    {
        static void Main(string[] args)
        {
            double travelToDisney = double.Parse(Console.ReadLine());
            double month = double.Parse(Console.ReadLine());

            double saveMoney = 0;
            for (int i = 1; i <= month; i++)
            {
                
                if (i != 1)
                {
                    if (i % 2 == 1)
                    {
                        saveMoney -= saveMoney * 0.16;

                    }
                    if(i % 4 == 0)
                    {
                        saveMoney += saveMoney * 0.25;
                    }
                }

                saveMoney += travelToDisney * 0.25;
            }
            double result = saveMoney - travelToDisney;
            if(result > 0)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have " +
                    $"{result:f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {Math.Abs}lv. more.");
            }


            Console.WriteLine(saveMoney);

        }
    }
}
