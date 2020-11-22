using System;
using System.Linq;

namespace stringLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = (Console.ReadLine());
            string letters = string.Empty;
            string numbers = string.Empty;
            string others = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    letters += text[i];
                }
                else if (char.IsDigit(text[i]))
                {
                    numbers += text[i];
                }
                else
                {
                    others += text[i];
                }

            }

            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
