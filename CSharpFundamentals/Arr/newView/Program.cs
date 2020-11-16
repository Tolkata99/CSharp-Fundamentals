using System;

namespace newView
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
        }

        static void printLine(int start = 1, int n = int.Parse(Console.ReadLine());
        {
            for (int i = start; i <= n; i++)
            {
                Console.Write("{0} ", i);

                Console.WriteLine();
            }
        }
        //static void printTriangle(int n)
        //{
        //    for (int line = 1; line <= n; line++)
        //    {
        //        printLine(1, line);
                
        //    }
        //    for (int line = n - 1; line <= 1; line--)
        //    {
        //        printLine(1, line);
        //    }
        //}


    }
}
