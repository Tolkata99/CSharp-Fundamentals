using System;

namespace _07StringExplotion
{
    class Program
    {
        static void Main(string[] args)
        {
            var feild = Console.ReadLine();
            int bomb = 0;


            for (int i = 0; i < feild.Length; i++)
            {
                var currChar = feild[i];

                if(currChar == '>')
                {
                    bomb += int.Parse(feild[i + 1].ToString());
                    continue;
                }

                if(bomb > 0)
                {
                    feild = feild.Remove(i, 1);
                    bomb--;
                    i--;
                }
            }
            Console.WriteLine(feild);

        }
    }
}
