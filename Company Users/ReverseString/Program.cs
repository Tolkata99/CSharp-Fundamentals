using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            while (input != "end")
            {
                string unReversed = input;
                string reversed = "";

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversed += input[i];
                }

                
                Console.WriteLine($"{unReversed }={ reversed}");
                input = Console.ReadLine();
            }
            
        }
    }
}
