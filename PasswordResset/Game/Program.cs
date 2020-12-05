using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> nameAndHP = new Dictionary<string, int>();
            Dictionary<string, int> nameAndMP = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());
            int hpMax = 100;
            int mpMax = 200;

            for (int i = 0; i < n; i++)
            {
                string[] heroes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = heroes[0];
                int HP = int.Parse(heroes[1]);
                int MP = int.Parse(heroes[2]);

                nameAndHP[name] = HP > hpMax ? hpMax : HP;
                nameAndMP[name] = MP < mpMax ? MP : mpMax;
            }

            string inputGame = Console.ReadLine();
            while (inputGame != "End")
            {
                string[] tokens = inputGame.Split(" - ");
                string comArg = tokens[0];
                string heroName = tokens[1];
                if (comArg == "CastSpell")
                {
                    int needMp = int.Parse(tokens[2]);
                    string nameMagic = tokens[3];

                    if (nameAndMP[heroName] >= needMp)
                    {
                        nameAndMP[heroName] -= needMp;
                        Console.WriteLine($"{heroName} has successfully cast {nameMagic} and now has {nameAndMP[heroName]} MP!");

                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {nameMagic}!");
                    }
                }
                else if (comArg == "TakeDamage")
                {
                    int damage = int.Parse(tokens[2]);
                    string attacker = tokens[3];

                    nameAndHP[heroName] -= damage;
                    if (nameAndHP[heroName] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {nameAndHP[heroName]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        nameAndHP.Remove(heroName);
                        nameAndMP.Remove(heroName);
                    }


                }
                else if (comArg == "Recharge")
                {
                    int amount = int.Parse(tokens[2]);
                    int currMp = nameAndMP[heroName];
                    
                    if(currMp + amount < 200)
                    {
                        nameAndMP[heroName] += amount ;
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                    else
                    {
                        int a = mpMax - currMp;
                        nameAndMP[heroName] = mpMax;
                        Console.WriteLine($"{heroName} recharged for {a} MP!");
                    }
                    

                    
                }
                else if (comArg == "Heal")
                {
                    int amount = int.Parse(tokens[2]);
                    int currHp = nameAndHP[heroName];
                    if (currHp + amount < 100)
                    {
                        nameAndHP[heroName] += amount;
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }
                    else
                    {
                        int a = hpMax - currHp;
                        nameAndHP[heroName] = hpMax;
                        Console.WriteLine($"{heroName} healed for {a} HP!");
                    }


                    

                    

                }


                inputGame = Console.ReadLine();
            }
            nameAndHP = nameAndHP.OrderByDescending(X => X.Value)
                .ThenBy(n => n.Key)
                .ToDictionary(h =>h.Key,p => p.Value);

            
            

              foreach (var nameAndHpPoints in nameAndHP)
              {
                  Console.WriteLine($"{nameAndHpPoints.Key}");
                  Console.WriteLine($"  HP: {nameAndHpPoints.Value}");
                  Console.WriteLine($"  MP: {nameAndMP[nameAndHpPoints.Key]}");
              }
            
        }
    }
}
