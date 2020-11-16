using System;
using System.Linq;
namespace Type
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int[] curName = new int[50];
            for (int i = 0; i < n; i++)
            {
                string currentName = Console.ReadLine();

                

                int total = 0;
                for (int j = 0; j < curName.Length; j++)
                {
                    char letter = currentName[i];
                    int sum = ((int)letter);
                    total += sum;
                    
                    
                }
                curName[i] = total;
            }
            Console.Write(string.Join(" ",curName));
            
            
        }
    }
}
