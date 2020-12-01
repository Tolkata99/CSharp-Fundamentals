using System;
using System.Collections.Generic;
using System.Linq;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listsWeapon = Console.ReadLine()
                                     .Split("|")
                                     .ToList();


            string[] printOdd = new string[listsWeapon.Count];
            string[] printEven = new string[listsWeapon.Count];
            int indx = 0;
            while (true)
            {
                string comand = Console.ReadLine();
                if (comand == "Done")
                {
                    break;
                }
                string[] tok = comand.Split(" ");

                string comandFirst = tok[1];


                if (comandFirst == "Left")
                {
                    int index = int.Parse(tok[2]);

                    if (index > 0 && index <= listsWeapon.Count)
                    {

                        string name = listsWeapon[index];
                        listsWeapon.RemoveAt(index);

                        listsWeapon.Insert(index - 1, name);

                    }
                }
                else if (comandFirst == "Right")
                {
                    int index = int.Parse(tok[2]);
                    if (index >= 0 && index < listsWeapon.Count)
                    {

                        string name = listsWeapon[index];
                        listsWeapon.RemoveAt(index);
                        if(index == listsWeapon.Count)
                        {
                            listsWeapon.Insert(index, name);
                        }
                        else
                        {
                            listsWeapon.Insert(index + 1, name);
                        }
                        

                    }


                }
                else if (comandFirst == "Even")
                {
                    for (int i = 0; i < listsWeapon.Count; i++)
                    {
                        
                        
                          if (i % 2 == 0)
                          {

                              for (int j = indx; j < listsWeapon.Count; j++)
                              {
                                  printEven[j] = listsWeapon[i];
                                  indx++;
                                  break;
                              }


                          }
                        
                    }
                    Console.WriteLine(string.Join(" ", printEven));
                }
                else if (comandFirst == "Odd")
                {
                    for (int i = 0; i < listsWeapon.Count; i++)
                    {


                        if (i % 2 == 1)
                        {

                            for (int j = indx; j < listsWeapon.Count; j++)
                            {
                                printOdd[j] = listsWeapon[i];
                                indx++;
                                break;
                            }


                        }

                    }
                    Console.WriteLine(string.Join(" ", printOdd));

                }

            }
            Console.WriteLine($"You crafted {string.Join("", listsWeapon)}!");
        }

    }
}
