using System;

namespace chara
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            int result = 0;
            string text = Console.ReadLine();


            foreach (char item in text)
            {
                if (a < item && b > item)
                {
                    result += item;
                }
            }
            Console.WriteLine(result);



        }
    }
}
