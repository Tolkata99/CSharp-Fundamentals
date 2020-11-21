using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _05MultiplyBigInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            int temp = 0; 

            string longNum = Console.ReadLine().TrimStart('0');
            int seconds = int.Parse(Console.ReadLine());

            if(seconds == 0 || longNum == "")
            {
                Console.WriteLine(0);
                return;
            }
            foreach (char ch in longNum.Reverse())
            {
                int digit = int.Parse(ch.ToString());
                int result = digit * seconds + temp;

                int restDigit = result % 10;
                temp = result / 10;
                sb.Insert(0, restDigit);
            }
            if(temp > 0)
            sb.Insert(0, temp);

            Console.WriteLine(sb);
        }
    }
}
