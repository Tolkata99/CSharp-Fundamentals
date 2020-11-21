using System;
using System.Text;

namespace _07CharArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            var input = Console.ReadLine().ToCharArray();
            string result = string.Empty;
            for (int i = 0; i < input.Length - 1; i++)
            {
                
                if(input[i] != input[i+1])
                {
                    sb.Append(input[i]);
                }
            }
            sb.Append(input[input.Length - 1]);
            Console.WriteLine(sb);
        }
    }
}
