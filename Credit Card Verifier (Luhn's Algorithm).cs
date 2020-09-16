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
         int n = int.Parse(Console.ReadLine());
        
        
        for (int i = 0; i < n; i++)
        {
            string card = Console.ReadLine();

            int[] arr = new int[16];
            int[] arr1 = new int[8];
            int sum1 = 0;
            int sum2 = 0;
            int x = 0;
            int k = 0;

            foreach (var ch in card)
            {
                int num = ch - '0';

                if (num >= 0 && num <= 9)
                {
                    arr[k] = num;

                    k++;
                }
                
            }
            for (int f = 14; f >= 0; f -= 2)
            {
                arr[f] = arr[f] * 2;
                
                if (arr[f] >= 10)
                {
                    arr[f] = arr[f] - 9;
                }
                arr1[x] = arr[f];
                x++;
            }
            for (int f = 0; f < 8; f++)
            {
                sum1 = sum1 + arr1[f];
            }
            for (int f2 = 15; f2 > 0; f2 -= 2)
            {
                sum2 = sum2 + arr[f2];
            }
            int SUM = sum1 + sum2;
            if (SUM % 10 == 0)
            {
                Console.WriteLine("YES");
            } else
            {
                Console.WriteLine("NO");
            }
        }
        


        
    }
}
