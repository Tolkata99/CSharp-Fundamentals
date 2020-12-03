using System;
using System.Linq;

namespace ActivationsKey
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string[] comand = Console.ReadLine()
                .Split(">>>", StringSplitOptions.RemoveEmptyEntries);
           
            while (comand[0] != "Generate")
            {
                string nameComand = comand[0];
                if (nameComand == "Slice")
                {
                    int count = int.Parse(comand[2]) - int.Parse(comand[1]);
                    text = text.Remove(int.Parse(comand[1]), count);
                    Console.WriteLine(text);
                }
                else if (nameComand == "Flip")
                {
                    int start = int.Parse(comand[2]);
                    int end = int.Parse(comand[3]) - int.Parse(comand[2]);
                    if (comand[1] == "Upper")
                    {
                        string a = text.Substring(start, end).ToUpper();
                        text = text.Remove(start, end);
                        text = text.Insert(start, a);

                        Console.WriteLine(text);
                    }
                    else if (comand[1] == "Lower")
                    {
                        string a = text.Substring(start, end).ToLower();
                        text = text.Remove(start, end);
                        text = text.Insert(start, a);

                        Console.WriteLine(text);
                    }
                    
                }
                else if(nameComand == "Contains")
                {
                    if(text.Contains(comand[1]))
                    {
                        Console.WriteLine($"{text} contains {comand[1]}.");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }





                comand = Console.ReadLine()
            .Split(">>>", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"Your activation key is: {text}");

        }
    }
}
