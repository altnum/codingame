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
        int m = 10000000;
        int[] strength = new int[N];
            
            for (int i = 0; i < N; i++)
            {
                int pi = int.Parse(Console.ReadLine());
                strength[i] = pi;
            }
            Array.Sort(strength);
            for (int i = 0; i < strength.Length - 1; i ++) {
                m = Math.Min(m, strength[i + 1] - strength[i]);
            }
            Console.WriteLine(m);
    }
}
