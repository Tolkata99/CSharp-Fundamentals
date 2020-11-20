using System;
using System.Linq;
namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] replace = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToArray();

            string text = Console.ReadLine();
                

            for (int i = 0; i < replace.Length; i++)
            {
                text = text.Replace(replace[i], new string('*', replace[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}
