using System;
using System.Text;

namespace ReversetString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            printText(text,n);
        }

        static void printText(string str,int n)
        {
           StringBuilder result = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                result.Append(str);
            }
            Console.WriteLine(result);
        }
    }
}
