using System;
using System.Text;

namespace PasswordResset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            StringBuilder sb = new StringBuilder();


            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string comandIf = tokens[0];
                if(comandIf == "Done")
                {
                    break;
                }

                if (comandIf == "TakeOdd")
                {
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sb.Append(password[i]);
                        }

                    }
                    password = sb.ToString();
                    Console.WriteLine(password);

                }
                else if (comandIf == "Cut")
                {
                    int index = int.Parse(tokens[1]);
                    int lenght = int.Parse(tokens[2]);

                    password = password.Remove(index, lenght);
                    Console.WriteLine(password);

                }
                else if (comandIf == "Substitute")
                {
                    string substring = tokens[1];
                    string substitute = tokens[2];
                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }


                    

                }


            }
            Console.WriteLine($"Your password is: {password}");



        }
    }
}
