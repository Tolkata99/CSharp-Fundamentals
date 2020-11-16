using System;
using System.Linq;

namespace dayOfWeek
{
    class Program
    {

        static void Main(string[] args)
        {

            string[] arr1 = Console.ReadLine().Split().ToArray();

            string[] arr2 = Console.ReadLine().Split().ToArray();
            string empt = string.Empty;

            string[] empty = new string[];
            for (int i = 0; i < arr1.Length; i++)
            {


                for (int k = 0; k < i; k++)
                {
                    if (arr2[i] == arr1[k])
                    {
                        Console.WriteLine(arr1[i]);
                        Console.WriteLine(arr2[k]);

                    }
                }






            }



        }
    }
}
