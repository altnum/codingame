using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    struct Tribute
    {
        public string Name;
        public string[] Victims;
        public string killer;

        public void AddVictim(string nameK)
        {
            string realNameK = "";

            foreach (char ch in nameK)
            {
                if (ch == 44)
                    break;
                realNameK += ch.ToString();
            }
            nameK = realNameK;
            if (Victims == null)
            {
                Victims = new string[1];
                Victims[0] = nameK;
            }
            else
            {
                var newVictims = new string[Victims.Length + 1];
                for (int i = 0; i < Victims.Length; i++)
                {
                    if (i < Victims.Length - 1)
                        newVictims[i] = Victims[i];
                    else if (i == Victims.Length - 1)
                        newVictims[i] = Victims[i];
                        
                }
                newVictims[Victims.Length] = nameK;
                Victims = newVictims;
            }
        }
        public int GetVictims()
        {
            if (Victims == null)
                return 0;
            return Victims.Length;
        }
        public void AddKiller(string killer)
        {
            
        }
    }
    class Program
    { 
        public static void Main(string[] args)
        {
            int tributes = int.Parse(Console.ReadLine());
            Tribute[] tribute = new Tribute[tributes];

            string[] sortedNames = new string[tributes];

            for (int i = 0; i < tributes; i++)
            {
                string playerName = Console.ReadLine();
                sortedNames[i] = playerName;
            }
            Array.Sort(sortedNames);

            for (int i = 0; i < tributes; i++)
            {
                tribute[i].Name = sortedNames[i];
                tribute[i].killer = "Winner";
            }
            int turns = int.Parse(Console.ReadLine());

            for (int i = 0; i < turns; i++)
            {
                string info = Console.ReadLine();
                string[] str = info.Split(' ');
                
                    for (int k = 0; k < tribute.Length; k++)
                    {
                        if (tribute[k].Name == str[0])
                        {
                            for (int y = 2; y < str.Length; y++)
                            {
                                tribute[k].AddVictim(str[y]);

                                for (int o = 0; o < tribute.Length; o++)
                                {
                                    string check = "";
                                    foreach (char ch in str[y])
                                    {
                                        if (ch == 44)
                                            break;
                                        check += ch.ToString();
                                    }

                                    if (tribute[o].Name  == check)
                                    {
                                        tribute[o].killer = str[0];
                                    }
                                }
                            }
                        }
                    }
                
            }
            for (int u = 0; u < tribute.Length; u++) {
                if (tribute[u].GetVictims() != 0)
                SortVictims(ref tribute[u].Victims);
            }

            for (int u = 0; u < tribute.Length; u++)
            {
                Console.WriteLine("Name: {0}", tribute[u].Name);
                Console.Write("Killed: ");
                if (tribute[u].GetVictims() == 0)
                {
                    Console.WriteLine("None");
                }
                else if (tribute[u].GetVictims() == 1)
                {
                    Console.WriteLine(tribute[u].Victims[0]);
                }
                else
                {
                    for (int i = 0; i < tribute[u].Victims.Length; i++)
                    {
                        if (i < tribute[u].Victims.Length - 1)
                            Console.Write(tribute[u].Victims[i] + ", ");
                        else
                            Console.WriteLine(tribute[u].Victims[i]);
                    }
                }
                Console.WriteLine("Killer: {0}", tribute[u].killer);
                if (u < tribute.Length - 1)
                    Console.WriteLine();
            }
        }
        public static void SortVictims(ref string[] arr)
        {
            Array.Sort(arr);
        }
    }
}
