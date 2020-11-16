using System;

namespace GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if(type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                

                int[] arr = { a, b };
                GetMax(arr );
            }
            if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
               
                char[] arr = { a, b };
            }
            if (type == "string")
            {
                string a = (Console.ReadLine());
                string b = (Console.ReadLine());
                
                string[] arr = { a, b };


            }

                
        }

        private static int GetMax(int arr)
        {
            throw new NotImplementedException();
            Console.WriteLine();
        }

       
    }
}
