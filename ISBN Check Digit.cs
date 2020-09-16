using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
         int N = int.Parse(Console.ReadLine());
        int invalid = 0;
        string[] INValids = new string[N];

        for (int i = 0; i < N; i++)
        {
            string ISBN = Console.ReadLine();
            int broyCh = 0;
            int k1 = 0;
            int greshka = 0;

            foreach (char ch in ISBN)
            {
                broyCh++;
            }
            if (broyCh != 10 && broyCh != 13)
            {
                invalid++;
                INValids[i] = ISBN;
                continue;
            }

            int[] arr = new int[broyCh];

            foreach (char ch in ISBN)
            {
                int num = ch - '0';
                arr[k1] = num;
                k1++;
            }
            for (int x = 0; x < arr.Length - 1; x++)
            {
                if (arr[x] > 9 || arr[x] < 0)
                {
                    invalid++;
                    greshka++;
                    break;
                }
            }
            if (greshka == 1)
            {
                INValids[i] = ISBN;
                continue;
            }
            if (arr[arr.Length - 1] != 40 && (arr[arr.Length - 1] < 0 || arr[arr.Length - 1] > 9))
            {
                invalid++;
                INValids[i] = ISBN;
                continue;
            }
            int sum = 0;
            if (arr.Length == 10)
            {
                int chisla = 10;
                for (int x = 0; x < arr.Length - 1; x++)
                {
                    sum += arr[x] * chisla;
                    chisla--;
                }
                int ostatuk = sum % 11;
                
                int checkDigit = 11 - ostatuk;
                if (checkDigit == 10)
                {
                    if(arr[arr.Length - 1] == 40)
                    {
                        continue;
                    } else if (arr[arr.Length - 1] != 40)
                    {
                        invalid++;
                        INValids[i] = ISBN;
                        continue;
                    }
               } 
                else if (checkDigit == 11)
                {
                    continue;
                }
                else if (arr[arr.Length - 1] == checkDigit)
                {
                    continue;
                } else if (arr[arr.Length - 1] != checkDigit)
                {
                    invalid++;
                    INValids[i] = ISBN;
                    continue;
                }
            }
            if (arr.Length == 13)
            {

                for(int x = 0; x < arr.Length - 1; x++)
                {
                    if (x == 0 || x % 2 == 0)
                    {
                        sum += arr[x] * 1;
                    } else if (x != 0 && x % 2 != 0)
                    {
                        sum += arr[x] * 3;
                    }
                }
                int ostatuk = sum % 10;
                
                int checkDigit = 10 - ostatuk;
                if (checkDigit == 10)
                {
                    if (arr[arr.Length - 1] == 0)
                    {
                        continue;
                    }
                    else if (arr[arr.Length - 1] != 0)
                    {
                        invalid++;
                        INValids[i] = ISBN;
                        continue;
                    }
                }
                
                else if (arr[arr.Length - 1] == checkDigit)
                {
                    continue;
                }
                else if (arr[arr.Length - 1] != checkDigit)
                {
                    invalid++;
                    INValids[i] = ISBN;
                    continue;
                }

            }



        }
        Console.WriteLine("{0} invalid:", invalid);
        for (int x = 0; x < INValids.Length; x++)
        {
            if (INValids[x] == null)
                continue;
            Console.WriteLine(INValids[x]);
        }
    }
}
