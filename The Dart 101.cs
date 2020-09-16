using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    
    
            public static double NaiMalko(double[] arr)
        {
            double lowest = 10000;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < lowest)
                {
                    lowest = arr[i];
                }
            }

           // double min = arr[0];
            return lowest;
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
           
            double[] rundoveIgrachi = new double[N];
            string[] Igrachi = new string[N];

            for (int i = 0; i < N; i++)
            {
                string PLAYER = Console.ReadLine();
                Igrachi[i] = PLAYER;

            }
            for (int i = 0; i < N; i++)
            {
                string SHOOTS = Console.ReadLine();
                int k1 = 0;
                int k2 = 0;
                int sum = 0;

                foreach (int ch in SHOOTS)
                {
                    int num = ch - '0';

                    k1++;
                }

                int[] arr = new int[k1];

                foreach (char ch in SHOOTS)
                {
                    int num = ch - '0';
                    arr[k2] = num;
                    k2++;
                }

                for (int z = 0; z < arr.Length; z++)
                {
                    if (arr[z] == -16)
                    {
                        arr[z] = 0;
                        z++;
                    }
                    if (arr[z] == -6)
                    {
                        if (z + 2 < arr.Length)
                        {
                            if (arr[z + 2] < 0)
                            {
                                arr[z] = arr[z - 1] * arr[z + 1];
                                arr[z - 1] = 0;
                                arr[z + 1] = 0;
                            }
                            else if (arr[z + 2] >= 0)
                            {
                                arr[z] = (arr[z + 1] * 10 + arr[z + 2]) * arr[z - 1];
                                arr[z - 1] = 0;
                                arr[z + 1] = 0;
                                arr[z + 2] = 0;
                            }

                            z++;
                        }
                        else
                        {
                            arr[z] = arr[z - 1] * arr[z + 1];
                            arr[z - 1] = 0;
                            arr[z + 1] = 0;
                            z++;
                        }
                    }
                    if (z <= arr.Length - 2)
                    {
                        if (arr[z + 1] >= 0)
                        {
                            arr[z] = arr[z] * 10 + arr[z + 1];
                            arr[z + 1] = 0;
                            z++;
                        }
                    }
                    if (arr[z] == 40)
                    {
                        int izp = 0;
                        if (z + 4 < arr.Length)
                        {

                            if (arr[z + 2] == 40 && arr[z + 4] != 40)
                            {
                                arr[z] = -20;
                                arr[z + 1] = 0;
                                arr[z + 2] = -30;

                                z += 2;
                            }
                            else if (arr[z + 2] == 40 && arr[z + 4] == 40)
                            {
                                arr[z] = -1;
                                arr[z + 1] = 0;
                                arr[z + 2] = -1;
                                arr[z + 3] = 0;
                                arr[z + 4] = -1;
                                z += 4;
                            }
                            else if (arr[z + 2] != 40)
                            {
                                arr[z] = -20;
                                arr[z + 1] = 0;
                                z ++;
                            }
                           
                        } else if ((z + 2 < arr.Length) && (izp == 0))
                        {
                            if (arr[z + 2] == 40)
                            {
                                arr[z] = -20;
                                arr[z + 1] = 0;
                                arr[z + 2] = -30;
                                z += 2;
                            }
                            else if (arr[z + 2] != 40)
                            {
                                arr[z] = -20;
                                arr[z + 1] = 0;
                                z++;
                            }
                        } else if (z + 1 < arr.Length)
                        {
                            arr[z] = -20;
                            arr[z + 1] = 0;
                            z++;
                        } else if (z < arr.Length)
                        {
                            arr[z] = -20;
                            
                        }
                        
                        
                    }
                    
                }
                int broyChisla = 0;
                for (int t = 0; t < arr.Length; t++)
                {
                    if (arr[t] != 0)
                    {
                        broyChisla++;
                    }
                }

                int[] masivGotovi = new int[broyChisla];
                int m = 0;
                for (int t = 0; t < arr.Length; t++)
                {
                    if (arr[t] != 0)
                    {
                        masivGotovi[m] = arr[t];
                        m++;
                    }
                }

                for (int y = 0; y < masivGotovi.Length; y++)
                {
                  //  Console.WriteLine(masivGotovi[y]);
                }
                double shoots = 0;
                double rounds = 0;
                for (int u = 0; u < masivGotovi.Length; u++)
                {
                    
                    if (masivGotovi[u] == -1) {
                    sum = 0;
                    } else {
                    sum += masivGotovi[u];
                    shoots++;
                    }
                    if (sum < 0) {
                        sum = 0;
                    }
                   // shoots++;
                    if ((sum + masivGotovi[u]) < 101) {
                        sum += masivGotovi[u];
                        
                        shoots++;
                    }
                    if (sum + masivGotovi[u] > 101)
                    {
                    
                       if ((shoots % 3) == 0) {
                       }
                       
                       rounds += 1; 
                       
                    }
                     else if (sum == 101)
                    {
                        break;
                        
                    }
                } 

                rounds += Math.Ceiling(shoots / 3);

                rundoveIgrachi[i] = rounds;
            }
            int nomer = 0;
            double min = NaiMalko(rundoveIgrachi);
            for (; nomer < rundoveIgrachi.Length; nomer++)
            {
                if (min == rundoveIgrachi[nomer])
                {
                    nomer = nomer + 1;
                    break;
                }
            }
            Console.WriteLine(Igrachi[nomer - 1]);
            
        }
        
    
}
