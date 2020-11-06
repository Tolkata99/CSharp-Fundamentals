using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeesOneAsk = int.Parse(Console.ReadLine());
            int employeesTwoAsk = int.Parse(Console.ReadLine());
            int employeesThreeAsk = int.Parse(Console.ReadLine());

            int peopleWaiting = int.Parse(Console.ReadLine());

            int totalTimeEmployeesHour = employeesOneAsk + employeesThreeAsk + employeesTwoAsk;
            int hours = 0;

            while (peopleWaiting > 0)
            {
                hours++;
                if(hours % 4 == 0)
                {
                    continue;
                }

                peopleWaiting -= totalTimeEmployeesHour;
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
