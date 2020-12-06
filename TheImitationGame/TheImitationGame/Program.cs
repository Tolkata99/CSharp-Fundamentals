using System;

namespace TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            string cmd = Console.ReadLine();

            while (cmd != "Decode")
            {
                string[] cmArg = cmd.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string comand = cmArg[0];

                if(comand == "Move")
                {
                    int nLeters = int.Parse(cmArg[1]);

                    string first = text.Substring(0, nLeters);
                    string seconds = text.Substring(nLeters, text.Length - nLeters);

                    text = seconds + first;
                   

                }
                else if(comand == "Insert")
                {
                    int index = int.Parse(cmArg[1]);
                    string insert = cmArg[2];

                    text = text.Insert(index, insert);
                }
                else if(comand == "ChangeAll")
                {
                    string old = cmArg[1];
                    string nnew = cmArg[2];

                    text = text.Replace(old, nnew);
                }



                cmd = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {text}");
        }
    }
}
