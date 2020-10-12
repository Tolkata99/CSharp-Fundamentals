using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine());

            while (input != "END")
            {
                bool output = IsPalindrome(input);
                Console.WriteLine(output);

                input = Console.ReadLine();
            }
            
        }
        private static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;
            char[] chars = input.ToLower().ToCharArray();
            for (int i = 0; i < chars.Length / 2; i++)
                if (chars[i] != chars[chars.Length - 1 - i])
                    return false;
            return true;
        }
    }
}
