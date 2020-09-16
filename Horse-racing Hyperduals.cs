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
        int[,] strength = new int[N, 2];
        int diff = int.MaxValue;

        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int V = int.Parse(inputs[0]);
            int E = int.Parse(inputs[1]);

            strength[i, 0] = V;
            strength[i, 1] = E;
        }

        for (int i = 0; i < N; i++)
        {
            for (int k = i + 1; k < N; k++)
            {
                int razlika = Math.Abs(strength[k, 0] - strength[i, 0]) + Math.Abs(strength[k, 1] - strength[i, 1]);
                if (razlika <= diff)
                {
                    diff = razlika;
                }
            }
        }
        Console.WriteLine(diff);
    }
}
