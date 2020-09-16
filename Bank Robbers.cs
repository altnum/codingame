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
          int R = int.Parse(Console.ReadLine());
            int V = int.Parse(Console.ReadLine());
            double[] vremeNaSeif = new double[V];
            double[] robbers = new double[R];

            for (int i = 0; i < R; i++)
            {
                robbers[i] = 0;
            }

            for (int i = 0; i < V; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int C = int.Parse(inputs[0]);
                int N = int.Parse(inputs[1]);

                double numberOfCombinations = Math.Pow(10, N) * Math.Pow(5, C - N);

                vremeNaSeif[i] = numberOfCombinations;
            }



             if (V > R)
            {
                double SborTime = 0;

                bool everyVZero = false;

              while (everyVZero == false)
                {
                    double MinTime = double.MaxValue;
                    int nulevi = 0;

                    for (int k = 0; k < R; k++)
                    {
                        if (vremeNaSeif[k + nulevi] <= 0)
                        {
                            if (k + nulevi <= vremeNaSeif.Length)
                            {
                                nulevi++;
                                if (vremeNaSeif.Length - nulevi < R)
                                {
                                    R = vremeNaSeif.Length - nulevi;
                                }
                                k--;
                                continue;
                            }
                        }
                        else if (vremeNaSeif[k + nulevi] < MinTime)
                        {
                            MinTime = vremeNaSeif[k + nulevi];
                            if (nulevi + k == vremeNaSeif.Length - 1)
                                break;
                        }
                    }

                    int nulevi2 = 0;
                    for (int k = 0; k < R; k++)
                    {
                        if (vremeNaSeif[k + nulevi2] <= 0)
                        {
                            if (k + nulevi2 <= vremeNaSeif.Length)
                            {
                                nulevi2++;
                                k--;
                                continue;
                            }
                        }
                        else if (vremeNaSeif[k + nulevi2] >= MinTime)
                        {
                            vremeNaSeif[k + nulevi2] -= MinTime;
                        }

                        int Vs0 = 0;
                        for (int c = 0; c < vremeNaSeif.Length; c++)
                        {
                            if (vremeNaSeif[c] == 0)
                            {
                                Vs0++;
                            }
                        }
                        if (Vs0 == V)
                        {
                            everyVZero = true;
                            break;
                        }
                    }
                    
                    SborTime += MinTime;
                }
                Console.WriteLine(SborTime);

            }
            else if (V == R)
            {
                int premestvaniq = V / R;
                int vrS = 0;
                double SborMaxTime = 0;

                for (int x = 0; x < premestvaniq; x++)
                {
                    double MaxTime = double.MinValue;

                    for (int i = 0; i < R; i++)
                    {
                        robbers[i] = vremeNaSeif[vrS];
                        if (robbers[i] > MaxTime)
                        {
                            MaxTime = robbers[i];
                        }
                        vrS++;
                    }

                    SborMaxTime += MaxTime; 
                }
                Console.WriteLine(SborMaxTime);
            }
        }
        
}
