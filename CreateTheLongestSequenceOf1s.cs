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
        string b = Console.ReadLine();
            string[] array = new string[b.Length];

            int i = 0;
            int broyNulls = 0;
            foreach (char ch in b)
            {
                array[i] = ch.ToString();

                if (ch == '0')
                broyNulls++;

                i++;
            }

            int maxLength = 0;
            for (int k = 0; k < array.Length; k++)
            {
                int length = 0;
                if (array[k] == "0")
                {
                    array[k] = "1";

                    for (int y = 0; y < array.Length; y++) {
                        if (array[y] == "1")
                        {
                            length++;
                            if (length > maxLength)
                                maxLength = length;
                        } else
                        {
                            length = 0;
                        }
                    }

                    array[k] = "*";
                }
            }
            Console.WriteLine(maxLength);
    }
}
