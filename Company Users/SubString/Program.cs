using System;
using System.Linq;

namespace SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            string removedString = Console.ReadLine().ToLower();

            string text = Console.ReadLine();
            int index = text.IndexOf(removedString);

            while (index != -1)
            {
                text = text.Remove(index, removedString.Length);

                index = text.IndexOf(removedString);
            }

            Console.WriteLine(text);
        }
    }
}
