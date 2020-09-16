using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
       string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);
            inputs = Console.ReadLine().Split(' ');
            int currency = 0;
            int currMax = 0;
            int[] Povt = new int[m];
            int povtorenieBroi = 0;

            bool Yes = true;

            int[] Ampers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int nx = int.Parse(inputs[i]);
                Ampers[i] = nx;

            }

            inputs = Console.ReadLine().Split(' ');

            for (int i = 0; i < m; i++)
            {
                int mx = int.Parse(inputs[i]);

                Povt[i] = mx;

                for (int k = 0; k <= i; k++)
                {

                    if (Povt[i] == Povt[k])
                    {

                        povtorenieBroi = povtorenieBroi + 1;

                    }



                }

                
                if ((povtorenieBroi % 2) == 0)
                {
                    currency = currency - Ampers[mx - 1];
                }
                if ((povtorenieBroi % 2) != 0)
                {
                    currency = currency + Ampers[mx - 1];
                }
                povtorenieBroi = 0;





                if (currency > c)
                {
                    Console.WriteLine("Fuse was blown.");
                    
                    Yes = false;
                    break;
                }
                if (currMax < currency)
                {
                    currMax = currency;
                }

            }


            if (Yes)
            {
                Console.WriteLine("Fuse was not blown.");
                Console.WriteLine("Maximal consumed current was {0} A.", currMax);
            }
    }
}
