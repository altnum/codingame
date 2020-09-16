using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    public static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
            int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
            string[,] table = new string[2, N];
            for (int i = 0; i < N; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                string EXT = inputs[0].ToLower(); // file extension
                string MT = inputs[1]; // MIME type.

                table[0, i] = EXT;
                table[1, i] = MT;
            }
            for (int i = 0; i < Q; i++)
            {
                string FNAME = Console.ReadLine(); // One file name per line.
                string[] str = new string[FNAME.Length];
                int k = 0;
                foreach(char ch in FNAME)
                {
                    str[k] = ch.ToString();
                    k++;
                }
                string extension = "";
                bool isRight = false;
                for (int t = str.Length - 1; t >= 0; t--)
                {
                    if (str[t] == ".")
                    {
                        isRight = true;
                        break;
                    }
                    extension = str[t].ToLower() + extension;
                    
                }
                if (isRight == true)
                {
                    bool unknown = true;
                    for (int t = table.GetLength(1) - 1; t >= 0; t--)
                    {
                        if (table[0, t] == extension)
                        {
                            Console.WriteLine(table[1, t]);
                            unknown = false;
                            break;
                        }
                    }
                    if (unknown == true)
                    Console.WriteLine("UNKNOWN");
                } else
                {
                    Console.WriteLine("UNKNOWN");
                }


            }

        }
}
