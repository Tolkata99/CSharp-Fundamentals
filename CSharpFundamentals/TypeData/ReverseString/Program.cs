using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] reverseString = Console.ReadLine().Split(' ').ToArray();


            Console.WriteLine(string.Join(' ', reverseString.Reverse()));

        }    
    }
}
